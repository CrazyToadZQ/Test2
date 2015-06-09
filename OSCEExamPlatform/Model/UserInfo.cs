using System;
using System.Text;
namespace Tellyes.Model
{
	/// <summary>
	/// 用户信息表
	/// </summary>
	[Serializable]
	public partial class UserInfo
	{
		public UserInfo()
		{}

        /// <summary>
        /// 2014-3-7范国斌修改，增加此构造方法，是为了存储在Session中的user对象，仅拥有少量的数据量，避免Session溢满而丢失。
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="uName"></param>
        /// <param name="trueName"></param>
        public UserInfo(int uid,string uName,string trueName)
        {
            this._u_id = uid;
            this._u_name = uName;
            this._u_truename = trueName;
        }
        #region Model
        private int _u_id;
        private string _u_name;
        private string _u_truename;
        private string _u_pwd;
        private int _u_sex = 0;
        private string _u_phone;
        private string _u_phone2;
        private string _u_email;
        private string _u_email2;
        private string _u_contont;
        private byte[] _u_photo;
        private string _u_goodfield;
        private string _u_title;
        private int? _int1 = 1;
        private int? _int2;
        private int? _int3;
        private string _string1;
        private string _string2;
        private string _string3;
        private DateTime? _date1;
        private DateTime? _date2;
        private DateTime? _date3;
        private decimal? _float1;
        private decimal? _float2;
        private decimal? _float3;
        private string _u_ethnic;
        private string _u_education;
        private DateTime? _u_intime;
        private string _u_source;
        private string _u_unit;
        private string _u_originalUrl;
        private string _u_thumbnailUrl;
        /// <summary>
        /// User标识，主键
        /// </summary>
        public virtual int U_ID
        {
            set { _u_id = value; }
            get { return _u_id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string U_Name
        {
            set { _u_name = value; }
            get { return _u_name; }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public virtual string U_TrueName
        {
            set { _u_truename = value; }
            get { return _u_truename; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public virtual string U_PWD
        {
            set { _u_pwd = value; }
            get { return _u_pwd; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public virtual int U_Sex
        {
            set { _u_sex = value; }
            get { return _u_sex; }
        }
        /// <summary>
        /// 手机号码
        /// </summary>
        public virtual string U_Phone
        {
            set { _u_phone = value; }
            get { return _u_phone; }
        }
        /// <summary>
        /// 备用手机号码
        /// </summary>
        public virtual string U_Phone2
        {
            set { _u_phone2 = value; }
            get { return _u_phone2; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public virtual string U_Email
        {
            set { _u_email = value; }
            get { return _u_email; }
        }
        /// <summary>
        /// 备用邮箱
        /// </summary>
        public virtual string U_Email2
        {
            set { _u_email2 = value; }
            get { return _u_email2; }
        }
        /// <summary>
        /// 用户描述
        /// </summary>
        public virtual string U_Contont
        {
            set { _u_contont = value; }
            get { return _u_contont; }
        }
        /// <summary>
        /// 照片
        /// </summary>
        public virtual byte[] U_Photo
        {
            set { _u_photo = value; }
            get { return _u_photo; }
        }
        /// <summary>
        /// 擅长领域
        /// </summary>
        public virtual string U_GoodField
        {
            set { _u_goodfield = value; }
            get { return _u_goodfield; }
        }
        /// <summary>
        /// 职称
        /// </summary>
        public virtual string U_Title
        {
            set { _u_title = value; }
            get { return _u_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? int1
        {
            set { _int1 = value; }
            get { return _int1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? int2
        {
            set { _int2 = value; }
            get { return _int2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? int3
        {
            set { _int3 = value; }
            get { return _int3; }
        }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public virtual string string1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 范国斌 2014-08-28修改此列用于存储用户的毕业院校
        /// </summary>
        public virtual string string2
        {
            set { _string2 = value; }
            get { return _string2; }
        }
        /// <summary>
        /// 范国斌 2014-08-28修改此列用于存储用户的政治背景
        /// </summary>
        public virtual string string3
        {
            set { _string3 = value; }
            get { return _string3; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public virtual DateTime? date1
        {
            set { _date1 = value; }
            get { return _date1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? date2
        {
            set { _date2 = value; }
            get { return _date2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? date3
        {
            set { _date3 = value; }
            get { return _date3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? float1
        {
            set { _float1 = value; }
            get { return _float1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? float2
        {
            set { _float2 = value; }
            get { return _float2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? float3
        {
            set { _float3 = value; }
            get { return _float3; }
        }
        /// <summary>
        /// 用户民族
        /// </summary>
        public virtual string U_Ethnic
        {
            set { _u_ethnic = value; }
            get { return _u_ethnic; }
        }
        /// <summary>
        /// 用户学历
        /// </summary>
        public virtual string U_Education
        {
            set { _u_education = value; }
            get { return _u_education; }
        }
        /// <summary>
        /// 学生入学时间
        /// </summary>
        public virtual DateTime? U_InTime
        {
            set { _u_intime = value; }
            get { return _u_intime; }
        }
        /// <summary>
        /// 评委或SP来源
        /// 范国斌2014年8月31日修改此列为：生源地（仅学生用户）
        /// </summary>
        public virtual string U_Source
        {
            set { _u_source = value; }
            get { return _u_source; }
        }
        /// <summary>
        /// 单位（非学生用户）
        /// </summary>
        public virtual string U_Unit
        {
            set { _u_unit = value; }
            get { return _u_unit; }
        }

        /// <summary>
        /// 原图路径
        /// </summary>
        public virtual string U_OriginalUrl
        {
            set { _u_originalUrl = value; }
            get { return _u_originalUrl; }
        }
        /// <summary>
        /// 缩略图路径
        /// </summary>
        public virtual string U_ThumbnailUrl
        {
            set { _u_thumbnailUrl = value; }
            get { return _u_thumbnailUrl; }
        }

        #endregion Model

        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder()
                .Append(close ? "{" : "")
                .Append("\"U_ID\":\"").Append(this.U_ID).Append("\",")
                .Append("\"U_Name\":\"").Append(Uri.EscapeDataString(this.U_Name)).Append("\",")
                .Append("\"U_TrueName\":\"").Append(Uri.EscapeDataString(this.U_TrueName)).Append("\",")
                .Append("\"U_Sex\":\"").Append(U_Sex).Append("\",")
                .Append("\"U_Age\":\"").Append(this.date1 == null ? "" : (DateTime.Now.Year - Convert.ToDateTime(this.date1).Year - (DateTime.Now >= Convert.ToDateTime(this.date1).AddYears(DateTime.Now.Year - Convert.ToDateTime(this.date1).Year) ? 0 : 1)).ToString()).Append("\",")
                .Append("\"U_Ethnic\":\"").Append(Uri.EscapeDataString(this.U_Ethnic == null ? "" : this.U_Ethnic)).Append("\",")
                .Append("\"U_Phone\":\"").Append(Uri.EscapeDataString(this.U_Phone)).Append("\",")
                .Append("\"U_Phone2\":\"").Append(Uri.EscapeDataString(this.U_Phone2 == null ? "" : this.U_Phone2)).Append("\",")
                .Append("\"U_Email\":\"").Append(Uri.EscapeDataString(this.U_Email)).Append("\",")
                .Append("\"U_Email2\":\"").Append(Uri.EscapeDataString(this.U_Email2 == null ? "" : this.U_Email2)).Append("\",")
                .Append("\"U_Contont\":\"").Append(Uri.EscapeDataString(this.U_Contont == null ? "" : this.U_Contont)).Append("\",")
                .Append("\"U_GoodField\":\"").Append(Uri.EscapeDataString(this.U_GoodField == null ? "" : this.U_GoodField)).Append("\",")
                .Append("\"string1\":\"").Append(Uri.EscapeDataString(this.string1 == null ? "" : this.string1)).Append("\",")
                .Append("\"U_Title\":\"").Append(Uri.EscapeDataString(this.U_Title == null ? "" : this.U_Title)).Append("\",")
                .Append("\"U_Unit\":\"").Append(Uri.EscapeDataString(this.U_Unit == null ? "" : this.U_Unit)).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }
	}
}

