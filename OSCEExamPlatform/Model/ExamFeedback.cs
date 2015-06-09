using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class ExamFeedback
    {
        #region Model

        /// <summary>
        /// ExamFeedback表的主键
        /// </summary>
        public virtual int ExamFeedbackID
        {
            get;
            set;
        }
        /// <summary>
        /// UserInfo表的ID
        /// </summary>
        public virtual int UserInfoID
        {
            get;
            set;
        }
        /// <summary>
        /// 当前登录者的真实姓名（UserInfo表中的UserTrueName）
        /// </summary>
        public virtual string UserTrueName
        {
            get;
            set;
        }
        /// <summary>
        /// 考试ID（ExamTable表中的E_ID）
        /// </summary>
        public virtual Guid ExamID
        {
            get;
            set;
        }
        /// <summary>
        /// 考试名称
        /// </summary>
        public virtual string ExamName
        {
            get;
            set;
        }
        /// <summary>
        /// 当前登录者的角色（学生，教师（督考官），评委，SP）
        /// </summary>
        public virtual string RoleName
        {
            get;
            set;
        }
        /// <summary>
        /// 考试反馈的具体内容
        /// </summary>
        public virtual string ExamFeedbackContent
        {
            get;
            set;
        }
        /// <summary>
        /// 考试反馈日期
        /// </summary>
        public virtual DateTime ExamFeedbackDate
        {
            get;
            set;
        }
        /// <summary>
        /// 预留字段
        /// </summary>
        public virtual int? ExamFeedbackNumber1
        {
            get;
            set;
        }
        /// <summary>
        /// 预留字段
        /// </summary>
        public virtual decimal? ExamFeedbackNumber2
        {
            get;
            set;
        }
        /// <summary>
        /// 预留字段
        /// </summary>
        public virtual string ExamFeedbackString1
        {
            get;
            set;
        }
        /// <summary>
        /// 预留字段
        /// </summary>
        public virtual string ExamFeedbackString2
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
                .Append("\"ExamFeedbackID\":\"").Append(Uri.EscapeDataString(this.ExamFeedbackID.ToString())).Append("\",")
                .Append("\"UserInfoID\":\"").Append(Uri.EscapeDataString(this.UserInfoID.ToString())).Append("\",")
                .Append("\"UserTrueName\":\"").Append(Uri.EscapeDataString(this.UserTrueName.ToString())).Append("\",")
                .Append("\"ExamID\":\"").Append(Uri.EscapeDataString(this.ExamID.ToString())).Append("\",")
                .Append("\"ExamName\":\"").Append(Uri.EscapeDataString(this.ExamName.ToString())).Append("\",")
                .Append("\"RoleName\":\"").Append(Uri.EscapeDataString(this.RoleName.ToString())).Append("\",")
                .Append("\"ExamFeedbackContent\":\"").Append(Uri.EscapeDataString(this.ExamFeedbackContent.ToString())).Append("\",")
                .Append("\"ExamFeedbackDate\":\"").Append(Uri.EscapeDataString(this.ExamFeedbackDate.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"ExamFeedbackNumber1\":\"").Append(Uri.EscapeDataString(this.ExamFeedbackNumber1 == null ? "" : this.ExamFeedbackNumber1.ToString())).Append("\",")
                .Append("\"ExamFeedbackNumber2\":\"").Append(Uri.EscapeDataString(this.ExamFeedbackNumber2 == null ? "" : this.ExamFeedbackNumber2.ToString())).Append("\",")
                .Append("\"ExamFeedbackString1\":\"").Append(Uri.EscapeDataString(this.ExamFeedbackString1 == null ? "" : this.ExamFeedbackString1.ToString())).Append("\",")
                .Append("\"ExamFeedbackString2\":\"").Append(Uri.EscapeDataString(this.ExamFeedbackString2 == null ? "" : this.ExamFeedbackString2.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion

    }
}
