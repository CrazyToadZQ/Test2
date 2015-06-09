using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tellyes.Log4Net;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Web.Script.Serialization;
using System.Text;

namespace OSCEExamPlatformWeb.AppDataInterface
{
    public partial class CenterScore : System.Web.UI.Page
    {
        private const string PAGE_PATH_INFO = "/AppDataInterface/CenterScore.aspx";
        private const string ASSEMBLY_NAME = "OSCEExamPlatformWeb";
        private const string CLASS_NAME = "OSCEExamPlatformWeb.AppDataInterface.CenterScore";

        protected override void OnInit(EventArgs e)
        {
            string errorJsonString = "{\"result\":\"0\"}";
            string pathInfo = Request.Params["PATH_INFO"];
            if (pathInfo.StartsWith(PAGE_PATH_INFO + "/"))
            {
                string[] nameList = pathInfo.Substring(PAGE_PATH_INFO.Length + 1).Split('/');
                if (nameList.Length < 1)
                {
                    Log4NetUtility.Error(this, "URL地址访问错误");
                    Response.Write(errorJsonString);
                    Response.End();
                    return;
                }
                try
                {
                    Assembly assembly = Assembly.Load(ASSEMBLY_NAME);
                    Type type = assembly.GetType(CLASS_NAME); ;
                    MethodInfo method = type.GetMethod(nameList[0], System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    method.Invoke(this, null);
                }
                catch (Exception exception)
                {
                    Log4NetUtility.Fatal(this, "处理程序访问失败", exception);
                    Response.Write(errorJsonString);
                    Response.End();
                    return;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["PATH_INFO"].StartsWith(PAGE_PATH_INFO + "/"))
            {
                Response.End();
                return;
            }
        }

        /// <summary>
        /// 提交评分成绩
        /// </summary>
        private void AddScoreInfo()
        {
            string errorJsonString1 = "{\"result\":\"0\"}";
            string errorJsonString2 = "{\"result\":\"-1\"}";

            Guid E_ID = Guid.Parse(Request.Form["E_ID"]);
            Guid ES_ID = Guid.Parse(Request.Form["ES_ID"]);
            int Room_ID = Convert.ToInt32(Request.Form["Room_ID"]);
            int Student_U_ID = Convert.ToInt32(Request.Form["Student_ID"]);
            int Judge_U_ID = Convert.ToInt32(Request.Form["Rater_ID"]);
            string SI_ActualScore = Request.Form["SI_ActualScore"];
            decimal SI_Score = Convert.ToDecimal(Request.Form["SI_Score"]);
            string SI_Item = Request.Form["SI_Item"];
            int MS_ID = Convert.ToInt32(Request.Form["MS_ID"]);
            Guid EU_ID = Guid.Parse(Request.Form["EU_ID"]);

            Tellyes.BLL.ExamUser examUserBLL = new Tellyes.BLL.ExamUser();
            Tellyes.Model.ExamUser examUser = examUserBLL.SearchExamUserByID(EU_ID);
            if (examUser == null)
            {
                Log4NetUtility.Error(this, "中央评分，查询考试评委信息失败，EU_ID：" + EU_ID);
                Response.Write(errorJsonString1);
                return;
            }

            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            { 
                {"Exam_ID,EQ", E_ID},
                {"ExamStation_ID,EQ", ES_ID},
                {"Room_ID,EQ", Room_ID},
                {"ScoreInfo_Type,EQ", 3},
                {"Rater_ID,EQ", Judge_U_ID},
                {"Student_ID,EQ", Student_U_ID}
            };
            Tellyes.BLL.ScoreInfo scoreInfoBLL = new Tellyes.BLL.ScoreInfo();
            List<Tellyes.Model.ScoreInfo> scoreInfoList = scoreInfoBLL.SearchScoreInfoByCondition(conditionDictionary);
            if (scoreInfoList == null)
            {
                Log4NetUtility.Error(this, "中央评分，考生评分信息查询失败");
                Response.Write(errorJsonString1);
                return;
            }
            Tellyes.Model.ScoreInfo scoreInfo = new Tellyes.Model.ScoreInfo();
            if (scoreInfoList.Count > 0)
            {
                scoreInfo = scoreInfoList[0];
                if (scoreInfo.SI_int2 == 2)
                {
                    Log4NetUtility.Error(this, "中央评分，考生评分信息已存在");
                    Response.Write(errorJsonString2);
                    return;
                }
            }

            scoreInfo.Exam_ID = E_ID;
            scoreInfo.ExamStation_ID = ES_ID;
            scoreInfo.Room_ID = Room_ID;
            scoreInfo.Score_Percent = examUser.int1;
            scoreInfo.Student_ID = Student_U_ID;
            scoreInfo.SI_Type = 3;
            scoreInfo.Rater_ID = Judge_U_ID;
            scoreInfo.SI_Score = SI_Score;
            scoreInfo.SI_ActualScore = SI_ActualScore;
            scoreInfo.SI_Items = Request.Form["SI_Items"];
            scoreInfo.SI_CreateTime = DateTime.Now;
            scoreInfo.SI_int1 = Convert.ToInt32(Request.Form["MS_ID"]);
            scoreInfo.SI_int2 = 2;
            scoreInfo.calcuated = 0;
            scoreInfo.timeStamp = "";
           

            //try
            //{
            //    HttpPostedFile image = Request.Files["image"];
            //    int length = image.ContentLength;
            //    byte[] imageByteArray = new byte[length];
            //    Stream imageStream = image.InputStream;
            //    imageStream.Read(imageByteArray, 0, length);
            //    scoreInfo.SI_DigitalSignature = imageByteArray;
            //}
            //catch (Exception e)
            //{
            //    Log4NetUtility.Error(this, "手持评分，签名图片上传失败，EU_ID：" + EU_ID + "，Student_UserInfo_ID：" + Student_U_ID, e);
            //    Response.Write(errorJsonString1);
            //    return;
            //}

            string scoreInfoItemJsonString = Request.Form["SI_Items"];
            if (scoreInfoItemJsonString == null || scoreInfoItemJsonString == "")
            {
                Log4NetUtility.Error(this, "手持评分，评分表评分内容为空");
                Response.Write(errorJsonString1);
                return;
            }
            ArrayList markSheetItemScoreList = new ArrayList();
            try
            {
                markSheetItemScoreList = new JavaScriptSerializer().Deserialize<ArrayList>(scoreInfoItemJsonString);

                List<int> markSheetItemIDList = new List<int>();
                foreach (Dictionary<string, object> markSheetItemScore in markSheetItemScoreList)
                {
                    markSheetItemIDList.Add(Convert.ToInt32(markSheetItemScore["MSI_ID"]));
                    if (markSheetItemScore.ContainsKey("children_item_list"))
                    {
                        ArrayList childrenItemList = (ArrayList)markSheetItemScore["children_item_list"];
                        foreach (Dictionary<string, object> subMarkSheetItemScore in childrenItemList)
                        {
                            markSheetItemIDList.Add(Convert.ToInt32(subMarkSheetItemScore["MSI_ID"]));
                        }
                    }
                }
                List<Tellyes.Model.MarkSheetItem> markSheetItemList = new Tellyes.BLL.MarkSheetItem().SearchMarkSheetItemByCondition
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MSI_ID,IN", markSheetItemIDList}
                    }
                );
                if (markSheetItemList == null)
                {
                    throw new Exception("评分表评分项查询失败");
                }
                Dictionary<int, Tellyes.Model.MarkSheetItem> markSheetItemDictionary = new Dictionary<int, Tellyes.Model.MarkSheetItem>();
                foreach (Tellyes.Model.MarkSheetItem markSheetItem in markSheetItemList)
                {
                    markSheetItemDictionary.Add(markSheetItem.MSI_ID, markSheetItem);
                }

                StringBuilder scoreInfoItemStringBuilder = new StringBuilder(string.Empty);
                scoreInfoItemStringBuilder.Append("[");
                foreach (Dictionary<string, object> markSheetItemScore in markSheetItemScoreList)
                {
                    int markSheetItemID = Convert.ToInt32(markSheetItemScore["MSI_ID"]);
                    if (!markSheetItemDictionary.ContainsKey(markSheetItemID))
                    {
                        continue;
                    }
                    Tellyes.Model.MarkSheetItem markSheetItem = markSheetItemDictionary[markSheetItemID];
                    scoreInfoItemStringBuilder.Append("{");
                    scoreInfoItemStringBuilder.Append("\"MSI_Item\":\"").Append(Uri.EscapeDataString(markSheetItem.MSI_Item)).Append("\",");
                    scoreInfoItemStringBuilder.Append("\"MSI_Score\":\"").Append(markSheetItem.MSI_Score).Append("\",");
                    scoreInfoItemStringBuilder.Append("\"Item_Score\":\"").Append(markSheetItemScore["Item_Score"]).Append("\",");
                    scoreInfoItemStringBuilder.Append("\"children_item_list\":[");
                    ArrayList childrenItemList = (ArrayList)markSheetItemScore["children_item_list"];
                    foreach (Dictionary<string, object> subMarkSheetItemScore in childrenItemList)
                    {
                        int subMarkSheetItemID = Convert.ToInt32(subMarkSheetItemScore["MSI_ID"]);
                        if (!markSheetItemDictionary.ContainsKey(subMarkSheetItemID))
                        {
                            continue;
                        }
                        Tellyes.Model.MarkSheetItem subMarkSheetItem = markSheetItemDictionary[subMarkSheetItemID];
                        scoreInfoItemStringBuilder.Append("{");
                        scoreInfoItemStringBuilder.Append("\"MSI_Item\":\"").Append(Uri.EscapeDataString(subMarkSheetItem.MSI_Item)).Append("\",");
                        scoreInfoItemStringBuilder.Append("\"MSI_Score\":\"").Append(subMarkSheetItem.MSI_Score).Append("\",");
                        scoreInfoItemStringBuilder.Append("\"Item_Score\":\"").Append(subMarkSheetItemScore["Item_Score"]).Append("\"");
                        scoreInfoItemStringBuilder.Append("},");
                    }
                    if (scoreInfoItemStringBuilder[scoreInfoItemStringBuilder.Length - 1] == ',')
                    {
                        scoreInfoItemStringBuilder.Remove(scoreInfoItemStringBuilder.Length - 1, 1);
                    }
                    scoreInfoItemStringBuilder.Append("]");
                    scoreInfoItemStringBuilder.Append("},");
                }
                if (scoreInfoItemStringBuilder[scoreInfoItemStringBuilder.Length - 1] == ',')
                {
                    scoreInfoItemStringBuilder.Remove(scoreInfoItemStringBuilder.Length - 1, 1);
                }
                scoreInfoItemStringBuilder.Append("]");
                scoreInfo.SI_Items = scoreInfoItemStringBuilder.ToString();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "远程评分，评分表评分内容解析失败，SI_Items：" + scoreInfoItemJsonString, e);
                Response.Write(errorJsonString1);
                return;
            }

