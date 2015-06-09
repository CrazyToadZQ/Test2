using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class TempExamStation
    {
        #region Model

        /// <summary>
        /// 临时考试考站ID
        /// </summary>		
        private Guid _tempexamstationid;
        public virtual Guid TempExamStationID
        {
            get { return _tempexamstationid; }
            set { _tempexamstationid = value; }
        }
        /// <summary>
        /// 临时考试ID
        /// </summary>		
        private Guid _tempexamtableid;
        public virtual Guid TempExamTableID
        {
            get { return _tempexamtableid; }
            set { _tempexamtableid = value; }
        }
        /// <summary>
        /// 考站类型ID
        /// </summary>		
        private int _examstationclassid;
        public virtual int ExamStationClassID
        {
            get { return _examstationclassid; }
            set { _examstationclassid = value; }
        }
        /// <summary>
        /// 考站名称
        /// </summary>		
        private string _tempexamstationname;
        public virtual string TempExamStationName
        {
            get { return _tempexamstationname; }
            set { _tempexamstationname = value; }
        }
        /// <summary>
        /// 考站描述
        /// </summary>		
        private string _tempexamstationcontent;
        public virtual string TempExamStationContent
        {
            get { return _tempexamstationcontent; }
            set { _tempexamstationcontent = value; }
        }
        /// <summary>
        /// 考试科目
        /// </summary>		
        private string _tempexamstationcurriculum;
        public virtual string TempExamStationCurriculum
        {
            get { return _tempexamstationcurriculum; }
            set { _tempexamstationcurriculum = value; }
        }
        /// <summary>
        /// 考站分类，1-长站，2-短站，只有长短站考试有区别，多站式考试和单站式考试可以设置1
        /// </summary>		
        private int _tempexamstationkind;
        public virtual int TempExamStationKind
        {
            get { return _tempexamstationkind; }
            set { _tempexamstationkind = value; }
        }
        /// <summary>
        /// 考站主观评分占比，百分之单位，客观评分100-主观评分百分比
        /// </summary>		
        private int _tempexamstationsubjectivepercent;
        public virtual int TempExamStationSubjectivePercent
        {
            get { return _tempexamstationsubjectivepercent; }
            set { _tempexamstationsubjectivepercent = value; }
        }
        /// <summary>
        /// 考站排序，应用于多站式中的考站顺序设置，从1开始递增。其他考试类型也可以使用
        /// </summary>		
        private int? _tempexamstationordernumber;
        public virtual int? TempExamStationOrderNumber
        {
            get { return _tempexamstationordernumber; }
            set { _tempexamstationordernumber = value; }
        }
        /// <summary>
        /// 考站信息完整性，1-完整，0-不完整
        /// </summary>		
        private int? _tempexamstationiscomplete;
        public virtual int? TempExamStationIsComplete
        {
            get { return _tempexamstationiscomplete; }
            set { _tempexamstationiscomplete = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamstationnumber1;
        public virtual int? TempExamStationNumber1
        {
            get { return _tempexamstationnumber1; }
            set { _tempexamstationnumber1 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamstationnumber2;
        public virtual int? TempExamStationNumber2
        {
            get { return _tempexamstationnumber2; }
            set { _tempexamstationnumber2 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamstationnumber3;
        public virtual int? TempExamStationNumber3
        {
            get { return _tempexamstationnumber3; }
            set { _tempexamstationnumber3 = value; }
        }
        /// <summary>
        /// 预留字段，长整型
        /// </summary>		
        private long? _tempexamstationnumber4;
        public virtual long? TempExamStationNumber4
        {
            get { return _tempexamstationnumber4; }
            set { _tempexamstationnumber4 = value; }
        }
        /// <summary>
        /// 预留字段，长整型
        /// </summary>		
        private long? _tempexamstationnumber5;
        public virtual long? TempExamStationNumber5
        {
            get { return _tempexamstationnumber5; }
            set { _tempexamstationnumber5 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationnumber6;
        public virtual decimal? TempExamStationNumber6
        {
            get { return _tempexamstationnumber6; }
            set { _tempexamstationnumber6 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationnumber7;
        public virtual decimal? TempExamStationNumber7
        {
            get { return _tempexamstationnumber7; }
            set { _tempexamstationnumber7 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationnumber8;
        public virtual decimal? TempExamStationNumber8
        {
            get { return _tempexamstationnumber8; }
            set { _tempexamstationnumber8 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamstationnumber9;
        public virtual decimal? TempExamStationNumber9
        {
            get { return _tempexamstationnumber9; }
            set { _tempexamstationnumber9 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度50
        /// </summary>		
        private string _tempexamstationstring1;
        public virtual string TempExamStationString1
        {
            get { return _tempexamstationstring1; }
            set { _tempexamstationstring1 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度50
        /// </summary>		
        private string _tempexamstationstring2;
        public virtual string TempExamStationString2
        {
            get { return _tempexamstationstring2; }
            set { _tempexamstationstring2 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度200
        /// </summary>		
        private string _tempexamstationstring3;
        public virtual string TempExamStationString3
        {
            get { return _tempexamstationstring3; }
            set { _tempexamstationstring3 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度200
        /// </summary>		
        private string _tempexamstationstring4;
        public virtual string TempExamStationString4
        {
            get { return _tempexamstationstring4; }
            set { _tempexamstationstring4 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度500
        /// </summary>		
        private string _tempexamstationstring5;
        public virtual string TempExamStationString5
        {
            get { return _tempexamstationstring5; }
            set { _tempexamstationstring5 = value; }
        }
        /// <summary>
        /// 董阳，2014-09-16，存储考站信息不完整时的提示信息
        /// </summary>		
        private string _tempexamstationstring6;
        public virtual string TempExamStationString6
        {
            get { return _tempexamstationstring6; }
            set { _tempexamstationstring6 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2000
        /// </summary>		
        private string _tempexamstationstring7;
        public virtual string TempExamStationString7
        {
            get { return _tempexamstationstring7; }
            set { _tempexamstationstring7 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度4000
        /// </summary>		
        private string _tempexamstationstring8;
        public virtual string TempExamStationString8
        {
            get { return _tempexamstationstring8; }
            set { _tempexamstationstring8 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
        private string _tempexamstationstring9;
        public virtual string TempExamStationString9
        {
            get { return _tempexamstationstring9; }
            set { _tempexamstationstring9 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationdatetime1;
        public virtual DateTime? TempExamStationDatetime1
        {
            get { return _tempexamstationdatetime1; }
            set { _tempexamstationdatetime1 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationdatetime2;
        public virtual DateTime? TempExamStationDatetime2
        {
            get { return _tempexamstationdatetime2; }
            set { _tempexamstationdatetime2 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationdatetime3;
        public virtual DateTime? TempExamStationDatetime3
        {
            get { return _tempexamstationdatetime3; }
            set { _tempexamstationdatetime3 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationdatetime4;
        public virtual DateTime? TempExamStationDatetime4
        {
            get { return _tempexamstationdatetime4; }
            set { _tempexamstationdatetime4 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationdatetime5;
        public virtual DateTime? TempExamStationDatetime5
        {
            get { return _tempexamstationdatetime5; }
            set { _tempexamstationdatetime5 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamstationdatetime6;
        public virtual DateTime? TempExamStationDatetime6
        {
            get { return _tempexamstationdatetime6; }
            set { _tempexamstationdatetime6 = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamStation()
            : this(default(Guid))
        {
            
        }

        /// <summary>
        /// 仅使用Guid构造对象
        /// </summary>
        /// <param name="tempExamStationID"></param>
        public TempExamStation(Guid tempExamStationID)
        {
            this.TempExamStationID = tempExamStationID;
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
                .Append("\"TempExamStationID\":\"").Append(this.TempExamStationID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID).Append("\",")
                .Append("\"ExamStationClassID\":\"").Append(this.ExamStationClassID).Append("\",")
                .Append("\"TempExamStationName\":\"").Append(Uri.EscapeDataString(this.TempExamStationName)).Append("\",")
                .Append("\"TempExamStationContent\":\"").Append(Uri.EscapeDataString(this.TempExamStationContent)).Append("\",")
                .Append("\"TempExamStationCurriculum\":\"").Append(Uri.EscapeDataString(this.TempExamStationCurriculum)).Append("\",")
                .Append("\"TempExamStationKind\":\"").Append(this.TempExamStationKind).Append("\",")
                .Append("\"TempExamStationSubjectivePercent\":\"").Append(this.TempExamStationSubjectivePercent).Append("\",")
                .Append("\"TempExamStationOrderNumber\":\"").Append(this.TempExamStationOrderNumber == null ? "" : Convert.ToInt32(this.TempExamStationOrderNumber).ToString()).Append("\",")
                .Append("\"TempExamStationIsComplete\":\"").Append(this.TempExamStationIsComplete == null ? "" : Convert.ToInt32(this.TempExamStationIsComplete).ToString()).Append("\",")
                .Append("\"TempExamStationString6\":\"").Append(this.TempExamStationString6 == null ? "" : Uri.EscapeDataString(this.TempExamStationString6)).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Model.TempExamStation && this.TempExamStationID == ((Model.TempExamStation)obj).TempExamStationID;
        }

        #endregion
    }
}
