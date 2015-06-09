using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HikVision;
using Tellyes.Log4Net;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Management;

namespace Tellyes.HikvisionCameraUtility
{
    public class HikvisionCameraUtility
    {
        /// <summary>
        /// 初始化海康SDK
        /// </summary>
        /// <returns></returns>
        public static bool InitNetDVR()
        {
            bool result = false;
            try
            { 
                result = Hik_HCNetSDK.NET_DVR_Init();
            } 
            catch(Exception e)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK初始化失败，错误代码：" + errorCode, e);
            }
            return result;
        }

        /// <summary>
        /// 连接超时设置
        /// </summary>
        /// <returns></returns>
        private static bool _connectTimeout()
        {
            bool result = Hik_HCNetSDK.NET_DVR_SetConnectTime(1500, 1);
            if (!result)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK设置连接超时时间失败，错误代码：" + errorCode);
            }
            return result;
        }

        /// <summary>
        /// 海康摄像头异常消息处理函数
        /// IntPtr 类型被设计成整数，其大小适用于特定平台。即是说，此类型的实例在 32 位硬件和操作系统中将是 32 位，在 64 位硬件和操作系统上将是 64 位
        /// </summary>
        /// <param name="nMessage"></param>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        private static bool _netDVR_SetDVRMessage(uint nMessage, System.IntPtr hWnd)
        {
            bool result = Hik_HCNetSDK.NET_DVR_SetDVRMessage(nMessage, hWnd);
            if (!result)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头异常消息处理失败，错误代码：" + errorCode);
            }
            return result;
        }

        /// <summary>
        /// 通过摄像头IP、端口号、用户名、密码 登录摄像头，可以取得此摄像头信息
        /// </summary>
        /// <param name="cameraIP"></param>
        /// <param name="cameraPort"></param>
        /// <param name="cameraUsername"></param>
        /// <param name="cameraPassword"></param>
        /// <param name="devInfo"></param>
        /// <returns></returns>
        public static Int32 NetDVRLogin(string cameraIP, string cameraPort, string cameraUsername, string cameraPassword, ref NET_DVR_DEVICEINFO devInfo)
        {
            Int32 userID = -1;
            try
            {
                userID = Hik_HCNetSDK.NET_DVR_Login(cameraIP, Convert.ToUInt16(cameraPort), cameraUsername, cameraPassword, ref devInfo);
            }
            catch (Exception e)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK登录失败，错误代码：" + errorCode, e);
            }
            if (userID == -1)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK登录失败，错误代码：" + errorCode);
            }
            return userID;
        }

        /// <summary>
        /// 通过UserID注销摄像头
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static bool NetDVRLogout(Int32 userID)
        {
            bool result = false;
            try
            {
                result = Hik_HCNetSDK.NET_DVR_Logout(userID);
            }
            catch (Exception e)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK登出失败，错误代码：" + errorCode, e);
            }
            if (!result)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK登出失败，错误代码：" + errorCode);
            }
            return result;
        }

        /// <summary>
        /// 释放海康SDK资源
        /// </summary>
        /// <returns></returns>
        public static bool NetDVRCleanup()
        {
            bool result = false;
            try
            {
                result = Hik_HCNetSDK.NET_DVR_Cleanup();
            }
            catch (Exception e)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK释放资源失败，错误代码：" + errorCode, e);
            }
            if (!result)
            {
                uint errorCode = Hik_HCNetSDK.NET_DVR_GetLastError();
                Log4NetUtility.Error("HikvisionCameraUtility", "海康摄像头SDK释放资源失败，错误代码：" + errorCode);
            }
            return result;
        }

        /// <summary>
        /// 通过cmd.exe Ping 指定IP
        /// </summary>
        /// <param name="strIp"></param>
        /// <returns></returns>
        public static string CmdPing(string strIp)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe"; //测试系统环境变量Path下的%Systemroot%
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.StandardInput.WriteLine("ping -n 1 " + strIp);
                p.StandardInput.WriteLine("exit");
                string strRst = p.StandardOutput.ReadToEnd();
                p.Close();
                return strRst;
            }
            catch (Exception e)
            {
                Log4NetUtility.Error("HikvisionCameraUtility", "Ping摄像头IP地址失败", e);
                return null;
            }
            
        }

        /// <summary>
        /// 通过cmd.exe 获取指定IP MAC地址
        /// </summary>
        /// <param name="strIp"></param>
        /// <returns></returns>
        public static string CmdArp(string strIp)
        {
            try 
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                string pingrst;
                p.Start();
                p.StandardInput.WriteLine("arp -a " + strIp);
                p.StandardInput.WriteLine("exit");
                string strRst = p.StandardOutput.ReadToEnd();
                pingrst = strRst;
                p.Close();

                string mac = pingrst.Substring(pingrst.LastIndexOf(strIp) + strIp.Length).TrimStart().Substring(0, 17).ToUpper();
                string pattern = "[A-F\\d]{2}\\-[A-F\\d]{2}\\-[A-F\\d]{2}\\-[A-F\\d]{2}\\-[A-F\\d]{2}\\-[A-F\\d]{2}";   //正则表达式
                bool result = Regex.IsMatch(mac, pattern);
                if (!result)
                {
                    Log4NetUtility.Error("HikvisionCameraUtility", "读取摄像头MAC地址失败");
                    return null;
                }
                return mac;
            }
            catch(Exception e)
            {
                Log4NetUtility.Error("HikvisionCameraUtility", "Arp摄像头MAC地址失败", e);
                return null;
            }
            

            
        }

        /// <summary>
        /// 通过摄像头IP、端口号、用户名、密码 测试连接摄像头
        /// </summary>
        /// <param name="cameraIP"></param>
        /// <param name="cameraPort"></param>
        /// <param name="cameraUsername"></param>
        /// <param name="cameraPassword"></param>
        /// <returns>CameraMAC</returns>
        public static string CameraTestConnect(string cameraIP, string cameraPort, string cameraUsername, string cameraPassword)
        {
            //
            bool result = HikvisionCameraUtility.InitNetDVR();
            if (!result) 
            {
                return null;
            }

            //
            NET_DVR_DEVICEINFO devInfo = default(NET_DVR_DEVICEINFO);
            Int32 userID = HikvisionCameraUtility.NetDVRLogin(cameraIP, cameraPort, cameraUsername, cameraPassword, ref devInfo);
            if (userID == -1)
            {
                return null;
            }

            //
            result = HikvisionCameraUtility.NetDVRLogout(userID);
            if (!result)
            {
                return null;
            }

            //
            result = HikvisionCameraUtility.NetDVRCleanup();
            if (!result)
            {
                return null;
            }

            //有效摄像头IP
            //Ping 摄像头IP
            CmdPing(cameraIP);
            //截取摄像头MAC地址（17位MAC）
            string cameraMAC = CmdArp(cameraIP);

            return cameraMAC;
        }

        /// <summary>
        /// 获取服务器IP和网关信息
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetServerNetConfig()
        {
            try
            { 
                string ipPattern = "\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}";
                List<KeyValuePair<string, string>> serverIPConfig = new List<KeyValuePair<string, string>>();
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if (!(bool)mo["IPEnabled"])
                        continue;
                    string[] ipaddress = (string[])mo["IPAddress"];
                    string[] gateways = (string[])mo["DefaultIPGateway"];
                    for (int i = 0; i < ipaddress.Length && i < gateways.Length; i++)
                    {
                        if (Regex.IsMatch(ipaddress[i], ipPattern)) 
                        {
                            serverIPConfig.Add(new KeyValuePair<string, string>(ipaddress[i], gateways[i]));
                        }
                    }
                    break;
                }
                return serverIPConfig;
            }
            catch(Exception e)
            {
                Log4NetUtility.Error("HikvisionCameraUtility", "获取服务器IP地址及网关地址失败", e);
                return null;
            }
        }
    }
}
