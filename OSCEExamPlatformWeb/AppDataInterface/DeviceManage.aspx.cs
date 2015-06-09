using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tellyes.Log4Net;
using System.Reflection;
using System.Text;
using System.IO;
using Tellyes.Common;
using System.Drawing;

namespace OSCEExamPlatformWeb.AppDataInterface
{
    public partial class DeviceManage : System.Web.UI.Page
    {
        private const string PAGE_PATH_INFO = "/AppDataInterface/DeviceManage.aspx";
        private const string ASSEMBLY_NAME = "OSCEExamPlatformWeb";
        private const string CLASS_NAME = "OSCEExamPlatformWeb.AppDataInterface.DeviceManage";

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
        /// 扫描二维码后查询设备信息
        /// </summary>
        private void SearchDeviceByDeviceID()
        {

            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-1\"}";
            string errorJson3 = "{\"result\":\"-2\"}";
            
            int DeviceID = Convert.ToInt32(Request.Form["DeviceID"]);
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);

            if (DeviceID == 0)
            {
                Log4NetUtility.Error(this, "DeviceID值有误!请查看SearchDeviceByDeviceID（）方法");
                Response.Write(errorJson1);
                return;
            }
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看SearchDeviceByDeviceID（）方法");
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
                Response.Write(errorJson3);
                return;
            }

            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>()
            {
                 {"D_ID", DeviceID}
            };

            Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            List<Tellyes.Model.Device> deviceList = deviceBll.SearchDeviceByCondition(conditionDictionary);
            if (deviceList == null)
            {
                Log4NetUtility.Error(this,"设备查询失败！数据库连接错误！");
                Response.Write(errorJson1);
                return;
            }
            if(deviceList.Count==0)
            {
                Log4NetUtility.Error(this, "设备信息不存在!");
                Response.Write(errorJson2);
                return;
            }
            //需补充注册编号校验！！！

            int NormalCount = 0;
            int ExceptionCount = 0;
            int MaintainCount = 0;
            int BorrowCount = 0;
            int ScrapCount = 0;
            int AllCount = deviceList.Count;

            foreach (Tellyes.Model.Device device in deviceList)
            {
                if(device.D_State=="良好")
                {
                    NormalCount++;
                }
                if (device.D_State == "异常")
                {
                    ExceptionCount++;
                }
                if (device.D_State == "维修")
                {
                    MaintainCount++;
                }
                if (device.D_State == "外借")
                {
                    BorrowCount++;
                }
                if (device.D_State == "报废")
                {
                    ScrapCount++;
                }
            }
            string deviceStatusCount = "["+NormalCount+","+ExceptionCount+","+MaintainCount+","+BorrowCount+","+ScrapCount+","+AllCount+"]";

           StringBuilder jsonStringBuilder = new StringBuilder();
               jsonStringBuilder.Append("{\"result\":\"1\",");
               jsonStringBuilder.Append("\"deviceStatusCount\":\"" + deviceStatusCount + "\",");
               jsonStringBuilder.Append("\"device\":" + deviceList[0].ToJsonString()+ "}");
            Response.Write(jsonStringBuilder);