            Dictionary<string, object> entityDictionary = new Dictionary<string, object>() 
            { 
                {"ScoreInfo,Add", scoreInfo}
            };

            Tellyes.BLL.ScoreSummariedScore scoreSummariedScoreBLL = new Tellyes.BLL.ScoreSummariedScore();
            Tellyes.Model.ScoreSummariedScore scoreSummariedScore
                = scoreSummariedScoreBLL.CreateScoreSummariedScoreObject(E_ID, ES_ID, EU_ID, Room_ID, Student_U_ID, Judge_U_ID, SI_Score);
            if (scoreSummariedScore == null)
            {
                Log4NetUtility.Error(this, "手持评分，成绩统计汇总错误");
                Response.Write(errorJsonString1);
                return;
            }
            scoreSummariedScore.ScoreType = 3;
            scoreSummariedScore.ScoreModifyUserInfoID = Judge_U_ID;
            scoreSummariedScore.LastScoreModifyDate = DateTime.Now;

            if (scoreSummariedScore.id == default(Int32))
            {
                entityDictionary.Add("ScoreSummariedScore,Add", scoreSummariedScore);
            }
            else
            {
                entityDictionary.Add("ScoreSummariedScore,Modify", scoreSummariedScore);
            }

            if (scoreSummariedScore.id == default(Int32))
            {
                int? scoreSummariedScoreIDObject = scoreSummariedScoreBLL.SearchScoreSummariedScoreIdentity();
                if (scoreSummariedScoreIDObject == null)
                {
                    Log4NetUtility.Error(this, "查询ScoreSummariedScore表自增ID失败");
                    Response.Write(errorJsonString1);
                    return;
                }
                scoreSummariedScore.id = Convert.ToInt32(scoreSummariedScoreIDObject);
            }

