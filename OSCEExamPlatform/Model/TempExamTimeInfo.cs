using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class TempExamTimeInfo
    {

        #region Model

        /// <summary>
		/// 临时考试有效时间ID
        /// </summary>		
		private int _tempexamtimeinfoid;
        public virtual int TempExamTimeInfoID
        {
            get{ return _tempexamtimeinfoid; }
            set{ _tempexamtimeinfoid = value; }
        }        
		/// <summary>
		/// TempExamTableID
        /// </summary>		
		private Guid? _tempexamtableid;
        public virtual Guid? TempExamTableID
        {
            get{ return _tempexamtableid; }
            set{ _tempexamtableid = value; }
        }        
		/// <summary>
		/// 考试有效时间日期部分
        /// </summary>		
		private string _tempexamtimeinfodate;
        public virtual string TempExamTimeInfoDate
        {
            get{ return _tempexamtimeinfodate; }
            set{ _tempexamtimeinfodate = value; }
        }        
		/// <summary>
		/// 考试有效时间开始时间（HH:mm）
        /// </summary>		
		private string _tempexamtimeinfostarttime;
        public virtual string TempExamTimeInfoStartTime
        {
            get{ return _tempexamtimeinfostarttime; }
            set{ _tempexamtimeinfostarttime = value; }
        }        
		/// <summary>
		/// 考试有效时间结束时间（HH:mm）
        /// </summary>		
		private string _tempexamtimeinfoendtime;
        public virtual string TempExamTimeInfoEndTime
        {
            get{ return _tempexamtimeinfoendtime; }
            set{ _tempexamtimeinfoendtime = value; }
        }        
		/// <summary>
		/// 考试时间段可容纳考生数量
        /// </summary>		
		private int? _tempexamtimeinfostudentcount;
        public virtual int? TempExamTimeInfoStudentCount
        {
            get{ return _tempexamtimeinfostudentcount; }
            set{ _tempexamtimeinfostudentcount = value; }
        }        
		/// <summary>
		/// 预留字段，整型
        /// </summary>		
		private int? _tempexamtimeinfonumber1;
        public virtual int? TempExamTimeInfoNumber1
        {
            get{ return _tempexamtimeinfonumber1; }
            set{ _tempexamtimeinfonumber1 = value; }
        }        
		/// <summary>
		/// 预留字段，整型
        /// </summary>		
		private int? _tempexamtimeinfonumber2;
        public virtual int? TempExamTimeInfoNumber2
        {
            get{ return _tempexamtimeinfonumber2; }
            set{ _tempexamtimeinfonumber2 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamtimeinfonumber3;
        public virtual decimal? TempExamTimeInfoNumber3
        {
            get{ return _tempexamtimeinfonumber3; }
            set{ _tempexamtimeinfonumber3 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamtimeinfonumber4;
        public virtual decimal? TempExamTimeInfoNumber4
        {
            get{ return _tempexamtimeinfonumber4; }
            set{ _tempexamtimeinfonumber4 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度1000
        /// </summary>		
		private string _tempexamtimeinfostring1;
        public virtual string TempExamTimeInfoString1
        {
            get{ return _tempexamtimeinfostring1; }
            set{ _tempexamtimeinfostring1 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2000
        /// </summary>		
		private string _tempexamtimeinfostring2;
        public virtual string TempExamTimeInfoString2
        {
            get{ return _tempexamtimeinfostring2; }
            set{ _tempexamtimeinfostring2 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度4000
        /// </summary>		
		private string _tempexamtimeinfostring3;
        public virtual string TempExamTimeInfoString3
        {
            get{ return _tempexamtimeinfostring3; }
            set{ _tempexamtimeinfostring3 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
		private string _tempexamtimeinfostring4;
        public virtual string TempExamTimeInfoString4
        {
            get{ return _tempexamtimeinfostring4; }
            set{ _tempexamtimeinfostring4 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamtimeinfodatetime1;
        public virtual DateTime? TempExamTimeInfoDatetime1
        {
            get{ return _tempexamtimeinfodatetime1; }
            set{ _tempexamtimeinfodatetime1 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamtimeinfodatetime2;
        public virtual DateTime? TempExamTimeInfoDatetime2
        {
            get{ return _tempexamtimeinfodatetime2; }
            set{ _tempexamtimeinfodatetime2 = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamTimeInfo()
            : this(default(Int32))
        { 
        
        }

        /// <summary>
        /// 仅使用Int32构造对象
        /// </summary>
        public TempExamTimeInfo(int tempExamTimeInfoID)
        {
            this.TempExamTimeInfoID = tempExamTimeInfoID;
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
                .Append("\"TempExamTimeInfoID\":\"").Append(this.TempExamTimeInfoID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID == null ? "" : this.TempExamTableID.ToString()).Append("\",")
                .Append("\"TempExamTimeInfoDate\":\"").Append(this.TempExamTimeInfoDate == null ? "" : this.TempExamTimeInfoDate).Append("\",")
                .Append("\"TempExamTimeInfoStartTime\":\"").Append(this.TempExamTimeInfoStartTime).Append("\",")
                .Append("\"TempExamTimeInfoEndTime\":\"").Append(this.TempExamTimeInfoEndTime).Append("\",")
                .Append("\"TempExamTimeInfoStudentCount\":\"").Append(this.TempExamTimeInfoStudentCount == null ? "" : Convert.ToInt32(this.TempExamTimeInfoStudentCount).ToString()).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
