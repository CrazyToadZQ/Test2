using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tellyes.Log4Net;
using System.Reflection;
using Tellyes.Common;

namespace OSCEExamPlatformWeb.AppDataInterface
{
    public partial class SystemDeviceRegisteInfo : System.Web.UI.Page
    {
        private const string PAGE_PATH_INFO = "/AppDataInterface/SystemDeviceRegisteInfo.aspx";
        private const string ASSEMBLY_NAME = "OSCEExamPlatformWeb";
        private const string CLASS_NAME = "OSCEExamPlatformWeb.AppDataInterface.SystemDeviceRegisteInfo";

        protected override void OnInit(EventArgs e)
        {
            string errorURL = "/error.html";
            string pathInfo = Request.Params["PATH_INFO"];
            if (pathInfo.StartsWith(PAGE_PATH_INFO + "/"))
            {
                string[] nameList = pathInfo.Substring(PAGE_PATH_INFO.Length + 1).Split('/');
                if (nameList.Length < 1)
                {
                    Log4NetUtility.Error(this, "URL地址访问错误");
                    Response.Redirect(errorURL);
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
                catch (Exception exception)
                {
                    Log4NetUtility.Fatal(this, "处理程序访问失败", exception);
                    Response.Redirect(errorURL);
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
            }
        }

        /// <summary>
        /// 系统设备注册
        /// </summary>
        private void AddSystemDeviceRegisteInfo()
        {

            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-1\"}";
            string errorJson3 = "{\"result\":\"2\"}";

            #region 公共参数校验
            string AppType = Request.Form["AppType"];
            string SystemDeviceType = Request.Form["SystemDeviceType"];
            string MacAddress = Request.Form["MacAddress"];

            if (AppType == "" || AppType == null)
            {
                Log4NetUtility.Error(this, "系统设备注册失败！AppType的值为空");
                Response.Write(errorJson1);
                return;
            }
            if (AppType != "HandScore" && AppType != "DeviceManage" && AppType != "GeneralControl" && AppType != "RemoteScore")
            {
                Log4NetUtility.Error(this, "系统设备注册失败！AppType的值有误！");
                Response.Write(errorJson1);
                return;
            }
            if (SystemDeviceType == "" || SystemDeviceType == null)
            {
                Log4NetUtility.Error(this, "系统设备注册失败！SystemDeviceType 的值为空");
                Response.Write(errorJson1);
                return;
            }
            if (SystemDeviceType != "ipad" && SystemDeviceType != "android" && SystemDeviceType != "surface" && SystemDeviceType != "pc")
            {
                Log4NetUtility.Error(this, "系统设备注册失败！SystemDeviceType 的值有误！");
                Response.Write(errorJson1);
                return;
            }
            if (MacAddress == "" || MacAddress == null)
            {
                Log4NetUtility.Error(this, "系统设备注册失败！MacAddress的值为空");
                Response.Write(errorJson1);
                return;
            }
            #endregion

            #region 判断各个应用类型是否达到注册上限

            Tellyes.BLL.SystemDevice systemDeviceBll = new Tellyes.BLL.SystemDevice();     
            List<Tellyes.Model.SystemDevice> systemDeviceList = systemDeviceBll.SearchSystemDeviceByCondition();
            if (systemDeviceList == null)
            {
                Log4NetUtility.Error(this, "查询系统设备列表为null，请查看数据库！");
                Response.Write(errorJson1);
                return;
            }
            int AppTypeHandScoreCount = 0;
            int AppTypeDeviceManageCount = 0;
            int AppTypeGeneralControlCount = 0;
            int AppTypeRemoteScoreCount = 0;
            foreach (Tellyes.Model.SystemDevice systemDeviceModel in systemDeviceList)
            {
                string systemDeviceID = OSCEAESCrypt.Decrypt_AES(OSCEAESCrypt.StrAesKeyText, systemDeviceModel.SD_ID);
                string systemDeviceAppType = OSCEAESCrypt.Decrypt_AES(OSCEAESCrypt.StrAesKeyText + systemDeviceID, systemDeviceModel.SD_Application_Type);
                if (systemDeviceAppType == "HandScore")
                {
                    AppTypeHandScoreCount++;
                }
                if (systemDeviceAppType == "DeviceManage")
                {
                    AppTypeDeviceManageCount++;
                }
                if (systemDeviceAppType == "GeneralControl")
                {
                    AppTypeGeneralControlCount++;
                }
                if (systemDeviceAppType == "RemoteScore")
                {
                    AppTypeRemoteScoreCount++;
                }
            }           
            int HandDeviceManagementMaxCount = Convert.ToInt32(Application["HandDeviceManagementMaxCount"]);
            int HandScoreMaxCount = Convert.ToInt32(Application["HandScoreMaxCount"]);
            int GeneralControlMaxCount = Convert.ToInt32(Application["GeneralControlMaxCount"]);
            int RemoteScoreMaxCount = Convert.ToInt32(Application["RemoteScoreMaxCount"]);
            if (HandDeviceManagementMaxCount <= AppTypeDeviceManageCount)
            {
                Log4NetUtility.Error(this, "手持设备管理注册设备数量已经达到上限！");
                Response.Write(errorJson2);
                return;
            }
            if (HandScoreMaxCount <= AppTypeHandScoreCount)
            {
                Log4NetUtility.Error(this, "手持评分注册设备数量已经达到上限！");
                Response.Write(errorJson2);
                return;
            }
            if (GeneralControlMaxCount <= AppTypeGeneralControlCount)
            {
                Log4NetUtility.Error(this, "中央总控注册设备数量已经达到上限！");
                Response.Write(errorJson2);
                return;
            }
            if (RemoteScoreMaxCount <= AppTypeRemoteScoreCount)
            {
                Log4NetUtility.Error(this, "远程评分注册设备数量已经达到上限！");
                Response.Write(errorJson2);
                return;
            }
            #endregion

            #region 手持设备

            if (AppType == "HandScore" || AppType == "DeviceManage")
            {
                string HardWareVersion = Request.Form["HardWareVersion"];
                string HardWareSystemVersion = Request.Form["HardWareSystemVersion"];
                string HardWareSerialNumber = Request.Form["HardWareSerialNumber"];
                if (HardWareVersion == "" || HardWareVersion == null)
                {
                    Log4NetUtility.Error(this, "手持终端注册失败！HardWareVersion的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                if (HardWareSystemVersion == "" || HardWareSystemVersion == null)
                {
                    Log4NetUtility.Error(this, "手持终端注册失败！HardWareSystemVersion 的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                if (HardWareSerialNumber == "" || HardWareSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "手持终端注册失败！HardWareSerialNumber的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                
                //判断设备是否注册过
                string systemDeviceVerificationSerialNumber = OSCEAESCrypt.Encrypt_AES(OSCEAESCrypt.StrAesKeyText, systemDeviceBll.ToJsonString(AppType, HardWareSerialNumber, MacAddress));
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>()
                    {
                          {"SD_Verification_SerialNumber_Is", systemDeviceVerificationSerialNumber}
                    };
                systemDeviceList = systemDeviceBll.SearchSystemDeviceByCondition(conditionDictionary);
                if (systemDeviceList == null)
                {
                    Log4NetUtility.Error(this, "查询系统设备列表为null，请查看数据库！");
                    Response.Write(errorJson1);
                    return;
                }
                if (systemDeviceList.Count!=0)
                {                   
                    Log4NetUtility.Error(this, "此设备已经注册过！");
                    Response.Write(errorJson3);
                    return;
                }

                Guid guid = Guid.NewGuid();
                string key = OSCEAESCrypt.StrAesKeyText + guid;
                Tellyes.Model.SystemDevice systemDevice = new Tellyes.Model.SystemDevice();
                systemDevice.SD_ID = OSCEAESCrypt.Encrypt_AES(guid.ToString());
                systemDevice.SD_Application_Type = OSCEAESCrypt.Encrypt_AES(key, AppType);
                systemDevice.SD_Type = OSCEAESCrypt.Encrypt_AES(key, SystemDeviceType);
                systemDevice.SD_HardWare_Version = OSCEAESCrypt.Encrypt_AES(key, HardWareVersion);
                systemDevice.SD_HardWare_System_Version = OSCEAESCrypt.Encrypt_AES(key, HardWareSystemVersion);
                systemDevice.SD_HardWare_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, HardWareSerialNumber);
                systemDevice.SD_CPU_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, Guid.NewGuid().ToString());
                systemDevice.SD_Mainboard_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, Guid.NewGuid().ToString());
                systemDevice.SD_BIOS_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, Guid.NewGuid().ToString());
                systemDevice.SD_HardDisk_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, Guid.NewGuid().ToString());
                systemDevice.SD_MAC_Address = OSCEAESCrypt.Encrypt_AES(key, MacAddress);
                systemDevice.SD_Verification_SerialNumber = OSCEAESCrypt.Encrypt_AES(OSCEAESCrypt.StrAesKeyText, systemDeviceBll.ToJsonString(AppType, HardWareSerialNumber, MacAddress));
                systemDevice.SD_Registration_Time = OSCEAESCrypt.Encrypt_AES(key, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                bool flag = systemDeviceBll.AddSystemDevice(systemDevice);
                if (flag == false)
                {
                    if (AppType == "DeviceManage")
                    {
                        Log4NetUtility.Error(this, "添加系统设备失败！（手持设备管理设备）");
                    }
                    if (AppType == "HandScore")
                    {
                        Log4NetUtility.Error(this, "添加系统设备失败！（手持评分设备）");
                    }                       
                    Response.Write(errorJson1);
                    return;
                }
                Response.Write("[{\"result\":\"1\",\"VerificationSerialNumber\":\"" + Uri.EscapeDataString(systemDeviceVerificationSerialNumber) + "\"}]");
            }
            #endregion

            #region PC设备

            if (AppType == "GeneralControl" || AppType == "RemoteScore")
            {
                string CPUSerialNumber = Request.Form["CPUSerialNumber"];
                string MainboardSerialNumber = Request.Form["MainboardSerialNumber"];
                string BIOSSerialNumber = Request.Form["BIOSSerialNumber"];
                string HardDiskSerialNumber = Request.Form["HardDiskSerialNumber"];
                if (CPUSerialNumber == "" || CPUSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "PC终端注册失败！CPUSerialNumber的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                if (MainboardSerialNumber == "" || MainboardSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "PC终端注册失败！MainboardSerialNumber 的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                if (BIOSSerialNumber == "" || BIOSSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "PC终端注册失败！BIOSSerialNumber的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                if (HardDiskSerialNumber == "" || HardDiskSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "PC终端注册失败！HardDiskSerialNumber的值为空");
                    Response.Write(errorJson1);
                    return;
                }

                //判断设备是否注册过
                string systemDeviceVerificationSerialNumber = OSCEAESCrypt.Encrypt_AES(OSCEAESCrypt.StrAesKeyText, systemDeviceBll.ToJsonString(AppType, CPUSerialNumber, MainboardSerialNumber, BIOSSerialNumber));
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>()
                    {
                          {"SD_Verification_SerialNumber_Is", systemDeviceVerificationSerialNumber}
                    };
                systemDeviceList = systemDeviceBll.SearchSystemDeviceByCondition(conditionDictionary);
                if (systemDeviceList == null)
                {
                    Log4NetUtility.Error(this, "查询系统设备列表为null，请查看数据库！");
                    Response.Write(errorJson1);
                    return;
                }
                if (systemDeviceList.Count!=0)
                {
                    Log4NetUtility.Error(this, "此设备已经注册过！");
                    Response.Write(errorJson3);
                    return;
                }            
  
                Guid guid = Guid.NewGuid();
                string key = OSCEAESCrypt.StrAesKeyText + guid;
                Tellyes.Model.SystemDevice systemDevice = new Tellyes.Model.SystemDevice();
                systemDevice.SD_ID = OSCEAESCrypt.Encrypt_AES(guid.ToString());
                systemDevice.SD_Application_Type = OSCEAESCrypt.Encrypt_AES(key, AppType);
                systemDevice.SD_Type = OSCEAESCrypt.Encrypt_AES(key, SystemDeviceType);
                systemDevice.SD_HardWare_Version = OSCEAESCrypt.Encrypt_AES(key, Guid.NewGuid().ToString());
                systemDevice.SD_HardWare_System_Version = OSCEAESCrypt.Encrypt_AES(key, Guid.NewGuid().ToString());
                systemDevice.SD_HardWare_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, Guid.NewGuid().ToString());
                systemDevice.SD_CPU_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, CPUSerialNumber);
                systemDevice.SD_Mainboard_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, MainboardSerialNumber);
                systemDevice.SD_BIOS_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, BIOSSerialNumber);
                systemDevice.SD_HardDisk_SerialNumber = OSCEAESCrypt.Encrypt_AES(key, HardDiskSerialNumber);
                systemDevice.SD_MAC_Address = OSCEAESCrypt.Encrypt_AES(key, MacAddress);

                systemDevice.SD_Verification_SerialNumber = OSCEAESCrypt.Encrypt_AES(OSCEAESCrypt.StrAesKeyText,systemDeviceBll.ToJsonString(AppType, CPUSerialNumber, MainboardSerialNumber, BIOSSerialNumber));
                systemDevice.SD_Registration_Time = OSCEAESCrypt.Encrypt_AES(key, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                bool flag = systemDeviceBll.AddSystemDevice(systemDevice);
                if (flag == false)
                {
                    if (AppType == "RemoteScore")
                    {
                        Log4NetUtility.Error(this, "添加系统设备失败！（远程评分设备）");
                    }
                    if (AppType == "GeneralControl")
                    {
                        Log4NetUtility.Error(this, "添加系统设备失败！（中央总控设备）");
                    }
                    Response.Write(errorJson1);
                    return;
                }
                Response.Write("{\"result\":\"1\",\"VerificationSerialNumber\":\"" + Uri.EscapeDataString(systemDeviceVerificationSerialNumber) + "\"}");
            }
            #endregion            

        }

