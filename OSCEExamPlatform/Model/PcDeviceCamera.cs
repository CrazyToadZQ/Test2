using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    //Pc设备摄像头关系表
    public class PcDeviceCamera
    {
        #region Model

        /// <summary>
        /// 主键
        /// </summary>
        public virtual int PDC_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 系统设备ID
        /// </summary>
        public virtual Guid SD_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 摄像头ID
        /// </summary>
        public virtual int Camera_ID
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_Number1
        /// </summary>
        public virtual int? Pc_Number1
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_Number2
        /// </summary>
        public virtual int? Pc_Number2
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_Number3
        /// </summary>
        public virtual int? Pc_Number3
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_Number4
        /// </summary>
        public virtual int? Pc_Number4
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_String1
        /// </summary>
        public virtual string Pc_String1
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_String2
        /// </summary>
        public virtual string Pc_String2
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_String3
        /// </summary>
        public virtual string Pc_String3
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_String4
        /// </summary>
        public virtual string Pc_String4
        {
            get;
            set;
        }
        /// <summary>
        /// Pc_String5
        /// </summary>
        public virtual string Pc_String5
        {
            get;
            set;
        }

        #endregion

        #region ToJsonString

        /// <summary>
        /// 生成闭合结构的json结构
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 生成json结构
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new System.Text.StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"PDC_ID\":\"").Append(Uri.EscapeDataString(this.PDC_ID.ToString())).Append("\",")
                .Append("\"SD_ID\":\"").Append(Uri.EscapeDataString(this.SD_ID.ToString())).Append("\",")
                .Append("\"Camera_ID\":\"").Append(Uri.EscapeDataString(this.Camera_ID.ToString())).Append("\",")
                .Append("\"Pc_Number1\":\"").Append(Uri.EscapeDataString(this.Pc_Number1 == null ? "" : this.Pc_Number1.ToString())).Append("\",")
                .Append("\"Pc_Number2\":\"").Append(Uri.EscapeDataString(this.Pc_Number2 == null ? "" : this.Pc_Number2.ToString())).Append("\",")
                .Append("\"Pc_Number3\":\"").Append(Uri.EscapeDataString(this.Pc_Number3 == null ? "" : this.Pc_Number3.ToString())).Append("\",")
                .Append("\"Pc_Number4\":\"").Append(Uri.EscapeDataString(this.Pc_Number4 == null ? "" : this.Pc_Number4.ToString())).Append("\",")
                .Append("\"Pc_String1\":\"").Append(Uri.EscapeDataString(this.Pc_String1 == null ? "" : this.Pc_String1.ToString())).Append("\",")
                .Append("\"Pc_String2\":\"").Append(Uri.EscapeDataString(this.Pc_String2 == null ? "" : this.Pc_String2.ToString())).Append("\",")
                .Append("\"Pc_String3\":\"").Append(Uri.EscapeDataString(this.Pc_String3 == null ? "" : this.Pc_String3.ToString())).Append("\",")
                .Append("\"Pc_String4\":\"").Append(Uri.EscapeDataString(this.Pc_String4 == null ? "" : this.Pc_String4.ToString())).Append("\",")
                .Append("\"Pc_String5\":\"").Append(Uri.EscapeDataString(this.Pc_String5 == null ? "" : this.Pc_String5.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
