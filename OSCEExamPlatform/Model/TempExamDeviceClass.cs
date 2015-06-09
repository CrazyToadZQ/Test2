using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class TempExamDeviceClass
    {
        #region Model

        /// <summary>
        /// 临时考试设备分类ID
        /// </summary>		
        private int _tempexamdeviceclassid;
        public virtual int TempExamDeviceClassID
        {
            get { return _tempexamdeviceclassid; }
            set { _tempexamdeviceclassid = value; }
        }
        /// <summary>
        /// 考试ID
        /// </summary>		
        private Guid? _tempexamtableid;
        public virtual Guid? TempExamTableID
        {
            get { return _tempexamtableid; }
            set { _tempexamtableid = value; }
        }
        /// <summary>
        /// 考站ID
        /// </summary>		
        private Guid? _tempexamstationid;
        public virtual Guid? TempExamStationID
        {
            get { return _tempexamstationid; }
            set { _tempexamstationid = value; }
        }
        /// <summary>
        /// 考站房间ID
        /// </summary>		
        private Guid _tempexamstationroomid;
        public virtual Guid TempExamStationRoomID
        {
            get { return _tempexamstationroomid; }
            set { _tempexamstationroomid = value; }
        }
        /// <summary>
        /// 房间ID
        /// </summary>		
        private int? _roomid;
        public virtual int? RoomID
        {
            get { return _roomid; }
            set { _roomid = value; }
        }
        /// <summary>
        /// 设备分类ID
        /// </summary>		
        private int _deviceclassid;
        public virtual int DeviceClassID
        {
            get { return _deviceclassid; }
            set { _deviceclassid = value; }
        }
        /// <summary>
        /// 设备数量
        /// </summary>		
        private int? _devicecount;
        public virtual int? DeviceCount
        {
            get { return _devicecount; }
            set { _devicecount = value; }
        }
        /// <summary>
        /// 客观评分表ID
        /// </summary>		
        private int? _objectivemarksheetid;
        public virtual int? ObjectiveMarkSheetID
        {
            get { return _objectivemarksheetid; }
            set { _objectivemarksheetid = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamdeviceclassnumber1;
        public virtual int? TempExamDeviceClassNumber1
        {
            get { return _tempexamdeviceclassnumber1; }
            set { _tempexamdeviceclassnumber1 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamdeviceclassnumber2;
        public virtual int? TempExamDeviceClassNumber2
        {
            get { return _tempexamdeviceclassnumber2; }
            set { _tempexamdeviceclassnumber2 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamdeviceclassnumber3;
        public virtual decimal? TempExamDeviceClassNumber3
        {
            get { return _tempexamdeviceclassnumber3; }
            set { _tempexamdeviceclassnumber3 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamdeviceclassnumber4;
        public virtual decimal? TempExamDeviceClassNumber4
        {
            get { return _tempexamdeviceclassnumber4; }
            set { _tempexamdeviceclassnumber4 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度1000
        /// </summary>		
        private string _tempexamdeviceclassstring1;
        public virtual string TempExamDeviceClassString1
        {
            get { return _tempexamdeviceclassstring1; }
            set { _tempexamdeviceclassstring1 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2000
        /// </summary>		
        private string _tempexamdeviceclassstring2;
        public virtual string TempExamDeviceClassString2
        {
            get { return _tempexamdeviceclassstring2; }
            set { _tempexamdeviceclassstring2 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度4000
        /// </summary>		
        private string _tempexamdeviceclassstring3;
        public virtual string TempExamDeviceClassString3
        {
            get { return _tempexamdeviceclassstring3; }
            set { _tempexamdeviceclassstring3 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
        private string _tempexamdeviceclassstring4;
        public virtual string TempExamDeviceClassString4
        {
            get { return _tempexamdeviceclassstring4; }
            set { _tempexamdeviceclassstring4 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdeviceclassdatetime1;
        public virtual DateTime? TempExamDeviceClassDatetime1
        {
            get { return _tempexamdeviceclassdatetime1; }
            set { _tempexamdeviceclassdatetime1 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdeviceclassdatetime2;
        public virtual DateTime? TempExamDeviceClassDatetime2
        {
            get { return _tempexamdeviceclassdatetime2; }
            set { _tempexamdeviceclassdatetime2 = value; }
        }  

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamDeviceClass()
            : this(default(Int32))
        { 
        
        }

        /// <summary>
        /// 仅使用Int32构造对象
        /// </summary>
        public TempExamDeviceClass(int tempExamDeviceClassID)
        {
            this.TempExamDeviceClassID = tempExamDeviceClassID;
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
                .Append("\"TempExamDeviceClassID\":\"").Append(this.TempExamDeviceClassID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID == null ? "" : this.TempExamTableID.ToString()).Append("\",")
                .Append("\"TempExamStationID\":\"").Append(this.TempExamStationID == null ? "" : this.TempExamStationID.ToString()).Append("\",")
                .Append("\"TempExamStationRoomID\":\"").Append(this.TempExamStationRoomID).Append("\",")
                .Append("\"RoomID\":\"").Append(this.RoomID == null ? "" : Convert.ToInt32(this.RoomID).ToString()).Append("\",")
                .Append("\"DeviceClassID\":\"").Append(this.DeviceClassID).Append("\",")
                .Append("\"DeviceCount\":\"").Append(this.DeviceCount == null ? "" : Convert.ToInt32(this.DeviceCount).ToString()).Append("\",")
                .Append("\"ObjectiveMarkSheetID\":\"").Append(this.ObjectiveMarkSheetID == null ? "" : Convert.ToInt32(this.ObjectiveMarkSheetID).ToString()).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
