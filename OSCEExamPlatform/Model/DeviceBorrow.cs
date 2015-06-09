using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    //设备外借表
    public class DeviceBorrow
    {

        /// <summary>
        /// 设备外借记录ID
        /// </summary>
        public virtual int DB_ID
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
        /// 设备外借开始时间
        /// </summary>
        public virtual DateTime DB_StartTime
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借结束时间
        /// </summary>
        public virtual DateTime? DB_EndTime
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借时长
        /// </summary>
        public virtual int? DB_TimeSpan
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借原因
        /// </summary>
        public virtual string DB_Reason
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借联系人单位
        /// </summary>
        public virtual string DB_ContactPersonCompany
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借联系人
        /// </summary>
        public virtual string DB_ContactPerson
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借联系人电话
        /// </summary>
        public virtual string DB_ContactPersonPhone
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借归还状态
        /// </summary>
        public virtual string DB_ReturnState
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借操作人ID
        /// </summary>
        public virtual int? DB_OperatePersonID
        {
            get;
            set;
        }
        /// <summary>
        /// 设备外借操作人姓名
        /// </summary>
        public virtual string DB_OperatePersonName
        {
            get;
            set;
        }
        /// <summary>
        /// DB_Number1
        /// </summary>
        public virtual int? DB_Number1
        {
            get;
            set;
        }
        /// <summary>
        /// DB_Number2
        /// </summary>
        public virtual int? DB_Number2
        {
            get;
            set;
        }
        /// <summary>
        /// DB_Number3
        /// </summary>
        public virtual int? DB_Number3
        {
            get;
            set;
        }
        /// <summary>
        /// DB_Number4
        /// </summary>
        public virtual int? DB_Number4
        {
            get;
            set;
        }
        /// <summary>
        /// DB_String1
        /// </summary>
        public virtual string DB_String1
        {
            get;
            set;
        }
        /// <summary>
        /// DB_String2
        /// </summary>
        public virtual string DB_String2
        {
            get;
            set;
        }
        /// <summary>
        /// DB_String3
        /// </summary>
        public virtual string DB_String3
        {
            get;
            set;
        }
        /// <summary>
        /// DB_String4
        /// </summary>
        public virtual string DB_String4
        {
            get;
            set;
        }
        /// <summary>
        /// DB_String5
        /// </summary>
        public virtual string DB_String5
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
                .Append("\"DB_ID\":\"").Append(Uri.EscapeDataString(this.DB_ID.ToString())).Append("\",")
                .Append("\"D_ID\":\"").Append(Uri.EscapeDataString(this.D_ID.ToString())).Append("\",")
                .Append("\"DB_StartTime\":\"").Append(Uri.EscapeDataString(this.DB_StartTime.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"DB_EndTime\":\"").Append(Uri.EscapeDataString(this.DB_EndTime == null ? "" : Convert.ToDateTime(this.DB_EndTime).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"DB_TimeSpan\":\"").Append(Uri.EscapeDataString(this.DB_TimeSpan == null ? "" : this.DB_TimeSpan.ToString())).Append("\",")
                .Append("\"DB_Reason\":\"").Append(Uri.EscapeDataString(this.DB_Reason == null ? "" : this.DB_Reason.ToString())).Append("\",")
                .Append("\"DB_ContactPersonCompany\":\"").Append(Uri.EscapeDataString(this.DB_ContactPersonCompany == null ? "" : this.DB_ContactPersonCompany.ToString())).Append("\",")
                .Append("\"DB_ContactPerson\":\"").Append(Uri.EscapeDataString(this.DB_ContactPerson == null ? "" : this.DB_ContactPerson.ToString())).Append("\",")
                .Append("\"DB_ContactPersonPhone\":\"").Append(Uri.EscapeDataString(this.DB_ContactPersonPhone == null ? "" : this.DB_ContactPersonPhone.ToString())).Append("\",")
                .Append("\"DB_ReturnState\":\"").Append(Uri.EscapeDataString(this.DB_ReturnState == null ? "" : this.DB_ReturnState.ToString())).Append("\",")
                .Append("\"DB_OperatePersonID\":\"").Append(Uri.EscapeDataString(this.DB_OperatePersonID == null ? "" : this.DB_OperatePersonID.ToString())).Append("\",")
                .Append("\"DB_OperatePersonName\":\"").Append(Uri.EscapeDataString(this.DB_OperatePersonName == null ? "" : this.DB_OperatePersonName.ToString())).Append("\",")
                .Append("\"DB_Number1\":\"").Append(Uri.EscapeDataString(this.DB_Number1 == null ? "" : this.DB_Number1.ToString())).Append("\",")
                .Append("\"DB_Number2\":\"").Append(Uri.EscapeDataString(this.DB_Number2 == null ? "" : this.DB_Number2.ToString())).Append("\",")
                .Append("\"DB_Number3\":\"").Append(Uri.EscapeDataString(this.DB_Number3 == null ? "" : this.DB_Number3.ToString())).Append("\",")
                .Append("\"DB_Number4\":\"").Append(Uri.EscapeDataString(this.DB_Number4 == null ? "" : this.DB_Number4.ToString())).Append("\",")
                .Append("\"DB_String1\":\"").Append(Uri.EscapeDataString(this.DB_String1 == null ? "" : this.DB_String1.ToString())).Append("\",")
                .Append("\"DB_String2\":\"").Append(Uri.EscapeDataString(this.DB_String2 == null ? "" : this.DB_String2.ToString())).Append("\",")
                .Append("\"DB_String3\":\"").Append(Uri.EscapeDataString(this.DB_String3 == null ? "" : this.DB_String3.ToString())).Append("\",")
                .Append("\"DB_String4\":\"").Append(Uri.EscapeDataString(this.DB_String4 == null ? "" : this.DB_String4.ToString())).Append("\",")
                .Append("\"DB_String5\":\"").Append(Uri.EscapeDataString(this.DB_String5 == null ? "" : this.DB_String5.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion

    }
}
