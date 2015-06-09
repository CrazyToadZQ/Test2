
using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 用户信息表
	/// </summary>
	[Serializable]
    public partial class OSCEExamArrangement_ExamStudent_ExamStationRoom2
    {
        public OSCEExamArrangement_ExamStudent_ExamStationRoom2()
        { }
        #region Model
        private int _oea_id;
        private DateTime _oea_starttime;
        private Guid _esr_id;
        private Guid _estu_id;
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
        private Guid _es_id;
        private int? _expr1;
        private int _room_id;
        private int? _expr2;
        private int? _expr3;
        private string _expr4;
        private string _expr5;
        private string _expr6;
        private DateTime? _expr7;
        private DateTime? _expr8;
        private DateTime? _expr9;
        private decimal? _expr10;
        private decimal? _expr11;
        private decimal? _float3;
        private int _u_id;
        private Guid _e_id;
        private int _estu_examnumber;
        private int? _estu_int;
        private string _estu_string;
        private bool _estu_bool;
        /// <summary>
        /// 
        /// </summary>
        public int OEA_ID
        {
            set { _oea_id = value; }
            get { return _oea_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OEA_StartTime
        {
            set { _oea_starttime = value; }
            get { return _oea_starttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid ESR_ID
        {
            set { _esr_id = value; }
            get { return _esr_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid EStu_ID
        {
            set { _estu_id = value; }
            get { return _estu_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OEA_EndTime
        {
            set { _oea_endtime = value; }
            get { return _oea_endtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? int1
        {
            set { _int1 = value; }
            get { return _int1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? int2
        {
            set { _int2 = value; }
            get { return _int2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? int3
        {
            set { _int3 = value; }
            get { return _int3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string string1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string string2
        {
            set { _string2 = value; }
            get { return _string2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string string3
        {
            set { _string3 = value; }
            get { return _string3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? date1
        {
            set { _date1 = value; }
            get { return _date1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? date2
        {
            set { _date2 = value; }
            get { return _date2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? date3
        {
            set { _date3 = value; }
            get { return _date3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? float1
        {
            set { _float1 = value; }
            get { return _float1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? float2
        {
            set { _float2 = value; }
            get { return _float2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid ES_ID
        {
            set { _es_id = value; }
            get { return _es_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Expr1
        {
            set { _expr1 = value; }
            get { return _expr1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Room_ID
        {
            set { _room_id = value; }
            get { return _room_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Expr2
        {
            set { _expr2 = value; }
            get { return _expr2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Expr3
        {
            set { _expr3 = value; }
            get { return _expr3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Expr4
        {
            set { _expr4 = value; }
            get { return _expr4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Expr5
        {
            set { _expr5 = value; }
            get { return _expr5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Expr6
        {
            set { _expr6 = value; }
            get { return _expr6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Expr7
        {
            set { _expr7 = value; }
            get { return _expr7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Expr8
        {
            set { _expr8 = value; }
            get { return _expr8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Expr9
        {
            set { _expr9 = value; }
            get { return _expr9; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Expr10
        {
            set { _expr10 = value; }
            get { return _expr10; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Expr11
        {
            set { _expr11 = value; }
            get { return _expr11; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? float3
        {
            set { _float3 = value; }
            get { return _float3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int U_ID
        {
            set { _u_id = value; }
            get { return _u_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid E_ID
        {
            set { _e_id = value; }
            get { return _e_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EStu_ExamNumber
        {
            set { _estu_examnumber = value; }
            get { return _estu_examnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? EStu_int
        {
            set { _estu_int = value; }
            get { return _estu_int; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EStu_string
        {
            set { _estu_string = value; }
            get { return _estu_string; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool EStu_bool
        {
            set { _estu_bool = value; }
            get { return _estu_bool; }
        }
        #endregion Model

    }
}