           ////string result = Request.Form["test"];
           ////string deviceStatusCount = "[1,0,0,0,0,1]";
           // StringBuilder jsonStringBuilder = new StringBuilder();
           // if (result == "1")
           // {
           //     jsonStringBuilder.Append("{\"result\":\"" + result + "\",");
           //     jsonStringBuilder.Append("\"deviceStatusCount\":\"" + deviceStatusCount + "\",");
           //     jsonStringBuilder.Append("\"device\":" + device.ToJsonString() + "}");
           // }
           // else
           // {
           //     jsonStringBuilder.Append("{\"result\":\"" + result + "\"}");
           // }
           // Response.Write(jsonStringBuilder);
            
        }

        /// <summary>
        /// 加载当前扫描设备的同类设备信息
        /// </summary>
        private void SearchDeviceListByDeviceClassID()
        {
            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-1\"}";
            string errorJson3 = "{\"result\":\"-2\"}";

            int DeviceID = Convert.ToInt32(Request.Form["DeviceID"]);
            int DeviceClassID = Convert.ToInt32(Request.Form["DeviceClassID"]);
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);

            if (DeviceID == 0)
            {
                Log4NetUtility.Error(this, "DeviceID值有误!请查看SearchDeviceListByDeviceClassID（）方法");
                Response.Write(errorJson1);
                return;
            }
            if (DeviceClassID == 0)
            {
                Log4NetUtility.Error(this, "DeviceClassID值有误!请查看SearchDeviceListByDeviceClassID（）方法");
                Response.Write(errorJson1);
                return;
            }

            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看SearchDeviceListByDeviceClassID（）方法");
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
                Response.Write(errorJson3);
                return;
            }


            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>()
            {
                 {"DC_ID",DeviceClassID}
            };

            Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            List<Tellyes.Model.Device> deviceList = deviceBll.SearchDeviceByCondition(conditionDictionary);
            if (deviceList == null)
            {
                Log4NetUtility.Error(this, "设备查询失败！数据库连接错误！");
                Response.Write(errorJson1);
                return;
            }

            if (deviceList.Count == 0)
            {
                Log4NetUtility.Error(this, "设备信息不存在!");
                Response.Write(errorJson2);
                return;
            }

            //需补充注册编号校验！！！   

            //删除设备ID=DeviceID的设备
            for (int i = 0; i < deviceList.Count;i++)
            {
                if (deviceList[i].D_ID == DeviceID)
                {
                    bool flag = deviceList.Remove(deviceList[i]);
                }
            }          

            int NormalCount = 0;
            int ExceptionCount = 0;
            int MaintainCount = 0;
            int BorrowCount = 0;
            int ScrapCount = 0;
            int AllCount = deviceList.Count;

            foreach (Tellyes.Model.Device deviceModel in deviceList)
            {
                if (deviceModel.D_State == "良好")
                {
                    NormalCount++;
                }
                if (deviceModel.D_State == "异常")
                {
                    ExceptionCount++;
                }
                if (deviceModel.D_State == "维修")
                {
                    MaintainCount++;
                }
                if (deviceModel.D_State == "外借")
                {
                    BorrowCount++;
                }
                if (deviceModel.D_State == "报废")
                {
                    ScrapCount++;
                }
            }
            string deviceStatusCount = "[" + NormalCount + "," + ExceptionCount + "," + MaintainCount + "," + BorrowCount + "," + ScrapCount + "," + AllCount + "]";

            StringBuilder jsonStringBuilder = new StringBuilder();
            jsonStringBuilder.Append("{\"result\":\"1\",");
            jsonStringBuilder.Append("\"deviceStatusCount\":\"" + deviceStatusCount + "\",");
            jsonStringBuilder.Append("\"deviceList\":[");
            foreach (Tellyes.Model.Device model in deviceList)
            {
                jsonStringBuilder.Append(model.ToJsonString() + ",");
            }
            if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
            {
                jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
            }
            jsonStringBuilder.Append("]}");
            Response.Write(jsonStringBuilder);

            //string result = Request.Form["test"];
            //string deviceStatusCount = "[3,1,1,2,1,8]";
            //Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            //List<Tellyes.Model.Device> deviceList = deviceBll.SearchDeviceByCondition();
            //StringBuilder jsonStringBuilder = new StringBuilder();
            //if (result == "1")
            //{
            //    jsonStringBuilder.Append("{\"result\":\"" + result + "\",");
            //    jsonStringBuilder.Append("\"deviceStatusCount\":\"" + deviceStatusCount + "\",");
            //    jsonStringBuilder.Append("\"deviceList\":[");

            //    foreach (Tellyes.Model.Device device in deviceList)
            //    {
            //        jsonStringBuilder.Append(device.ToJsonString() + ",");
            //    }
            //    if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
            //    {
            //        jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
            //    }
            //    jsonStringBuilder.Append("]}");
            //}
            //else
            //{
            //    jsonStringBuilder.Append("{\"result\":\"" + result + "\"}");
            //}
            //Response.Write(jsonStringBuilder);
        }

        /// <summary>
        /// 查询选择设备的基本信息
        /// </summary>
        private void SearchDeviceBaseInfoByDeviceID()
        {
            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-1\"}";
            string errorJson3 = "{\"result\":\"-2\"}";

            int DeviceID = Convert.ToInt32(Request.Form["DeviceID"]);
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);


            if (DeviceID == 0)
            {
                Log4NetUtility.Error(this, "DeviceID值有误!请查看SearchDeviceBaseInfoByDeviceID（）方法");
                Response.Write(errorJson1);
                return;
            }
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看SearchDeviceBaseInfoByDeviceID（）方法");
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
                Response.Write(errorJson3);
                return;
            }


            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            {
                 {"D_ID", DeviceID}
            };

            List<KeyValuePair<string, string>> orderList=new List<KeyValuePair<string,string>>(){};
            Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            List<Dictionary<string, object>> deviceStaticInfoDictionaryList = deviceBll.SelectDeviceStatisticInfoPageByCondition(conditionDictionary, orderList,0,10);
            if (deviceStaticInfoDictionaryList == null)
            {
                Log4NetUtility.Error(this, "设备查询失败！数据库连接错误！");
                Response.Write(errorJson1);
                return;
            }
            if (deviceStaticInfoDictionaryList.Count == 0)
            {
                Log4NetUtility.Error(this, "设备查询失败！设备信息不存在！");
                Response.Write(errorJson2);
                return;
            }

            StringBuilder jsonStringBuilder = new StringBuilder();
            jsonStringBuilder.Append("{\"result\":\"1\",");
            jsonStringBuilder.Append("\"device\":{\"D_ID\":\"" + deviceStaticInfoDictionaryList[0]["D_ID"] + "\",\"D_SerialNumber\":\"" + Uri.EscapeDataString(deviceStaticInfoDictionaryList[0]["D_SerialNumber"].ToString())+ "\",\"D_Name\":\"" + Uri.EscapeDataString(deviceStaticInfoDictionaryList[0]["D_Name"].ToString()) + "\",\"D_TotalUseCount\":\"" + deviceStaticInfoDictionaryList[0]["UseCount"] + "\",\"DeviceUseRate\":\"" + deviceStaticInfoDictionaryList[0]["DeviceUseFrequency"] + "\"}");
            jsonStringBuilder.Append("}");
            Response.Write(jsonStringBuilder);

            //string result = Request.Form["test"];
            //Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            //Tellyes.Model.Device device = deviceBll.SearchDeviceByID(1066);

            //StringBuilder jsonStringBuilder = new StringBuilder();
            //if (result == "1")
            //{
            //    jsonStringBuilder.Append("{\"result\":\"" + result + "\",");
            //    jsonStringBuilder.Append("\"device\":" + device.ToJsonString() + "}");
            //}
            //else
            //{
            //    jsonStringBuilder.Append("{\"result\":\"" + result + "\"}");
            //}
            //Response.Write(jsonStringBuilder);
        }

        /// <summary>
        /// 查询选择设备的图片
        /// </summary>
        private void SearchDeviceImageByDeviceID()
        {
            int DeviceID = Convert.ToInt32(Request.QueryString["DeviceID"]);
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.QueryString["VerificationSerialNumber"]);

            if (DeviceID == 0)
            {
                Log4NetUtility.Error(this, "DeviceID值有误!请查看SearchDeviceImageByDeviceID（）方法");
                return;
            }
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看SearchDeviceImageByDeviceID（）方法");
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
                return;
            }
            if (systemDeviceList.Count == 0)
            {
                Log4NetUtility.Error(this, "此设备未注册！请从新注册该设备！");
                return;
            }

            Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            Tellyes.Model.Device device = deviceBll.SearchDeviceByID(DeviceID);
            if(device==null)
            {
                Log4NetUtility.Error(this,"设备信息查询失败！deviceID="+DeviceID);
                return;
            }

            Response.Cache.SetNoStore();
            Response.ClearContent();
            Response.ContentType = "application/octet-stream";

            if (device.D_Image != null)
            {
                Response.BinaryWrite(device.D_Image);
            }
            else
            {
                Log4NetUtility.Error(this, "此设备目前无设备图片！deviceID=" + DeviceID);
                return;
            }
        }

        /// <summary>
        /// 上传选择设备的图片
        /// </summary>
        private void ModifyDeviceImageByDeviceID()
        {
            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-1\"}";
            string errorJson3 = "{\"result\":\"-2\"}";

            int DeviceID = Convert.ToInt32(Request.Form["DeviceID"]);
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);


            if (DeviceID == 0)
            {
                Log4NetUtility.Error(this, "DeviceID值有误!请查看ModifyDeviceImageByDeviceID（）方法");
                Response.Write(errorJson1);
                return;
            }
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看ModifyDeviceImageByDeviceID（）方法");
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
                Response.Write(errorJson3);
                return;
            }

            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            {
                 {"D_ID", DeviceID}
            };
            List<KeyValuePair<string, string>> orderList = new List<KeyValuePair<string, string>>() { };
            Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            List<Tellyes.Model.Device> deviceList = deviceBll.SearchDeviceByCondition(conditionDictionary, orderList);
            if (deviceList==null)
            {
                Log4NetUtility.Error(this,"设备信息查询失败，数据库错误！");
                Response.Write(errorJson1);
                return;
            }
            if(deviceList.Count==0)
            {
                Log4NetUtility.Error(this,"设备信息查询失败,设备信息不存在！DeviceID="+DeviceID);
                Response.Write(errorJson2);
                return;
            }

            try
            {
                //获取图片信息
                HttpPostedFile image = Request.Files["DeviceImage"];
                string fileName = System.IO.Path.GetFileName(image.FileName);
                string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                if (fileExtension != ".bmp" && fileExtension != ".gif" && fileExtension != ".jpeg" && fileExtension != ".png")
                {
                    Log4NetUtility.Error(this,"图片类型不正确！");
                    Response.Write(errorJson2);
                    return;
                }

                //图片大小进行缩放
                byte[] imageBytes = ImageProcessHelper.ZoomInOut(image.InputStream, 400, 300);
                deviceList[0].D_Image = imageBytes;
            }
            catch(Exception e)
            {
                Log4NetUtility.Error(this,"手持设备上传设备图片信息失败！DeviceID="+DeviceID, e);
                Response.Write(errorJson2);
                return;
            }

            bool flag = false;
            flag = deviceBll.ModifyDevice(deviceList[0]);
            if (flag == false)
            {

                Log4NetUtility.Error(this, "设备信息保存失败！DeviceID=" + DeviceID);
                Response.Write(errorJson2);
                return;
            }
            Response.Write("{\"result\":\"1\"}");
        }

        /// <summary>
        /// 查询选择设备的全部信息
        /// </summary>
        private void SearchDeviceAllInfoByDeviceID()
        {
            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-1\"}";
            string errorJson3 = "{\"result\":\"-2\"}";

            int DeviceID = Convert.ToInt32(Request.Form["DeviceID"]);
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);


            if (DeviceID==0)
            {
                Log4NetUtility.Error(this, "DeviceID值有误!请查看SearchDeviceAllInfoByDeviceID（）方法");
                Response.Write(errorJson1);
                return;
            }
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看SearchDeviceAllInfoByDeviceID（）方法");
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
                Response.Write(errorJson3);
                return;
            }


            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            {
                 {"D_ID", DeviceID}
            };

            Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            List<Tellyes.Model.Device> deviceList = deviceBll.SearchDeviceByCondition(conditionDictionary);
            if (deviceList == null)
            {
                Log4NetUtility.Error(this, "设备查询失败！数据库连接错误！");
                Response.Write(errorJson1);
                return;
            }
            if (deviceList.Count == 0)
            {
                Log4NetUtility.Error(this, "设备查询失败！设备信息不存在！");
                Response.Write(errorJson2);
                return;
            }


            //获取设备类别信息
            string DeviceClass1 = "";
            string DeviceClass2 = "";
            string DeviceClass3 = "";
            Tellyes.BLL.DeviceClassBLL deviceClassBll=new Tellyes.BLL.DeviceClassBLL();
            Tellyes.Model.DeviceClass deviceClassModel1=new Tellyes.Model.DeviceClass();
            Tellyes.Model.DeviceClass deviceClassModel2=new Tellyes.Model.DeviceClass();
            Tellyes.Model.DeviceClass deviceClassModel3=new Tellyes.Model.DeviceClass();

            if (deviceList[0].DC_ID == 0)
            {
                DeviceClass3 = "未定义";
            }
            else
            {
                deviceClassModel3 = deviceClassBll.SearchDeviceClassByDCID(Convert.ToInt32(deviceList[0].DC_ID));
                if (deviceClassModel3==null)
                {
                    Log4NetUtility.Error(this, "查询设备类型失败！设备类别ID=" + deviceList[0].DC_ID);
                    Response.Write(errorJson2);
                    return;
                }                
                DeviceClass3 =deviceClassModel3.DC_Name;

                if (deviceClassModel3.DC_ParentID == 0)
                {
                    DeviceClass2 = "";
                }
                else
                {
                    deviceClassModel2 = deviceClassBll.SearchDeviceClassByDCID(deviceClassModel3.DC_ParentID);
                    if (deviceClassModel2 == null)
                    {
                        Log4NetUtility.Error(this, "查询设备类型失败！设备类别ID=" + deviceClassModel3.DC_ParentID);
                        Response.Write(errorJson2);
                        return;
                    }
                    DeviceClass2 = deviceClassModel2.DC_Name;

                    if(deviceClassModel2.DC_ParentID==0)
                    {
                        DeviceClass1 = "";
                    }
                    else
                    {
                        deviceClassModel1 = deviceClassBll.SearchDeviceClassByDCID(deviceClassModel2.DC_ParentID);
                        if (deviceClassModel1 == null)
                        {
                            Log4NetUtility.Error(this, "查询设备类型失败！设备类别ID=" + deviceClassModel2.DC_ParentID);
                            Response.Write(errorJson2);
                            return;
                        }
                        DeviceClass1 = deviceClassModel1.DC_Name;
                    }
                }
            }

            string DeviceClassNameList = "["+DeviceClass1+","+DeviceClass2+","+DeviceClass3+"]";

            StringBuilder jsonStringBuilder = new StringBuilder();           
            jsonStringBuilder.Append("{\"result\":\"1\",");
            jsonStringBuilder.Append("\"deviceAllInfo\":{" + deviceList[0].ToJsonString(false) + "," + "\"DeviceClassNameList\":\"" + DeviceClassNameList + "\"},");
            jsonStringBuilder.Append("\"selectableDeviceStatusList\":\"[良好,异常,维修,外借,报废]\"}");           
            Response.Write(jsonStringBuilder);


            //string result = Request.Form["test"];
            //Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            //Tellyes.Model.Device device = deviceBll.SearchDeviceByID(1066);

            //StringBuilder jsonStringBuilder = new StringBuilder();
            //if (result == "1")
            //{
            //    jsonStringBuilder.Append("{\"result\":\"" + result + "\",");
            //    jsonStringBuilder.Append("\"deviceAllInfo\":{" + device.ToJsonString(false) + "," + "\"DeviceClassNameList\":\"[设备类型1,设备类型2,设备类型3]\"" + "},");
            //    jsonStringBuilder.Append("\"selectableDeviceStatusList\":\"[良好,异常,维修,外借,报废]\"}");
            //}
            //else
            //{
            //    jsonStringBuilder.Append("{\"result\":\"" + result + "\"}");
            //}
            //Response.Write(jsonStringBuilder);
        }

        /// <summary>
        /// 查询设备分类树形结构
        /// </summary>
        private void SearchDeviceClass()
        {
            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-2\"}";

            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);
            if (VerificationSerialNumber == "" || VerificationSerialNumber == null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看SearchDeviceClass（）方法");
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


            Tellyes.BLL.DeviceClassBLL deviceClassBll = new Tellyes.BLL.DeviceClassBLL();
            List<Tellyes.Model.DeviceClass> deviceClassList = new List<Tellyes.Model.DeviceClass>();
            deviceClassList = deviceClassBll.SearchDeviceClass();
            if (deviceClassList == null)
            {
                Log4NetUtility.Error(this, "查询设备类别列表失败！");
                Response.Write(errorJson1);
                return;
            }

            StringBuilder jsonStringBuilder = new StringBuilder();
            jsonStringBuilder.Append("{\"result\":\"1\",");
            jsonStringBuilder.Append("\"deviceClassList\":");
            jsonStringBuilder.Append(deviceClassBll.IteraDeviceClassToJsonString(deviceClassList, 0));
            if (jsonStringBuilder[jsonStringBuilder.Length - 1] == ',')
            {
                jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);
            }
            jsonStringBuilder.Append("}");
            Response.Write(jsonStringBuilder.ToString());
        }

        /// <summary>
        /// 保存选择设备的全部信息
        /// </summary>
        private void ModifyDeviceAllInfoByDeviceID()
        {

        }

        /// <summary>
        /// 查询选择设备的统计信息
        /// </summary>
        private void SearchDeviceStatisticsInfoByDeviceID()
        {

            string errorJson1 = "{\"result\":\"0\"}";
            string errorJson2 = "{\"result\":\"-1\"}";
            string errorJson3 = "{\"result\":\"-2\"}";

            int DeviceID = Convert.ToInt32(Request.Form["DeviceID"]);
            string VerificationSerialNumber = Uri.UnescapeDataString(Request.Form["VerificationSerialNumber"]);
            string SearchType = Request.Form["SearchType"];


            if (DeviceID==0)
            {
                Log4NetUtility.Error(this, "DeviceID值有误!请查看SearchDeviceStatisticsInfoByDeviceID（）方法");
                Response.Write(errorJson1);
                return;
            }
            if (VerificationSerialNumber == "" || VerificationSerialNumber==null)
            {
                Log4NetUtility.Error(this, "VerificationSerialNumber值为空!请查看SearchDeviceStatisticsInfoByDeviceID（）方法");
                Response.Write(errorJson1);
                return;
            }
            if (SearchType == "" || SearchType==null)
            {
                Log4NetUtility.Error(this, "SearchType值为空!请查看SearchDeviceStatisticsInfoByDeviceID（）方法");
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
                Response.Write(errorJson3);
                return;
            }


             Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            {
                 {"D_ID", DeviceID},
                 
            };
            List<KeyValuePair<string, string>> orderList=new List<KeyValuePair<string,string>>();
            //设定检索起始时间
            if(SearchType=="1")
            {
                DateTime NewTime = DateTime.Now.AddMonths(-1);
                conditionDictionary.Add(">StartTime", NewTime.ToString());
            }
            if(SearchType=="2")
            {
                DateTime NewTime = DateTime.Now.AddMonths(-3);
                conditionDictionary.Add(">StartTime", NewTime.ToString());
            }
            if(SearchType=="3")
            {
                DateTime NewTime = DateTime.Now.AddMonths(-6);
                conditionDictionary.Add(">StartTime", NewTime.ToString());
            }
            if (SearchType == "4")
            {
                DateTime NewTime = DateTime.Now.AddMonths(-12);
                conditionDictionary.Add(">StartTime", NewTime.ToString());
            }

            Tellyes.BLL.Device deviceBll = new Tellyes.BLL.Device();
            List<Dictionary<string, object>> deviceList = deviceBll.SelectDeviceStatisticInfoPageByCondition(conditionDictionary, orderList,0,10);
            if (deviceList == null)
            {
                Log4NetUtility.Error(this, "设备查询失败！数据库连接错误！");
                Response.Write(errorJson1);
                return;
            }
            if (deviceList.Count == 0)
            {
                Log4NetUtility.Error(this, "设备查询失败！设备信息不存在！");
                Response.Write(errorJson2);
                return;
            }

            List<int> DeviceClassIDList=new List<int>(){ Convert.ToInt32(deviceList[0]["DC_ID"])};

            Dictionary<string, object> conditionDictionaryDeviceClass = new Dictionary<string, object>() 
            {
                 {"DC_ID,IN",DeviceClassIDList }                 
            };
           

            List<Dictionary<string, object>> deviceClassList = deviceBll.SelectDeviceClassStatisticInfoPageByCondition(conditionDictionaryDeviceClass, orderList, 0, 10);
            if (deviceClassList == null)
            {
                Log4NetUtility.Error(this, "设备类别查询失败！数据库连接错误！");
                Response.Write(errorJson1);
                return;
            }
            if (deviceClassList.Count == 0)
            {
                Log4NetUtility.Error(this, "设备类别查询失败！设备信息不存在！");
                Response.Write(errorJson2);
                return;
            }

            //获取设备类别信息
            string DeviceClass1 = "";
            string DeviceClass2 = "";
            string DeviceClass3 = "";
            Tellyes.BLL.DeviceClassBLL deviceClassBll = new Tellyes.BLL.DeviceClassBLL();
            Tellyes.Model.DeviceClass deviceClassModel1 = new Tellyes.Model.DeviceClass();
            Tellyes.Model.DeviceClass deviceClassModel2 = new Tellyes.Model.DeviceClass();
            Tellyes.Model.DeviceClass deviceClassModel3 = new Tellyes.Model.DeviceClass();

            if (Convert.ToInt32(deviceList[0]["DC_ID"])== 0)
            {
                DeviceClass3 = "未定义";
            }
            else
            {
                deviceClassModel3 = deviceClassBll.SearchDeviceClassByDCID(Convert.ToInt32(deviceList[0]["DC_ID"]));
                if (deviceClassModel3 == null)
                {
                    Log4NetUtility.Error(this, "查询设备类型失败！设备类别ID=" + Convert.ToInt32(deviceList[0]["DC_ID"]));
                    Response.Write(errorJson2);
                    return;
                }
                DeviceClass3 = deviceClassModel3.DC_Name;

                if (deviceClassModel3.DC_ParentID == 0)
                {
                    DeviceClass2 = "";
                }
                else
                {
                    deviceClassModel2 = deviceClassBll.SearchDeviceClassByDCID(deviceClassModel3.DC_ParentID);
                    if (deviceClassModel2 == null)
                    {
                        Log4NetUtility.Error(this, "查询设备类型失败！设备类别ID=" + deviceClassModel3.DC_ParentID);
                        Response.Write(errorJson2);
                        return;
                    }
                    DeviceClass2 = deviceClassModel2.DC_Name;

                    if (deviceClassModel2.DC_ParentID == 0)
                    {
                        DeviceClass1 = "";
                    }
                    else
                    {
                        deviceClassModel1 = deviceClassBll.SearchDeviceClassByDCID(deviceClassModel2.DC_ParentID);
                        if (deviceClassModel1 == null)
                        {
                            Log4NetUtility.Error(this, "查询设备类型失败！设备类别ID=" + deviceClassModel2.DC_ParentID);
                            Response.Write(errorJson2);
                            return;
                        }
                        DeviceClass1 = deviceClassModel1.DC_Name;
                    }
                }
            }

            string DeviceClassNameList = "\"[" + DeviceClass1 + "," + DeviceClass2 + "," + DeviceClass3 + "]\"";

            StringBuilder jsonStringBuilder = new StringBuilder();
            jsonStringBuilder.Append("{\"result\":\"1\",");
            jsonStringBuilder.Append("\"deviceStatisticsInfo\":{");
            jsonStringBuilder.Append("  \"D_ID\":\"" + deviceList[0]["D_ID"] + "\",");
            jsonStringBuilder.Append("  \"D_SerialNumber\":\"" + deviceList[0]["D_SerialNumber"] + "\",");
            jsonStringBuilder.Append("  \"D_Name\":\"" + deviceList[0]["D_Name"] + "\",");
            jsonStringBuilder.Append("  \"D_State\":\"" + deviceList[0]["D_State"] + "\",");
            jsonStringBuilder.Append("  \"DeviceClassNameList\":" + DeviceClassNameList);
            jsonStringBuilder.Append("  ,\"D_UseCount\":\"" + deviceList[0]["UseCount"] + "\",");
            jsonStringBuilder.Append("  \"D_UseTime\":\"" + deviceList[0]["UseTime"] + "\",");
            jsonStringBuilder.Append("  \"DeviceUseRate\":\"" + deviceList[0]["DeviceUseFrequency"] + "\",");
            jsonStringBuilder.Append("  \"DeviceMaintainCount\":\"" + deviceList[0]["DeviceMaintainCount"] + "\",");
            jsonStringBuilder.Append("  \"DeviceMaintainRate\":\"" + deviceList[0]["DeviceMaintainFrequency"] + "\"");
            jsonStringBuilder.Append("  },");
            jsonStringBuilder.Append("\"deviceClassStatisticsInfo\":{");
            jsonStringBuilder.Append("  \"DC_ID\":\"" + deviceClassList[0]["DC_ID"] + "\",");
            jsonStringBuilder.Append("  \"DeviceClassNameList\":" + DeviceClassNameList);
            jsonStringBuilder.Append("  ,\"DeviceMaintainSuccessRate\":\"" + deviceClassList[0]["DeviceMaintainSuccessRate"] + "\",");
            jsonStringBuilder.Append("  \"MaxDeviceMaintainSuccessCount\":\"" + deviceClassList[0]["DeviceClassMaxMaintainCount"] + "\",");
            jsonStringBuilder.Append("  \"ExamAverageUseCount\":\"" + deviceClassList[0]["DeviceClassAverageUseCount"] + "\",");
            jsonStringBuilder.Append("  \"DeviceCount\":\"" + deviceClassList[0]["DeviceClassCount"] + "\"");
            jsonStringBuilder.Append("  }");
            jsonStringBuilder.Append("}");
            Response.Write(jsonStringBuilder.ToString());
        }
       
    }
}