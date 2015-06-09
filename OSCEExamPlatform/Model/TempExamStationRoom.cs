using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [TableRelationShipAtrribute]
    public class TempExamStationRoom
    {
        #region Model

        /// <summary>
        /// TempExamStationRoomID
        /// </summary>		
        private Guid _tempexamstationroomid;
        public virtual Guid TempExamStationRoomID
        {
            get { return _tempexamstationroomid; }
            set { _tempexamstationroomid = value; }
        }
        /// <summary>
        /// 临时考试ID
        /// </summary>		
        private Guid? _tempexamtableid;
        public virtual Guid? TempExamTableID
        {
            get { return _tempexamtableid; }
            set { _tempexamtableid = value; }
        }
        /// <summary>
        /// TempExamStationID
        /// </summary>		
        private Guid _tempexamstationid;
        public virtual Guid TempExamStationID
        {
            get { return _tempexamstationid; }
            set { _tempexamstationid = value; }
        }
        /// <summary>
        /// 房间ID
        /// </summary>		
        private int _roomid;
        public virtual int RoomID
        {
            get { return _roomid; }
            set { _roomid = value; }
        }
        /// <summary>
        /// 考站房间信息完整性，1-完整，0-不完整
        /// </summary>		
        private int? _tempexamstationroomiscomplete;
        public virtual int? TempExamStationRoomIsComplete
        {
            get { return _tempexamstationroomiscomplete; }
            set { _tempexamstationroomiscomplete = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamstationroomnumber1;
        public virtual int? TempExamStationRoomNumber1
        {
            get { return _tempexamstationroomnumber1; }
            set { _tempexamstationroomnumber1 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamstationroomnumber2;
        public virtual int? TempExamStationRoomNumber2
        {
            get { return _tempexamstationroomnumber2; }
            set { _tempexamstationroomnumber2 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamstationroomnumber3;
        public virtual int? TempExamStationRoomNumber3
        {
            get { return _tempexamstationroomnumber3; }
            set { _tempexamstationroomnumber3 = value; }
        }
        /// <summary>
        /// 预留字段，长整型
        /// </summary>		
        private long? _tempexamstationroomnumber4;
        public virtual long? TempExamStationRoomNumber4
        {
            get { return _tempexamstationroomnumber4; }
            set { _tempexamstationroomnumber4 = value; }
        }
        /// <summary>
        /// 预留字段，长整型
        /// </summary>		
        private long? _tempexamstationroomnumber5;
        public virtual long? TempExamStationRoomNumber5
        {
            get { return _tempexamstationroomnumber5; }
            set { _tempexamstationroomnumber5 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationroomnumber6;
        public virtual decimal? TempExamStationRoomNumber6
        {
            get { return _tempexamstationroomnumber6; }
            set { _tempexamstationroomnumber6 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationroomnumber7;
        public virtual decimal? TempExamStationRoomNumber7
        {
            get { return _tempexamstationroomnumber7; }
            set { _tempexamstationroomnumber7 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationroomnumber8;
        public virtual decimal? TempExamStationRoomNumber8
        {
            get { return _tempexamstationroomnumber8; }
            set { _tempexamstationroomnumber8 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationroomnumber9;
        public virtual decimal? TempExamStationRoomNumber9
        {
            get { return _tempexamstationroomnumber9; }
            set { _tempexamstationroomnumber9 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度50
        /// </summary>		
        private string _tempexamstationroomstring1;
        public virtual string TempExamStationRoomString1
        {
            get { return _tempexamstationroomstring1; }
            set { _tempexamstationroomstring1 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度50
        /// </summary>		
        private string _tempexamstationroomstring2;
        public virtual string TempExamStationRoomString2
        {
            get { return _tempexamstationroomstring2; }
            set { _tempexamstationroomstring2 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度200
        /// </summary>		
        private string _tempexamstationroomstring3;
        public virtual string TempExamStationRoomString3
        {
            get { return _tempexamstationroomstring3; }
            set { _tempexamstationroomstring3 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度200
        /// </summary>		
        private string _tempexamstationroomstring4;
        public virtual string TempExamStationRoomString4
        {
            get { return _tempexamstationroomstring4; }
            set { _tempexamstationroomstring4 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度500
        /// </summary>		
        private string _tempexamstationroomstring5;
        public virtual string TempExamStationRoomString5
        {
            get { return _tempexamstationroomstring5; }
            set { _tempexamstationroomstring5 = value; }
        }
        /// <summary>
        /// 董阳，2014-09-16，存储考站房间信息不完整时的提示信息
        /// </summary>		
        private string _tempexamstationroomstring6;
        public virtual string TempExamStationRoomString6
        {
            get { return _tempexamstationroomstring6; }
            set { _tempexamstationroomstring6 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2000
        /// </summary>		
        private string _tempexamstationroomstring7;
        public virtual string TempExamStationRoomString7
        {
            get { return _tempexamstationroomstring7; }
            set { _tempexamstationroomstring7 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度4000
        /// </summary>		
        private string _tempexamstationroomstring8;
        public virtual string TempExamStationRoomString8
        {
            get { return _tempexamstationroomstring8; }
            set { _tempexamstationroomstring8 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
        private string _tempexamstationroomstring9;
        public virtual string TempExamStationRoomString9
        {
            get { return _tempexamstationroomstring9; }
            set { _tempexamstationroomstring9 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationroomdatetime1;
        public virtual DateTime? TempExamStationRoomDatetime1
        {
            get { return _tempexamstationroomdatetime1; }
            set { _tempexamstationroomdatetime1 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationroomdatetime2;
        public virtual DateTime? TempExamStationRoomDatetime2
        {
            get { return _tempexamstationroomdatetime2; }
            set { _tempexamstationroomdatetime2 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationroomdatetime3;
        public virtual DateTime? TempExamStationRoomDatetime3
        {
            get { return _tempexamstationroomdatetime3; }
            set { _tempexamstationroomdatetime3 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationroomdatetime4;
        public virtual DateTime? TempExamStationRoomDatetime4
        {
            get { return _tempexamstationroomdatetime4; }
            set { _tempexamstationroomdatetime4 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationroomdatetime5;
        public virtual DateTime? TempExamStationRoomDatetime5
        {
            get { return _tempexamstationroomdatetime5; }
            set { _tempexamstationroomdatetime5 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationroomdatetime6;
        public virtual DateTime? TempExamStationRoomDatetime6
        {
            get { return _tempexamstationroomdatetime6; }
            set { _tempexamstationroomdatetime6 = value; }
        }  

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamStationRoom()
            : this(default(Guid))
        { 
        
        }

        /// <summary>
        /// 仅使用Guid构造对象
        /// </summary>
        public TempExamStationRoom(Guid tempExamStationRoomID)
        {
            this.TempExamStationRoomID = tempExamStationRoomID;
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
                .Append("\"TempExamStationRoomID\":\"").Append(this.TempExamStationRoomID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID == null ? "" : this.TempExamTableID.ToString()).Append("\",")
                .Append("\"TempExamStationID\":\"").Append(this.TempExamStationID).Append("\",")
                .Append("\"RoomID\":\"").Append(this.RoomID).Append("\",")
                .Append("\"TempExamStationRoomIsComplete\":\"").Append(this.TempExamStationRoomIsComplete == null ? "" : Convert.ToInt32(TempExamStationRoomIsComplete).ToString()).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
