using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// DeviceManufacturer:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class DeviceManufacturer
    {
        public DeviceManufacturer()
        { }
        #region Model
        private int _dm_id;
        private string _dm_name;
        private int? _dm_int;
        private string _dm_string;
        /// <summary>
        /// 制造商ID
        /// </summary>
        public virtual int DMA_ID
        {
            set { _dm_id = value; }
            get { return _dm_id; }
        }
        /// <summary>
        /// 制造商名称
        /// </summary>
        public virtual string DMA_Name
        {
            set { _dm_name = value; }
            get { return _dm_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? DMA_int
        {
            set { _dm_int = value; }
            get { return _dm_int; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string DMA_string
        {
            set { _dm_string = value; }
            get { return _dm_string; }
        }
        #endregion Model

        public virtual string ToJsonString()
        {
            return new StringBuilder()
                .Append("{")
                .Append("\"DMA_ID\":\"" + this.DMA_ID + "\",")
                .Append("\"DMA_Name\":\"" + Uri.EscapeDataString(this.DMA_Name == null ? "" : this.DMA_Name) + "\",")
                .Append("\"DMA_int\":\"" + this.DMA_int + "\",")
                .Append("\"DMA_string\":\"" + Uri.EscapeDataString(this.DMA_string == null ? "" : this.DMA_string) + "\"")
                .Append("}")
                .ToString();
        }
    }
}
