using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class Camera
    {
        public const string CAMERA_PORT = "8000";
        public const string CAMERA_USERNAME = "admin";
        public const string CAMERA_PASSWORD = "12345";

        public static string[] CameraClassList = new string[] 
        { 
            "智能球型摄像机",
            "半球型摄像机",
            "枪型摄像机",
            "筒型摄像机"
        };

        

        /// <summary>
        /// 主键编号
        /// </summary>
        public virtual int CameraID
        {
            get;
            set;
        }
        /// <summary>
        /// 父房间ID(‘0’表示摄像头未分配房间，‘非0’表示摄像头已分配房间)
        /// </summary>
        public virtual int ParentRoomID
        {
            get;
            set;
        }
        /// <summary>
        /// 子房间ID(‘0’表示父房间没有子房间，‘非0’表示父房间中对应子房间的ID)
        /// </summary>
        public virtual int ChildRoomID
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头IP
        /// </summary>
        public virtual string CameraIP
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头端口号
        /// </summary>
        public virtual string CameraPort
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头登录用户
        /// </summary>
        public virtual string CameraUsername
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头登录密码
        /// </summary>
        public virtual string CameraPassword
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头mac
        /// </summary>
        public virtual string CameraMAC
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头类别(全景定焦,)
        /// </summary>
        public virtual string CameraClass
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头名字
        /// </summary>
        public virtual string CameraName
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头描述
        /// </summary>
        public virtual string CameraDescribe
        {
            get;
            set;
        }

        public virtual string ToJsonString() 
        {
            string jsonString = "{";
            jsonString += "\"CameraID\":\"" + this.CameraID + "\",";
            jsonString += "\"ParentRoomID\":\"" + this.ParentRoomID + "\",";
            jsonString += "\"ChildRoomID\":\"" + this.ChildRoomID + "\",";
            jsonString += "\"CameraIP\":\"" + this.CameraIP + "\",";
            jsonString += "\"CameraPort\":\"" + this.CameraPort + "\",";
            jsonString += "\"CameraUsername\":\"" + this.CameraUsername + "\",";
            jsonString += "\"CameraPassword\":\"" + this.CameraPassword + "\",";
            jsonString += "\"CameraMAC\":\"" + this.CameraMAC + "\",";
            jsonString += "\"CameraClass\":\"" + this.CameraClass + "\",";
            jsonString += "\"CameraName\":\"" + Uri.EscapeDataString(this.CameraName) + "\",";                   //手动输入的内容 需要进行校验转换
            jsonString += "\"CameraDescribe\":\"" + Uri.EscapeDataString(this.CameraDescribe) + "\"";            //手动输入的内容 需要进行校验转换
            jsonString += "}";
            return jsonString;
        }






        //public virtual string ToJsonString2()
        //{
        //    string jsonString = "{";
        //    jsonString += "\"CameraID\":\"" + this.CameraID + "\",";
        //    jsonString += "\"ParentRoomID\":\"" + this.ParentRoomID + "\",";
        //    jsonString += "\"ChildRoomID\":\"" + this.ChildRoomID + "\",";
        //    jsonString += "\"CameraIP\":\"" + this.CameraIP+ "\",";
        //    jsonString += "\"CameraMAC\":\"" + this.CameraMAC + "\",";
        //    jsonString += "\"CameraClass\":\"" + this.CameraClass + "\",";
        //    jsonString += "\"CameraName\":\"" + Uri.EscapeDataString(this.CameraName) + "\",";
        //    jsonString += "\"CameraDescribe\":\"" + Uri.EscapeDataString(this.CameraDescribe) + "\"";
        //    jsonString += "}";
        //    return jsonString;
        //}
    }
}
