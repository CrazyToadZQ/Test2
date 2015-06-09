using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 考站类型表
    /// </summary>
    [Serializable]
    public partial class ExamStationClass
    {
        public ExamStationClass()
        { }
        #region Model
        private int _exam_station_class_id;
        private string _exam_station_class_name;
        private int? _number1 = null;
        private int? _number2 = null;
        private int? _number3 = null;
        private int? _number4 = null;
        private int? _number5 = null;
        private decimal? _number6 = null;
        private decimal? _number7 = null;
        private decimal? _number8 = null;
        private string _string1 = "NULL";
        private string _string2 = "NULL";
        private string _string3 = "NULL";
        private string _string4 = "NULL";
        private string _string5 = "NULL";
        private string _string6 = "NULL";
        private string _string7 = "NULL";
        private string _string8 = "NULL";
        private DateTime? _datetime1 = Convert.ToDateTime(null);
        private DateTime? _datetime2 = Convert.ToDateTime(null);
        private DateTime? _datetime3 = Convert.ToDateTime(null);
        private DateTime? _datetime4 = Convert.ToDateTime(null);
        /// <summary>
        /// 考站类型ID
        /// </summary>
        public virtual int Exam_Station_Class_ID
        {
            set { _exam_station_class_id = value; }
            get { return _exam_station_class_id; }
        }
        /// <summary>
        /// 考站类型名称
        /// </summary>
        public virtual string Exam_Station_Class_Name
        {
            set { _exam_station_class_name = value; }
            get { return _exam_station_class_name; }
        }
        /// <summary>
        /// 逻辑删除列，用于说明此条记录在实际中是否已经删除，主要为了避免历史数据丢失问题。
        /// 其中，0：代表此条记录在实际中已经删除，1：代表此条记录在实际中还未删除
        /// </summary>
        public virtual int? Number1
        {
            set { _number1 = value; }
            get { return _number1; }
        }
        /// <summary>
        /// 董阳，2014-09-22，标示当前排考系统中是否支持该类型考站排考，1-支持，0-不支持，不需要在设置页面中修改，只用于程序部署或更新时调整
        /// </summary>
        public virtual int? Number2
        {
            set { _number2 = value; }
            get { return _number2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? Number3
        {
            set { _number3 = value; }
            get { return _number3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? Number4
        {
            set { _number4 = value; }
            get { return _number4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? Number5
        {
            set { _number5 = value; }
            get { return _number5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? Number6
        {
            set { _number6 = value; }
            get { return _number6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? Number7
        {
            set { _number7 = value; }
            get { return _number7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? Number8
        {
            set { _number8 = value; }
            get { return _number8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String2
        {
            set { _string2 = value; }
            get { return _string2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String3
        {
            set { _string3 = value; }
            get { return _string3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String4
        {
            set { _string4 = value; }
            get { return _string4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String5
        {
            set { _string5 = value; }
            get { return _string5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String6
        {
            set { _string6 = value; }
            get { return _string6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String7
        {
            set { _string7 = value; }
            get { return _string7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string String8
        {
            set { _string8 = value; }
            get { return _string8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? Datetime1
        {
            set { _datetime1 = value; }
            get { return _datetime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? Datetime2
        {
            set { _datetime2 = value; }
            get { return _datetime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? Datetime3
        {
            set { _datetime3 = value; }
            get { return _datetime3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? Datetime4
        {
            set { _datetime4 = value; }
            get { return _datetime4; }
        }
        #endregion Model


        public virtual string ToJsonString()
        {
            string jsonString = "{";
            jsonString += "\"ExamStationClassID\":\"" + this.Exam_Station_Class_ID + "\",";
            jsonString += "\"ExamStationClassName\":\"" + Uri.EscapeDataString(this.Exam_Station_Class_Name) + "\",";
            jsonString += "\"IsExist\":\"" + this.Number1 + "\",";    //"1"表示存在，"0"表示不存在
            jsonString += "\"IsEnable\":\"" + this.Number2 + "\"";
            jsonString += "}";
            return jsonString;

        }
    }
    
}
