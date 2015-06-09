using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// ExamTable:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ExamTable
    {
        public ExamTable()
        { }
        #region Model
        private Guid _e_id;
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
        private int _e_isopenscore = 1;
        private int _e_isopenvideo = 1;
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
        /// 主键，唯一标识
        /// </summary>
        public virtual Guid E_ID
        {
            set { _e_id = value; }
            get { return _e_id; }
        }

       
        /// <summary>
        /// 考试名称
        /// </summary>
        public virtual string E_Name
        {
            set { _e_name = value; }
            get { return _e_name; }
        }
        /// <summary>
        /// 开考时间
        /// </summary>
        public virtual DateTime E_StartTime
        {
            set { _e_starttime = value; }
            get { return _e_starttime; }
        }
        /// <summary>
        /// 考试结束时间
        /// </summary>
        public virtual DateTime? E_EndTime
        {
            set { _e_endtime = value; }
            get { return _e_endtime; }
        }
        /// <summary>
        /// 创建者U_Name
        /// </summary>
        public virtual string E_CreateUser
        {
            set { _e_createuser = value; }
            get { return _e_createuser; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? E_CreateTime
        {
            set { _e_createtime = value; }
            get { return _e_createtime; }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime? E_ModifyTime
        {
            set { _e_modifytime = value; }
            get { return _e_modifytime; }
        }
        /// <summary>
        /// 考试类型（1,、长短站；2、多站式；3、单站式）
        /// </summary>
        public virtual int? E_Kind
        {
            set { _e_kind = value; }
            get { return _e_kind; }
        }
        /// <summary>
        /// 参加考试的组织机构ID的集合
        /// </summary>
        public virtual string E_OID
        {
            set { _e_oid = value; }
            get { return _e_oid; }
        }
        /// <summary>
        /// 参加考试的组ID的集合
        /// </summary>
        public virtual string E_GID
        {
            set { _e_gid = value; }
            get { return _e_gid; }
        }
        /// <summary>
        /// 个别不参加考试的学生的ID集合
        /// </summary>
        public virtual string E_NoStuID
        {
            set { _e_nostuid = value; }
            get { return _e_nostuid; }
        }
        /// <summary>
        /// 长站的考试时长
        /// </summary>
        public virtual int? E_LongStationExamTimeNum
        {
            set { _e_longstationexamtimenum = value; }
            get { return _e_longstationexamtimenum; }
        }
        /// <summary>
        /// 长站的打分时长
        /// </summary>
        public virtual int? E_LongStationScoreTimeNum
        {
            set { _e_longstationscoretimenum = value; }
            get { return _e_longstationscoretimenum; }
        }
        /// <summary>
        /// 短站的考试时长
        /// </summary>
        public virtual int? E_ShortStationExamTimeNum
        {
            set { _e_shortstationexamtimenum = value; }
            get { return _e_shortstationexamtimenum; }
        }
        /// <summary>
        /// 短站的打分时长
        /// </summary>
        public virtual int? E_ShortStationScoreTimeNum
        {
            set { _e_shortstationscoretimenum = value; }
            get { return _e_shortstationscoretimenum; }
        }
        /// <summary>
        /// 考试状态（包含，审批等代码，如：1代表待审批，2代表已审批等）
        /// </summary>
        public virtual int? E_State
        {
            set { _e_state = value; }
            get { return _e_state; }
        }
        /// <summary>
        /// 督考官
        /// </summary>
        public virtual string E_ZadokTheExaminer
        {
            set { _e_zadoktheexaminer = value; }
            get { return _e_zadoktheexaminer; }
        }
        /// <summary>
        /// 是否公开成绩
        /// </summary>
        public virtual int E_IsOpenScore
        {
            set { _e_isopenscore = value; }
            get { return _e_isopenscore; }
        }
        /// <summary>
        /// 是否公开视频
        /// </summary>
        public virtual int E_IsOpenVideo
        {
            set { _e_isopenvideo = value; }
            get { return _e_isopenvideo; }
        }
        /// <summary>
        /// 是否通过审核：0未审核，1已审核，-1已拒绝
        /// </summary>
        public virtual int? int1
        {
            set { _int1 = value; }
            get { return _int1; }
        }
        /// <summary>
        /// 申请人U_ID
        /// </summary>
        public virtual int? int2
        {
            set { _int2 = value; }
            get { return _int2; }
        }
        /// <summary>
        /// 考试业务类型：期中考试，期末考试等，内部保存值为对应具体表的主键
        /// </summary>
        public virtual int? int3
        {
            set { _int3 = value; }
            get { return _int3; }
        }
        /// <summary>
        /// 4月16日范国斌修改此列用于存储考试编号，可以是字母、数字、下划线组成。
        /// </summary>
        public virtual string string1
        {
            set { _string1 = value; }
            get { return _string1; }
        }
        /// <summary>
        /// 8月20日范国斌修改此列用于：适用于长短站，‘1’表示16人制排考，‘2’表示8人制排考
        /// 董阳，2014-09-27，增加枚举值，'1'表示长短站16人制排考，'2'-表示长短站8人制排考，'3'-多站式轮训，'4'-多站式队列
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

        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder()
                .Append(close ? "{" : "")
                .Append("\"E_ID\":\"" + this.E_ID + "\",")
                .Append("\"E_Name\":\"" + Uri.EscapeDataString(this.E_Name) + "\",")
                .Append("\"E_StartTime\":\"" + this.E_StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "\",")
                .Append("\"E_EndTime\":\"" + (this.E_EndTime == null ? "" : Convert.ToDateTime(this.E_EndTime).ToString("yyyy-MM-dd HH:mm:ss")) + "\",")
                .Append("\"E_CreateUser\":\"" + Uri.EscapeDataString(this.E_CreateUser == null ? "" : this.E_CreateUser) + "\",")
                .Append("\"E_CreateTime\":\"" + (this.E_CreateTime == null ? "" : Convert.ToDateTime(this.E_CreateTime).ToString("yyyy-MM-dd HH:mm:ss")) + "\",")
                .Append("\"E_ModifyTime\":\"" + (this.E_ModifyTime == null ? "" : Convert.ToDateTime(this.E_ModifyTime).ToString("yyyy-MM-dd HH:mm:ss")) + "\",")
                .Append("\"E_Kind\":\"" + (this.E_Kind == null ? "" : this.E_Kind.ToString()) + "\",")
                .Append("\"E_OID\":\"" + (this.E_OID == null ? "" : this.E_OID) + "\",")
                .Append("\"E_GID\":\"" + (this.E_GID == null ? "" : this.E_GID) + "\",")
                .Append("\"E_NoStuID\":\"" + (this.E_NoStuID == null ? "" : this.E_NoStuID) + "\",")
                .Append("\"E_LongStationExamTimeNum\":\"" + (this.E_LongStationExamTimeNum == null ? "" : this.E_LongStationExamTimeNum.ToString()) + "\",")
                .Append("\"E_LongStationScoreTimeNum\":\"" + (this.E_LongStationScoreTimeNum == null ? "" : this.E_LongStationScoreTimeNum.ToString()) + "\",")
                .Append("\"E_ShortStationExamTimeNum\":\"" + (this.E_ShortStationExamTimeNum == null ? "" : this.E_ShortStationExamTimeNum.ToString()) + "\",")
                .Append("\"E_ShortStationScoreTimeNum\":\"" + (this.E_ShortStationScoreTimeNum == null ? "" : this.E_ShortStationScoreTimeNum.ToString()) + "\",")
                .Append("\"E_State\":\"" + (this.E_State == null ? "" : this.E_State.ToString()) + "\",")
                .Append("\"E_ZadokTheExaminer\":\"" + Uri.EscapeDataString(this.E_ZadokTheExaminer == null ? "" : this.E_ZadokTheExaminer) + "\",")
                .Append("\"E_IsOpenScore\":\"" + this.E_IsOpenScore + "\",")
                .Append("\"E_IsOpenVideo\":\"" + this.E_IsOpenVideo + "\",")
                .Append("\"int1\":\"" + (this.int1 == null ? "" : this.int1.ToString()) + "\",")
                .Append("\"int2\":\"" + (this.int2 == null ? "" : this.int2.ToString()) + "\",")
                .Append("\"int3\":\"" + (this.int3 == null ? "" : this.int3.ToString()) + "\",")
                .Append("\"string1\":\"" + (this.string1 == null ? "" : Uri.EscapeDataString(this.string1)) + "\",")
                .Append("\"string2\":\"" + (this.string2 == null ? "" : Uri.EscapeDataString(this.string2)) + "\"")
                .Append(close ? "}" : "")
                .ToString();
        }
    }
}
