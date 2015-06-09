using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tellyes.Log4Net;
using System.Reflection;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;

namespace OSCEExamPlatformWeb.AppDataInterface
{
    public partial class HandScore : System.Web.UI.Page
    {
        #region Controller

        /// <summary>
        /// URL访问路径
        /// </summary>
        private const string PAGE_PATH_INFO = "/AppDataInterface/HandScore.aspx";

        /// <summary>
        /// 程序集名称
        /// </summary>
        private const string ASSEMBLY_NAME = "OSCEExamPlatformWeb";

        /// <summary>
        /// ASPX类名
        /// </summary>
        private const string CLASS_NAME = "OSCEExamPlatformWeb.AppDataInterface.HandScore";

        /// <summary>
        /// ASPX页面生命周期：OnInit事件
        /// </summary>
        /// <param name="e"></param>
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

        /// <summary>
        /// ASPX页面生命周期：Page_Load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["PATH_INFO"].StartsWith(PAGE_PATH_INFO + "/"))
            {
                Response.End();
                return;
            }
        }

        #endregion

        /// <summary>
        /// 查询考生数量
        /// </summary>
        private void SearchStudentCount()
        {
            string errorJsonString = "{\"result\":\"0\"}";

            Guid E_ID = Guid.Parse(Request.Form["E_ID"]);
            Guid ES_ID = Guid.Parse(Request.Form["ES_ID"]);
            int Room_ID = Convert.ToInt32(Request.Form["Room_ID"]);
            int U_ID = Convert.ToInt32(Request.Form["U_ID"]);
            //Guid ESR_ID = Guid.Parse(Request.Form["ESR_ID"]);

            Tellyes.Model.ExamTable examTable = new Tellyes.BLL.ExamTable().SearchExamTableByID(E_ID);
            if (examTable == null) 
            {
                Log4NetUtility.Error(this, "手持评分，查询考生数量失败，查询考试信息失败，E_ID：" + E_ID);
                Response.Write(errorJsonString);
                return;
            }

            if (examTable.E_Kind == 1)
            {
                #region 长短站考试
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
                { 
                    {"E_ID,EQ", E_ID},
                    {"ES_ID,EQ", ES_ID},
                    {"Room_ID,EQ", Room_ID},
                    {"JudgeUserInfoID,EQ", U_ID},
                    {"Exam_StartTime,GE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00", "yyyy-MM-dd HH:mm:ss",null)},
                    {"Exam_StartTime,LE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59", "yyyy-MM-dd HH:mm:ss",null)}
                };

