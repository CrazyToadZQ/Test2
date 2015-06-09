using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class ExamDevice
    {
        #region Model

        /// <summary>
        /// ExamDeviceID
        /// </summary>
        public virtual Guid ExamDeviceID
        {
            get;
            set;
        }
        /// <summary>
        /// E_ID
        /// </summary>
        public virtual Guid E_ID
        {
            get;
            set;
        }
        /// <summary>
        /// ES_ID
        /// </summary>
        public virtual Guid ES_ID
        {
            get;
            set;
        }
        /// <summary>
        /// ESR_ID
        /// </summary>
        public virtual Guid ESR_ID
        {
            get;
            set;
        }
        /// <summary>
        /// Room_ID
        /// </summary>
        public virtual int Room_ID
        {
            get;
            set;
        }
        /// <summary>
        /// D_ID
        /// </summary>
        public virtual int? D_ID
        {
            get;
            set;
        }
        /// <summary>
        /// DC_ID
        /// </summary>
        public virtual int DC_ID
        {
            get;
            set;
        }
        /// <summary>
        /// DM_ID
        /// </summary>
        public virtual string D_Manufacturer
        {
            get;
            set;
        }
        /// <summary>
        /// U_ID
        /// </summary>
        public virtual int U_ID
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceCreateTime
        /// </summary>
        public virtual DateTime ExamDeviceCreateTime
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceNumber1
        /// </summary>
        public virtual int? ExamDeviceNumber1
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceNumber2
        /// </summary>
        public virtual int? ExamDeviceNumber2
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceNumber3
        /// </summary>
        public virtual decimal? ExamDeviceNumber3
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceNumber4
        /// </summary>
        public virtual decimal? ExamDeviceNumber4
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceString1
        /// </summary>
        public virtual string ExamDeviceString1
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceString2
        /// </summary>
        public virtual string ExamDeviceString2
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceString3
        /// </summary>
        public virtual string ExamDeviceString3
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceString4
        /// </summary>
        public virtual string ExamDeviceString4
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceDateTime1
        /// </summary>
        public virtual DateTime? ExamDeviceDateTime1
        {
            get;
            set;
        }
        /// <summary>
        /// ExamDeviceDateTime2
        /// </summary>
        public virtual DateTime? ExamDeviceDateTime2
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
                .Append("\"ExamDeviceID\":\"").Append(Uri.EscapeDataString(this.ExamDeviceID.ToString())).Append("\",")
                .Append("\"E_ID\":\"").Append(Uri.EscapeDataString(this.E_ID.ToString())).Append("\",")
                .Append("\"ES_ID\":\"").Append(Uri.EscapeDataString(this.ES_ID.ToString())).Append("\",")
                .Append("\"ESR_ID\":\"").Append(Uri.EscapeDataString(this.ESR_ID.ToString())).Append("\",")
                .Append("\"Room_ID\":\"").Append(Uri.EscapeDataString(this.Room_ID.ToString())).Append("\",")
                .Append("\"D_ID\":\"").Append(Uri.EscapeDataString(this.D_ID == null ? "" : this.D_ID.ToString())).Append("\",")
                .Append("\"DC_ID\":\"").Append(Uri.EscapeDataString(this.DC_ID.ToString())).Append("\",")
                .Append("\"D_Manufacturer\":\"").Append(Uri.EscapeDataString(this.D_Manufacturer.ToString())).Append("\",")
                .Append("\"U_ID\":\"").Append(Uri.EscapeDataString(this.U_ID.ToString())).Append("\",")
                .Append("\"ExamDeviceCreateTime\":\"").Append(Uri.EscapeDataString(this.ExamDeviceCreateTime.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"ExamDeviceNumber1\":\"").Append(Uri.EscapeDataString(this.ExamDeviceNumber1 == null ? "" : this.ExamDeviceNumber1.ToString())).Append("\",")
                .Append("\"ExamDeviceNumber2\":\"").Append(Uri.EscapeDataString(this.ExamDeviceNumber2 == null ? "" : this.ExamDeviceNumber2.ToString())).Append("\",")
                .Append("\"ExamDeviceNumber3\":\"").Append(Uri.EscapeDataString(this.ExamDeviceNumber3 == null ? "" : this.ExamDeviceNumber3.ToString())).Append("\",")
                .Append("\"ExamDeviceNumber4\":\"").Append(Uri.EscapeDataString(this.ExamDeviceNumber4 == null ? "" : this.ExamDeviceNumber4.ToString())).Append("\",")
                .Append("\"ExamDeviceString1\":\"").Append(Uri.EscapeDataString(this.ExamDeviceString1 == null ? "" : this.ExamDeviceString1.ToString())).Append("\",")
                .Append("\"ExamDeviceString2\":\"").Append(Uri.EscapeDataString(this.ExamDeviceString2 == null ? "" : this.ExamDeviceString2.ToString())).Append("\",")
                .Append("\"ExamDeviceString3\":\"").Append(Uri.EscapeDataString(this.ExamDeviceString3 == null ? "" : this.ExamDeviceString3.ToString())).Append("\",")
                .Append("\"ExamDeviceString4\":\"").Append(Uri.EscapeDataString(this.ExamDeviceString4 == null ? "" : this.ExamDeviceString4.ToString())).Append("\",")
                .Append("\"ExamDeviceDateTime1\":\"").Append(Uri.EscapeDataString(this.ExamDeviceDateTime1 == null ? "" : Convert.ToDateTime(this.ExamDeviceDateTime1).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"ExamDeviceDateTime2\":\"").Append(Uri.EscapeDataString(this.ExamDeviceDateTime2 == null ? "" : Convert.ToDateTime(this.ExamDeviceDateTime2).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
