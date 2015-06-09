using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.Model;
using HikVision;
using System.Threading;

namespace Tellyes.HikvisionCameraUtility
{
    public class HikvisionCameraScanUtility
    {
        /// <summary>
        /// 摄像头端口号
        /// </summary>
        public string CameraPort
        {
            get;
            set;
        }

        /// <summary>
        /// 摄像头用户名
        /// </summary>
        public string CameraUsername
        {
            get;
            set;
        }

        /// <summary>
        /// 摄像头密码
        /// </summary>
        public string CameraPassword
        {
            get;
            set;
        }

        /// <summary>
        /// 数据库中已经存在的摄像头列表？？？
        /// </summary>
        public List<Camera> ExistsCameraList
        {
            get;
            set;
        }

        /// <summary>
        /// 扫描出的摄像头列表
        /// </summary>
        public List<Camera> ScanResultCameraList
        {
            set;
            get;
        }

        /// <summary>
        /// 扫描出的IP地址列表
        /// </summary>
        public List<string> ScanIPAddressList
        {
            get;
            set;
        }

        /// <summary>
        /// 已经扫描的IP地址列表
        /// </summary>
        private List<string> HasScanedIPAddressList = new List<string>();

        /// <summary>
        /// 摄像头扫描进度百分比
        /// </summary>
        public int ScanPercent 
        {
            get
            {
                return HasScanedIPAddressList.Count * 100 / ScanIPAddressList.Count;
            }
        }

        /// <summary>
        /// 是否继续扫描标示位，扫描摄像头线程的是否结束标识位
        /// </summary>
        private bool IsScanContinue = true;

        /// <summary>
        /// 开始扫描摄像头，启动扫描摄像头线程
        /// </summary>
        /// <returns></returns>
        public bool ScanCameraStart()
        {
            //
            bool result = HikvisionCameraUtility.InitNetDVR();
            if (!result)
            {
                return false;
            }

            //启动线程，开始扫描
            new Thread(this.ScanCamera).Start();    //通过“委托”调用扫描摄像头方法

            return true;
        }

        /// <summary>
        /// 结束扫描摄像头，关闭扫描摄像头线程
        /// </summary>
        /// <returns></returns>
        public void ScanCameraEnd()
        {
            this.IsScanContinue = false;
        }

        /// <summary>
        /// 扫描摄像头方法
        /// </summary>
        public void ScanCamera()
        { 
            foreach(string ipAddress in this.ScanIPAddressList)                 ////////////目前数据为“假数据”，需要进一步完善
            {
                if(new Random().Next() % 10 == 1) 
                {
                    //有效摄像头IP
                    Camera camera = new Camera();
                    camera.CameraID = 0;
                    camera.ParentRoomID = 0;
                    camera.ChildRoomID = 0;
                    camera.CameraPort = "8000";
                    camera.CameraUsername = "admin";
                    camera.CameraPassword = "12345";
                    camera.CameraClass = "";
                    camera.CameraName = "";
                    camera.CameraDescribe = "";
                    camera.CameraIP = ipAddress;
                    camera.CameraMAC = "12-12-12-12-12-12";
                    ScanResultCameraList.Add(camera);
                } 
                
                HasScanedIPAddressList.Add(ipAddress);

                if(!this.IsScanContinue) 
                {
                    break;
                }

                Thread.Sleep(30);
            }

            //
            bool result = HikvisionCameraUtility.NetDVRCleanup();
            if (!result) 
            {
                
            }
        }
    }
}
