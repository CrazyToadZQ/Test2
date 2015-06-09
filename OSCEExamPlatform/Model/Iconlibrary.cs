using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
  public  class Iconlibrary
    {
        public Iconlibrary()
        { }
        #region Model
        private int _icon_id;
        private string _icon_name;
        private string _icon_path;
        private int _icon_person;
        private int _icon_is_existing;
        private int? _number1;
        private int? _number2;
        private int? _number3;
        private int? _number4;
        private int? _number5;
        private decimal? _number6;
        private decimal? _number7;
        private decimal? _number8;
        private string _string1;
        private string _string2;
        private string _string3;
        private string _string4;
        private string _string5;
        private string _string6;
        private string _string7;
        private string _string8;
        private DateTime? _datetime1;
        private DateTime? _datetime2;
        private DateTime? _datetime3;
        private DateTime? _datetime4;
        /// <summary>
        /// 
        /// </summary>
        public int Icon_ID
        {
            set { _icon_id = value; }
            get { return _icon_id; }
        }
        /// <summary>
        /// 图标名称
        /// </summary>
        public string Icon_Name
        {
            set { _icon_name = value; }
            get { return _icon_name; }
        }
        /// <summary>
        /// 图标保存路径
        /// </summary>
        public string Icon_Path
        {
            set { _icon_path = value; }
            get { return _icon_path; }
        }
        /// <summary>
        /// 图标属于哪位评委，存储评委ID（如果此值是“0”，则表示此图标是系统图标；此值是“-1”，则表示此图标是评语专用图标；此值是“-2”，则表示此图标是音频专用图标）
        /// </summary>
        public int Icon_Person
        {
            set { _icon_person = value; }
            get { return _icon_person; }
        }
        /// <summary>
        /// 图标目前是否存在，逻辑删除列（0-不存在，1-存在）
        /// </summary>
        public int Icon_Is_Existing
        {
            set { _icon_is_existing = value; }
            get { return _icon_is_existing; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Number1
        {
            set { _number1 = value; }
            get { return _number1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Number2
        {
            set { _number2 = value; }
            get { return _number2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Number3
        {
            set { _number3 = value; }
            get { return _number3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Number4
        {
            set { _number4 = value; }
            get { return _number4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Number5
        {
            set { _number5 = value; }
            get { return _number5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Number6
        {
            set { _number6 = value; }
            get { return _number6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Number7
        {
            set { _number7 = value; }
            get { return _number7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Number8
        {
            set { _number8 = value; }
            get { return _number8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String2
        {
            set { _string2 = value; }
            get { return _string2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String3
        {
            set { _string3 = value; }
            get { return _string3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String4
        {
            set { _string4 = value; }
            get { return _string4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String5
        {
            set { _string5 = value; }
            get { return _string5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String6
        {
            set { _string6 = value; }
            get { return _string6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String7
        {
            set { _string7 = value; }
            get { return _string7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string String8
        {
            set { _string8 = value; }
            get { return _string8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Datetime1
        {
            set { _datetime1 = value; }
            get { return _datetime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Datetime2
        {
            set { _datetime2 = value; }
            get { return _datetime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Datetime3
        {
            set { _datetime3 = value; }
            get { return _datetime3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Datetime4
        {
            set { _datetime4 = value; }
            get { return _datetime4; }
        }
        #endregion Model
    }
}
