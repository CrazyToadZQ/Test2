using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    //设备维修表
    public class DeviceMaintain
    {

        /// <summary>
        /// 设备维修记录ID
        /// </summary>
        public virtual int DM_ID
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
        /// 设备维修开始时间
        /// </summary>
        public virtual DateTime DM_StartTime
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修结束时间
        /// </summary>
        public virtual DateTime? DM_EndTime
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修时长
        /// </summary>
        public virtual int? DM_TimeSpan
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修原因
        /// </summary>
        public virtual string DM_Reason
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修结果
        /// </summary>
        public virtual string DM_Result
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修费用
        /// </summary>
        public virtual string DM_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修内容
        /// </summary>
        public virtual string DM_Content
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修联系人单位
        /// </summary>
        public virtual string DM_ContactPersonCompany
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修联系人
        /// </summary>
        public virtual string DM_ContactPerson
        {
            get;
            set;
        }
        /// <summary>
        /// 设备维修联系人电话
        /// </summary>
        public virtual string DM_ContactPersonPhone
        {
            get;
            set;
        }
        /// <summary>
        /// DM_Number1
        /// </summary>
        public virtual int? DM_Number1
        {
            get;
            set;
        }
        /// <summary>
        /// DM_Number2
        /// </summary>
        public virtual int? DM_Number2
        {
            get;
            set;
        }
        /// <summary>
        /// DM_Number3
        /// </summary>
        public virtual int? DM_Number3
        {
            get;
            set;
        }
        /// <summary>
        /// DM_Number4
        /// </summary>
        public virtual int? DM_Number4
        {
            get;
            set;
        }
        /// <summary>
        /// DM_String1
        /// </summary>
        public virtual string DM_String1
        {
            get;
            set;
        }
        /// <summary>
        /// DM_String2
        /// </summary>
        public virtual string DM_String2
        {
            get;
            set;
        }
        /// <summary>
        /// DM_String3
        /// </summary>
        public virtual string DM_String3
        {
            get;
            set;
        }
        /// <summary>
        /// DM_String4
        /// </summary>
        public virtual string DM_String4
        {
            get;
            set;
        }
        /// <summary>
        /// DM_String5
        /// </summary>
        public virtual string DM_String5
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
                .Append("\"DM_ID\":\"").Append(Uri.EscapeDataString(this.DM_ID.ToString())).Append("\",")
                .Append("\"D_ID\":\"").Append(Uri.EscapeDataString(this.D_ID.ToString())).Append("\",")
                .Append("\"DM_StartTime\":\"").Append(Uri.EscapeDataString(this.DM_StartTime.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"DM_EndTime\":\"").Append(Uri.EscapeDataString(this.DM_EndTime == null ? "" : Convert.ToDateTime(this.DM_EndTime).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"DM_TimeSpan\":\"").Append(Uri.EscapeDataString(this.DM_TimeSpan == null ? "" : this.DM_TimeSpan.ToString())).Append("\",")
                .Append("\"DM_Reason\":\"").Append(Uri.EscapeDataString(this.DM_Reason == null ? "" : this.DM_Reason.ToString())).Append("\",")
                .Append("\"DM_Result\":\"").Append(Uri.EscapeDataString(this.DM_Result == null ? "" : this.DM_Result.ToString())).Append("\",")
                .Append("\"DM_Fee\":\"").Append(Uri.EscapeDataString(this.DM_Fee == null ? "" : this.DM_Fee.ToString())).Append("\",")
                .Append("\"DM_Content\":\"").Append(Uri.EscapeDataString(this.DM_Content == null ? "" : this.DM_Content.ToString())).Append("\",")
                .Append("\"DM_ContactPersonCompany\":\"").Append(Uri.EscapeDataString(this.DM_ContactPersonCompany == null ? "" : this.DM_ContactPersonCompany.ToString())).Append("\",")
                .Append("\"DM_ContactPerson\":\"").Append(Uri.EscapeDataString(this.DM_ContactPerson == null ? "" : this.DM_ContactPerson.ToString())).Append("\",")
                .Append("\"DM_ContactPersonPhone\":\"").Append(Uri.EscapeDataString(this.DM_ContactPersonPhone == null ? "" : this.DM_ContactPersonPhone.ToString())).Append("\",")
                .Append("\"DM_Number1\":\"").Append(Uri.EscapeDataString(this.DM_Number1 == null ? "" : this.DM_Number1.ToString())).Append("\",")
                .Append("\"DM_Number2\":\"").Append(Uri.EscapeDataString(this.DM_Number2 == null ? "" : this.DM_Number2.ToString())).Append("\",")
                .Append("\"DM_Number3\":\"").Append(Uri.EscapeDataString(this.DM_Number3 == null ? "" : this.DM_Number3.ToString())).Append("\",")
                .Append("\"DM_Number4\":\"").Append(Uri.EscapeDataString(this.DM_Number4 == null ? "" : this.DM_Number4.ToString())).Append("\",")
                .Append("\"DM_String1\":\"").Append(Uri.EscapeDataString(this.DM_String1 == null ? "" : this.DM_String1.ToString())).Append("\",")
                .Append("\"DM_String2\":\"").Append(Uri.EscapeDataString(this.DM_String2 == null ? "" : this.DM_String2.ToString())).Append("\",")
                .Append("\"DM_String3\":\"").Append(Uri.EscapeDataString(this.DM_String3 == null ? "" : this.DM_String3.ToString())).Append("\",")
                .Append("\"DM_String4\":\"").Append(Uri.EscapeDataString(this.DM_String4 == null ? "" : this.DM_String4.ToString())).Append("\",")
                .Append("\"DM_String5\":\"").Append(Uri.EscapeDataString(this.DM_String5 == null ? "" : this.DM_String5.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion

    }
}