            decimal? examScoreObject = scoreSummariedScoreBLL.CreateExamScore(E_ID, ES_ID, Student_U_ID, scoreSummariedScore.score);
            if (examScoreObject == null)
            {
                Log4NetUtility.Error(this, "汇总ExamScore数据失败，E_ID：" + E_ID + "，ES_ID：" + ES_ID + "，Student_U_ID：" + Student_U_ID + "，examStationScore：" + scoreSummariedScore.score);
                Response.Write(errorJsonString1);
                return;
            }

            Tellyes.Model.ScoreLog scoreLog = new Tellyes.Model.ScoreLog();
            scoreLog.LogUserInfoID = Judge_U_ID;
            scoreLog.LogDatetime = DateTime.Now;
            scoreLog.LogType = 3;
            scoreLog.ScoreSummariedScoreID = scoreSummariedScore.id;
            scoreLog.E_ID = E_ID;
            scoreLog.ES_ID = ES_ID;
            scoreLog.Room_ID = Room_ID;
            scoreLog.StudentUserInfoID = Student_U_ID;
            scoreLog.Score = scoreInfo.SI_Score;
            scoreLog.MS_ID = scoreInfo.SI_int1;
            scoreLog.ScorePercent = examUser.int1;
            scoreLog.ExamStationScore = scoreSummariedScore.score;
            scoreLog.ExamStationPercent = 100;
            scoreLog.ExamScore = Convert.ToDecimal(examScoreObject);
            entityDictionary.Add("ScoreLog,Add", scoreLog);

            bool result = scoreInfoBLL.AddScoreInfo(entityDictionary);
            Response.Write("{\"result\":\"" + (result ? "1" : "0") + "\"}");
        }
    }
}