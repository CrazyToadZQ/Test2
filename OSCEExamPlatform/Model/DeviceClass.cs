using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class DeviceClass
    {
        private int _dc_id;
        private string _dc_name;
        private int _dc_parentid;
        private string _dc_content;
        private int _dc_isvalid;
        private int? _dc_int;
        private string _dc_string;

        /// <summary>
        /// 设备分类ID
        /// </summary>
        public virtual int DC_ID
        {
            get { return _dc_id; }
            set { _dc_id = value; }
        }
        /// <summary>
        /// 设备分类名称
        /// </summary>
        public virtual string DC_Name
        {
            get { return _dc_name; }
            set { _dc_name = value; }
        }
        /// <summary>
        /// 父节点ID
        /// </summary>
        public virtual int DC_ParentID
        {
            get { return _dc_parentid; }
            set { _dc_parentid = value; }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public virtual string DC_Content
        {
            get { return _dc_content; }
            set { _dc_content = value; }
        }
        /// <summary>
        /// 数据有效性，1-有效，0-无效（查有效数据时，请添加条件 DC_IsValid=1）
        /// </summary>
        public virtual int DC_IsValid
        {
            get { return _dc_isvalid; }
            set { _dc_isvalid = value; }
        }
        /// <summary>
        /// 建议合理库存
        /// </summary>
        public virtual int? DC_int
        {
            get { return _dc_int; }
            set { _dc_int = value; }
        }
        /// <summary>
        /// 预留
        /// </summary>
        public virtual string DC_string
        {
            get { return _dc_string; }
            set { _dc_string = value; }
        }

        /// <summary>
        /// 设备分类级别，业务逻辑属性，没有对应的数据库字段映射
        /// </summary>
        public virtual int DC_Level
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString() 
        {
            string jsonString = "{";
            jsonString += "\"DC_ID\":\"" + this.DC_ID + "\",";
            jsonString += "\"DC_Name\":\"" + Uri.EscapeDataString(this.DC_Name) + "\",";
            jsonString += "\"DC_ParentID\":\"" + this.DC_ParentID + "\",";
            jsonString += "\"DC_Content\":\"" + Uri.EscapeDataString(this.DC_Content) + "\",";            //手动输入的内容 需要进行校验转换
            jsonString += "\"DC_IsValid\":\"" + this.DC_IsValid + "\",";
            jsonString += "\"DC_Level\":\"" + this.DC_Level + "\",";
            jsonString += "\"DC_int\":\"" + (this.DC_int == null ? "" : Convert.ToInt32(this.DC_int).ToString()) + "\"";
            jsonString += "}";
            return jsonString;
        }

    }
}
