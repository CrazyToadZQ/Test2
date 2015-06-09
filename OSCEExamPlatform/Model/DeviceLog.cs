using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// DeviceLog:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class DeviceLog
    {
        public DeviceLog()
        { }
        #region Model
        private int _dl_id;
        private int _d_id;
        private string _dl_type;
        private string _dl_description;
        private  DateTime _dl_createtime;
        private int _dl_creatorid;
        private string _dl_creatorname;
        private int? _dl_int1;
        private int? _dl_int2;
        private string _dl_string1;
        private string _dl_string2;
        private byte[] _dl_image;
        private string _dl_reason;
        private string _dl_contact_person;
        private string _dl_contact_person_company;
        private string _dl_contact_person_phone;
        /// <summary>
        /// 设备日志ID
        /// </summary>
        public virtual int DL_ID
        {
            set { _dl_id = value; }
            get { return _dl_id; }
        }
        /// <summary>
        /// 设备ID
        /// </summary>
        public virtual int D_ID
        {
            set { _d_id = value; }
            get { return _d_id; }
        }
        /// <summary>
        /// 日志类型
        /// </summary>
        public virtual string DL_Type
        {
            set { _dl_type = value; }
            get { return _dl_type; }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public virtual string DL_Description
        {
            set { _dl_description = value; }
            get { return _dl_description; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime DL_CreateTime
        {
            set { _dl_createtime = value; }
            get { return _dl_createtime; }
        }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public virtual  int DL_CreatorID
        {
            set { _dl_creatorid = value; }
            get { return _dl_creatorid; }
        }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public virtual string DL_CreatorName
        {
            set { _dl_creatorname = value; }
            get { return _dl_creatorname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? DL_int1
        {
            set { _dl_int1 = value; }
            get { return _dl_int1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? DL_int2
        {
            set { _dl_int2 = value; }
            get { return _dl_int2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string DL_string1
        {
            set { _dl_string1 = value; }
            get { return _dl_string1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string DL_string2
        {
            set { _dl_string2 = value; }
            get { return _dl_string2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual  byte[] DL_image
        {
            set { _dl_image = value; }
            get { return _dl_image; }
        }

        /// <summary>
        /// 此条日志原因
        /// </summary>
        public virtual string DL_Reason
        {
            set { _dl_reason = value; }
            get { return _dl_reason; }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public virtual string DL_Contact_Person
        {
            set { _dl_contact_person = value; }
            get { return _dl_contact_person; }
        }
        /// <summary>
        /// 联系人单位
        /// </summary>
        public virtual string DL_Contact_Person_Company
        {
            set { _dl_contact_person_company = value; }
            get { return _dl_contact_person_company; }
        }
        /// <summary>
        /// 联系人电话
        /// </summary>
        public virtual string DL_Contact_Person_Phone
        {
            set { _dl_contact_person_phone = value; }
            get { return _dl_contact_person_phone; }
        }
        #endregion Model

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder()
                .Append(close ? "{" : "")
                .Append("\"DL_ID\":\"" + this.DL_ID + "\",")
                .Append("\"D_ID\":\"" + this.D_ID + "\",")
                .Append("\"DL_Type\":\"" + Uri.EscapeDataString(this.DL_Type == null ? "" : this.DL_Type) + "\",")
                .Append("\"DL_Description\":\"" + Uri.EscapeDataString(this.DL_Description == null ? "" : this.DL_Description) + "\",")
                .Append("\"DL_CreateTime\":\"" + Uri.EscapeDataString(this.DL_CreateTime.ToString("yyyy-MM-dd HH:mm:ss")) + "\",")
                .Append("\"DL_CreatorID\":\"" + this.DL_CreatorID + "\",")
                .Append("\"DL_CreatorName\":\"" + Uri.EscapeDataString(this.DL_CreatorName == null ? "" : this.DL_CreatorName) + "\",")
                .Append("\"DL_Reason\":\"" + Uri.EscapeDataString(this.DL_Reason == null ? "" : this.DL_Reason) + "\",")
                .Append("\"DL_Contact_Person\":\"" + Uri.EscapeDataString(this.DL_Contact_Person == null ? "" : this.DL_Contact_Person) + "\",")
                .Append("\"DL_Contact_Person_Company\":\"" + Uri.EscapeDataString(this.DL_Contact_Person_Company == null ? "" : this.DL_Contact_Person_Company) + "\",")
                .Append("\"DL_Contact_Person_Phone\":\"" + Uri.EscapeDataString(this.DL_Contact_Person_Phone == null ? "" : this.DL_Contact_Person_Phone) + "\"")
                .Append(close ? "}" : "")
                .ToString();
        }

    }
}
