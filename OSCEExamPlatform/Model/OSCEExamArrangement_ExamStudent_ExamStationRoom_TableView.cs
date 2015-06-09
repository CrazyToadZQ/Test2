using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView
    {
        public OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView()
        { }
        #region Model
        private int _u_id;
        private Guid _e_id;
        private int _estu_examnumber;
        private int? _estu_int;
        private string _estu_string;
        private bool _estu_bool;
        private int _oea_id;
        private Guid _estu_id;
        private Guid _esr_id;
        private DateTime _oea_starttime;
        private DateTime _oea_endtime;
        private int? _osceexamint1;
        private int? _osceexamint2;
        private int? _osceexamint3;
        private string _osceexamstring1;
        private string _osceexamstring2;
        private string _osceexamstring3;
        private DateTime? _osceexamdate1;
        private DateTime? _osceexamdate2;
        private DateTime? _osceexamdate3;
        private decimal? _osceexamfloat1;
        private decimal? _osceexamfloat2;
        private decimal? _osceexamfloat3;
        private Guid _es_id;
        private int _room_id;
        private int? _examstationroomint1;
        private int? _examstationroomint2;
        private int? _examstationroomint3;
        private string _examstationroomstring1;
        private string _examstationroomstring2;
        private string _examstationroomstring3;
        private DateTime? _examstationroomdate1;
        private DateTime? _examstationroomdate2;
        private DateTime? _examstationroomdate3;
        private decimal? _examstationroomfloat1;
        private decimal? _examstationroomfloat2;
        private decimal? _examstationroomfloat3;
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
        public Guid EStu_ID
        {
            set { _estu_id = value; }
            get { return _estu_id; }
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
        public DateTime OEA_StartTime
        {
            set { _oea_starttime = value; }
            get { return _oea_starttime; }
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
        public int? OSCEExamInt1
        {
            set { _osceexamint1 = value; }
            get { return _osceexamint1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OSCEExamInt2
        {
            set { _osceexamint2 = value; }
            get { return _osceexamint2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OSCEExamInt3
        {
            set { _osceexamint3 = value; }
            get { return _osceexamint3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OSCEExamString1
        {
            set { _osceexamstring1 = value; }
            get { return _osceexamstring1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OSCEExamString2
        {
            set { _osceexamstring2 = value; }
            get { return _osceexamstring2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OSCEExamString3
        {
            set { _osceexamstring3 = value; }
            get { return _osceexamstring3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? OSCEExamDate1
        {
            set { _osceexamdate1 = value; }
            get { return _osceexamdate1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? OSCEExamDate2
        {
            set { _osceexamdate2 = value; }
            get { return _osceexamdate2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? OSCEExamDate3
        {
            set { _osceexamdate3 = value; }
            get { return _osceexamdate3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OSCEExamFloat1
        {
            set { _osceexamfloat1 = value; }
            get { return _osceexamfloat1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OSCEExamFloat2
        {
            set { _osceexamfloat2 = value; }
            get { return _osceexamfloat2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OSCEExamFloat3
        {
            set { _osceexamfloat3 = value; }
            get { return _osceexamfloat3; }
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
        public int Room_ID
        {
            set { _room_id = value; }
            get { return _room_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamStationRoomInt1
        {
            set { _examstationroomint1 = value; }
            get { return _examstationroomint1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamStationRoomInt2
        {
            set { _examstationroomint2 = value; }
            get { return _examstationroomint2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExamStationRoomInt3
        {
            set { _examstationroomint3 = value; }
            get { return _examstationroomint3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamStationRoomString1
        {
            set { _examstationroomstring1 = value; }
            get { return _examstationroomstring1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamStationRoomString2
        {
            set { _examstationroomstring2 = value; }
            get { return _examstationroomstring2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExamStationRoomString3
        {
            set { _examstationroomstring3 = value; }
            get { return _examstationroomstring3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamStationRoomDate1
        {
            set { _examstationroomdate1 = value; }
            get { return _examstationroomdate1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamStationRoomDate2
        {
            set { _examstationroomdate2 = value; }
            get { return _examstationroomdate2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExamStationRoomDate3
        {
            set { _examstationroomdate3 = value; }
            get { return _examstationroomdate3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamStationRoomFloat1
        {
            set { _examstationroomfloat1 = value; }
            get { return _examstationroomfloat1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamStationRoomFloat2
        {
            set { _examstationroomfloat2 = value; }
            get { return _examstationroomfloat2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExamStationRoomFloat3
        {
            set { _examstationroomfloat3 = value; }
            get { return _examstationroomfloat3; }
        }
        #endregion Model

    }
}
