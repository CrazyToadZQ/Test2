using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 考试用户表
    /// </summary>
    [Serializable]
    public partial class ExamUser
    {
        public ExamUser()
        { }
        #region Model
        private Guid _eu_id;
        private int _eu_issp = 0;
        private int _eu_iszadoktheexaminer = 0;
        private int _eu_isreserve = 0;
        private Guid _e_id;
        private int _u_id;
        private Guid _esr_id;
        private int? _int1;
        private int? _int2;
        private int? _int3;
        private Guid? _string1;
        private string _string2;
        private string _string3;
        private DateTime? _date1;
        private DateTime? _date2;
        private DateTime? _date3;
        private decimal? _float1;
        private decimal? _float2;
        private decimal? _float3;
        /// <summary>
        /// 主键，唯一标识
        /// </summary>
        public virtual Guid EU_ID
        {
            set { _eu_id = value; }
            get { return _eu_id; }
        }
        /// <summary>
        /// 是否是SP
        /// </summary>
        public virtual int EU_ISSP
        {
            set { _eu_issp = value; }
            get { return _eu_issp; }
        }
        /// <summary>
        /// 是否是督考官
        /// </summary>
        public virtual int EU_ISZadokTheExaminer
        {
            set { _eu_iszadoktheexaminer = value; }
            get { return _eu_iszadoktheexaminer; }
        }
        /// <summary>
        /// 是否是后备
        /// </summary>
        public virtual int EU_ISReserve
        {
            set { _eu_isreserve = value; }
            get { return _eu_isreserve; }
        }
        /// <summary>
        /// 外键，链接考试的ID
        /// </summary>
        public virtual Guid E_ID
        {
            set { _e_id = value; }
            get { return _e_id; }
        }
        /// <summary>
        /// 外键链接User的ID
        /// </summary>
        public virtual int U_ID
        {
            set { _u_id = value; }
            get { return _u_id; }
        }
        /// <summary>
        /// 外键，用户表示连接考站房间的ID。
        /// </summary>
        public virtual Guid ESR_ID
        {
            set { _esr_id = value; }
            get { return _esr_id; }
        }
        /// <summary>
        /// 范国斌4月10日修改此列用于表示如果是打分User，那么他所占打分的权重。
        /// </summary>
        public virtual int? int1
        {
            set { _int1 = value; }
            get { return _int1; }
        }
        /// <summary>
        /// 黄志龙4月16日修改此列用于表示评委类型：1-客观评委,2-现场评委,3-远程评委,0-非评委；默认值为0
        /// </summary>
        public virtual int? int2
        {
            set { _int2 = value; }
            get { return _int2; }
        }
        /// <summary>
        /// 董阳，2014-10-21，房间ID（Room_ID）
        /// </summary>
        public virtual int? int3
        {
            set { _int3 = value; }
            get { return _int3; }
        }
        /// <summary>
        /// 董阳，2014-10-21，考站ID（ES_ID）
        /// </summary>
        public virtual Guid? string1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string string2
        {
            set { _string2 = value; }
            get { return _string2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string string3
        {
            set { _string3 = value; }
            get { return _string3; }
        }
        /// <summary>
        /// 
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

        /*
           下方包含属性，范国斌2014-4-28添加，用于存储考站设置中临时显示在页面中的和UserInfo以及评分表的关联信息，方便页面的显示         
         */
        /// <summary>
        /// 临时对象存储，user的用户名
        /// </summary>
        public virtual string UName { get; set; }
        /// <summary>
        /// 临时对象存储，user的真实姓名
        /// </summary>
        public virtual string UTrueName { get; set; }
        /// <summary>
        /// 临时对象存储，user的职称或擅长领域
        /// </summary>
        public virtual string UTitle { get; set; }
        /// <summary>
        /// 临时对象存储，user所关联评分表的个数
        /// </summary>
        public virtual int MarkCount { get; set; }

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
        /// ToJsonString
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"EU_ID\":\"").Append(this.EU_ID.ToString().Trim()).Append("\",")
                .Append("\"EU_ISSP\":\"").Append(this.EU_ISSP).Append("\",")
                .Append("\"EU_ISZadokTheExaminer\":\"").Append(this.EU_ISZadokTheExaminer).Append("\",")
                .Append("\"EU_ISReserve\":\"").Append(this.EU_ISReserve).Append("\",")
                .Append("\"E_ID\":\"").Append(this.E_ID.ToString().Trim()).Append("\",")
                .Append("\"U_ID\":\"").Append(this.U_ID).Append("\",")
                .Append("\"ESR_ID\":\"").Append(this.ESR_ID.ToString().Trim()).Append("\",")
                .Append("\"int1\":\"").Append(this.int1.ToString().Trim()).Append("\",")
                .Append("\"int2\":\"").Append(this.int2.ToString().Trim()).Append("\",")
                .Append("\"int3\":\"").Append(this.int3.ToString().Trim()).Append("\",")
                .Append("\"string1\":\"").Append(this.string1.ToString().Trim()).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }
        
    }
}