                Dictionary<string, int> studentCountDictionary
                    = new Tellyes.BLL.OSCEExaminationArrangement().SearchStudentCountDictionaryInHandScoreByCondition(conditionDictionary);
                if (studentCountDictionary == null)
                {
                    Log4NetUtility.Error(this, "手持评分，多站式考试查询考生数量失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }

                StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"type_1_count\":\"").Append(studentCountDictionary["All_Student_Count"]).Append("\",");
                jsonStringBuilder.Append("\"type_2_count\":\"").Append(studentCountDictionary["Student_With_Score_Count"]).Append("\",");
                jsonStringBuilder.Append("\"type_3_count\":\"").Append(studentCountDictionary["All_Student_Count"] - studentCountDictionary["Student_With_Score_Count"]).Append("\"");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
                #endregion
            }
            else if (examTable.E_Kind == 2)
            {
                #region 多站式考试
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
                { 
                    {"E_ID,EQ", E_ID},
                    {"ES_ID,EQ", ES_ID},
                    {"Room_ID,EQ", Room_ID},
                    {"JudgeUserInfoID,EQ", U_ID},
                    {"Exam_StartTime,GE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00", "yyyy-MM-dd HH:mm:ss",null)},
                    {"Exam_StartTime,LE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59", "yyyy-MM-dd HH:mm:ss",null)}
                };

                Dictionary<string, int> studentCountDictionary 
                    = new Tellyes.BLL.MultiStationExamArrangement().SearchStudentCountDictionaryInHandScoreByCondition(conditionDictionary);
                if (studentCountDictionary == null) 
                {
                    Log4NetUtility.Error(this, "手持评分，多站式考试查询考生数量失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }

                StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"type_1_count\":\"").Append(studentCountDictionary["All_Student_Count"]).Append("\",");
                jsonStringBuilder.Append("\"type_2_count\":\"").Append(studentCountDictionary["Student_With_Score_Count"]).Append("\",");
                jsonStringBuilder.Append("\"type_3_count\":\"").Append(studentCountDictionary["All_Student_Count"] - studentCountDictionary["Student_With_Score_Count"]).Append("\"");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
                #endregion
            }
            else if (examTable.E_Kind == 3)
            {
                #region 单站式考试
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
                { 
                    {"E_ID,Eq", E_ID},
                    {"ES_ID,Eq", ES_ID},
                    {"Room_ID,Eq", Room_ID},
                    {"JudgeUserInfoID,Eq", U_ID},
                    {"SE_StartTime,Ge", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00", "yyyy-MM-dd HH:mm:ss",null)},
                    {"SE_StartTime,Le", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59", "yyyy-MM-dd HH:mm:ss",null)}
                };

                Dictionary<string, int> studentCountDictionary
                    = new Tellyes.BLL.SingleStationExamArrangement().SearchStudentCountDictionaryInHandScoreByCondition(conditionDictionary);
                if (studentCountDictionary == null)
                {
                    Log4NetUtility.Error(this, "手持评分，单站式考试查询考生数量失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }

                StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"type_1_count\":\"").Append(studentCountDictionary["All_Student_Count"]).Append("\",");
                jsonStringBuilder.Append("\"type_2_count\":\"").Append(studentCountDictionary["Student_With_Score_Count"]).Append("\",");
                jsonStringBuilder.Append("\"type_3_count\":\"").Append(studentCountDictionary["All_Student_Count"] - studentCountDictionary["Student_With_Score_Count"]).Append("\"");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
                #endregion
            }
            else
            {
                Response.Write(errorJsonString);
                Log4NetUtility.Error(this, "手持评分，查询考生数量失败，未知的考试类型，E_ID：" + E_ID);
                return;
            }
        }

        /// <summary>
        /// 查询考生信息
        /// </summary>
        private void SearchStudentInfo()
        {
            string errorJsonString = "{\"result\":\"0\"}";

            Guid E_ID = Guid.Parse(Request.Form["E_ID"]);
            Guid ES_ID = Guid.Parse(Request.Form["ES_ID"]);
            int Room_ID = Convert.ToInt32(Request.Form["Room_ID"]);
            int U_ID = Convert.ToInt32(Request.Form["U_ID"]);
            string searchType = Request.Form["search_type"]; //1-全部，2-已考，3-未考
            string searchKeyword = Request.Form["search_keyword"];
            int pageIndex = Convert.ToInt32(Request.Form["page_index"]);
            int pageSize = Convert.ToInt32(Request.Form["page_size"]);

            Tellyes.Model.ExamTable examTable = new Tellyes.BLL.ExamTable().SearchExamTableByID(E_ID);
            if (examTable == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，查询考试信息失败，E_ID：" + E_ID);
                Response.Write(errorJsonString);
                return;
            }

            if (examTable.E_Kind == 1)
            {
                #region 长短站考试
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
                { 
                    {"E_ID,EQ", E_ID},
                    {"ES_ID,EQ", ES_ID},
                    {"Room_ID,EQ", Room_ID},
                    {"JudgeUserInfoID,EQ", U_ID}
                };

                if (searchKeyword != null && searchKeyword != "")
                {
                    conditionDictionary.Add("UserInfoName,UserInfoTrueName,ExamStudentNumber,Like", searchKeyword);
                }
                else
                {
                    conditionDictionary.Add("Exam_StartTime,GE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00", "yyyy-MM-dd HH:mm:ss", null));
                    conditionDictionary.Add("Exam_StartTime,LE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59", "yyyy-MM-dd HH:mm:ss", null));
                    if (searchType == "2")
                    {
                        conditionDictionary.Add("ScoreInfoID,IsNotNull", "");
                    }
                    else if (searchType == "3")
                    {
                        conditionDictionary.Add("ScoreInfoID,IsNull", "");
                    }
                }
                Tellyes.BLL.OSCEExaminationArrangement osceExaminationArrangementBLL = new Tellyes.BLL.OSCEExaminationArrangement();
                int? studentCountObject = osceExaminationArrangementBLL.SearchStudentCountInHandScoreByCondition(conditionDictionary);
                if (studentCountObject == null)
                {
                    Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }
                int studentCount = Convert.ToInt32(studentCountObject);
                if (studentCount == 0)
                {
                    Response.Write("{\"result\":\"1\",\"page_index\":\"1\",\"student_list\":[]}");
                    return;
                }

                int pageCount = (studentCount + pageSize - 1) / pageSize;
                pageIndex = pageIndex < 1 ? 1 : pageIndex;
                pageIndex = pageIndex > pageCount ? pageCount : pageIndex;

                List<Dictionary<string, object>> studentList
                    = osceExaminationArrangementBLL.SearchStudentListInHandScoreByCondition(conditionDictionary, pageIndex, pageSize);
                if (studentList == null)
                {
                    Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }

                StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"page_index\":\"").Append(pageIndex).Append("\",");
                jsonStringBuilder.Append("\"student_list\":[");
                foreach (Dictionary<string, object> student in studentList)
                {
                    jsonStringBuilder.Append("{");
                    jsonStringBuilder.Append("\"U_ID\":\"").Append(student["StudentUserInfoID"]).Append("\",");
                    jsonStringBuilder.Append("\"U_TrueName\":\"").Append(Uri.EscapeDataString(student["StudentUserInfoTrueName"].ToString())).Append("\",");
                    jsonStringBuilder.Append("\"U_Name\":\"").Append(student["StudentUserInfoName"]).Append("\",");
                    jsonStringBuilder.Append("\"EStu_ExamNumber\":\"").Append(student["ExamStudentNumber"]).Append("\",");
                    jsonStringBuilder.Append("\"O_Name\":\"").Append(student["OrganizationName"] == null ? "" : Uri.EscapeDataString(student["OrganizationName"].ToString())).Append("\",");
                    jsonStringBuilder.Append("\"Exam_StartTime\":\"").Append(Convert.ToDateTime(student["ExamStartTime"]).ToString("HH:mm")).Append("\",");
                    jsonStringBuilder.Append("\"Exam_EndTime\":\"").Append(Convert.ToDateTime(student["ExamEndTime"]).ToString("HH:mm")).Append("\",");
                    jsonStringBuilder.Append("\"Exam_Date\":\"").Append(Convert.ToDateTime(student["ExamStartTime"]).ToString("yyyy-MM-dd")).Append("\",");
                    jsonStringBuilder.Append("\"student_state\":\"").Append(student["StudentState"] == null ? "3" : student["StudentState"]).Append("\",");
                    jsonStringBuilder.Append("\"student_score\":\"").Append(student["StudentState"] != null && student["StudentState"].Equals(2) ? (student["StudentScore"].Equals(0) ? "0" : String.Format("{0:N1}", student["StudentScore"])) : "").Append("\"");
                    jsonStringBuilder.Append("},");
                }
                if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
                {
                    jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
                }
                jsonStringBuilder.Append("]");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
                #endregion
            }
            else if (examTable.E_Kind == 2)
            {
                #region 多站式考试
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
                { 
                    {"E_ID,EQ", E_ID},
                    {"ES_ID,EQ", ES_ID},
                    {"Room_ID,EQ", Room_ID},
                    {"JudgeUserInfoID,EQ", U_ID}
                };
                
                if (searchKeyword != null && searchKeyword != "")
                {
                    conditionDictionary.Add("UserInfoName,UserInfoTrueName,ExamStudentNumber,Like", searchKeyword);
                }
                else
                {
                    conditionDictionary.Add("Exam_StartTime,GE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00", "yyyy-MM-dd HH:mm:ss", null));
                    conditionDictionary.Add("Exam_StartTime,LE", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59", "yyyy-MM-dd HH:mm:ss", null));
                    if (searchType == "2")
                    {
                        conditionDictionary.Add("ScoreInfoID,IsNotNull", "");
                    }
                    else if (searchType == "3")
                    {
                        conditionDictionary.Add("ScoreInfoID,IsNull", "");
                    }
                }
                Tellyes.BLL.MultiStationExamArrangement multiStationExamArrangementBLL = new Tellyes.BLL.MultiStationExamArrangement();
                int? studentCountObject = multiStationExamArrangementBLL.SearchStudentCountInHandScoreByCondition(conditionDictionary);
                if (studentCountObject == null)
                {
                    Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }
                int studentCount = Convert.ToInt32(studentCountObject);
                if (studentCount == 0)
                {
                    Response.Write("{\"result\":\"1\",\"page_index\":\"1\",\"student_list\":[]}");
                    return;
                }

                int pageCount = (studentCount + pageSize - 1) / pageSize;
                pageIndex = pageIndex < 1 ? 1 : pageIndex;
                pageIndex = pageIndex > pageCount ? pageCount : pageIndex;

                List<Dictionary<string, object>> studentList 
                    = multiStationExamArrangementBLL.SearchStudentListInHandScoreByCondition(conditionDictionary, pageIndex, pageSize);
                if (studentList == null) 
                {
                    Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }

                StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"page_index\":\"").Append(pageIndex).Append("\",");
                jsonStringBuilder.Append("\"student_list\":[");
                foreach (Dictionary<string, object> student in studentList)
                {
                    jsonStringBuilder.Append("{");
                    jsonStringBuilder.Append("\"U_ID\":\"").Append(student["StudentUserInfoID"]).Append("\",");
                    jsonStringBuilder.Append("\"U_TrueName\":\"").Append(Uri.EscapeDataString(student["StudentUserInfoTrueName"].ToString())).Append("\",");
                    jsonStringBuilder.Append("\"U_Name\":\"").Append(student["StudentUserInfoName"]).Append("\",");
                    jsonStringBuilder.Append("\"EStu_ExamNumber\":\"").Append(student["ExamStudentNumber"]).Append("\",");
                    jsonStringBuilder.Append("\"O_Name\":\"").Append(student["OrganizationName"] == null ? "" : Uri.EscapeDataString(student["OrganizationName"].ToString())).Append("\",");
                    jsonStringBuilder.Append("\"Exam_StartTime\":\"").Append(Convert.ToDateTime(student["ExamStartTime"]).ToString("HH:mm")).Append("\",");
                    jsonStringBuilder.Append("\"Exam_EndTime\":\"").Append(Convert.ToDateTime(student["ExamEndTime"]).ToString("HH:mm")).Append("\",");
                    jsonStringBuilder.Append("\"Exam_Date\":\"").Append(Convert.ToDateTime(student["ExamStartTime"]).ToString("yyyy-MM-dd")).Append("\",");
                    jsonStringBuilder.Append("\"student_state\":\"").Append(student["StudentState"] == null ? "3" : student["StudentState"]).Append("\",");
                    jsonStringBuilder.Append("\"student_score\":\"").Append(student["StudentState"] != null && student["StudentState"].Equals(2) ? (student["StudentScore"].Equals(0) ? "0" : String.Format("{0:N1}", student["StudentScore"])) : "").Append("\"");
                    jsonStringBuilder.Append("},");
                }
                if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
                {
                    jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
                }
                jsonStringBuilder.Append("]");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
                #endregion
            }
            else if (examTable.E_Kind == 3)
            {
                #region 单站式考试
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
                { 
                    {"E_ID,Eq", E_ID},
                    {"ES_ID,Eq", ES_ID},
                    {"Room_ID,Eq", Room_ID},
                    {"JudgeUserInfoID,Eq", U_ID}
                };

                if (searchKeyword != null && searchKeyword != "")
                {
                    conditionDictionary.Add("UserInfoName,UserInfoTrueName,ExamStudentNumber,Like", searchKeyword);
                }
                else
                {
                    conditionDictionary.Add("SE_StartTime,Ge", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00", "yyyy-MM-dd HH:mm:ss", null));
                    conditionDictionary.Add("SE_StartTime,Le", DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59", "yyyy-MM-dd HH:mm:ss", null));
                    if (searchType == "2")
                    {
                        conditionDictionary.Add("ScoreInfoID,IsNotNull", "");
                    }
                    else if (searchType == "3")
                    {
                        conditionDictionary.Add("ScoreInfoID,IsNull", "");
                    }
                }
                Tellyes.BLL.SingleStationExamArrangement singleStationExamArrangementBLL = new Tellyes.BLL.SingleStationExamArrangement();
                int? studentCountObject = singleStationExamArrangementBLL.SearchStudentCountInHandScoreByCondition(conditionDictionary);
                if (studentCountObject == null)
                {
                    Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }
                int studentCount = Convert.ToInt32(studentCountObject);
                if (studentCount == 0)
                {
                    Response.Write("{\"result\":\"1\",\"page_index\":\"1\",\"student_list\":[]}");
                    return;
                }

                int pageCount = (studentCount + pageSize - 1) / pageSize;
                pageIndex = pageIndex < 1 ? 1 : pageIndex;
                pageIndex = pageIndex > pageCount ? pageCount : pageIndex;

                List<Dictionary<string, object>> studentList
                    = singleStationExamArrangementBLL.SearchStudentListInHandScoreByCondition(conditionDictionary, pageIndex, pageSize);
                if (studentList == null)
                {
                    Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，E_ID：" + E_ID);
                    Response.Write(errorJsonString);
                    return;
                }

                StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"page_index\":\"").Append(pageIndex).Append("\",");
                jsonStringBuilder.Append("\"student_list\":[");
                foreach (Dictionary<string, object> student in studentList)
                {
                    jsonStringBuilder.Append("{");
                    jsonStringBuilder.Append("\"U_ID\":\"").Append(student["StudentUserInfoID"]).Append("\",");
                    jsonStringBuilder.Append("\"U_TrueName\":\"").Append(Uri.EscapeDataString(student["StudentUserInfoTrueName"].ToString())).Append("\",");
                    jsonStringBuilder.Append("\"U_Name\":\"").Append(student["StudentUserInfoName"]).Append("\",");
                    jsonStringBuilder.Append("\"EStu_ExamNumber\":\"").Append(student["ExamStudentNumber"]).Append("\",");
                    jsonStringBuilder.Append("\"O_Name\":\"").Append(student["OrganizationName"] == null ? "" : Uri.EscapeDataString(student["OrganizationName"].ToString())).Append("\",");
                    jsonStringBuilder.Append("\"Exam_StartTime\":\"").Append(Convert.ToDateTime(student["ExamStartTime"]).ToString("HH:mm")).Append("\",");
                    jsonStringBuilder.Append("\"Exam_EndTime\":\"").Append(Convert.ToDateTime(student["ExamEndTime"]).ToString("HH:mm")).Append("\",");
                    jsonStringBuilder.Append("\"Exam_Date\":\"").Append(Convert.ToDateTime(student["ExamStartTime"]).ToString("yyyy-MM-dd")).Append("\",");
                    jsonStringBuilder.Append("\"student_state\":\"").Append(student["StudentState"] == null ? "3" : student["StudentState"]).Append("\",");
                    jsonStringBuilder.Append("\"student_score\":\"").Append(student["StudentState"] != null && student["StudentState"].Equals(2) ? (student["StudentScore"].Equals(0) ? "0" : String.Format("{0:N1}", student["StudentScore"])) : "").Append("\"");
                    jsonStringBuilder.Append("},");
                }
                if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
                {
                    jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
                }
                jsonStringBuilder.Append("]");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
                #endregion
            }
            else
            {
                Response.Write(errorJsonString);
                Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败，未知的考试类型，E_ID：" + E_ID);
                return;
            }
        }

        /// <summary>
        /// 查询学生照片
        /// </summary>
        private void SearchStudentPhoto()
        {
            int U_ID = Convert.ToInt32(Request.QueryString["U_ID"]);

            Tellyes.Model.UserInfo userInfo = new Tellyes.BLL.UserInfo().SearchUserInfoByID(U_ID);
            if (userInfo == null) 
            {
                Log4NetUtility.Error(this, "手持评分，查询学生照片失败，U_ID：" + U_ID);
                return;
            }

            Response.Cache.SetNoStore();
            Response.ClearContent();
            Response.ContentType = "application/octet-stream";
            if (userInfo.U_Photo != null)
            {
                Response.BinaryWrite(userInfo.U_Photo.ToArray());
            }
        }
        /// <summary>
        /// 查询学生照片从userphoto表中
        /// </summary>
        private void SearchStudentPhotoFromUserPhoto()
        {
            int U_ID = Convert.ToInt32(Request.QueryString["U_ID"]);
            string E_ID = Request.QueryString["E_ID"].ToString();
         
            Tellyes.BLL.UserPhoto userInfo = new Tellyes.BLL.UserPhoto();
            byte[] img = userInfo.GetUserPhoto(U_ID, Guid.Parse(E_ID));
            if (img == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询学生照片失败，U_ID：" + U_ID);
                return;
            }

            Response.Cache.SetNoStore();
            Response.ClearContent();
            Response.ContentType = "application/octet-stream";
            if (img.Length>0)
            {
                Response.BinaryWrite(img);
            }
        }
        /// <summary>
        /// 查询评分表
        /// </summary>
        private void SearchMarkSheet()
        {
            string errorJsonString = "{\"result\":\"0\"}";

            Guid EU_ID = Guid.Parse(Request.Form["EU_ID"]);

            List<Tellyes.Model.MarkSheet> markSheetList
                = new Tellyes.BLL.ExamUserMarkSheet().SearchMarkSheetByExamUserID(EU_ID);
            if (markSheetList == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询评委评分表失败，EU_ID：" + EU_ID);
                Response.Write(errorJsonString);
                return;
            }

            List<int> markSheetIDList = new List<int>();
            foreach (Tellyes.Model.MarkSheet markSheet in markSheetList)
            {
                markSheetIDList.Add(markSheet.MS_ID);
            }
            List<Tellyes.Model.MarkSheetItem> markSheetItemList = new Tellyes.BLL.MarkSheetItem().SearchMarkSheetItemByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"MS_ID,IN", markSheetIDList}
                },
                new List<KeyValuePair<string, string>>() 
                { 
                    new KeyValuePair<string, string>("MSI_ID", "asc")
                }
            );
            if (markSheetItemList == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询评委评分表评分项失败，EU_ID：" + EU_ID);
                Response.Write(errorJsonString);
                return;
            }

            StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
            jsonStringBuilder.Append("{");
            jsonStringBuilder.Append("\"result\":\"1\",");
            jsonStringBuilder.Append("\"mark_sheet_list\":[");
            foreach (Tellyes.Model.MarkSheet markSheet in markSheetList)
            {
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"MS_ID\":\"").Append(markSheet.MS_ID).Append("\",");
                jsonStringBuilder.Append("\"MS_Name\":\"").Append(Uri.EscapeDataString(markSheet.MS_Name)).Append("\",");
                jsonStringBuilder.Append("\"item_list\":[");
                decimal? markSheetScoreSum = 0;
                foreach (Tellyes.Model.MarkSheetItem markSheetItem in markSheetItemList) 
                {
                    if (markSheetItem.MS_ID == markSheet.MS_ID && markSheetItem.string1 == "0")
                    {
                        markSheetScoreSum += markSheetItem.MSI_Score;
                        jsonStringBuilder.Append("{");
                        jsonStringBuilder.Append("\"MSI_ID\":\"").Append(markSheetItem.MSI_ID).Append("\",");
                        jsonStringBuilder.Append("\"MSI_Item\":\"").Append(Uri.EscapeDataString(markSheetItem.MSI_Item)).Append("\",");
                        string markSheetID = Convert.ToString(markSheetItem.MSI_ID);
                        int i = 0;
                        for (; i < markSheetItemList.Count && markSheetItemList[i].string1 != markSheetID; i++) ;
                        if (i < markSheetItemList.Count)
                        {
                            jsonStringBuilder.Append("\"children_item_list\":[");
                            foreach (Tellyes.Model.MarkSheetItem subMarkSheetItem in markSheetItemList)
                            {
                                if (Convert.ToString(markSheetItem.MSI_ID) == subMarkSheetItem.string1)
                                {
                                    jsonStringBuilder.Append("{");
                                    jsonStringBuilder.Append("\"MSI_ID\":\"").Append(subMarkSheetItem.MSI_ID).Append("\",");
                                    jsonStringBuilder.Append("\"MSI_Item\":\"").Append(Uri.EscapeDataString(subMarkSheetItem.MSI_Item)).Append("\",");
                                    jsonStringBuilder.Append("\"MSI_Score\":\"").Append(subMarkSheetItem.MSI_Score).Append("\"");
                                    jsonStringBuilder.Append("},");
                                }
                            }
                            if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
                            {
                                jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
                            }
                            jsonStringBuilder.Append("]");
                        }
                        else 
                        {
                            jsonStringBuilder.Append("\"MSI_Score\":\"").Append(markSheetItem.MSI_Score).Append("\"");
                        }
                        jsonStringBuilder.Append("},");
                    }
                }
                if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
                {
                    jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
                }
                jsonStringBuilder.Append("],");
                jsonStringBuilder.Append("\"MS_Sum\":\"").Append(markSheetScoreSum).Append("\"");
                jsonStringBuilder.Append("},");
            }
            if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
            {
                jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
            }
            jsonStringBuilder.Append("]");
            jsonStringBuilder.Append("}");
            Response.Write(jsonStringBuilder.ToString());
        }

        /// <summary>
        /// 查询学生得分
        /// </summary>
        private void SearchStudentScore()
        {
            string errorJsonString = "{\"result\":\"0\"}";

            Guid E_ID = Guid.Parse(Request.Form["E_ID"]);
            Guid ES_ID = Guid.Parse(Request.Form["ES_ID"]);
            int Room_ID = Convert.ToInt32(Request.Form["Room_ID"]);
            int U_ID = Convert.ToInt32(Request.Form["U_ID"]);
            int Student_U_ID = Convert.ToInt32(Request.Form["Student_U_ID"]);

            Tellyes.Model.ScoreInfo scoreInfo = new Tellyes.BLL.ScoreInfo().SearchUniqueScoreInfoByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"Exam_ID,EQ", E_ID},
                    {"ExamStation_ID,EQ", ES_ID},
                    {"Room_ID,EQ", Room_ID},
                    //{"ScoreInfo_Type,EQ", 2},
                    {"Rater_ID,EQ", U_ID},
                    {"Student_ID,EQ", Student_U_ID}
                }
            );
            if (scoreInfo == null) 
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩失败，E_ID：" + E_ID + "，ES_ID：" + ES_ID + "，Room_ID：" + Room_ID + "，Rater_ID：" + U_ID + "，Student_ID：" + Student_U_ID);
                Response.Write(errorJsonString);
                return;
            }

            if (scoreInfo.SI_int1 == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩失败，评分表ID为空");
                Response.Write(errorJsonString);
                return;
            }
            int markSheetID = Convert.ToInt32(scoreInfo.SI_int1);
            Tellyes.Model.MarkSheet markSheet = new Tellyes.BLL.MarkSheet().SearchMarkSheetByID(markSheetID);
            if (markSheet == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩失败，评分表查询失败，MarkSheetID：" + markSheetID);
                Response.Write(errorJsonString);
                return;
            }

            List<Tellyes.Model.MarkSheetItem> markSheetItemList = new Tellyes.BLL.MarkSheetItem().SearchMarkSheetItemByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"MarkSheetID,EQ", markSheetID}
                }
            );
            if (markSheetItemList == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩失败，评分表评分项查询失败，MarkSheetID：" + markSheetID);
                Response.Write(errorJsonString);
                return;
            }
            decimal? markSheetScore = 0;
            foreach (Tellyes.Model.MarkSheetItem markSheetItem in markSheetItemList)
            {
                if(markSheetItem.string1 == "0")
                {
                    markSheetScore += markSheetItem.MSI_Score;
                }
            }

            Tellyes.Model.ExamStudent examStudent = new Tellyes.BLL.ExamStudent().SearchUniqueExamStudentByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"E_ID,EQ", E_ID},
                    {"U_ID,EQ", Student_U_ID}
                }
            );
            if (examStudent == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩失败，查询考生信息失败，E_ID：" + E_ID + "，Student_ID：" + Student_U_ID);
                Response.Write(errorJsonString);
                return;
            }

            Tellyes.Model.UserInfo studentUserInfo = new Tellyes.BLL.UserInfo().SearchUserInfoByID(Student_U_ID);
            if (studentUserInfo == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩失败，查询考生用户信息失败，Student_ID：" + Student_U_ID);
                Response.Write(errorJsonString);
                return;
            }

            List<Tellyes.Model.Organization> organizationList = new Tellyes.BLL.Organization().SearchOrganizationByUserInfoID(Student_U_ID);
            if (organizationList == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩失败，查询考生用户班级信息失败，Student_ID：" + Student_U_ID);
                Response.Write(errorJsonString);
                return;
            }

            StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
            jsonStringBuilder.Append("{");
            jsonStringBuilder.Append("\"result\":\"1\",");

            jsonStringBuilder.Append("\"SI_ID\":\"").Append(scoreInfo.SI_ID).Append("\",");
            jsonStringBuilder.Append("\"SI_CreateTime\":\"").Append(scoreInfo.SI_CreateTime.ToString("yyyy-MM-dd HH:mm")).Append("\",");
            jsonStringBuilder.Append("\"SI_Score\":\"").Append(scoreInfo.SI_Score == 0 ? "0" : String.Format("{0:N1}", scoreInfo.SI_Score)).Append("\",");

            jsonStringBuilder.Append("\"EStu_ExamNumber\":\"").Append(examStudent.EStu_ExamNumber).Append("\",");
            jsonStringBuilder.Append("\"U_TrueName\":\"").Append(Uri.EscapeDataString(studentUserInfo.U_TrueName)).Append("\",");
            jsonStringBuilder.Append("\"U_Name\":\"").Append(studentUserInfo.U_Name).Append("\",");
            jsonStringBuilder.Append("\"O_Name\":\"").Append(organizationList.Count > 0 ? Uri.EscapeDataString(organizationList[0].O_Name) : "").Append("\",");

            jsonStringBuilder.Append("\"MS_ID\":\"").Append(scoreInfo.SI_int1).Append("\",");
            jsonStringBuilder.Append("\"MS_Name\":\"").Append(Uri.EscapeDataString(markSheet.MS_Name)).Append("\",");
            jsonStringBuilder.Append("\"MS_Sum\":\"").Append(markSheetScore).Append("\",");

            try
            {
                new JavaScriptSerializer().Deserialize<ArrayList>(scoreInfo.SI_Items);
                jsonStringBuilder.Append("\"item_score_list\":").Append(scoreInfo.SI_Items);
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生成绩，评分表评分内容字符串解析失败，SI_Items：" + scoreInfo.SI_Items, e);
                jsonStringBuilder.Append("\"item_score_list\":").Append("[]");
            }
            jsonStringBuilder.Append("}");
            Response.Write(jsonStringBuilder.ToString());
        }

        /// <summary>
        /// 查询成绩提交签名图像  
        /// </summary>
        private void SearchScoreInfoImage()
        {
            int SI_ID = Convert.ToInt32(Request.QueryString["SI_ID"]);

            Tellyes.Model.ScoreInfo scoreInfo = new Tellyes.BLL.ScoreInfo().SearchScoreInfoByID(SI_ID);
            if (scoreInfo == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询评分成绩签名图片失败，SI_ID：" + SI_ID);
                return;
            }

            Response.Cache.SetNoStore();
            Response.ClearContent();
            Response.ContentType = "application/octet-stream";
            if (scoreInfo.SI_DigitalSignature != null)
            {
                Response.BinaryWrite(scoreInfo.SI_DigitalSignature.ToArray());
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
            decimal SI_Score = Convert.ToDecimal(Request.Form["SI_Score"]);
            string SI_Item = Request.Form["SI_Item"];
            int MS_ID = Convert.ToInt32(Request.Form["MS_ID"]);
            Guid EU_ID = Guid.Parse(Request.Form["EU_ID"]);

            Tellyes.BLL.ExamUser examUserBLL = new Tellyes.BLL.ExamUser();
            Tellyes.Model.ExamUser examUser = examUserBLL.SearchExamUserByID(EU_ID);
            if (examUser == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考试评委信息失败，EU_ID：" + EU_ID);
                Response.Write(errorJsonString1);
                return;
            }

            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            { 
                {"Exam_ID,EQ", E_ID},
                {"ExamStation_ID,EQ", ES_ID},
                {"Room_ID,EQ", Room_ID},
                //{"ScoreInfo_Type,EQ", 2},
                {"Rater_ID,EQ", Judge_U_ID},
                {"Student_ID,EQ", Student_U_ID}
            };
            Tellyes.BLL.ScoreInfo scoreInfoBLL = new Tellyes.BLL.ScoreInfo();
            List<Tellyes.Model.ScoreInfo> scoreInfoList = scoreInfoBLL.SearchScoreInfoByCondition(conditionDictionary);
            if (scoreInfoList == null)
            {
                Log4NetUtility.Error(this, "手持评分，考生评分信息查询失败");
                Response.Write(errorJsonString1);
                return;
            }
            Tellyes.Model.ScoreInfo scoreInfo = new Tellyes.Model.ScoreInfo();
            if (scoreInfoList.Count > 0)
            {
                scoreInfo = scoreInfoList[0];
                if (scoreInfo.SI_int2 == 2)
                {
                    Log4NetUtility.Error(this, "手持评分，考生评分信息已存在");
                    Response.Write(errorJsonString2);
                    return;
                }
                else if (scoreInfo.SI_int2 == 1)
                {
                   Tellyes.BLL.ScoreInfo exec=new Tellyes.BLL.ScoreInfo();
                   exec.Delete(scoreInfo.SI_ID);                
                }
            }

            scoreInfo.Exam_ID = E_ID;
            scoreInfo.ExamStation_ID = ES_ID;
            scoreInfo.Room_ID = Room_ID;
            scoreInfo.Score_Percent = examUser.int1;
            scoreInfo.Student_ID = Student_U_ID;
            scoreInfo.SI_Type = 2;
            scoreInfo.Rater_ID = Judge_U_ID;
            scoreInfo.SI_Score = SI_Score;
            scoreInfo.SI_Items = Request.Form["SI_Items"];
            scoreInfo.SI_CreateTime = DateTime.Now;
            scoreInfo.SI_int1 = Convert.ToInt32(Request.Form["MS_ID"]);
            scoreInfo.SI_int2 = 2;
            scoreInfo.calcuated = 0;
            scoreInfo.timeStamp = "";
            
            try 
            {
                HttpPostedFile image = Request.Files["image"];
                int length = image.ContentLength;
                byte[] imageByteArray = new byte[length];
                Stream imageStream = image.InputStream;

                imageStream.Read(imageByteArray, 0, length);
                scoreInfo.SI_DigitalSignature = imageByteArray;
            }
            catch(Exception e)
            {
                Log4NetUtility.Error(this, "手持评分，签名图片上传失败，EU_ID：" + EU_ID + "，Student_UserInfo_ID：" + Student_U_ID, e);
                Response.Write(errorJsonString1);
                return;
            }

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
                markSheetItemScoreList = (ArrayList)new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(scoreInfoItemJsonString)["item_list"];

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
                    if (markSheetItemScore.ContainsKey("MSI_Score"))
                    {
                        scoreInfoItemStringBuilder.Append("\"MSI_Score\":\"").Append(markSheetItem.MSI_Score).Append("\",");
                        scoreInfoItemStringBuilder.Append("\"Item_Score\":\"").Append(markSheetItemScore["MSI_Score"]).Append("\"");
                    }
                    else if (markSheetItemScore.ContainsKey("children_item_list"))
                    {
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
                            scoreInfoItemStringBuilder.Append("\"Item_Score\":\"").Append(subMarkSheetItemScore["MSI_Score"]).Append("\"");
                            scoreInfoItemStringBuilder.Append("},");
                        }
                        if (scoreInfoItemStringBuilder[scoreInfoItemStringBuilder.Length - 1] == ',')
                        {
                            scoreInfoItemStringBuilder.Remove(scoreInfoItemStringBuilder.Length - 1, 1);
                        }
                        scoreInfoItemStringBuilder.Append("]");
                    }
                    else
                    {
                        scoreInfoItemStringBuilder.Remove(scoreInfoItemStringBuilder.Length - 1, 1);
                    }
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
                Log4NetUtility.Error(this, "手持评分，评分表评分内容解析失败，SI_Items：" + scoreInfoItemJsonString, e);
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
            scoreSummariedScore.ScoreType = 1;
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
            scoreLog.LogType = 1;
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

        /// <summary>
        /// 提交学生缺考信息
        /// </summary>
        private void AddScoreInfoWithMiss()
        {
            string errorJsonString1 = "{\"result\":\"0\"}";
            string errorJsonString2 = "{\"result\":\"-1\"}";

            Guid E_ID = Guid.Parse(Request.Form["E_ID"]);
            Guid ES_ID = Guid.Parse(Request.Form["ES_ID"]);
            int Room_ID = Convert.ToInt32(Request.Form["Room_ID"]);
            int Student_U_ID = Convert.ToInt32(Request.Form["Student_U_ID"]);
            int Judge_U_ID = Convert.ToInt32(Request.Form["U_ID"]);
            Guid EU_ID = Guid.Parse(Request.Form["EU_ID"]);

            Tellyes.BLL.ExamUser examUserBLL = new Tellyes.BLL.ExamUser();
            Tellyes.Model.ExamUser examUser = examUserBLL.SearchExamUserByID(EU_ID);
            if (examUser == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考试评委信息失败，EU_ID：" + EU_ID);
                Response.Write(errorJsonString1);
                return;
            }

            Tellyes.Model.ScoreInfo scoreInfo = new Tellyes.Model.ScoreInfo();
            scoreInfo.Exam_ID = E_ID;
            scoreInfo.ExamStation_ID = ES_ID;
            scoreInfo.Room_ID = Room_ID;
            scoreInfo.Score_Percent = examUser.int1;
            scoreInfo.Student_ID = Student_U_ID;
            scoreInfo.SI_Type = 2;
            scoreInfo.Rater_ID = Judge_U_ID;
            scoreInfo.SI_Score = 0;
            scoreInfo.SI_Items = "";
            scoreInfo.SI_CreateTime = DateTime.Now;
            scoreInfo.SI_int1 = 0;
            scoreInfo.SI_int2 = 1;
            scoreInfo.calcuated = 0;
            scoreInfo.timeStamp = "";

            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            { 
                {"Exam_ID,EQ", scoreInfo.Exam_ID},
                {"ExamStation_ID,EQ", scoreInfo.ExamStation_ID},
                {"Room_ID,EQ", scoreInfo.Room_ID},
                {"ScoreInfo_Type,EQ", scoreInfo.SI_Type},
                {"Rater_ID,EQ", scoreInfo.Rater_ID},
                {"Student_ID,EQ", scoreInfo.Student_ID}
            };
            Tellyes.BLL.ScoreInfo scoreInfoBLL = new Tellyes.BLL.ScoreInfo();
            bool? isScoreInfoExists = scoreInfoBLL.SearchScoreInfoExists(conditionDictionary);
            if (isScoreInfoExists == null)
            {
                Log4NetUtility.Error(this, "手持评分，考生评分信息查询失败");
                Response.Write(errorJsonString1);
                return;
            }
            if (Convert.ToBoolean(isScoreInfoExists))
            {
                Log4NetUtility.Error(this, "手持评分，考生评分信息已存在");
                Response.Write(errorJsonString2);
                return;
            }

            try
            {
                HttpPostedFile image = Request.Files["image"];
                int length = image.ContentLength;
                byte[] imageByteArray = new byte[length];
                Stream imageStream = image.InputStream;
                imageStream.Read(imageByteArray, 0, length);
                scoreInfo.SI_DigitalSignature = imageByteArray;
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持评分，考生缺考，签名图片上传失败，EU_ID：" + EU_ID + "，Student_UserInfo_ID：" + Student_U_ID, e);
                //Response.Write(errorJsonString1);
                //return;
            }

            Dictionary<string, object> entityDictionary = new Dictionary<string, object>() 
            { 
                {"ScoreInfo,Add", scoreInfo}
            };

            Tellyes.BLL.ScoreSummariedScore scoreSummariedScoreBLL = new Tellyes.BLL.ScoreSummariedScore();
            Tellyes.Model.ScoreSummariedScore scoreSummariedScore
                = scoreSummariedScoreBLL.CreateScoreSummariedScoreObject(E_ID, ES_ID, EU_ID, Room_ID, Student_U_ID, Judge_U_ID, 0);
            if (scoreSummariedScore == null)
            {
                Log4NetUtility.Error(this, "手持评分，成绩统计汇总错误");
                Response.Write(errorJsonString1);
                return;
            }
            scoreSummariedScore.ScoreType = 1;
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
            scoreLog.LogType = 1;
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

        /// <summary>
        /// 获取当前系统时间
        /// </summary>
        private void SearchCurrentSystemDatetime()
        {
            Response.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        /// 获取当前考站信息
        /// </summary>
        private void SearchExamStationInfoByExamStationID()
        {
            string errorJsonString = "{\"result\":\"0\"}";

            Guid examStationID = Guid.Parse(Request.Form["ES_ID"]);
            Tellyes.Model.ExamStation examStation = new Tellyes.BLL.ExamStation().SearchExamStationByID(examStationID);
            if (examStation == null) 
            {
                Log4NetUtility.Error(this, "查询考站信息失败，examStationID：" + examStationID);
                Response.Write(errorJsonString);
                return;
            }

            Guid examTableID = Guid.Parse(Request.Form["E_ID"]);
            Tellyes.Model.ExamTable examTable = new Tellyes.BLL.ExamTable().SearchExamTableByID(examTableID);
            if (examTable == null)
            {
                Log4NetUtility.Error(this, "查询考试信息失败，examTableID：" + examTableID);
                Response.Write(errorJsonString);
                return;
            }
            Tellyes.Model.IllnessCase illnessCase = null;
            Tellyes.Model.IllnessCaseScript illnessCaseScript = null;
            if (examStation.ESC_ID == 6 || examStation.ESC_ID == 8)
            {
                Dictionary<string, object> examStationIllnessCaseDictionary = new Tellyes.BLL.IllnessCase().SearchIllnessCaseByExamStationID(examStationID, Convert.ToInt32(examTable.E_Kind));
                if (examStationIllnessCaseDictionary == null)
                {
                    Log4NetUtility.Error(this, "考站病例与病例脚本信息查询失败，examStationID：" + examStationID);
                    Response.Write(errorJsonString);
                    return;
                }
                illnessCase = (Tellyes.Model.IllnessCase)examStationIllnessCaseDictionary["illnessCase"];
                illnessCaseScript = (Tellyes.Model.IllnessCaseScript)examStationIllnessCaseDictionary["illnessCaseScript"];
            }

            StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
            jsonStringBuilder.Append("{");
            jsonStringBuilder.Append("\"result\":\"1\",");
            jsonStringBuilder.Append("\"ES_Name\":\"").Append(Uri.EscapeDataString(examStation.ES_Name)).Append("\",");
            jsonStringBuilder.Append("\"ES_Curriculum\":\"").Append(Uri.EscapeDataString(examStation.ES_Curriculum)).Append("\",");
            jsonStringBuilder.Append("\"ES_Ccontent\":\"").Append(Uri.EscapeDataString(examStation.ES_Ccontent)).Append("\",");
            jsonStringBuilder.Append("\"ExamTimeNum\":\"").Append(examStation.ES_Kind == 1 ? examTable.E_LongStationExamTimeNum : examTable.E_ShortStationExamTimeNum).Append("\",");
            jsonStringBuilder.Append("\"ScoreTimeNum\":\"").Append(examStation.ES_Kind == 1 ? examTable.E_LongStationScoreTimeNum : examTable.E_ShortStationScoreTimeNum).Append("\"");

            if (examStation.ESC_ID == 6 || examStation.ESC_ID == 8)
            {
                jsonStringBuilder
                    .Append(",")
                    .Append("\"illnessCaseContent\":\"").Append(Uri.EscapeDataString(illnessCase.IllnessCaseContent)).Append("\",")
                    .Append("\"illnessCaseScriptContent\":\"").Append(Uri.EscapeDataString(illnessCaseScript.IllnessCaseScriptContent)).Append("\"");
            }

            jsonStringBuilder.Append("}");
            Response.Write(jsonStringBuilder.ToString());
        }
    }
}