using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// ExamUserExamTableView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ExamUserExamTableView
    {
        public ExamUserExamTableView()
        { }
        #region Model
        private int _e_id;
        private string _e_name;
        private DateTime _e_starttime;
        private DateTime? _e_endtime;
        private string _e_createuser;
        private DateTime? _e_createtime;
        private DateTime? _e_modifytime;
        private int? _e_kind;
        private string _e_oid;
        private string _e_gid;
        private string _e_nostuid;
        private int? _e_longstationexamtimenum;
        private int? _e_longstationscoretimenum;
        private int? _e_shortstationexamtimenum;
        private int? _e_shortstationscoretimenum;
        private int? _e_state;
        private string _e_zadoktheexaminer;
        private int _e_isopenscore;
        private int _e_isopenvideo;
        private int? _examtableint1;
        private int? _examtableint2;
        private int? _examtableint3;
        private string _examtablestring1;
        private string _examtablestring2;
        private string _examtablestring3;
        private DateTime? _examtabledate1;
        private DateTime? _examtabledate2;
        private DateTime? _examtabledate3;
        private decimal? _examtablefloat1;
        private decimal? _examtablefloat2;
        private decimal? _examtablefloat3;
        private int _eu_issp;
        private int _eu_iszadoktheexaminer;
        private int _eu_isreserve;
        private int _eu_id;
        private int _u_id;
        private int _esr_id;
        private int? _examuserint1;
        private int? _examuserint2;
        private int? _examuserint3;
        private string _examuserstring1;
        private string _examuserstring2;
        private string _examuserstring3;
        private DateTime? _examuserdate1;
        private DateTime? _examuserdate2;
        private DateTime? _examuserdate3;
        private decimal? _examuserfloat1;
        private decimal? _examuserfloat2;
        private decimal? _examuserfloat3;
        /// <summary>
        /// 
        /// </summary>
        public int E_ID
        {
            set { _e_id = value; }
            get { return _e_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_Name
        {
            set { _e_name = value; }
            get { return _e_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime E_StartTime
        {
            set { _e_starttime = value; }
            get { return _e_starttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? E_EndTime
        {
            set { _e_endtime = value; }
            get { return _e_endtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_CreateUser
        {
            set { _e_createuser = value; }
            get { return _e_createuser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? E_CreateTime
        {
            set { _e_createtime = value; }
            get { return _e_createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? E_ModifyTime
        {
            set { _e_modifytime = value; }
            get { return _e_modifytime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? E_Kind
        {
            set { _e_kind = value; }
            get { return _e_kind; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_OID
        {
            set { _e_oid = value; }
            get { return _e_oid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_GID
        {
            set { _e_gid = value; }
            get { return _e_gid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_NoStuID
        {
            set { _e_nostuid = value; }
            get { return _e_nostuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? E_LongStationExamTimeNum
        {
            set { _e_longstationexamtimenum = value; }
            get { return _e_longstationexamtimenum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? E_LongStationScoreTimeNum
        {
            set { _e_longstationscoretimenum = value; }
            get { return _e_longstationscoretimenum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? E_ShortStationExamTimeNum
        {
            set { _e_shortstationexamtimenum = value; }
            get { return _e_shortstationexamtimenum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? E_ShortStationScoreTimeNum
        {
            set { _e_shortstationscoretimenum = value; }
            get { return _e_shortstationscoretimenum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? E_State
        {
            set { _e_state = value; }
            get { return _e_state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_ZadokTheExaminer
        {
            set { _e_zadoktheexaminer = value; }
            get { return _e_zadoktheexaminer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int E_IsOpenScore
        {
            set { _e_isopenscore = value; }
            get { return _e_isopenscore; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int E_IsOpenVideo
        {
            set { _e_isopenvideo = value; }
            get { return _e_isopenvideo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamTableInt1
        {
            set { _examtableint1 = value; }
            get { return _examtableint1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamTableInt2
        {
            set { _examtableint2 = value; }
            get { return _examtableint2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamTableInt3
        {
            set { _examtableint3 = value; }
            get { return _examtableint3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamTableString1
        {
            set { _examtablestring1 = value; }
            get { return _examtablestring1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamTableString2
        {
            set { _examtablestring2 = value; }
            get { return _examtablestring2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamTableString3
        {
            set { _examtablestring3 = value; }
            get { return _examtablestring3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamTableDate1
        {
            set { _examtabledate1 = value; }
            get { return _examtabledate1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamTableDate2
        {
            set { _examtabledate2 = value; }
            get { return _examtabledate2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamTableDate3
        {
            set { _examtabledate3 = value; }
            get { return _examtabledate3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamTableFloat1
        {
            set { _examtablefloat1 = value; }
            get { return _examtablefloat1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamTableFloat2
        {
            set { _examtablefloat2 = value; }
            get { return _examtablefloat2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamTableFloat3
        {
            set { _examtablefloat3 = value; }
            get { return _examtablefloat3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EU_ISSP
        {
            set { _eu_issp = value; }
            get { return _eu_issp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EU_ISZadokTheExaminer
        {
            set { _eu_iszadoktheexaminer = value; }
            get { return _eu_iszadoktheexaminer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EU_ISReserve
        {
            set { _eu_isreserve = value; }
            get { return _eu_isreserve; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int EU_ID
        {
            set { _eu_id = value; }
            get { return _eu_id; }
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
        public int ESR_ID
        {
            set { _esr_id = value; }
            get { return _esr_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamUserInt1
        {
            set { _examuserint1 = value; }
            get { return _examuserint1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamUserInt2
        {
            set { _examuserint2 = value; }
            get { return _examuserint2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamUserInt3
        {
            set { _examuserint3 = value; }
            get { return _examuserint3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamUserString1
        {
            set { _examuserstring1 = value; }
            get { return _examuserstring1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamUserString2
        {
            set { _examuserstring2 = value; }
            get { return _examuserstring2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamUserString3
        {
            set { _examuserstring3 = value; }
            get { return _examuserstring3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamUserDate1
        {
            set { _examuserdate1 = value; }
            get { return _examuserdate1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamUserDate2
        {
            set { _examuserdate2 = value; }
            get { return _examuserdate2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamUserDate3
        {
            set { _examuserdate3 = value; }
            get { return _examuserdate3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamUserFloat1
        {
            set { _examuserfloat1 = value; }
            get { return _examuserfloat1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamUserFloat2
        {
            set { _examuserfloat2 = value; }
            get { return _examuserfloat2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamUserFloat3
        {
            set { _examuserfloat3 = value; }
            get { return _examuserfloat3; }
        }
        #endregion Model

    }
}
