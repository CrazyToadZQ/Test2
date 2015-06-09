using System;
using System.Text;
namespace Tellyes.Model
{
    /// <summary>
    /// MarkSheetItem:子评分表
    /// </summary>
    [Serializable]
    public partial class MarkSheetItem
    {
        public MarkSheetItem()
        { }
        #region Model
        private int _msi_id;
        private int _ms_id;
        private string _msi_item;
        private decimal? _msi_score;
        private string _string1;
        private string _string2;
        private string _string3;
        /// <summary>
        /// 主键，标志位
        /// </summary>
        public virtual int MSI_ID
        {
            set { _msi_id = value; }
            get { return _msi_id; }
        }
        /// <summary>
        /// 外键，父评分表id
        /// </summary>
        public virtual int MS_ID
        {
            set { _ms_id = value; }
            get { return _ms_id; }
        }
        /// <summary>
        /// 评分项内容
        /// </summary>
        public virtual string MSI_Item
        {
            set { _msi_item = value; }
            get { return _msi_item; }
        }
        /// <summary>
        /// 评分项分值
        /// </summary>
        public virtual decimal? MSI_Score
        {
            set { _msi_score = value; }
            get { return _msi_score; }
        }
        /// <summary>
        /// （韩兴伟 2014-05-16修改）评分项分二级，该字段为0时，代表该行是一级评分项；该字段为非0时，代表该行是二级评分项，且其值为其所属的一级评分项的id.
        /// </summary>
        public virtual string string1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 预留
        /// </summary>
        public virtual string string2
        {
            set { _string2 = value; }
            get { return _string2; }
        }
        /// <summary>
        /// 预留
        /// </summary>
        public virtual string string3
        {
            set { _string3 = value; }
            get { return _string3; }
        }
        #endregion Model

        public virtual string ToJsonString()
        {
            return new StringBuilder()
                .Append("{")
                .Append("\"MSI_ID\":\"" + this.MSI_ID + "\",")
                .Append("\"MS_ID\":\"" + this.MS_ID + "\",")
                .Append("\"MSI_Item\":\"" + Uri.EscapeDataString(this.MSI_Item) + "\",")
                .Append("\"MSI_Score\":\"" + this.MSI_Score + "\",")
                .Append("\"string1\":\"" + this.string1 + "\"")
                .Append("}")
                .ToString();
        }
    }
}

