using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    //设备异常表
    public class DeviceException
    {

        /// <summary>
        /// 设备异常记录ID
        /// </summary>
        public virtual int DE_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 设备ID
        /// </summary>
        public virtual int D_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 设备异常开始时间
        /// </summary>
        public virtual DateTime DE_StartTime
        {
            get;
            set;
        }
        /// <summary>
        /// 设备异常结束时间
        /// </summary>
        public virtual DateTime? DE_EndTime
        {
            get;
            set;
        }
        /// <summary>
        /// 设备异常时长
        /// </summary>
        public virtual int? DE_TimeSpan
        {
            get;
            set;
        }
        /// <summary>
        /// 设备异常描述
        /// </summary>
        public virtual string DE_Description
        {
            get;
            set;
        }
        /// <summary>
        /// DE_Number1
        /// </summary>
        public virtual int? DE_Number1
        {
            get;
            set;
        }
        /// <summary>
        /// DE_Number2
        /// </summary>
        public virtual int? DE_Number2
        {
            get;
            set;
        }
        /// <summary>
        /// DE_Number3
        /// </summary>
        public virtual int? DE_Number3
        {
            get;
            set;
        }
        /// <summary>
        /// DE_Number4
        /// </summary>
        public virtual int? DE_Number4
        {
            get;
            set;
        }
        /// <summary>
        /// DE_String1
        /// </summary>
        public virtual string DE_String1
        {
            get;
            set;
        }
        /// <summary>
        /// DE_String2
        /// </summary>
        public virtual string DE_String2
        {
            get;
            set;
        }
        /// <summary>
        /// DE_String3
        /// </summary>
        public virtual string DE_String3
        {
            get;
            set;
        }
        /// <summary>
        /// DE_String4
        /// </summary>
        public virtual string DE_String4
        {
            get;
            set;
        }
        /// <summary>
        /// DE_String5
        /// </summary>
        public virtual string DE_String5
        {
            get;
            set;
        }

        /// <summary>
        /// 异常解决办法
        /// </summary>
        public virtual string DE_Solve_Method
        {
            get;
            set;
        }

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
                .Append("\"DE_ID\":\"").Append(Uri.EscapeDataString(this.DE_ID.ToString())).Append("\",")
                .Append("\"D_ID\":\"").Append(Uri.EscapeDataString(this.D_ID.ToString())).Append("\",")
                .Append("\"DE_StartTime\":\"").Append(Uri.EscapeDataString(this.DE_StartTime.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"DE_EndTime\":\"").Append(Uri.EscapeDataString(this.DE_EndTime == null ? "" : Convert.ToDateTime(this.DE_EndTime).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"DE_TimeSpan\":\"").Append(Uri.EscapeDataString(this.DE_TimeSpan == null ? "" : this.DE_TimeSpan.ToString())).Append("\",")
                .Append("\"DE_Description\":\"").Append(Uri.EscapeDataString(this.DE_Description == null ? "" : this.DE_Description.ToString())).Append("\",")
                .Append("\"DE_Solve_Method\":\"").Append(Uri.EscapeDataString(this.DE_Solve_Method == null ? "" : this.DE_Solve_Method.ToString())).Append("\",")
                .Append("\"DE_Number1\":\"").Append(Uri.EscapeDataString(this.DE_Number1 == null ? "" : this.DE_Number1.ToString())).Append("\",")
                .Append("\"DE_Number2\":\"").Append(Uri.EscapeDataString(this.DE_Number2 == null ? "" : this.DE_Number2.ToString())).Append("\",")
                .Append("\"DE_Number3\":\"").Append(Uri.EscapeDataString(this.DE_Number3 == null ? "" : this.DE_Number3.ToString())).Append("\",")
                .Append("\"DE_Number4\":\"").Append(Uri.EscapeDataString(this.DE_Number4 == null ? "" : this.DE_Number4.ToString())).Append("\",")
                .Append("\"DE_String1\":\"").Append(Uri.EscapeDataString(this.DE_String1 == null ? "" : this.DE_String1.ToString())).Append("\",")
                .Append("\"DE_String2\":\"").Append(Uri.EscapeDataString(this.DE_String2 == null ? "" : this.DE_String2.ToString())).Append("\",")
                .Append("\"DE_String3\":\"").Append(Uri.EscapeDataString(this.DE_String3 == null ? "" : this.DE_String3.ToString())).Append("\",")
                .Append("\"DE_String4\":\"").Append(Uri.EscapeDataString(this.DE_String4 == null ? "" : this.DE_String4.ToString())).Append("\",")
                .Append("\"DE_String5\":\"").Append(Uri.EscapeDataString(this.DE_String5 == null ? "" : this.DE_String5.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion

    }
}