        /// <summary>
        /// 生成设备验证码
        /// </summary>
        private void GenerateSystemDeviceVerificationSerialNumber()
        {

            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-2\"}";

            string AppType = Request.Form["AppType"];
            string MacAddress = Request.Form["MacAddress"];

            if (AppType == "" || AppType == null)
            {
                Log4NetUtility.Error(this, "系统设备参数获取失败！AppType的值为空");
                Response.Write(errorJson1);
                return;
            }
            if (AppType != "HandScore" && AppType != "DeviceManage" && AppType != "GeneralControl" && AppType != "RemoteScore")
            {
                Log4NetUtility.Error(this, "系统设备参数获取失败！AppType的值有误！");
                Response.Write(errorJson1);
                return;
            }
            if (MacAddress == "" || MacAddress == null)
            {
                Log4NetUtility.Error(this, "系统设备参数获取失败！MacAddress的值为空");
                Response.Write(errorJson1);
                return;
            }

            Tellyes.BLL.SystemDevice systemDeviceBll = new Tellyes.BLL.SystemDevice();
            List<Tellyes.Model.SystemDevice> systemDeviceList = new List<Tellyes.Model.SystemDevice>();

            //手持设备
            if (AppType == "HandScore" || AppType == "DeviceManage")
            {
                string HardWareSerialNumber = Request.Form["HardWareSerialNumber"];
                if (HardWareSerialNumber == "" || HardWareSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "手持终端设备参数获取失败！HardWareSerialNumber的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                //验证设备是否注册过
                string systemDeviceVerificationSerialNumber = OSCEAESCrypt.Encrypt_AES(OSCEAESCrypt.StrAesKeyText, systemDeviceBll.ToJsonString(AppType, HardWareSerialNumber, MacAddress));
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>()
                    {
                          {"SD_Verification_SerialNumber_Is", systemDeviceVerificationSerialNumber}
                    };
                systemDeviceList = systemDeviceBll.SearchSystemDeviceByCondition(conditionDictionary);
                if (systemDeviceList == null)
                {
                    Log4NetUtility.Error(this, "查询系统设备列表为null，请查看数据库！");
                    Response.Write(errorJson1);
                    return;
                }
                if (systemDeviceList.Count == 0)
                {
                    Log4NetUtility.Error(this, "此设备未注册！请从新注册该设备！");
                    Response.Write(errorJson2);
                    return;
                }

                //生成验证码，返回
                Response.Write("{\"result\":\"1\",\"VerificationSerialNumber\":\"" + Uri.EscapeDataString(systemDeviceVerificationSerialNumber) + "\"}");
            }

            //PC设备
            if (AppType == "GeneralControl" || AppType == "RemoteScore")
            {
                string CPUSerialNumber = Request.Form["CPUSerialNumber"];
                string MainboardSerialNumber = Request.Form["MainboardSerialNumber"];
                string BIOSSerialNumber = Request.Form["BIOSSerialNumber"];
                if (CPUSerialNumber == "" || CPUSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "PC终端参数获取失败！CPUSerialNumber的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                if (MainboardSerialNumber == "" || MainboardSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "PC终端参数获取失败！MainboardSerialNumber 的值为空");
                    Response.Write(errorJson1);
                    return;
                }
                if (BIOSSerialNumber == "" || BIOSSerialNumber == null)
                {
                    Log4NetUtility.Error(this, "PC终端参数获取失败！BIOSSerialNumber的值为空");
                    Response.Write(errorJson1);
                    return;
                }

                //验证设备是否注册过
                string systemDeviceVerificationSerialNumber = OSCEAESCrypt.Encrypt_AES(OSCEAESCrypt.StrAesKeyText, systemDeviceBll.ToJsonString(AppType, CPUSerialNumber, MainboardSerialNumber, BIOSSerialNumber));
                Dictionary<string, object> conditionDictionary = new Dictionary<string, object>()
                    {
                          {"SD_Verification_SerialNumber_Is", systemDeviceVerificationSerialNumber}
                    };
                systemDeviceList = systemDeviceBll.SearchSystemDeviceByCondition(conditionDictionary);
                if (systemDeviceList == null)
                {
                    Log4NetUtility.Error(this, "查询系统设备列表为null，请查看数据库！");
                    Response.Write(errorJson1);
                    return;
                }
                if (systemDeviceList.Count == 0)
                {
                    Log4NetUtility.Error(this, "此设备未注册过！请从新注册该设备！");
                    Response.Write(errorJson2);
                    return;
                }

                //生成验证码，返回
                Response.Write("{\"result\":\"1\",\"VerificationSerialNumber\":\"" + Uri.EscapeDataString(systemDeviceVerificationSerialNumber) + "\"}");
            }

        }


        /// <summary>
        /// PC端设备校验
        /// </summary>
        private void PcDeviceVerification()
        {
            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-2\"}";

            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "PC终端验证失败！VerificationSerialNumber的值为空");
                Response.Write(errorJson1);
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
                Response.Write(errorJson1);
                return;
            }
            if (systemDeviceList.Count == 0)
            {
                Log4NetUtility.Error(this, "此设备未注册！请从新注册该设备！");
                Response.Write(errorJson2);
                return;
            }
            Response.Write("{\"result\":\"1\"}");
        }
    }
}
         