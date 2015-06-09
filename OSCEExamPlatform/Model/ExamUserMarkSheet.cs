using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 考试用户与评分表关联表
    /// </summary>
    [Serializable]
    public partial class ExamUserMarkSheet
    {
        public ExamUserMarkSheet()
        { }
        #region Model
        private int _eums_id;
        private Guid _eu_id;
        private int _ms_id;
        private int? _int1;
        private Guid _int2;
        private int? _int3;
        private Guid? _string1;
        private Guid? _string2;
        private string _string3;
        private DateTime? _date1;
        private DateTime? _date2;
        private DateTime? _date3;
        private decimal? _float1;
        private decimal? _float2;
        private decimal? _float3;
        /// <summary>
        /// 
        /// </summary>
        public virtual int EUMS_ID
        {
            set { _eums_id = value; }
            get { return _eums_id; }
        }
        /// <summary>
        /// 考试用户表的ID
        /// </summary>
        public virtual Guid EU_ID
        {
            set { _eu_id = value; }
            get { return _eu_id; }
        }
        /// <summary>
        /// 评分表ID
        /// </summary>
        public virtual int MS_ID
        {
            set { _ms_id = value; }
            get { return _ms_id; }
        }
        /// <summary>
        /// U_ID
        /// </summary>
        public virtual int? int1
        {
            set { _int1 = value; }
            get { return _int1; }
        }
        /// <summary>
        /// ES_ID
        /// </summary>
        public virtual Guid int2
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
        /// 董阳，2014-10-21，考试ID（E_ID）
        /// </summary>
        public virtual Guid? string1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 董阳，2014-10-21，考试房间ID（ESR_ID）
        /// </summary>
        public virtual Guid? string2
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

    }
}
