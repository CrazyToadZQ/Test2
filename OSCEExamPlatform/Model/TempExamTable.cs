using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class TempExamTable
    {
        #region Model

        /// <summary>
        /// 临时考试信息ID
        /// </summary>		
        private Guid _tempexamtableid;
        public virtual Guid TempExamTableID
        {
            get { return _tempexamtableid; }
            set { _tempexamtableid = value; }
        }
        /// <summary>
        /// 考试名称
        /// </summary>		
        private string _tempexamname;
        public virtual string TempExamName
        {
            get { return _tempexamname; }
            set { _tempexamname = value; }
        }
        /// <summary>
        /// 考试模式（1-长短站，2-多站式，3-单站式）
        /// </summary>		
        private int _tempexamkind;
        public virtual int TempExamKind
        {
            get { return _tempexamkind; }
            set { _tempexamkind = value; }
        }
        /// <summary>
        /// 考试类型ID
        /// </summary>		
        private int? _examclassid;
        public virtual int? ExamClassID
        {
            get { return _examclassid; }
            set { _examclassid = value; }
        }
        /// <summary>
        /// 已选择的考生数量
        /// </summary>		
        private int? _tempexamstudentcount;
        public virtual int? TempExamStudentCount
        {
            get { return _tempexamstudentcount; }
            set { _tempexamstudentcount = value; }
        }
        /// <summary>
        /// 已设置的考站数量
        /// </summary>		
        private int? _tempexamstationcount;
        public virtual int? TempExamStationCount
        {
            get { return _tempexamstationcount; }
            set { _tempexamstationcount = value; }
        }
        /// <summary>
        /// 已设置的考站房间数量
        /// </summary>		
        private int? _tempexamroomcount;
        public virtual int? TempExamRoomCount
        {
            get { return _tempexamroomcount; }
            set { _tempexamroomcount = value; }
        }
        /// <summary>
        /// 考试开始时间
        /// </summary>		
        private DateTime? _tempexamstarttime;
        public virtual DateTime? TempExamStartTime
        {
            get { return _tempexamstarttime; }
            set { _tempexamstarttime = value; }
        }
        /// <summary>
        /// 考试结束时间
        /// </summary>		
        private DateTime? _tempexamendtime;
        public virtual DateTime? TempExamEndTime
        {
            get { return _tempexamendtime; }
            set { _tempexamendtime = value; }
        }
        /// <summary>
        /// 长站考试时间（分钟数），当考试为多站或单站时，为考站的考试时间（分钟数）
        /// </summary>		
        private int _tempexamlongexamminute;
        public virtual int TempExamLongExamMinute
        {
            get { return _tempexamlongexamminute; }
            set { _tempexamlongexamminute = value; }
        }
        /// <summary>
        /// 长站打分时间（分钟数），当考试为多站或单站时，为考站的打分时间（分钟数）
        /// </summary>		
        private int _tempexamlongscoreminute;
        public virtual int TempExamLongScoreMinute
        {
            get { return _tempexamlongscoreminute; }
            set { _tempexamlongscoreminute = value; }
        }
        /// <summary>
        /// 短站考试时间（分钟数），当考试为多站或单站时，不需要此字段，设置为0即可
        /// </summary>		
        private int _tempexamshortexamminute;
        public virtual int TempExamShortExamMinute
        {
            get { return _tempexamshortexamminute; }
            set { _tempexamshortexamminute = value; }
        }
        /// <summary>
        /// 短站打分时间（分钟数），当考试为多站或单站时，不需要此字段，设置为0即可
        /// </summary>		
        private int _tempexamshortscoreminute;
        public virtual int TempExamShortScoreMinute
        {
            get { return _tempexamshortscoreminute; }
            set { _tempexamshortscoreminute = value; }
        }
        /// <summary>
        /// 考试成绩公开标示，1-考试成绩公开，0-考试成绩不公开
        /// </summary>		
        private int _tempexamisopenscore;
        public virtual int TempExamIsOpenScore
        {
            get { return _tempexamisopenscore; }
            set { _tempexamisopenscore = value; }
        }
        /// <summary>
        /// 考试视频公开标示，1-考试视频公开，0-考试视频不公开
        /// </summary>		
        private int? _tempexamisopenvideo;
        public virtual int? TempExamIsOpenVideo
        {
            get { return _tempexamisopenvideo; }
            set { _tempexamisopenvideo = value; }
        }
        /// <summary>
        /// 考试信息设置完整标示，1-考试信息完整，0-考试信息不完整
        /// </summary>		
        private int? _tempexamiscomplete;
        public virtual int? TempExamIsComplete
        {
            get { return _tempexamiscomplete; }
            set { _tempexamiscomplete = value; }
        }
        /// <summary>
        /// 考试状态，0-编辑中，1-申请中，2-申请未通过，3-申请已通过
        /// </summary>		
        private int _tempexamstate;
        public virtual int TempExamState
        {
            get { return _tempexamstate; }
            set { _tempexamstate = value; }
        }
        /// <summary>
        /// 考试创建时间
        /// </summary>		
        private DateTime _tempexamcreatetime;
        public virtual DateTime TempExamCreateTime
        {
            get { return _tempexamcreatetime; }
            set { _tempexamcreatetime = value; }
        }
        /// <summary>
        /// 考试最近修改时间
        /// </summary>		
        private DateTime? _tempexamlastmodifytime;
        public virtual DateTime? TempExamLastModifyTime
        {
            get { return _tempexamlastmodifytime; }
            set { _tempexamlastmodifytime = value; }
        }
        /// <summary>
        /// 创建考试的用户ID
        /// </summary>		
        private int _tempexamuserinfoid;
        public virtual int TempExamUserInfoID
        {
            get { return _tempexamuserinfoid; }
            set { _tempexamuserinfoid = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// 董阳，2014-08-27，考试模式二级分类（1-多站试轮循，2-多站试队列，3-长短站8人制，4-长短站16人制）
        /// </summary>		
        private int? _tempexamnumber1;
        public virtual int? TempExamNumber1
        {
            get { return _tempexamnumber1; }
            set { _tempexamnumber1 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamnumber2;
        public virtual int? TempExamNumber2
        {
            get { return _tempexamnumber2; }
            set { _tempexamnumber2 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamnumber3;
        public virtual int? TempExamNumber3
        {
            get { return _tempexamnumber3; }
            set { _tempexamnumber3 = value; }
        }
        /// <summary>
        /// 预留字段，长整型
        /// </summary>		
        private long? _tempexamnumber4;
        public virtual long? TempExamNumber4
        {
            get { return _tempexamnumber4; }
            set { _tempexamnumber4 = value; }
        }
        /// <summary>
        /// 预留字段，长整型
        /// </summary>		
        private long? _tempexamnumber5;
        public virtual long? TempExamNumber5
        {
            get { return _tempexamnumber5; }
            set { _tempexamnumber5 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamnumber6;
        public virtual decimal? TempExamNumber6
        {
            get { return _tempexamnumber6; }
            set { _tempexamnumber6 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamnumber7;
        public virtual decimal? TempExamNumber7
        {
            get { return _tempexamnumber7; }
            set { _tempexamnumber7 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamnumber8;
        public virtual decimal? TempExamNumber8
        {
            get { return _tempexamnumber8; }
            set { _tempexamnumber8 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamnumber9;
        public virtual decimal? TempExamNumber9
        {
            get { return _tempexamnumber9; }
            set { _tempexamnumber9 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度50
        /// </summary>		
        private string _tempexamstring1;
        public virtual string TempExamString1
        {
            get { return _tempexamstring1; }
            set { _tempexamstring1 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度50
        /// </summary>		
        private string _tempexamstring2;
        public virtual string TempExamString2
        {
            get { return _tempexamstring2; }
            set { _tempexamstring2 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度200
        /// </summary>		
        private string _tempexamstring3;
        public virtual string TempExamString3
        {
            get { return _tempexamstring3; }
            set { _tempexamstring3 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度200
        /// </summary>		
        private string _tempexamstring4;
        public virtual string TempExamString4
        {
            get { return _tempexamstring4; }
            set { _tempexamstring4 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度500
        /// </summary>		
        private string _tempexamstring5;
        public virtual string TempExamString5
        {
            get { return _tempexamstring5; }
            set { _tempexamstring5 = value; }
        }
        /// <summary>
        /// 董阳，2014-09-16，存储考试信息不完整时的提示信息
        /// </summary>		
        private string _tempexamstring6;
        public virtual string TempExamString6
        {
            get { return _tempexamstring6; }
            set { _tempexamstring6 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2000
        /// </summary>		
        private string _tempexamstring7;
        public virtual string TempExamString7
        {
            get { return _tempexamstring7; }
            set { _tempexamstring7 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度4000
        /// </summary>		
        private string _tempexamstring8;
        public virtual string TempExamString8
        {
            get { return _tempexamstring8; }
            set { _tempexamstring8 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
        private string _tempexamstring9;
        public virtual string TempExamString9
        {
            get { return _tempexamstring9; }
            set { _tempexamstring9 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdatetime1;
        public virtual DateTime? TempExamDatetime1
        {
            get { return _tempexamdatetime1; }
            set { _tempexamdatetime1 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdatetime2;
        public virtual DateTime? TempExamDatetime2
        {
            get { return _tempexamdatetime2; }
            set { _tempexamdatetime2 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdatetime3;
        public virtual DateTime? TempExamDatetime3
        {
            get { return _tempexamdatetime3; }
            set { _tempexamdatetime3 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdatetime4;
        public virtual DateTime? TempExamDatetime4
        {
            get { return _tempexamdatetime4; }
            set { _tempexamdatetime4 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdatetime5;
        public virtual DateTime? TempExamDatetime5
        {
            get { return _tempexamdatetime5; }
            set { _tempexamdatetime5 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamdatetime6;
        public virtual DateTime? TempExamDatetime6
        {
            get { return _tempexamdatetime6; }
            set { _tempexamdatetime6 = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamTable()
            : this(default(Guid))
        {
            
        }

        /// <summary>
        /// 仅使用Guid构造对象
        /// </summary>
        /// <param name="tempExamTableID"></param>
        public TempExamTable(Guid tempExamTableID)
        {
            this.TempExamTableID = tempExamTableID;
        }

        #endregion

        #region ToJsonString

        /// <summary>
        /// 返回对象的闭合Json字符串
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

         /// <summary>
         /// 根据参数返回对象的Json字符创
         /// </summary>
         /// <param name="close"></param>
         /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID).Append("\",")
                .Append("\"TempExamName\":\"").Append(Uri.EscapeDataString(this.TempExamName)).Append("\",")
                .Append("\"TempExamKind\":\"").Append(this.TempExamKind).Append("\",")
                .Append("\"ExamClassID\":\"").Append(this.ExamClassID == null ? "" : this.ExamClassID.ToString()).Append("\",")
                .Append("\"TempExamStudentCount\":\"").Append(this.TempExamStudentCount == null ? "" : this.TempExamStudentCount.ToString()).Append("\",")
                .Append("\"TempExamStationCount\":\"").Append(this.TempExamStationCount == null ? "" : this.TempExamStationCount.ToString()).Append("\",")
                .Append("\"TempExamRoomCount\":\"").Append(this.TempExamRoomCount == null ? "" : this.TempExamRoomCount.ToString()).Append("\",")
                .Append("\"TempExamStartTime\":\"").Append(this.TempExamStartTime == null ? "" : Convert.ToDateTime(this.TempExamStartTime).ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"TempExamEndTime\":\"").Append(this.TempExamEndTime == null ? "" : Convert.ToDateTime(this.TempExamEndTime).ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"TempExamLongExamMinute\":\"").Append(this.TempExamLongExamMinute).Append("\",")
                .Append("\"TempExamLongScoreMinute\":\"").Append(this.TempExamLongScoreMinute).Append("\",")
                .Append("\"TempExamShortExamMinute\":\"").Append(this.TempExamShortExamMinute).Append("\",")
                .Append("\"TempExamShortScoreMinute\":\"").Append(this.TempExamShortScoreMinute).Append("\",")
                .Append("\"TempExamIsOpenScore\":\"").Append(this.TempExamIsOpenScore).Append("\",")
                .Append("\"TempExamIsOpenVideo\":\"").Append(this.TempExamIsOpenVideo == null ? "" : this.TempExamIsOpenVideo.ToString()).Append("\",")
                .Append("\"TempExamIsComplete\":\"").Append(this.TempExamIsComplete == null ? "" : this.TempExamIsComplete.ToString()).Append("\",")
                .Append("\"TempExamState\":\"").Append(this.TempExamState).Append("\",")
                .Append("\"TempExamCreateTime\":\"").Append(this.TempExamCreateTime == null ? "" : Convert.ToDateTime(this.TempExamCreateTime).ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"TempExamLastModifyTime\":\"").Append(this.TempExamLastModifyTime == null ? "" : Convert.ToDateTime(this.TempExamLastModifyTime).ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"TempExamUserInfoID\":\"").Append(this.TempExamUserInfoID).Append("\",")
                .Append("\"TempExamNumber1\":\"").Append(this.TempExamNumber1 == null ? "" : Convert.ToInt32(this.TempExamNumber1).ToString()).Append("\",")
                .Append("\"TempExamString6\":\"").Append(this.TempExamString6 == null ? "" : Uri.EscapeDataString(this.TempExamString6)).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
