using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 长短站式排考表
    /// </summary>
    [Serializable]
    public partial class OSCEExaminationArrangement
    {
        public OSCEExaminationArrangement()
        { }
        #region Model
        private int _oea_id;
        private Guid _estu_id;
        private Guid _esr_id;
        private DateTime _oea_starttime;
        private DateTime _oea_endtime;
        private int? _int1;
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
        /// 
        /// </summary>
        public virtual int OEA_ID
        {
            set { _oea_id = value; }
            get { return _oea_id; }
        }
        /// <summary>
        /// 外键，关联ExamStudent表的ID
        /// </summary>
        public virtual Guid EStu_ID
        {
            set { _estu_id = value; }
            get { return _estu_id; }
        }
        /// <summary>
        /// 外键，关联ExamStation_Room表的主键标识
        /// </summary>
        public virtual Guid ESR_ID
        {
            set { _esr_id = value; }
            get { return _esr_id; }
        }
        /// <summary>
        /// 进入该考站的开始考试时间
        /// </summary>
        public virtual DateTime OEA_StartTime
        {
            set { _oea_starttime = value; }
            get { return _oea_starttime; }
        }
        /// <summary>
        /// 考试结束时间
        /// </summary>
        public virtual DateTime OEA_EndTime
        {
            set { _oea_endtime = value; }
            get { return _oea_endtime; }
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

        private Guid? _e_id;
        /// <summary>
        /// 
        /// </summary>
        public virtual Guid? E_ID
        {
            set { _e_id = value; }
            get { return _e_id; }
        }

        private Guid? _es_id;
        /// <summary>
        /// 
        /// </summary>
        public virtual Guid? ES_ID
        {
            set { _es_id = value; }
            get { return _es_id; }
        }

        private int? _room_id;
        /// <summary>
        /// 
        /// </summary>
        public virtual int? Room_ID
        {
            set { _room_id = value; }
            get { return _room_id; }
        }

        private int? _u_id;
        /// <summary>
        /// 
        /// </summary>
        public virtual int? U_ID
        {
            set { _u_id = value; }
            get { return _u_id; }
        }

        #endregion Model

    }
}
