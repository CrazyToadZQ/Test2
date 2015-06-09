using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [TableRelationShipAtrribute]
    public class TempExamUserMarkSheet
    {
        #region Model

        /// <summary>
		/// 临时考试用户评分表ID
        /// </summary>		
		private int _tempexamusermarksheetid;
        public virtual int TempExamUserMarkSheetID
        {
            get{ return _tempexamusermarksheetid; }
            set{ _tempexamusermarksheetid = value; }
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
		private Guid? _tempexamstationroomid;
        public virtual Guid? TempExamStationRoomID
        {
            get{ return _tempexamstationroomid; }
            set{ _tempexamstationroomid = value; }
        }        
		/// <summary>
		/// 考试用户ID
        /// </summary>		
		private Guid _tempexamuserid;
        public virtual Guid TempExamUserID
        {
            get{ return _tempexamuserid; }
            set{ _tempexamuserid = value; }
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
		/// 用户ID
        /// </summary>		
		private int? _userinfoid;
        public virtual int? UserInfoID
        {
            get{ return _userinfoid; }
            set{ _userinfoid = value; }
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
		private int? _tempexamusermarksheetnumber1;
        public virtual int? TempExamUserMarkSheetNumber1
        {
            get{ return _tempexamusermarksheetnumber1; }
            set{ _tempexamusermarksheetnumber1 = value; }
        }        
		/// <summary>
		/// 预留字段，整型
        /// </summary>		
		private int? _tempexamusermarksheetnumber2;
        public virtual int? TempExamUserMarkSheetNumber2
        {
            get{ return _tempexamusermarksheetnumber2; }
            set{ _tempexamusermarksheetnumber2 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamusermarksheetnumber3;
        public virtual decimal? TempExamUserMarkSheetNumber3
        {
            get{ return _tempexamusermarksheetnumber3; }
            set{ _tempexamusermarksheetnumber3 = value; }
        }        
		/// <summary>
		/// 预留字段，精确浮点型
        /// </summary>		
		private decimal? _tempexamusermarksheetnumber4;
        public virtual decimal? TempExamUserMarkSheetNumber4
        {
            get{ return _tempexamusermarksheetnumber4; }
            set{ _tempexamusermarksheetnumber4 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度1000
        /// </summary>		
		private string _tempexamusermarksheetstring1;
        public virtual string TempExamUserMarkSheetString1
        {
            get{ return _tempexamusermarksheetstring1; }
            set{ _tempexamusermarksheetstring1 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2000
        /// </summary>		
		private string _tempexamusermarksheetstring2;
        public virtual string TempExamUserMarkSheetString2
        {
            get{ return _tempexamusermarksheetstring2; }
            set{ _tempexamusermarksheetstring2 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度4000
        /// </summary>		
		private string _tempexamusermarksheetstring3;
        public virtual string TempExamUserMarkSheetString3
        {
            get{ return _tempexamusermarksheetstring3; }
            set{ _tempexamusermarksheetstring3 = value; }
        }        
		/// <summary>
		/// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
		private string _tempexamusermarksheetstring4;
        public virtual string TempExamUserMarkSheetString4
        {
            get{ return _tempexamusermarksheetstring4; }
            set{ _tempexamusermarksheetstring4 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamusermarksheetdatetime1;
        public virtual DateTime? TempExamUserMarkSheetDatetime1
        {
            get{ return _tempexamusermarksheetdatetime1; }
            set{ _tempexamusermarksheetdatetime1 = value; }
        }        
		/// <summary>
		/// 预留字段，日期时间
        /// </summary>		
		private DateTime? _tempexamusermarksheetdatetime2;
        public virtual DateTime? TempExamUserMarkSheetDatetime2
        {
            get{ return _tempexamusermarksheetdatetime2; }
            set{ _tempexamusermarksheetdatetime2 = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamUserMarkSheet()
            : this(default(Int32))
        { 
        
        }

        /// <summary>
        /// 仅使用Int32构造对象
        /// </summary>
        public TempExamUserMarkSheet(int tempExamUserMarkSheetID)
        {
            this.TempExamUserMarkSheetID = tempExamUserMarkSheetID;
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
                .Append("\"TempExamUserMarkSheetID\":\"").Append(this.TempExamUserMarkSheetID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID == null ? "" : this.TempExamTableID.ToString()).Append("\",")
                .Append("\"TempExamStationID\":\"").Append(this.TempExamStationID == null ? "" : this.TempExamStationID.ToString()).Append("\",")
                .Append("\"TempExamStationRoomID\":\"").Append(this.TempExamStationRoomID == null ? "" : this.TempExamStationRoomID.ToString()).Append("\",")
                .Append("\"TempExamUserID\":\"").Append(this.TempExamUserID).Append("\",")
                .Append("\"RoomID\":\"").Append(this.RoomID == null ? "" : this.RoomID.ToString()).Append("\",")
                .Append("\"UserInfoID\":\"").Append(this.UserInfoID == null ? "" : Convert.ToInt32(this.UserInfoID).ToString()).Append("\",")
                .Append("\"MarkSheetID\":\"").Append(this.MarkSheetID).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
