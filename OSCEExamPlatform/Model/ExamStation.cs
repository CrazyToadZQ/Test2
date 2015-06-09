using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// ExamStation:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ExamStation
    {
        public ExamStation()
        { }
        #region Model
        private Guid _es_id;
        private string _es_name;
        private string _es_ccontent;
        private int _es_kind;
        private string _es_curriculum;
        private int _esc_id;
        private Guid _int1;
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
        /// <summary>
        /// 主键，唯一标识
        /// </summary>
        public virtual Guid ES_ID
        {
            set { _es_id = value; }
            get { return _es_id; }
        }
        /// <summary>
        /// 考站名称
        /// </summary>
        public virtual string ES_Name
        {
            set { _es_name = value; }
            get { return _es_name; }
        }
        /// <summary>
        /// 考站描述
        /// </summary>
        public virtual string ES_Ccontent
        {
            set { _es_ccontent = value; }
            get { return _es_ccontent; }
        }
        /// <summary>
        /// 考站类别（1、长站；2、短站）
        /// </summary>
        public virtual int ES_Kind
        {
            set { _es_kind = value; }
            get { return _es_kind; }
        }
        /// <summary>
        /// 考试科目
        /// </summary>
        public virtual string ES_Curriculum
        {
            set { _es_curriculum = value; }
            get { return _es_curriculum; }
        }
        /// <summary>
        /// 外键，考试类别，外联ExamStationClass表的ID
        /// </summary>
        public virtual int ESC_ID
        {
            set { _esc_id = value; }
            get { return _esc_id; }
        }
        /// <summary>
        /// 2014-4-8 范国斌修改此列用于关联外键（ExamTable表的E_ID）
        /// </summary>
        public virtual Guid int1
        {
            set { _int1 = value; }
            get { return _int1; }
        }
        /// <summary>
        /// 2014-4-10 范国斌修改此列用于表示，主客观打分的权重，此列为主观打分权重，显示为百分比的整数，如50%，则此列为50，相对客观权重就是100-50=50；
        /// </summary>
        public virtual int? int2
        {
            set { _int2 = value; }
            get { return _int2; }
        }
        /// <summary>
        /// 董阳，2014-09-26，考站的排序（应用于多站的轮循式和队列式）按照1,2,3,4,5,6……顺序排序考站，单站和长短站可以暂不使用
        /// </summary>
        public virtual int? int3
        {
            set { _int3 = value; }
            get { return _int3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string string1
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
        #endregion Model

        /// <summary>
        /// ToJsonString
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
                .Append("\"ES_ID\":\"").Append(this.ES_ID).Append("\",")
                .Append("\"ES_Name\":\"").Append(Uri.EscapeDataString(this.ES_Name)).Append("\",")
                .Append("\"ES_Ccontent\":\"").Append(this.ES_Ccontent == null ? "" : Uri.EscapeDataString(this.ES_Ccontent)).Append("\",")
                .Append("\"ES_Kind\":\"").Append(this.ES_Kind).Append("\",")
                .Append("\"ES_Curriculum\":\"").Append(Uri.EscapeDataString(this.ES_Curriculum)).Append("\",")
                .Append("\"ESC_ID\":\"").Append(this.ESC_ID).Append("\",")
                .Append("\"int1\":\"").Append(this.int1).Append("\",")
                .Append("\"int2\":\"").Append(this.int2 == null ? "" : this.int2.ToString()).Append("\",")
                .Append("\"int3\":\"").Append(this.int3 == null ? "" : this.int3.ToString()).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }
    }
}
