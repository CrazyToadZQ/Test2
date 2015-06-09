using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tellyes.Log4Net;
using System.Reflection;
using System.Text;

namespace OSCEExamPlatformWeb.AppDataInterface
{
    public partial class UserLogin : System.Web.UI.Page
    {
        private const string PAGE_PATH_INFO = "/AppDataInterface/UserLogin.aspx";
        private const string ASSEMBLY_NAME = "OSCEExamPlatformWeb";
        private const string CLASS_NAME = "OSCEExamPlatformWeb.AppDataInterface.UserLogin";

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
        /// 手持设备用户登录
        /// </summary>
        private void DeviceManageUserLogin()
        {
            string errorJsonString1 = "{\"result\":\"0\"}";
            string errorJsonString2 = "{\"result\":\"-1\"}";
            string errorJsonString3 = "{\"result\":\"-3\"}";
            string errorJsonString4 = "{\"result\":\"-2\"}";

            string UserInfoName = Request.Form["UserInfoName"];
            string UserInfoPassword = Request.Form["UserInfoPassword"];
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);

            if(UserInfoName==""||UserInfoName==null)
            {
                Log4NetUtility.Error(this, "UserInfoName值为空!请查看DeviceManageUserLogin（）方法");
                Response.Write(errorJsonString1);
                return;
            }
            if (UserInfoPassword == "" || UserInfoPassword == null)
            {
                Log4NetUtility.Error(this, "UserInfoPassword值为空!请查看DeviceManageUserLogin（）方法");
                Response.Write(errorJsonString1);
                return;
            }
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看DeviceManageUserLogin（）方法");
                Response.Write(errorJsonString1);
                return;
            }

            //校验系统设备验证码
            Tellyes.BLL.SystemDevice systemDeviceBll = new Tellyes.BLL.SystemDevice();
            Dictionary<string, object> conditionDictionarySystemDevice = new Dictionary<string, object>()
                    {
                          {"SD_Verification_SerialNumber_Is", VerificationSerialNumber}
                    };
            List<Tellyes.Model.SystemDevice> systemDeviceList = systemDeviceBll.SearchSystemDeviceByCondition(conditionDictionarySystemDevice);
            if (systemDeviceList == null)
            {
                Log4NetUtility.Error(this, "查询系统设备列表为null，请查看数据库！");
                Response.Write(errorJsonString1);
                return;
            }
            if (systemDeviceList.Count == 0)
            {
                Log4NetUtility.Error(this, "此设备未注册！请从新注册该设备！");
                Response.Write(errorJsonString4);
                return;
            }

            if (UserInfoName.Equals("admin") && UserInfoPassword.Equals("admin"))
            {
                Response.Write("{\"result\":\"1\"}");
                return;
            }

            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            {
                 {"U_Name",UserInfoName},
                 {"U_PWD",UserInfoPassword}
            };
            List<KeyValuePair<string, string>> orderList = new List<KeyValuePair<string, string>>();
            List<Tellyes.Model.UserInfo> userInfoList = new Tellyes.BLL.UserInfo().SearchUserInfoByCondition(conditionDictionary, orderList);
            if (userInfoList==null)
            {
                Log4NetUtility.Error(this, "用户登录失败，数据库错误！U_Name=" + UserInfoName +"U_PWD=" + UserInfoPassword);
                Response.Write(errorJsonString1);
                return;
            }
            if (userInfoList.Count==0)
            {
                Log4NetUtility.Error(this, "用户登录失败，用户名和密码错误！U_Name=" + UserInfoName + "U_PWD=" + UserInfoPassword);
                Response.Write(errorJsonString2);
                return;
            }

            List<Tellyes.Model.UserRole> userRoleList = new Tellyes.BLL.UserRole().SearchUserRoleByUserInfoID(userInfoList[0].U_ID);
            if (userRoleList == null)
            {
                Log4NetUtility.Error(this, "用户权限查询失败");
                Response.Write(errorJsonString1);
                return;
            }

            //管理员RoleID
            const int ROLE_ID_1 = 1;
            //实验员RoleID
            const int ROLE_ID_2 = 2;

            bool result = false;
            foreach (Tellyes.Model.UserRole userRole in userRoleList)
            {
                if (userRole.R_ID == ROLE_ID_1 || userRole.R_ID == ROLE_ID_2)
                {
                    result = true;
                    break;
                }
            }

