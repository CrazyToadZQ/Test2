using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 考试类型表
    /// </summary>
    [Serializable]
    public partial class ExamClass
    {
        public ExamClass()
        { }
        #region Model
        private int _exam_class_id;
        private string _exam_class_name;
        private int _exam_class_level;
        private int _is_system;
        private int? _number1;
        private int? _number2;
        private int? _number3;
        private int? _number4;
        private int? _number5;
        private string _string1;
        private string _string2;
        private string _string3;
        private string _string4;
        private string _string5;
        private DateTime? _datetime1;
        private DateTime? _datetime2;
        private DateTime? _datetime3;
        private DateTime? _datetime4;
        /// <summary>
        /// 考试类型ID
        /// </summary>
        public virtual int Exam_Class_ID
        {
            set { _exam_class_id = value; }
            get { return _exam_class_id; }
        }
        /// <summary>
        /// 考试类型名称
        /// </summary>
        public virtual string Exam_Class_Name
        {
            set { _exam_class_name = value; }
            get { return _exam_class_name; }
        }
        /// <summary>
        /// 考试类型级别（1-1星级重要，2-2星级重要，3-3星级重要，4-4星级重要，5-5星级重要，6-6星级重要,级数越多越重要）
        /// </summary>
        public virtual int Exam_Class_Level
        {
            set { _exam_class_level = value; }
            get { return _exam_class_level; }
        }
        /// <summary>
        /// 是否是系统自带考试类型（1-是系统自带，0-不是系统自带）
        /// </summary>
        public virtual int Is_System
        {
            set { _is_system = value; }
            get { return _is_system; }
        }
        /// <summary>
        /// 逻辑删除列（1：此条记录未被删除，0：此条记录已经被删除）
        /// </summary>
        public virtual int? Number1
        {
            set { _number1 = value; }
            get { return _number1; }
        }
        /// <summary>
        /// 
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


        /// <summary>
        ///  model To Jason 转换方法， 如果其他预留字段需要使用，则需要扩展该方法，2014-7-7 陶东利
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            string jsonString = "{";
            jsonString += "\"Exam_Class_ID\":\"" + this.Exam_Class_ID + "\",";
            jsonString += "\"Exam_Class_Name\":\"" + Uri.EscapeDataString(this.Exam_Class_Name) + "\",";
            jsonString += "\"Exam_Class_Level\":\"" + this.Exam_Class_Level + "\",";
            jsonString += "\"Is_System\":\"" + this.Is_System + "\"";
            jsonString += "}";
            return jsonString;

        }
    }
}
