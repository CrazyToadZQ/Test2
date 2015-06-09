using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Reflection;
using System.Data;
using System.Text;
using System.IO;
using Tellyes.Log4Net;
using System.Drawing;

namespace OSCEExamPlatformWeb.AppDataInterface
{
    public partial class ExamInfoShow : System.Web.UI.Page
    {
        private const string PAGE_PATH_INFO = "/AppDataInterface/ExamInfoShow.aspx";
        private const string ASSEMBLY_NAME = "OSCEExamPlatformWeb";
        private const string CLASS_NAME = "OSCEExamPlatformWeb.AppDataInterface.ExamInfoShow";

        private Tellyes.BLL.ExamTable ExamTableBLL = new Tellyes.BLL.ExamTable();
        private Tellyes.BLL.Room1 RoomBLL = new Tellyes.BLL.Room1();
        private Tellyes.BLL.SingleStationExamArrangement SingleExamBLL = new Tellyes.BLL.SingleStationExamArrangement();
        private Tellyes.BLL.MultiStationExamArrangement MultiExamBLL = new Tellyes.BLL.MultiStationExamArrangement();
        private Tellyes.BLL.OSCEExaminationArrangement OsceBLL = new Tellyes.BLL.OSCEExaminationArrangement();
        private Tellyes.BLL.OSCEExamArrangement_ExamStudent_ExamStationRoom2 OSCEExamBLL = new Tellyes.BLL.OSCEExamArrangement_ExamStudent_ExamStationRoom2();
        private Tellyes.BLL.ExamStation ExamStationBLL = new Tellyes.BLL.ExamStation();
        private Tellyes.BLL.ExamStudent ExamStudentBLL = new Tellyes.BLL.ExamStudent();
        private Tellyes.BLL.UserInfo UserInfoBLL = new Tellyes.BLL.UserInfo();
        private Tellyes.BLL.UserPhoto UserPhotoBLL = new Tellyes.BLL.UserPhoto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["PATH_INFO"].StartsWith(PAGE_PATH_INFO + "/"))
            {
                Response.End();
            }
        }

        protected override void OnInit(EventArgs e)
        {
            string pathInfo = Request.Params["PATH_INFO"];
            if (pathInfo.StartsWith(PAGE_PATH_INFO + "/"))
            {
                string[] nameList = pathInfo.Substring(PAGE_PATH_INFO.Length + 1).Split('/');
                if (nameList.Length < 1)
                {
                    Response.End();
                    return;
                }

                try
                {
                    Assembly assembly = Assembly.Load(ASSEMBLY_NAME);
                    Type type = assembly.GetType(CLASS_NAME);
                    MethodInfo method = type.GetMethod(nameList[0], System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    method.Invoke(this, null);
                }
                catch (Exception ex)
                {
                    Response.End();
                    return;
                }
            }
        }

        //查找考试ID
        private string GetExamID()
        {
            string ExamID = "";
            DateTime dt;
            string RoomName = Request.Form["RoomName"];
            int RoomID = RoomBLL.GetRoomID(RoomName);
            DataTable dtSingle = SingleExamBLL.GetExamID(RoomID.ToString());
            DataTable dtMulti = MultiExamBLL.GetExamID(RoomID.ToString());
            DataTable dtOSCE = OSCEExamBLL.GetExamID(RoomID.ToString());

            int rows = dtMulti.Rows.Count;
            int rows2 = dtOSCE.Rows.Count;
            int rows3 = dtSingle.Rows.Count;

            #region 获取考试ID
            if (rows > 0)
            {
                DateTime dt1 = DateTime.Parse(dtMulti.Rows[0]["Exam_EndTime"].ToString());
                ExamID = dtMulti.Rows[0]["E_ID"].ToString();
                dt = dt1;

                if (rows2 > 0)
                {
                    DateTime dt2 = DateTime.Parse(dtOSCE.Rows[0]["OEA_EndTime"].ToString());
                    if (dt2 < dt)
                    {
                        dt = dt2;
                        ExamID = dtOSCE.Rows[0]["E_ID"].ToString();
                    }
                }

                if (rows3 > 0)
                {
                    DateTime dt3 = DateTime.Parse(dtSingle.Rows[0]["SE_StartTime"].ToString());
                    if (dt3 < dt)
                    {
                        ExamID = dtSingle.Rows[0]["E_ID"].ToString();
                    }
                }
            }
            else
            {
                if (rows2 > 0)
                {
                    DateTime dt2 = DateTime.Parse(dtOSCE.Rows[0]["OEA_EndTime"].ToString());
                    ExamID = dtOSCE.Rows[0]["E_ID"].ToString();
                    dt = dt2;

                    if (rows3 > 0)
                    {
                        DateTime dt3 = DateTime.Parse(dtSingle.Rows[0]["SE_StartTime"].ToString());
                        if (dt3 < dt)
                        {
                            ExamID = dtSingle.Rows[0]["E_ID"].ToString();
                        }
                    }
                }
                else
                {
                    if (rows3 > 0)
                    {
                        ExamID = dtSingle.Rows[0]["E_ID"].ToString();
                    }
                }
            }
            #endregion

            return ExamID;
        }

        //获取考站信息
        private void GetStationInfoUTF8()
        {
            string Curriculum = "";//考试科目
            string Content = "";//考试内容
            string EsName = "";//当前考站名称
            string RoomName = "";//当前考站的房间名称
            string ExamName = "";//考试名称
            string StationExamTime = "";//考站考试时间
            string StationScoreTime = "";//考站评分时间
            string ShortStationExamTime = "";
            string ShortStationScoreTime = "";
            string ExamKind = "";//考试种类
            string SystemTime = "";
            string ExamStartTime = "";//考试开始时间
            string ExamEndTime = "";//考试结束时间

            try
            {
                #region 获取信息
                string ExamIDStr = GetExamID();
                if (string.IsNullOrEmpty(ExamIDStr))
                {
                    string errorJson1 = "{\"result\":\"没有考试\"}";
                    Response.Write(errorJson1);
                    return;
                }
                Guid EID = new Guid(ExamIDStr);//考试的GUID
                RoomName = Request.Form["RoomName"];
                int RoomID = RoomBLL.GetRoomID(RoomName);
                Tellyes.Model.ExamTable ExamTableModel = ExamTableBLL.GetModel(EID);
                ExamName = ExamTableModel.E_Name;
                ExamKind = ExamTableModel.E_Kind.ToString();

                StationExamTime = ExamTableModel.E_LongStationExamTimeNum.ToString();
                StationScoreTime = ExamTableModel.E_LongStationScoreTimeNum.ToString();
                string ESIDStr = "";

                if (ExamTableModel.E_Kind == 1)
                {
                    //长短站
                    ShortStationExamTime = ExamTableModel.E_ShortStationExamTimeNum.ToString();
                    ShortStationScoreTime = ExamTableModel.E_ShortStationScoreTimeNum.ToString();

                    ESIDStr = OSCEExamBLL.GetESIDStr(EID, RoomID);

                    ExamStartTime = ExamTableModel.E_StartTime.ToString();
                    ExamEndTime = ExamTableModel.E_EndTime.ToString();

                    #region 判断该考站是长站还是短站，并确定考试时间
                    DataTable dtArrangement = OSCEExamBLL.GetArrangementTable(EID, RoomID);//本考站的排考表
                    DateTime dtStart = DateTime.Parse(dtArrangement.Rows[0]["OEA_StartTime"].ToString());
                    DateTime dtEnd = DateTime.Parse(dtArrangement.Rows[0]["OEA_EndTime"].ToString());
                    int totalTime = (int)(dtEnd - dtStart).TotalMinutes;//本考站单个考试的考试总时间

                    if (totalTime != (Convert.ToInt32(StationExamTime) + Convert.ToInt32(StationScoreTime)))//
                    {
                        StationExamTime = ShortStationExamTime;
                        StationScoreTime = ShortStationScoreTime;
                    }
                    #endregion
                }
                else if (ExamTableModel.E_Kind == 2)
                {
                    ESIDStr = MultiExamBLL.GetESIDStr(EID, RoomID);
                    #region 查找本考站的考试开始时间和结束时间
                    DataTable dt = MultiExamBLL.GetRoomExamStartEndTime(EID, RoomID).Tables[0];
                    int rows = dt.Rows.Count;
                    if (rows > 0)
                    {
                        ExamStartTime = dt.Rows[0]["Exam_StartTime"].ToString();
                        ExamEndTime = dt.Rows[rows - 1]["Exam_EndTime"].ToString();
                    }
                    #endregion

                }
                else if (ExamTableModel.E_Kind == 3)
                {
                    ESIDStr = SingleExamBLL.GetESIDStr(EID, RoomID);

                    #region 查找本考站的考试开始时间和结束时间
                    DataTable dt = SingleExamBLL.GetRoomExamStartEndTime(EID, RoomID).Tables[0];
                    int rows = dt.Rows.Count;
                    if (rows > 0)
                    {
                        ExamStartTime = dt.Rows[0]["SE_StartTime"].ToString();
                        ExamEndTime = dt.Rows[rows - 1]["SE_EndTime"].ToString();
                    }
                    #endregion
                }

                Guid ESID = new Guid(ESIDStr);
                Tellyes.Model.ExamStation ExamStationModel = ExamStationBLL.GetModel(ESID);
                Curriculum = ExamStationModel.ES_Curriculum;
                Content = ExamStationModel.ES_Ccontent;
                EsName = ExamStationModel.ES_Name;
                SystemTime = DateTime.Parse(MultiExamBLL.GetSystemTime()).ToLongTimeString();

                #endregion

                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"ExamName\":\"").Append(Uri.EscapeDataString(ExamName)).Append("\",");
                jsonStringBuilder.Append("\"Curriculum\":\"").Append(Uri.EscapeDataString(Curriculum)).Append("\",");
                jsonStringBuilder.Append("\"Content\":\"").Append(Uri.EscapeDataString(Content)).Append("\",");
                jsonStringBuilder.Append("\"ExamKind\":\"").Append(ExamKind).Append("\",");
                jsonStringBuilder.Append("\"SystemTime\":\"").Append(SystemTime).Append("\",");
                jsonStringBuilder.Append("\"StationExamTime\":\"").Append(StationExamTime).Append("\",");
                jsonStringBuilder.Append("\"StationScoreTime\":\"").Append(StationScoreTime).Append("\",");
                jsonStringBuilder.Append("\"EsName\":\"").Append(Uri.EscapeDataString(EsName)).Append("\",");
                jsonStringBuilder.Append("\"RoomName\":\"").Append(Uri.EscapeDataString(RoomName)).Append("\",");
                jsonStringBuilder.Append("\"ShortStationExamTime\":\"").Append(ShortStationExamTime).Append("\",");
                jsonStringBuilder.Append("\"ShortStationScoreTime\":\"").Append(ShortStationScoreTime).Append("\"");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
            }
            catch (Exception ex)
            {
                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{\"result\":\"0\"}");
                Response.Write(jsonStringBuilder.ToString());
            }
        }

        //获取考站信息
        private void GetStationInfo()
        {
            string Curriculum = "";//考试科目
            string Content = "";//考试内容
            string EsName = "";//当前考站名称
            string RoomName = "";//当前考站的房间名称
            string ExamName = "";//考试名称
            string StationExamTime = "";//考站考试时间(最终传输出去的时间)
            string StationScoreTime = "";//考站评分时间（最终传输出去的时间）
            string ShortStationExamTime = "";
            string ShortStationScoreTime = "";
            string ExamKind = "";//考试种类
            string SystemTime = "";
            string ExamStartTime = "";//考试开始时间
            string ExamEndTime = "";//考试结束时间

            try
            {
                #region 获取信息
                string ExamIDStr = GetExamID();
                if (string.IsNullOrEmpty(ExamIDStr))
                {
                    string errorJson1 = "{\"result\":\"没有考试\"}";
                    Response.Write(errorJson1);
                    return;
                }
                Guid EID = new Guid(ExamIDStr);//考试的GUID
                RoomName = Request.Form["RoomName"];
                int RoomID = RoomBLL.GetRoomID(RoomName);
                Tellyes.Model.ExamTable ExamTableModel = ExamTableBLL.GetModel(EID);
                ExamName = ExamTableModel.E_Name;
                ExamKind = ExamTableModel.E_Kind.ToString();
                
                StationExamTime = ExamTableModel.E_LongStationExamTimeNum.ToString();
                StationScoreTime = ExamTableModel.E_LongStationScoreTimeNum.ToString();
                string ESIDStr = "";

                if (ExamTableModel.E_Kind == 1)
                {
                    //长短站
                    ShortStationExamTime = ExamTableModel.E_ShortStationExamTimeNum.ToString();
                    ShortStationScoreTime = ExamTableModel.E_ShortStationScoreTimeNum.ToString();

                    ESIDStr = OSCEExamBLL.GetESIDStr(EID, RoomID);

                    ExamStartTime = ExamTableModel.E_StartTime.ToString();
                    ExamEndTime = ExamTableModel.E_EndTime.ToString();

                    #region 判断该考站是长站还是短站，并确定考试时间
                    DataTable dtArrangement = OSCEExamBLL.GetArrangementTable(EID, RoomID);//本考站的排考表
                    DateTime dtStart = DateTime.Parse(dtArrangement.Rows[0]["OEA_StartTime"].ToString());
                    DateTime dtEnd = DateTime.Parse(dtArrangement.Rows[0]["OEA_EndTime"].ToString());
                    int totalTime = (int)(dtEnd - dtStart).TotalMinutes;//本考站单个考试的考试总时间

                    if (totalTime != (Convert.ToInt32(StationExamTime) + Convert.ToInt32(StationScoreTime)))//
                    {
                        StationExamTime = ShortStationExamTime;
                        StationScoreTime = ShortStationScoreTime;
                    }
                    #endregion
                }
                else if (ExamTableModel.E_Kind == 2)
                {
                    ESIDStr = MultiExamBLL.GetESIDStr(EID, RoomID);
                    #region 查找本考站的考试开始时间和结束时间
                    DataTable dt = MultiExamBLL.GetRoomExamStartEndTime(EID, RoomID).Tables[0];
                    int rows = dt.Rows.Count;
                    if (rows > 0)
                    {
                        ExamStartTime = dt.Rows[0]["Exam_StartTime"].ToString();
                        ExamEndTime = dt.Rows[rows - 1]["Exam_EndTime"].ToString();
                    }
                    #endregion
                    
                }
                else if (ExamTableModel.E_Kind == 3)
                {
                    ESIDStr = SingleExamBLL.GetESIDStr(EID, RoomID);

                    #region 查找本考站的考试开始时间和结束时间
                    DataTable dt = SingleExamBLL.GetRoomExamStartEndTime(EID, RoomID).Tables[0];
                    int rows = dt.Rows.Count;
                    if (rows > 0)
                    {
                        ExamStartTime = dt.Rows[0]["SE_StartTime"].ToString();
                        ExamEndTime = dt.Rows[rows - 1]["SE_EndTime"].ToString();
                    }
                    #endregion
                }

                Guid ESID = new Guid(ESIDStr);
                Tellyes.Model.ExamStation ExamStationModel = ExamStationBLL.GetModel(ESID);
                Curriculum = ExamStationModel.ES_Curriculum;
                Content = ExamStationModel.ES_Ccontent;
                EsName = ExamStationModel.ES_Name;
                SystemTime = DateTime.Parse(MultiExamBLL.GetSystemTime()).ToLongTimeString ();

                #endregion

                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"ExamName\":\"").Append(ExamName).Append("\",");
                jsonStringBuilder.Append("\"Curriculum\":\"").Append(Curriculum).Append("\",");
                jsonStringBuilder.Append("\"Content\":\"").Append(Content).Append("\",");
                jsonStringBuilder.Append("\"ExamKind\":\"").Append(ExamKind).Append("\",");
                jsonStringBuilder.Append("\"SystemTime\":\"").Append(SystemTime).Append("\",");
                jsonStringBuilder.Append("\"StationExamTime\":\"").Append(StationExamTime).Append("\",");
                jsonStringBuilder.Append("\"StationScoreTime\":\"").Append(StationScoreTime).Append("\",");
                jsonStringBuilder.Append("\"EsName\":\"").Append(EsName).Append("\",");
                jsonStringBuilder.Append("\"RoomName\":\"").Append(RoomName).Append("\",");
                jsonStringBuilder.Append("\"ExamStartTime\":\"").Append(ExamStartTime).Append("\",");
                jsonStringBuilder.Append("\"ExamEndTime\":\"").Append(ExamEndTime).Append("\",");
                jsonStringBuilder.Append("\"ShortStationExamTime\":\"").Append(ShortStationExamTime).Append("\",");
                jsonStringBuilder.Append("\"ShortStationScoreTime\":\"").Append(ShortStationScoreTime).Append("\"");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
            }
            catch (Exception ex)
            {
                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{\"result\":\"0\"}");
                Response.Write(jsonStringBuilder.ToString());
            }          
        }

        //获取考生信息
        private void GetUserInfo()
        {
            string StuExamNumber = "";//当前考生考号
            string NextESName = "";//当前考生的下一站
            string NextRoomName = "";//当前考生的下一站房间名称
            string StuStartTime = "";//当前考生考试开始时间
            string StuEndTime = "";
            string NextStuExamNumber = "";//下一位考生考号
            int ExamState = 0;//无考试、考试中
            string StuState = "";//考生考试中、评分中
            int CurrentUID = 0;//当前考生的学号
            string UName = "";//考生姓名
            string NextUName = "";

            //test
            string strSystemTime = "";
            string strStudentStartTime = "";
            string strStationExamTime = "";
            string strStationScoreTime = "";

            try
            {
                #region 获取信息
                string ExamIDStr = GetExamID();
                if (string.IsNullOrEmpty(ExamIDStr))
                {
                    string errorJson1 = "{\"result\":\"没有考试\"}";
                    Response.Write(errorJson1);
                    return;
                }
                Guid EID = new Guid(ExamIDStr);//考试的GUID
                string RoomName = Request.Form["RoomName"];
                int RoomID = RoomBLL.GetRoomID(RoomName);
                Tellyes.Model.ExamTable ExamTableModel = ExamTableBLL.GetModel(EID);
                int StationExamTime = (int)ExamTableModel.E_LongStationExamTimeNum;
                int StationScoreTime = (int)ExamTableModel.E_LongStationScoreTimeNum;
                int ShortStationExamTime = 0;
                int ShortStationScoreTime = 0;
                int ExamKind = (int)ExamTableModel.E_Kind;


                #region 查找该考站排考表,并确定考生考试时间
                DataTable dtArrangement;
                if (ExamKind == 1)
                {
                    dtArrangement = OSCEExamBLL.GetArrangementTable(EID, RoomID);//
                }
                else if (ExamKind == 2)
                {
                    dtArrangement = MultiExamBLL.GetArrangementTable(EID, RoomID);
                }
                else
                {
                    dtArrangement = SingleExamBLL.GetArrangementTable(EID, RoomID);
                }

                DateTime dt1 = Convert.ToDateTime(dtArrangement.Rows[0][4].ToString());
                DateTime dt2 = Convert.ToDateTime(dtArrangement.Rows[1][4].ToString());
                int stationTime = (int)(dt2 - dt1).TotalMinutes;

                if (ExamKind == 1)
                {
                    #region 长短站
                    ShortStationExamTime = Convert.ToInt32(ExamTableModel.E_ShortStationExamTimeNum.ToString());
                    ShortStationScoreTime = Convert.ToInt32(ExamTableModel.E_ShortStationScoreTimeNum.ToString());
                    DateTime dtStart = DateTime.Parse(dtArrangement.Rows[0]["OEA_StartTime"].ToString());
                    DateTime dtEnd = DateTime.Parse(dtArrangement.Rows[0]["OEA_EndTime"].ToString());
                    int totalTime = (int)(dtEnd - dtStart).TotalMinutes;//本考站单个考试的考试总时间
                    if (totalTime != (Convert.ToInt32(StationExamTime) + Convert.ToInt32(StationScoreTime)))//
                    {
                        StationExamTime = ShortStationExamTime;
                        StationScoreTime = ShortStationScoreTime;
                    }

                    //if (totalShortTime != (Convert .ToInt32 (StationExamTime) + Convert .ToInt32 (StationScoreTime )))
                    //{
                    //    //短站
                    //    StationExamTime = ShortStationExamTime;
                    //    StationScoreTime = ShortStationScoreTime;
                    //} 
                    #endregion
                }
                #endregion

                #region 查找当前时间处在排考表的哪一行
                //查找服务器的当前时间
                DateTime systemTime = Convert.ToDateTime(MultiExamBLL.GetSystemTime());
                int currentRow = 0;//当前行数
                while (systemTime > Convert.ToDateTime(dtArrangement.Rows[currentRow][4].ToString()).AddMinutes(stationTime))
                {
                    if (currentRow < dtArrangement.Rows.Count - 1)
                    {
                        currentRow++;
                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                DateTime studentStartTime = DateTime.Parse(dtArrangement.Rows[currentRow][4].ToString());//单个考生本考站考试开始时间
                DateTime studentEndTime = studentStartTime.AddMinutes(stationTime);//单个考生本考站考试结束时间
                DateTime dt11 = studentStartTime.AddSeconds(1);
                DateTime dt22 = studentEndTime.AddSeconds(1);
                StuStartTime = studentStartTime.ToLongTimeString();
                StuEndTime = studentStartTime.AddMinutes(stationTime).ToLongTimeString ();

                if (!(currentRow == 0 && systemTime < studentStartTime.AddMinutes(-5)))
                {
                    #region 查找考生信息
                    ExamState = 1;
                    int UID = Convert.ToInt32(dtArrangement.Rows[currentRow][3].ToString());
                    Tellyes.Model.UserInfo userInfo = UserInfoBLL.GetModel(UID);
                    UName = userInfo.U_Name;
                    CurrentUID = UID;
                    StuExamNumber = ExamStudentBLL.GetEStuExamNumber(UID, EID);

                    //查找下一考站
                    if (ExamKind == 3)
                    {
                        NextESName = "当前考生考试结束";
                        NextRoomName = "";
                    }
                    else
                    {
                        NextESName = ExamStationBLL.SelectNextStationName(EID, ExamKind, UID, dt11, dt22);
                        NextRoomName = ExamStationBLL.SelectNextStationRoomName(EID, ExamKind, UID, dt11, dt22);
                    }

                    //查找下一个考生
                    if (currentRow == (dtArrangement.Rows.Count - 1))
                    {
                        NextStuExamNumber = "本考站考试结束";
                    }
                    else
                    {
                        int nextUID = Convert.ToInt32(dtArrangement.Rows[currentRow + 1][3].ToString());
                        Tellyes.Model.UserInfo userInfo2 = UserInfoBLL.GetModel(nextUID);
                        NextUName = userInfo2.U_Name;
                        NextStuExamNumber = ExamStudentBLL.GetEStuExamNumber(nextUID, EID);
                    }

                    if (systemTime >= studentStartTime && systemTime < studentStartTime.AddMinutes(StationExamTime))
                    {
                        StuState = "考试中";
                    }
                    else if (systemTime >= studentStartTime.AddMinutes(StationExamTime) && systemTime <= studentStartTime.AddMinutes(StationExamTime + StationScoreTime))
                    {
                        StuState = "评分中";
                    }
                    else
                    {
                        StuState = "等待中";
                    }

                    //test
                    strSystemTime = systemTime.ToString();
                    strStudentStartTime = studentStartTime.ToString();
                    strStationExamTime = StationExamTime.ToString();
                    strStationScoreTime = StationScoreTime.ToString();
                    #endregion
                }
                else
                {
                    //没有考试
                }

                #endregion

                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"result\":\"1\",");
                jsonStringBuilder.Append("\"ExamState\":\"").Append(ExamState).Append("\",");
                jsonStringBuilder.Append("\"StuState\":\"").Append(StuState).Append("\",");
                jsonStringBuilder.Append("\"StuExamNumber\":\"").Append(StuExamNumber).Append("\",");
                jsonStringBuilder.Append("\"CurrentUID\":\"").Append(CurrentUID).Append("\",");
                jsonStringBuilder.Append("\"UName\":\"").Append(UName).Append("\",");
                jsonStringBuilder.Append("\"NextESName\":\"").Append(NextESName).Append("\",");
                jsonStringBuilder.Append("\"NextRoomName\":\"").Append(NextRoomName).Append("\",");
                jsonStringBuilder.Append("\"StuStartTime\":\"").Append(StuStartTime).Append("\",");
                jsonStringBuilder.Append("\"StuEndTime\":\"").Append(StuEndTime).Append("\",");
                jsonStringBuilder.Append("\"NextStuExamNumber\":\"").Append(NextStuExamNumber).Append("\",");
                //test
                jsonStringBuilder.Append("\"strSystemTime\":\"").Append(strSystemTime).Append("\",");
                jsonStringBuilder.Append("\"strStudentStartTime\":\"").Append(strStudentStartTime).Append("\",");
                jsonStringBuilder.Append("\"strStationExamTime\":\"").Append(strStationExamTime).Append("\",");
                jsonStringBuilder.Append("\"strStationScoreTime\":\"").Append(strStationScoreTime).Append("\",");
                //
                jsonStringBuilder.Append("\"NextUName\":\"").Append(NextUName).Append("\"");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
            }
            catch (Exception ex)
            {
                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{\"result\":\"0\"}");
                Response.Write(jsonStringBuilder.ToString());
            }

        }

        //查询考生图片
        private void GetCurrentUserPhoto()
        {
            try
            {
                int U_ID = Convert.ToInt32(Request.QueryString["U_ID"]);
                Tellyes.Model.UserInfo userInfo = UserInfoBLL.SearchUserInfoByID(U_ID);
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
            catch (Exception ex)
            {
                Log4NetUtility.Error(this, ex.ToString());
                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{\"result\":\"0\"}");
                Response.Write(jsonStringBuilder.ToString());
            }           
        }

        //保存图片
        private void SaveCurrentUserPhoto()
        {
            try
            {
                HttpPostedFile image = Request.Files["image"];
                int length = image.ContentLength;
                byte[] imageByteArray = new byte[length];
                Stream imageStream = image.InputStream;
                imageStream.Read(imageByteArray, 0, length);
                Tellyes.Model.UserPhoto userPhoto = new Tellyes.Model.UserPhoto();
                userPhoto.UP_Photo = imageByteArray;
                string ExamIDStr = GetExamID();
                //Log4NetUtility.Error(this, "exam id is=============：" + ExamIDStr);
                if (string.IsNullOrEmpty(ExamIDStr))
                {
                    return;
                }
                userPhoto.E_ID = Guid.Parse(ExamIDStr);//考试的GUID
                userPhoto.U_ID = Convert.ToInt32(Request.Form["UID"].ToString());
                userPhoto.UP_CreateTime = DateTime.Now;
                string RoomName = Request.Form["RoomName"];
                userPhoto.Room_ID = RoomBLL.GetRoomID(RoomName);
                userPhoto.int1 = 0;
                //判断是否已存在此图片
                if (!(UserPhotoBLL.IsHavePhoto(userPhoto.U_ID, userPhoto.E_ID)))
                {
                    int count = UserPhotoBLL.Add(userPhoto);
                    Response.Write("{\"IsSave\":\"" + (count > 0 ? "1" : "0") + "\"}");
                }
                else
                {
                    Response.Write("{\"hasPhoto\":\"1\"}");
                }
                
            }
            catch (Exception ex)
            {
                Log4NetUtility.Error(this, ex.ToString());
                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{\"result\":\"0\"}");
                Response.Write(jsonStringBuilder.ToString());
            }
            
        }

        //响应更新状态
        private void SendExamState()
        {
            int UpdateState = 0;

            try
            {
                //查找服务器的当前时间
                DateTime systemTime = Convert.ToDateTime(MultiExamBLL.GetSystemTime());

                string ExamIDStr = GetExamID();
                if (string.IsNullOrEmpty(ExamIDStr))
                {
                    return;
                }
                Guid EID = new Guid(ExamIDStr);//考试的GUID
                string RoomName = Request.Form["RoomName"];
                int RoomID = RoomBLL.GetRoomID(RoomName);
                Tellyes.Model.ExamTable ExamTableModel = ExamTableBLL.GetModel(EID);
                int StationExamTime = (int)ExamTableModel.E_LongStationExamTimeNum;
                int ShortStationExamTime = 0;
                int ShortStationScoreTime = 0;
                int ExamKind = (int)ExamTableModel.E_Kind;

                #region 查找该考站排考表,并确定考生考试时间
                DataTable dtArrangement;
                if (ExamKind == 1)
                {
                    dtArrangement = OSCEExamBLL.GetArrangementTable(EID, RoomID);
                }
                else if (ExamKind == 2)
                {
                    dtArrangement = MultiExamBLL.GetArrangementTable(EID, RoomID);
                }
                else
                {
                    dtArrangement = SingleExamBLL.GetArrangementTable(EID, RoomID);
                }

                DateTime dt1 = Convert.ToDateTime(dtArrangement.Rows[0][4].ToString());
                DateTime dt2 = Convert.ToDateTime(dtArrangement.Rows[1][4].ToString());
                int stationTime = (int)(dt2 - dt1).TotalMinutes;

                if (ExamKind == 1)
                {
                    //长短站
                    ShortStationExamTime = Convert.ToInt32(ExamTableModel.E_ShortStationExamTimeNum.ToString());
                    ShortStationScoreTime = Convert.ToInt32(ExamTableModel.E_ShortStationScoreTimeNum.ToString());
                    DateTime dtStart = DateTime.Parse(dtArrangement.Rows[0][4].ToString());
                    DateTime dtEnd = DateTime.Parse(dtArrangement.Rows[0][5].ToString());

                    TimeSpan ts = dtStart - dtEnd;
                    int totalShortTime = (int)ts.TotalMinutes;
                    if (totalShortTime == stationTime)
                    {
                        //短站
                        StationExamTime = ShortStationExamTime;
                    }
                }
                #endregion

                #region 查找当前时间处在排考表的哪一行
                int currentRow = 0;//当前行数
                while (systemTime > Convert.ToDateTime(dtArrangement.Rows[currentRow][4].ToString()).AddMinutes(stationTime))
                {
                    if (currentRow < dtArrangement.Rows.Count - 1)
                    {
                        currentRow++;
                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                DateTime studentStartTime = DateTime.Parse(dtArrangement.Rows[currentRow][4].ToString());//单个考生本考站考试开始时间
                DateTime studentEndTime = studentStartTime.AddMinutes(stationTime);//单个考生本考站考试结束时间

                if (systemTime > studentStartTime.AddSeconds(-10) && systemTime < studentStartTime.AddSeconds(10))
                {
                    UpdateState = 1;
                }

                if (systemTime > studentStartTime.AddMinutes(StationExamTime).AddSeconds(-10) && systemTime < studentStartTime.AddMinutes(StationExamTime).AddSeconds(10))
                {
                    UpdateState = 1;
                }

                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{");
                jsonStringBuilder.Append("\"UpdateState\":\"").Append(UpdateState).Append("\"");
                jsonStringBuilder.Append("}");
                Response.Write(jsonStringBuilder.ToString());
            }
            catch (Exception ex)
            {
                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("{\"result\":\"0\"}");
                Response.Write(jsonStringBuilder.ToString());
            }

            
        }

        private void GetRoomInfoUTF8()
        {
            try
            {
                DataTable dtNew = GetRoomDataTable();
                DataTable dt = TransformDatatable (dtNew );
                StringBuilder jsonStringBuilder = new StringBuilder();
                jsonStringBuilder.Append("[");
                DataRowCollection drc = dt.Rows;
                for (int i = 0; i < drc.Count; i++)
                {
                    jsonStringBuilder.Append("{");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        string strkey = dt.Columns[j].ColumnName;
                        string strValue0 = drc[i][j].ToString();
                        string strValue = Uri.EscapeDataString(strValue0);
                        Type type = dt.Columns[j].DataType;
                        jsonStringBuilder.Append("\"" + strkey + "\":");
                        strValue = String.Format(strValue, type);
                        if (j < dt.Columns.Count - 1)
                        {
                            jsonStringBuilder.Append("\"" + strValue + "\"" + ",");
                        }
                        else
                        {
                            jsonStringBuilder.Append("\"" + strValue + "\"");
                        }
                    }
                    jsonStringBuilder.Append("},");
                }
                jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
                jsonStringBuilder.Append("]");
                if (jsonStringBuilder.Length == 1)
                {
                    Response.Write("[]");
                }
                Response.Write(jsonStringBuilder.ToString());
            }
            catch (Exception ex)
            {
                
                throw;
            }

        }

        private DataTable GetRoomDataTable()
        {
            DataTable dtRoom = CreateRoomDataTable();

            DataTable dt = ExamTableBLL.GetTodayExamInfoTable().Tables[0];//考试信息
            int rows = dt.Rows.Count;
            if (rows > 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    Guid EID = new Guid(dt.Rows[i]["E_ID"].ToString());
                    int examKind = Convert.ToInt32(dt.Rows[i]["E_Kind"].ToString());
                    switch (examKind)
                    { 
                        case 1:
                            //长短站无法使用导致异常
                            //DataTable dtExamRoom = OsceBLL.GetOsceRoom(EID).Tables[0];
                            //DealRoomDatatable(EID, dtRoom, dtExamRoom);
                            break;
                        case 2:
                            DataTable dtExamRoom2 = MultiExamBLL.GetMultiRoom(EID).Tables[0];
                            DealRoomDatatable(EID, dtRoom, dtExamRoom2);
                            break;
                        case 3:
                            DataTable dtExamRoom3 = SingleExamBLL.GetSingleRoom(EID).Tables[0];
                            DealRoomDatatable(EID, dtRoom, dtExamRoom3);
                            break;
                        default :
                            break;
                    }
                }
            }

            return dtRoom;
        }

        private void DealRoomDatatable(Guid EID, DataTable dt,DataTable dtExamRoom)
        {
            int rows = dtExamRoom.Rows.Count;
            int rows2 = dt.Rows.Count;//假设认定肯定存在房间
            if (rows > 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < rows2; j++)
                    {
                        if (dt.Rows[j][2].ToString() == dtExamRoom.Rows[i][0].ToString())
                        {
                            dt.Rows[j][1] = 1;
                        }
                    }
                }
            }
        }

        private DataTable CreateRoomDataTable()
        {
            DataTable dtRoomName = new DataTable();
            dtRoomName.Columns.Add(new DataColumn("RoomName", typeof(string)));
            dtRoomName.Columns.Add(new DataColumn("State", typeof(int)));
            dtRoomName.Columns.Add(new DataColumn("RoomID", typeof(int)));

            DataTable dt = RoomBLL.GetRoomIDName().Tables[0];
            int rows = dt.Rows .Count ;
            if (rows > 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    DataRow dr = dtRoomName.NewRow();
                    dr["RoomName"] = dt.Rows[i][0];
                    dr["State"] = 0;
                    dr["RoomID"] = dt.Rows[i][1];
                    dtRoomName.Rows.Add(dr);
                }
            }

            return dtRoomName;
        }

        private DataTable TransformDatatable(DataTable dt)
        {
            DataTable dtNew = new DataTable();
            dtNew.Columns.Add(new DataColumn("RoomName", typeof(string)));
            dtNew.Columns.Add(new DataColumn("State", typeof(int)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dtNew.NewRow();
                dr["RoomName"] = dt.Rows[i][0];
                dr["State"] = dt.Rows[i][1];
                dtNew.Rows.Add(dr);
            }

            return dtNew;
        }
    }
}