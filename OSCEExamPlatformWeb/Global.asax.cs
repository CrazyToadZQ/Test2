using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Tellyes.Log4Net;
using System.Threading;
using System.Web.Script.Serialization;

namespace OSCEExamPlatformWeb
{
    public class Global : System.Web.HttpApplication
    {
        public static readonly bool IsXiehe=true;
        protected void Application_Start(object sender, EventArgs e)
        {
            Log4NetUtility.DebugLog("应用程序已启动");
            Application.Add("HandDeviceManagementMaxCount", 10);//手持设备最大数量
            Application.Add("GeneralControlMaxCount", 10);//手持设备最大数量
            Application.Add("RemoteScoreMaxCount", 10);//手持设备最大数量
            Application.Add("HandScoreMaxCount",10);
            //部署时需要删除的代码************************************************************************************************************************************************************************************************************************
            bool isDevelopment = true;
            if(isDevelopment) 
            {
                Application.Add("copyright", true);
                return;
            }
            //部署时需要删除的代码************************************************************************************************************************************************************************************************************************

            #region 查询网站加密码
            Tellyes.Model.GlobalParametersSetting globalParametersSetting = new Tellyes.BLL.GlobalParametersSetting().SearchUniqueGlobalParametersSettingByCondition();
            if (globalParametersSetting == null) 
            {
                Log4NetUtility.Error(this, "初始化数据读取失败，请检查GlobalParametersSetting");
                Application.Add("copyright", false);
                return;
            }
            #endregion

            #region 解密加密数据
            string codeAES = globalParametersSetting.Global_Parameter22 + globalParametersSetting.Global_Parameter19 + globalParametersSetting.Global_Parameter25;
            string code = "";
            try
            {
                code = Tellyes.Common.OSCEAESCrypt.Decrypt_AES(codeAES);
            }
            catch(Exception ex)
            {
                Log4NetUtility.Error(this, "网站加密码解密失败：", ex);
                Application.Add("copyright", false);
                return;
            }
            #endregion

            #region 解析网站加密数据
            Dictionary<string, object> osceServerConfig = null;
            try
            {
                osceServerConfig = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(code);
            }
            catch(Exception ex)
            {
                Log4NetUtility.Error(this, "网站加密码解析失败");
                Application.Add("copyright", false);
                return;
            }
            #endregion
            
            #region 与当前服务器数据对比
            if (!osceServerConfig["ProcessorID"].Equals(Uri.EscapeDataString(Tellyes.Common.OSCEServerInformation.SearchServerProcessorID())))
            {
                Log4NetUtility.Error(this, "网站服务器验证CPU ID不正确");
                Application.Add("copyright", false);
                return;
            }
            if (!osceServerConfig["BaseBoardID"].Equals(Uri.EscapeDataString(Tellyes.Common.OSCEServerInformation.SearchServerBaseBoardID())))
            {
                Log4NetUtility.Error(this, "网站服务器验证主板ID不正确");
                Application.Add("copyright", false);
                return;
            }
            if (!osceServerConfig["BiosID"].Equals(Uri.EscapeDataString(Tellyes.Common.OSCEServerInformation.SearchBiosID())))
            {
                Log4NetUtility.Error(this, "网站服务器验证BIOS ID不正确");
                Application.Add("copyright", false);
                return;
            }
            if (!osceServerConfig["DiskDriveID"].Equals(Uri.EscapeDataString(Tellyes.Common.OSCEServerInformation.SearchDiskDriveID())))
            {
                Log4NetUtility.Error(this, "网站服务器验证硬盘ID不正确");
                Application.Add("copyright", false);
                return;
            }
            if (!osceServerConfig["MacAddress"].Equals(Uri.EscapeDataString(Tellyes.Common.OSCEServerInformation.SearchMacAddress())))
            {
                Log4NetUtility.Error(this, "网站服务器验证MAC地址不正确");
                Application.Add("copyright", false);
                return;
            }
            #endregion
            
            #region 设置考站数量、考站房间数量、手持评分终端数量
            Application.Add("ExamStationMaxCount", Convert.ToInt32(Uri.UnescapeDataString(osceServerConfig["ExamStationCount"].ToString())));
            Application.Add("ExamStationRoomMaxCount", Convert.ToInt32(Uri.UnescapeDataString(osceServerConfig["ExamStationRoomCount"].ToString())));
            Application.Add("HandScoreMaxCount", Convert.ToInt32(Uri.UnescapeDataString(osceServerConfig["HandScoreCount"].ToString())));
            Application.Add("HandDeviceManagementMaxCount", 1);//手持设备最大数量
            Application.Add("GeneralControlMaxCount", 1);//手持设备最大数量
            Application.Add("RemoteScoreMaxCount", 1);//手持设备最大数量
            #endregion

            if (!Application.AllKeys.Contains<string>("copyright"))
            {
                Application.Add("copyright", true);
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Application["copyright"].Equals(false))
            {
                Response.Write("网站服务器未授权！");
                Response.Flush();
                Response.End();
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}