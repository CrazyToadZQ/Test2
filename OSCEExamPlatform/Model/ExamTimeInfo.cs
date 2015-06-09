using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// ExamTimeInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ExamTimeInfo
    {
        public ExamTimeInfo()
        { }
        #region Model

        private int _eti_id;
        private string _eti_starttime;
        private string _eti_endtime;
        private Guid _e_id;
        private int? _int1;
        private string _string1;

        /// <summary>
        /// ETI_ID
        /// </summary>		
        public virtual int ETI_ID
        {
            get { return _eti_id; }
            set { _eti_id = value; }
        }
        /// <summary>
        /// 考试有效时间段开始时间
        /// </summary>		
        public virtual string ETI_StartTime
        {
            get { return _eti_starttime; }
            set { _eti_starttime = value; }
        }
        /// <summary>
        /// 考试有效时间段结束时间
        /// </summary>		
        public virtual string ETI_EndTime
        {
            get { return _eti_endtime; }
            set { _eti_endtime = value; }
        }
        /// <summary>
        /// 考试ID（E_ID）
        /// </summary>		
        public virtual Guid E_ID
        {
            get { return _e_id; }
            set { _e_id = value; }
        }
        /// <summary>
        /// 董阳，2014-09-10，存储考试有效时间段范围内可容纳的考生数量
        /// </summary>		
        public virtual int? int1
        {
            get { return _int1; }
            set { _int1 = value; }
        }
        /// <summary>
        /// int2
        /// </summary>		
        private int? _int2;
        public virtual int? int2
        {
            get { return _int2; }
            set { _int2 = value; }
        }
        /// <summary>
        /// int3
        /// </summary>		
        private int? _int3;
        public virtual int? int3
        {
            get { return _int3; }
            set { _int3 = value; }
        }
        /// <summary>
        /// 董阳，2014-09-10，存储考试有效时间的日期部分，格式：yyyy-MM-dd
        /// </summary>		
        public virtual string string1
        {
            get { return _string1; }
            set { _string1 = value; }
        }
        /// <summary>
        /// string2
        /// </summary>		
        private string _string2;
        public virtual string string2
        {
            get { return _string2; }
            set { _string2 = value; }
        }
        /// <summary>
        /// string3
        /// </summary>		
        private string _string3;
        public virtual string string3
        {
            get { return _string3; }
            set { _string3 = value; }
        }
        /// <summary>
        /// date1
        /// </summary>		
        private DateTime? _date1;
        public virtual DateTime? date1
        {
            get { return _date1; }
            set { _date1 = value; }
        }
        /// <summary>
        /// date2
        /// </summary>		
        private DateTime? _date2;
        public virtual DateTime? date2
        {
            get { return _date2; }
            set { _date2 = value; }
        }
        /// <summary>
        /// date3
        /// </summary>		
        private DateTime? _date3;
        public virtual DateTime? date3
        {
            get { return _date3; }
            set { _date3 = value; }
        }
        /// <summary>
        /// float1
        /// </summary>		
        private decimal? _float1;
        public virtual decimal? float1
        {
            get { return _float1; }
            set { _float1 = value; }
        }
        /// <summary>
        /// float2
        /// </summary>		
        private decimal? _float2;
        public virtual decimal? float2
        {
            get { return _float2; }
            set { _float2 = value; }
        }
        /// <summary>
        /// float3
        /// </summary>		
        private decimal? _float3;
        public virtual decimal? float3
        {
            get { return _float3; }
            set { _float3 = value; }
        }
        #endregion Model

    }
}
