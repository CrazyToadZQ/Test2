using System;
namespace Tellyes.Model
{
    /// <summary>
    /// MarkSheetKind:评分表类型
    /// </summary>
    [Serializable]
    public partial class MarkSheetKind
    {
        public MarkSheetKind()
        { }
        #region Model
        private int _msk_id;
        private string _msk_kind;
        private string _string1;
        private string _string2;
        private string _string3;
        /// <summary>
        /// 主键，标志位
        /// </summary>
        public virtual int MSK_ID
        {
            set { _msk_id = value; }
            get { return _msk_id; }
        }
        /// <summary>
        /// 类型
        /// </summary>
        public virtual string MSK_Kind
        {
            set { _msk_kind = value; }
            get { return _msk_kind; }
        }
        /// <summary>
        /// 逻辑删除列（1-目前还存在，0-已经删除）
        /// </summary>
        public virtual string string1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 是否是系统自带评分表类别（1-是系统自带，0-不是系统自带）
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


        /// <summary>
        ///  model To Json 转换方法， 如果其他预留字段需要使用，则需要扩展该方法，2014-5-21 陶东利
        /// </summary>
        /// <returns></returns>

        public virtual string ToJsonString()
        {
            string jsonString = "{";
            jsonString += "\"MSK_ID\":\"" + this.MSK_ID + "\",";
            jsonString += "\"MSK_Kind\":\"" + Uri.EscapeDataString(this.MSK_Kind) + "\",";
            jsonString += "\"string1\":\"" + this.string1 + "\",";
            jsonString += "\"string2\":\"" + this.string2 + "\"";
            jsonString += "}";
            return jsonString;

        }

    }
}

