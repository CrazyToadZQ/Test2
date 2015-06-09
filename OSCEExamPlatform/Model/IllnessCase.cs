using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 病例信息
    /// </summary>
    public class IllnessCase
    {
        #region Model
        /// <summary>
        /// 病例信息主键
        /// </summary>		
        private int _illnesscaseid;
        public virtual int IllnessCaseID
        {
            get { return _illnesscaseid; }
            set { _illnesscaseid = value; }
        }
        /// <summary>
        /// 病例信息名称
        /// </summary>		
        private string _illnesscasename;
        public virtual string IllnessCaseName
        {
            get { return _illnesscasename; }
            set { _illnesscasename = value; }
        }
        /// <summary>
        /// 病例所属分类ID
        /// </summary>		
        private int _marksheetkindid;
        public virtual int MarkSheetKindID
        {
            get { return _marksheetkindid; }
            set { _marksheetkindid = value; }
        }
        /// <summary>
        /// 病例描述内容（HTML格式）
        /// </summary>		
        private string _illnesscasecontent;
        public virtual string IllnessCaseContent
        {
            get { return _illnesscasecontent; }
            set { _illnesscasecontent = value; }
        }
        /// <summary>
        /// 病例描述内容（文本格式）
        /// </summary>		
        private string _illnesscasetext;
        public virtual string IllnessCaseText
        {
            get { return _illnesscasetext; }
            set { _illnesscasetext = value; }
        }
        /// <summary>
        /// 创建者用户ID
        /// </summary>		
        private int _creatoruserinfoid;
        public virtual int CreatorUserInfoID
        {
            get { return _creatoruserinfoid; }
            set { _creatoruserinfoid = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>		
        private DateTime _createdatetime;
        public virtual DateTime CreateDatetime
        {
            get { return _createdatetime; }
            set { _createdatetime = value; }
        }
        /// <summary>
        /// 最新修改用户ID
        /// </summary>		
        private int? _modifieruserinfoid;
        public virtual int? ModifierUserInfoID
        {
            get { return _modifieruserinfoid; }
            set { _modifieruserinfoid = value; }
        }
        /// <summary>
        /// 最新修改时间
        /// </summary>		
        private DateTime? _modifydatetime;
        public virtual DateTime? ModifyDatetime
        {
            get { return _modifydatetime; }
            set { _modifydatetime = value; }
        }
        /// <summary>
        /// 逻辑删除（1-有效记录，0-无效记录）
        /// </summary>		
        private int _isvalid;
        public virtual int IsValid
        {
            get { return _isvalid; }
            set { _isvalid = value; }
        }
        /// <summary>
        /// Number1
        /// </summary>		
        private int? _number1;
        public virtual int? Number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }
        /// <summary>
        /// Number2
        /// </summary>		
        private int? _number2;
        public virtual int? Number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }
        /// <summary>
        /// Number3
        /// </summary>		
        private int? _number3;
        public virtual int? Number3
        {
            get { return _number3; }
            set { _number3 = value; }
        }
        /// <summary>
        /// Number4
        /// </summary>		
        private int? _number4;
        public virtual int? Number4
        {
            get { return _number4; }
            set { _number4 = value; }
        }
        /// <summary>
        /// Number5
        /// </summary>		
        private int? _number5;
        public virtual int? Number5
        {
            get { return _number5; }
            set { _number5 = value; }
        }
        /// <summary>
        /// Number6
        /// </summary>		
        private decimal? _number6;
        public virtual decimal? Number6
        {
            get { return _number6; }
            set { _number6 = value; }
        }
        /// <summary>
        /// Number7
        /// </summary>		
        private decimal? _number7;
        public virtual decimal? Number7
        {
            get { return _number7; }
            set { _number7 = value; }
        }
        /// <summary>
        /// Number8
        /// </summary>		
        private decimal? _number8;
        public virtual decimal? Number8
        {
            get { return _number8; }
            set { _number8 = value; }
        }
        /// <summary>
        /// String1
        /// </summary>		
        private string _string1;
        public virtual string String1
        {
            get { return _string1; }
            set { _string1 = value; }
        }
        /// <summary>
        /// String2
        /// </summary>		
        private string _string2;
        public virtual string String2
        {
            get { return _string2; }
            set { _string2 = value; }
        }
        /// <summary>
        /// String3
        /// </summary>		
        private string _string3;
        public virtual string String3
        {
            get { return _string3; }
            set { _string3 = value; }
        }
        /// <summary>
        /// String4
        /// </summary>		
        private string _string4;
        public virtual string String4
        {
            get { return _string4; }
            set { _string4 = value; }
        }
        /// <summary>
        /// String5
        /// </summary>		
        private string _string5;
        public virtual string String5
        {
            get { return _string5; }
            set { _string5 = value; }
        }
        /// <summary>
        /// String6
        /// </summary>		
        private string _string6;
        public virtual string String6
        {
            get { return _string6; }
            set { _string6 = value; }
        }
        /// <summary>
        /// String7
        /// </summary>		
        private string _string7;
        public virtual string String7
        {
            get { return _string7; }
            set { _string7 = value; }
        }
        /// <summary>
        /// String8
        /// </summary>		
        private string _string8;
        public virtual string String8
        {
            get { return _string8; }
            set { _string8 = value; }
        }
        /// <summary>
        /// Datetime1
        /// </summary>		
        private DateTime _datetime1;
        public virtual DateTime Datetime1
        {
            get { return _datetime1; }
            set { _datetime1 = value; }
        }
        /// <summary>
        /// Datetime2
        /// </summary>		
        private DateTime _datetime2;
        public virtual DateTime Datetime2
        {
            get { return _datetime2; }
            set { _datetime2 = value; }
        }
        /// <summary>
        /// Datetime3
        /// </summary>		
        private DateTime _datetime3;
        public virtual DateTime Datetime3
        {
            get { return _datetime3; }
            set { _datetime3 = value; }
        }
        /// <summary>
        /// Datetime4
        /// </summary>		
        private DateTime _datetime4;
        public virtual DateTime Datetime4
        {
            get { return _datetime4; }
            set { _datetime4 = value; }
        }
        #endregion Model

        /// <summary>
        /// 生成json字符串
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return new StringBuilder()
                .Append("{")
                .Append("\"IllnessCaseID\":\"" + this.IllnessCaseID + "\",")
                .Append("\"IllnessCaseName\":\"" + Uri.EscapeDataString(this.IllnessCaseName) + "\",")
                .Append("\"MarkSheetKindID\":\"" + this.MarkSheetKindID + "\",")
                .Append("\"IllnessCaseContent\":\"" + Uri.EscapeDataString(this.IllnessCaseContent) + "\",")
                .Append("\"IllnessCaseText\":\"" + Uri.EscapeDataString(this.IllnessCaseText) + "\",")
                .Append("\"CreatorUserInfoID\":\"" + this.CreatorUserInfoID + "\",")
                .Append("\"CreateDatetime\":\"" + this.CreateDatetime.ToString("yyyy-MM-dd") + "\",")
                .Append("\"ModifierUserInfoID\":\"" + (this.ModifierUserInfoID == null ? "" : this.ModifierUserInfoID.ToString()) + "\",")
                .Append("\"ModifyDatetime\":\"" + (this.ModifyDatetime == null ? "" : Convert.ToDateTime(this.ModifyDatetime).ToString("yyyy-MM-dd")) + "\",")
                .Append("\"IsValid\":\"" + this.IsValid + "\"")
                .Append("}")
                .ToString();
        }
    }
}