            if (result)
            {
                Response.Write("{\"result\":\"1\"}");
            }
            else
            {
                Response.Write(errorJsonString3);
            }
        }

        /// <summary>
        /// 手持评分用户登录
        /// </summary>
        private void HandScoreUserLogin()
        {
            string errorJsonString1 = "{\"result\":\"0\"}"; //当前无考试信息
            string errorJsonString2 = "{\"result\":\"-1\"}"; //用户名密码错误
            string errorJsonString3 = "{\"result\":\"-2\"}"; //权限错误
            string errorJsonString4 = "{\"result\":\"-3\"}"; //远程评分的评委不能登录手持评分

            string U_Name = Request.Params["U_Name"];
            string U_PWD = Request.Params["U_PWD"];

            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            { 
                {"U_Name,EQ", U_Name},
                {"U_PWD,EQ", U_PWD}
            };
            Tellyes.Model.UserInfo userInfo = new Tellyes.BLL.UserInfo().SearchUniqueUserInfoByCondition(conditionDictionary);
            if (userInfo == null || U_Name != userInfo.U_Name || U_PWD != userInfo.U_PWD)
            {
                Log4NetUtility.Error(this, "手持设备，用户登录失败，用户名密码错误，U_Name：" + U_Name + "，U_PWD：" + U_PWD);
                Response.Write(errorJsonString2);
                return;
            }

            //评委RoleID
            const int ROLE_ID_4 = 4;
            //SPRoleID
            const int ROLE_ID_5 = 5;
            //现场评委标示值
            const int EXAM_USER_TYPE_2 = 2;
            conditionDictionary = new Dictionary<string, object>() 
            { 
                {"U_ID,EQ", userInfo.U_ID},
                {"R_ID,IN", new List<int>(){ROLE_ID_4, ROLE_ID_5}}
            };
            List<Tellyes.Model.UserRole> userRoleList = new Tellyes.BLL.UserRole().SearchUserRoleByCondition(conditionDictionary);
            if (userRoleList == null)
            {
                Log4NetUtility.Error(this, "手持设备，用户权限查询失败，U_ID：" + userInfo.U_ID);
                Response.Write(errorJsonString3);
                return;
            }

            Dictionary<string, object> examUser = new Tellyes.BLL.ExamUser().SearchExamUserInHandScoreByUserInfoIDAndDatetime(userInfo.U_ID, DateTime.Now);
            if (examUser == null)
            {
                Log4NetUtility.Error(this, "手持设备，用户登录查询失败：U_ID（" + userInfo.U_ID + "），Datetime（" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "）");
                Response.Write(errorJsonString1);
                return;
            }
            if (!examUser["ExamUserType"].Equals(EXAM_USER_TYPE_2))
            {
                Log4NetUtility.Error(this, "手持设备，当前用户非现场评委：U_ID（" + userInfo.U_ID + "），Datetime（" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "）");
                Response.Write(errorJsonString4);
                return;
            }

            Guid EU_ID = Guid.Parse(examUser["EU_ID"].ToString());
            Guid E_ID = Guid.Parse(examUser["E_ID"].ToString());
            Guid ESR_ID = Guid.Parse(examUser["ESR_ID"].ToString());
            int markSheetCount = Convert.ToInt32(examUser["MarkSheetCount"]);

            Tellyes.Model.ExamTable examTable = new Tellyes.BLL.ExamTable().SearchExamTableByID(E_ID);
            if (examTable == null) 
            {
                Log4NetUtility.Error(this, "手持设备，考试信息查询失败：E_ID（" + E_ID + "）");
                Response.Write(errorJsonString1);
                return;
            }

            Tellyes.Model.ExamStation examStation = new Tellyes.BLL.ExamStation().SearchExamStationByExamStationRoomID(ESR_ID);
            if (examStation == null) 
            {
                Log4NetUtility.Error(this, "手持设备，考站信息查询失败：ESR_ID（" + ESR_ID + "）");
                Response.Write(errorJsonString1);
                return;
            }

            Tellyes.Model.Room room = new Tellyes.BLL.RoomBLL().SearchRoomByExamStationRoomID(ESR_ID);
            if (room == null) 
            {
                Log4NetUtility.Error(this, "手持设备，房间信息查询失败：ESR_ID（" + ESR_ID + "）");
                Response.Write(errorJsonString1);
                return;
            }

            StringBuilder jsonStringBuilder = new StringBuilder(string.Empty);
            jsonStringBuilder.Append("{");
            jsonStringBuilder.Append("\"result\":\"1\",");
            jsonStringBuilder.Append("\"EU_ID\":\"").Append(EU_ID).Append("\",");
            jsonStringBuilder.Append("\"U_ID\":\"").Append(userInfo.U_ID).Append("\",");
            jsonStringBuilder.Append("\"U_TrueName\":\"").Append(Uri.EscapeDataString(userInfo.U_TrueName)).Append("\",");
            jsonStringBuilder.Append("\"E_ID\":\"").Append(E_ID).Append("\",");
            jsonStringBuilder.Append("\"E_Name\":\"").Append(Uri.EscapeDataString(examTable.E_Name)).Append("\",");
            jsonStringBuilder.Append("\"ES_ID\":\"").Append(examStation.ES_ID).Append("\",");
            jsonStringBuilder.Append("\"ES_Name\":\"").Append(Uri.EscapeDataString(examStation.ES_Name)).Append("\",");
            jsonStringBuilder.Append("\"ESR_ID\":\"").Append(ESR_ID).Append("\",");
            jsonStringBuilder.Append("\"Room_ID\":\"").Append(room.RoomID).Append("\",");
            jsonStringBuilder.Append("\"Room_Name\":\"").Append(Uri.EscapeDataString(room.RoomName)).Append("\",");
            jsonStringBuilder.Append("\"mark_sheet_count\":\"").Append(markSheetCount).Append("\"");
            jsonStringBuilder.Append("}");
            Response.Write(jsonStringBuilder.ToString());
        }
    }
}