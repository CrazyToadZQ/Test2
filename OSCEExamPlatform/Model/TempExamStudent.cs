using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class TempExamStudent
    {
        #region Model

        /// <summary>
		/// 临时考试学生ID
        /// </summary>		
		private Guid _tempexamstudentid;
        public virtual Guid TempExamStudentID
        {
            get{ return _tempexamstudentid; }
            set{ _tempexamstudentid = value; }
        }        
		/// <summary>
		/// 考试ID
        /// </summary>		
		private Guid _tempexamtableid;
        public virtual Guid TempExamTableID
        {
            get{ return _tempexamtableid; }
            set{ _tempexamtableid = value; }
        }        
		/// <summary>
		/// 学生用户ID
        /// </summary>		
		private int _userinfoid;
        public virtual int UserInfoID
        {
            get{ return _userinfoid; }
            set{ _userinfoid = value; }
        }        
		/// <summary>
		/// 学生考号，从1开始
        /// </summary>		
		private int _examnumber;
        public virtual int ExamNumber
        {
            get{ return _examnumber; }
            set{ _examnumber = value; }
        }        
		/// <summary>
		/// 预留字段，整型
        /// </summary>		
		private int? _tempexamstudentnumber1;
        public virtual int? TempExamStudentNumber1
        {
            get{ return _tempexamstudentnumber1; }
            set{ _tempexamstudentnumber1 = value; }
        }        
		/// <summary>
		/// 预留字段，整型
        /// </summary>		
		private int? _tempexamstudentnumber2;
        public virtual int? TempExamStudentNumber2
        {
            get{ return _tempexamstudentnumber2; }
            set{ _tempexamstudentnumber2 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamstudentnumber3;
        public virtual decimal? TempExamStudentNumber3
        {
            get{ return _tempexamstudentnumber3; }
            set{ _tempexamstudentnumber3 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamstudentnumber4;
        public virtual decimal? TempExamStudentNumber4
        {
            get{ return _tempexamstudentnumber4; }
            set{ _tempexamstudentnumber4 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度1000
        /// </summary>		
		private string _tempexamstudentstring1;
        public virtual string TempExamStudentString1
        {
            get{ return _tempexamstudentstring1; }
            set{ _tempexamstudentstring1 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2000
        /// </summary>		
		private string _tempexamstudentstring2;
        public virtual string TempExamStudentString2
        {
            get{ return _tempexamstudentstring2; }
            set{ _tempexamstudentstring2 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度4000
        /// </summary>		
		private string _tempexamstudentstring3;
        public virtual string TempExamStudentString3
        {
            get{ return _tempexamstudentstring3; }
            set{ _tempexamstudentstring3 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
		private string _tempexamstudentstring4;
        public virtual string TempExamStudentString4
        {
            get{ return _tempexamstudentstring4; }
            set{ _tempexamstudentstring4 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamstudentdatetime1;
        public virtual DateTime? TempExamStudentDatetime1
        {
            get{ return _tempexamstudentdatetime1; }
            set{ _tempexamstudentdatetime1 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamstudentdatetime2;
        public virtual DateTime? TempExamStudentDatetime2
        {
            get{ return _tempexamstudentdatetime2; }
            set{ _tempexamstudentdatetime2 = value; }
        }     

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamStudent()
            : this(default(Guid))
        { 
        
        }

        /// <summary>
        /// 仅使用Guid构造对象
        /// </summary>
        public TempExamStudent(Guid tempExamStudentID)
        {
            this.TempExamStudentID = tempExamStudentID;
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
                .Append("\"TempExamStudentID\":\"").Append(this.TempExamStudentID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID).Append("\",")
                .Append("\"UserInfoID\":\"").Append(this.UserInfoID).Append("\",")
                .Append("\"ExamNumber\":\"").Append(this.ExamNumber).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
