using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class TempExamIllnessCase
    {
        #region Model

        /// <summary>
		/// 临时考试病例ID
        /// </summary>		
		private int _tempexamillnesscaseid;
        public virtual int TempExamIllnessCaseID
        {
            get{ return _tempexamillnesscaseid; }
            set{ _tempexamillnesscaseid = value; }
        }        
		/// <summary>
		/// 考试ID
        /// </summary>		
		private Guid? _tempexamtableid;
        public virtual Guid? TempExamTableID
        {
            get{ return _tempexamtableid; }
            set{ _tempexamtableid = value; }
        }        
		/// <summary>
		/// 考站ID
        /// </summary>		
		private Guid? _tempexamstationid;
        public virtual Guid? TempExamStationID
        {
            get{ return _tempexamstationid; }
            set{ _tempexamstationid = value; }
        }        
		/// <summary>
		/// 考站房间ID
        /// </summary>		
		private Guid _tempexamstationroomid;
        public virtual Guid TempExamStationRoomID
        {
            get{ return _tempexamstationroomid; }
            set{ _tempexamstationroomid = value; }
        }        
		/// <summary>
		/// 房间ID
        /// </summary>		
		private int? _roomid;
        public virtual int? RoomID
        {
            get{ return _roomid; }
            set{ _roomid = value; }
        }        
		/// <summary>
		/// 病例ID
        /// </summary>		
		private int _illnesscaseid;
        public virtual int IllnessCaseID
        {
            get{ return _illnesscaseid; }
            set{ _illnesscaseid = value; }
        }        
		/// <summary>
		/// 病例脚本ID
        /// </summary>		
		private int _illnesscasescriptid;
        public virtual int IllnessCaseScriptID
        {
            get{ return _illnesscasescriptid; }
            set{ _illnesscasescriptid = value; }
        }        
		/// <summary>
		/// 评分表ID
        /// </summary>		
		private int _marksheetid;
        public virtual int MarkSheetID
        {
            get{ return _marksheetid; }
            set{ _marksheetid = value; }
        }        
		/// <summary>
		/// 预留字段，整型
        /// </summary>		
		private int? _tempexamillnesscasenumber1;
        public virtual int? TempExamIllnessCaseNumber1
        {
            get{ return _tempexamillnesscasenumber1; }
            set{ _tempexamillnesscasenumber1 = value; }
        }        
		/// <summary>
		/// 预留字段，整型
        /// </summary>		
		private int? _tempexamillnesscasenumber2;
        public virtual int? TempExamIllnessCaseNumber2
        {
            get{ return _tempexamillnesscasenumber2; }
            set{ _tempexamillnesscasenumber2 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamillnesscasenumber3;
        public virtual decimal? TempExamIllnessCaseNumber3
        {
            get{ return _tempexamillnesscasenumber3; }
            set{ _tempexamillnesscasenumber3 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamillnesscasenumber4;
        public virtual decimal? TempExamIllnessCaseNumber4
        {
            get{ return _tempexamillnesscasenumber4; }
            set{ _tempexamillnesscasenumber4 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度1000
        /// </summary>		
		private string _tempexamillnesscasestring1;
        public virtual string TempExamIllnessCaseString1
        {
            get{ return _tempexamillnesscasestring1; }
            set{ _tempexamillnesscasestring1 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2000
        /// </summary>		
		private string _tempexamillnesscasestring2;
        public virtual string TempExamIllnessCaseString2
        {
            get{ return _tempexamillnesscasestring2; }
            set{ _tempexamillnesscasestring2 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度4000
        /// </summary>		
		private string _tempexamillnesscasestring3;
        public virtual string TempExamIllnessCaseString3
        {
            get{ return _tempexamillnesscasestring3; }
            set{ _tempexamillnesscasestring3 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
		private string _tempexamillnesscasestring4;
        public virtual string TempExamIllnessCaseString4
        {
            get{ return _tempexamillnesscasestring4; }
            set{ _tempexamillnesscasestring4 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamillnesscasedatetime1;
        public virtual DateTime? TempExamIllnessCaseDatetime1
        {
            get{ return _tempexamillnesscasedatetime1; }
            set{ _tempexamillnesscasedatetime1 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamillnesscasedatetime2;
        public virtual DateTime? TempExamIllnessCaseDatetime2
        {
            get{ return _tempexamillnesscasedatetime2; }
            set{ _tempexamillnesscasedatetime2 = value; }
        }   

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamIllnessCase()
            : this(default(Int32))
        { 
        
        }

        /// <summary>
        /// 仅使用Int32构造对象
        /// </summary>
        public TempExamIllnessCase(int tempExamIllnessCaseID)
        {
            this.TempExamIllnessCaseID = tempExamIllnessCaseID;
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
                .Append("\"TempExamIllnessCaseID\":\"").Append(this.TempExamIllnessCaseID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID == null ? "" : this.TempExamTableID.ToString()).Append("\",")
                .Append("\"TempExamStationID\":\"").Append(this.TempExamStationID == null ? "" : this.TempExamStationID.ToString()).Append("\",")
                .Append("\"TempExamStationRoomID\":\"").Append(this.TempExamStationRoomID).Append("\",")
                .Append("\"RoomID\":\"").Append(this.RoomID == null ? "" : Convert.ToInt32(this.RoomID).ToString()).Append("\",")
                .Append("\"IllnessCaseID\":\"").Append(this.IllnessCaseID).Append("\",")
                .Append("\"IllnessCaseScriptID\":\"").Append(this.IllnessCaseScriptID).Append("\",")
                .Append("\"MarkSheetID\":\"").Append(this.MarkSheetID).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
