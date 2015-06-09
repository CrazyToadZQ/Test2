using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class TempExamLog
    {
        #region Model

        /// <summary>
        /// 考试日志信息ID
        /// </summary>		
        private int _tempexamlogid;
        public virtual int TempExamLogID
        {
            get { return _tempexamlogid; }
            set { _tempexamlogid = value; }
        }
        /// <summary>
        /// 临时考试信息ID
        /// </summary>		
        private Guid _tempexamtableid;
        public virtual Guid TempExamTableID
        {
            get { return _tempexamtableid; }
            set { _tempexamtableid = value; }
        }
        /// <summary>
        /// 日志类型，add-新建考试，modify-修改考试，reserve-预约类型操作（提交申请，申请未通过，申请已通过）
        /// </summary>		
        private string _logtype;
        public virtual string LogType
        {
            get { return _logtype; }
            set { _logtype = value; }
        }
        /// <summary>
        /// 日志内容
        /// </summary>		
        private string _logcontent;
        public virtual string LogContent
        {
            get { return _logcontent; }
            set { _logcontent = value; }
        }
        /// <summary>
        /// 日志日期时间
        /// </summary>		
        private DateTime _logdatetime;
        public virtual DateTime LogDatetime
        {
            get { return _logdatetime; }
            set { _logdatetime = value; }
        }
        /// <summary>
        /// 操作人用户ID
        /// </summary>		
        private int _loguserinfoid;
        public virtual int LogUserInfoID
        {
            get { return _loguserinfoid; }
            set { _loguserinfoid = value; }
        }
        /// <summary>
        /// 操作人用户姓名
        /// </summary>		
        private string _loguerinfotruename;
        public virtual string LogUerInfoTrueName
        {
            get { return _loguerinfotruename; }
            set { _loguerinfotruename = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamlognumber1;
        public virtual int? TempExamLogNumber1
        {
            get { return _tempexamlognumber1; }
            set { _tempexamlognumber1 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamlognumber2;
        public virtual int? TempExamLogNumber2
        {
            get { return _tempexamlognumber2; }
            set { _tempexamlognumber2 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamlognumber3;
        public virtual decimal? TempExamLogNumber3
        {
            get { return _tempexamlognumber3; }
            set { _tempexamlognumber3 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamlognumber4;
        public virtual decimal? TempExamLogNumber4
        {
            get { return _tempexamlognumber4; }
            set { _tempexamlognumber4 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度1000
        /// </summary>		
        private string _tempexamlogstring1;
        public virtual string TempExamLogString1
        {
            get { return _tempexamlogstring1; }
            set { _tempexamlogstring1 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2000
        /// </summary>		
        private string _tempexamlogstring2;
        public virtual string TempExamLogString2
        {
            get { return _tempexamlogstring2; }
            set { _tempexamlogstring2 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度4000
        /// </summary>		
        private string _tempexamlogstring3;
        public virtual string TempExamLogString3
        {
            get { return _tempexamlogstring3; }
            set { _tempexamlogstring3 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
        private string _tempexamlogstring4;
        public virtual string TempExamLogString4
        {
            get { return _tempexamlogstring4; }
            set { _tempexamlogstring4 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamlogdatetime1;
        public virtual DateTime? TempExamLogDatetime1
        {
            get { return _tempexamlogdatetime1; }
            set { _tempexamlogdatetime1 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamlogdatetime2;
        public virtual DateTime? TempExamLogDatetime2
        {
            get { return _tempexamlogdatetime2; }
            set { _tempexamlogdatetime2 = value; }
        }  

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamLog()
            : this(default(Int32))
        { 
        
        }

        /// <summary>
        /// 仅使用Int32构造对象
        /// </summary>
        public TempExamLog(int tempExamLogID)
        {
            this.TempExamLogID = tempExamLogID;
        }

        #endregion

        #region ToJsonString

        /// <summary>
        /// 返回对象的闭合Json字符串
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 根据参数返回对象的Json字符创
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"TempExamLogID\":\"").Append(this.TempExamLogID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID).Append("\",")
                .Append("\"LogType\":\"").Append(this.LogType).Append("\",")
                .Append("\"LogContent\":\"").Append(Uri.EscapeDataString(this.LogContent)).Append("\",")
                .Append("\"LogDatetime\":\"").Append(this.LogDatetime.ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"LogUserInfoID\":\"").Append(this.LogUserInfoID).Append("\",")
                .Append("\"LogUerInfoTrueName\":\"").Append(Uri.EscapeDataString(this.LogUerInfoTrueName)).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
