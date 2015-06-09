using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class ScoreInfo
    {
        #region Model
		private int _si_id;
        private Guid _exam_id;
        private Guid _examstation_id;
		private int? _room_id;
		private int? _score_percent;
		private int _student_id;
		private int _si_type;
		private int _rater_id;
        private decimal _si_score;
		private string _si_actualscore;
		private string _si_items;
		private string _si_provisionscore;
		private byte[] _si_digitalsignature;
		private DateTime _si_createtime= DateTime.Now;
		private int? _si_int1;
		private int? _si_int2;
		private string _si_string1;
		private string _si_string2;
		private DateTime? _si_datetime;
		private int? _calcuated=0;
        private string _timestamp = DateTime.Now.ToString();
		/// <summary>
		/// 成绩表ID
		/// </summary>
		public virtual int SI_ID
		{
			set{ _si_id=value;}
			get{return _si_id;}
		}
		/// <summary>
		/// 考试ID
		/// </summary>
		public virtual Guid Exam_ID
		{
			set{ _exam_id=value;}
			get{return _exam_id;}
		}
		/// <summary>
		/// 考站ID
		/// </summary>
        public virtual Guid ExamStation_ID
		{
			set{ _examstation_id=value;}
			get{return _examstation_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public virtual int? Room_ID
		{
			set{ _room_id=value;}
			get{return _room_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public virtual int? Score_Percent
		{
			set{ _score_percent=value;}
			get{return _score_percent;}
		}
		/// <summary>
		/// 考生ID（UserInfo中的U_ID）
		/// </summary>
		public virtual int Student_ID
		{
			set{ _student_id=value;}
			get{return _student_id;}
		}
		/// <summary>
		/// 评分类型:1-客观评委,2-现场评委,3-远程评委;0为非评委
		/// </summary>
		public virtual int SI_Type
		{
			set{ _si_type=value;}
			get{return _si_type;}
		}
		/// <summary>
		/// 评分者ID（类型为0或2时，为用户ID；类型为1时，为设备ID）
		/// </summary>
		public virtual int Rater_ID
		{
			set{ _rater_id=value;}
			get{return _rater_id;}
		}
		/// <summary>
		/// 分数
		/// </summary>
        public virtual decimal SI_Score
		{
			set{ _si_score=value;}
			get{return _si_score;}
		}
		/// <summary>
		/// 实际分值（中间用"，"分隔）;使用Json向SI_Items存储细节，此列废弃
		/// </summary>
		public virtual string SI_ActualScore
		{
			set{ _si_actualscore=value;}
			get{return _si_actualscore;}
		}
		/// <summary>
		/// 评分项，使用Json存储
		/// </summary>
		public virtual string SI_Items
		{
			set{ _si_items=value;}
			get{return _si_items;}
		}
		/// <summary>
		/// 规定分值（中间用"，"分隔）;使用Json向SI_Items存储细节，此列废弃
		/// </summary>
		public virtual string SI_ProvisionScore
		{
			set{ _si_provisionscore=value;}
			get{return _si_provisionscore;}
		}
		/// <summary>
		/// 数字签名
		/// </summary>
		public virtual byte[] SI_DigitalSignature
		{
			set{ _si_digitalsignature=value;}
			get{return _si_digitalsignature;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public virtual DateTime SI_CreateTime
		{
			set{ _si_createtime=value;}
			get{return _si_createtime;}
		}
		/// <summary>
		/// 评分表id（MS_ID）
		/// </summary>
		public virtual int? SI_int1
		{
			set{ _si_int1=value;}
			get{return _si_int1;}
		}
		/// <summary>
        /// 董阳，2014-09-11，考生评分状态，1-缺考，2-已考
		/// </summary>
		public virtual int? SI_int2
		{
			set{ _si_int2=value;}
			get{return _si_int2;}
		}
		/// <summary>
		/// 预留
		/// </summary>
		public virtual string SI_string1
		{
			set{ _si_string1=value;}
			get{return _si_string1;}
		}
		/// <summary>
		/// 预留
		/// </summary>
		public virtual string SI_string2
		{
			set{ _si_string2=value;}
			get{return _si_string2;}
		}
		/// <summary>
		/// 预留
		/// </summary>
		public virtual DateTime? SI_datetime
		{
			set{ _si_datetime=value;}
			get{return _si_datetime;}
		}
		/// <summary>
		/// 已运算标志位
		/// </summary>
		public virtual int? calcuated
		{
			set{ _calcuated=value;}
			get{return _calcuated;}
		}
		/// <summary>
		/// 时间戳
		/// </summary>
		public virtual string timeStamp
		{
			set{ _timestamp=value;}
			get{return _timestamp;}
		}
		#endregion Model

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"SI_ID\":\"").Append(this.SI_ID).Append("\",")
                .Append("\"Exam_ID\":\"").Append(this.Exam_ID).Append("\",")
                .Append("\"ExamStation_ID\":\"").Append(this.ExamStation_ID).Append("\",")
                .Append("\"Room_ID\":\"").Append(this.Room_ID == null ? "" : this.Room_ID.ToString()).Append("\",")
                .Append("\"Score_Percent\":\"").Append(this.Score_Percent == null ? "" : this.Score_Percent.ToString()).Append("\",")
                .Append("\"Student_ID\":\"").Append(this.Student_ID).Append("\",")
                .Append("\"SI_Type\":\"").Append(this.SI_Type).Append("\",")
                .Append("\"Rater_ID\":\"").Append(this.Rater_ID).Append("\",")
                .Append("\"SI_Score\":\"").Append(this.SI_Score).Append("\",")
                .Append("\"SI_ActualScore\":\"").Append(Uri.EscapeDataString(this.SI_ActualScore == null ? "" : this.SI_ActualScore)).Append("\",")
                .Append("\"SI_Items\":").Append(this.SI_Items == null ? "[]" : this.SI_Items).Append(",")
                .Append("\"SI_ProvisionScore\":\"").Append(Uri.EscapeDataString(this.SI_ProvisionScore == null ? "" : this.SI_ProvisionScore)).Append("\",")
                .Append("\"SI_CreateTime\":\"").Append(this.SI_CreateTime.ToString("yyyy-MM-dd HH:mm:ss")).Append("\",")
                .Append("\"SI_int1\":\"").Append(this.SI_int1 == null ? "" : this.SI_int1.ToString()).Append("\",")
                .Append("\"SI_int2\":\"").Append(this.SI_int2 == null ? "" : this.SI_int2.ToString()).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }
    }
}
