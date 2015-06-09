using System;
using System.Data;
using System.Text;
namespace Tellyes.Model
{
	/// <summary>
	/// 预约信息表
	/// </summary>
	[Serializable]
	public partial class Reservation
	{
		public Reservation()
		{}
		#region Model
		private int _reservation_id;
		private string _reservation_code;
		private string _reservation_type;
		private string _reservation_name;
		private string _enity_id;
		private DateTime _reservation_starttime;
		private DateTime _reservation_endtime;
		private string _remark;
		private int _is_examine;
		private string _examine_state;
		private string _examine_message;
		private int _apply_u_id;
		private string _apply_r_name;
		private string _apply_u_turename;
		private int _examine_u_id;
		private string _examine_r_name;
		private string _examine_u_truename;
		private DateTime _apply_datetime;
		private DateTime? _examine_datetime;
		private int? _number1;
		private int? _number2;
		private int? _number3;
		private int? _number4;
		private int? _number5;
		private decimal? _number6;
		private decimal? _number7;
		private decimal? _number8;
		private string _string1;
		private string _string2;
		private string _string3;
		private string _string4;
		private string _string5;
		private string _string6;
		private string _string7;
		private string _string8;
		private DateTime? _datetime1= Convert.ToDateTime(DateTime.Now);
		private DateTime? _datetime2= Convert.ToDateTime(DateTime.Now);
		private DateTime? _datetime3= Convert.ToDateTime(DateTime.Now);
		private DateTime? _datetime4= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键编号
		/// </summary>
        public virtual int ReservationID
		{
			set{ _reservation_id=value;}
			get{return _reservation_id;}
		}
		/// <summary>
		/// 预约编号
		/// </summary>
        public virtual string ReservationCode
		{
			set{ _reservation_code=value;}
			get{return _reservation_code;}
		}
		/// <summary>
		/// 预约类型(课程、考试)
		/// </summary>
        public virtual string ReservationType
		{
			set{ _reservation_type=value;}
			get{return _reservation_type;}
		}
		/// <summary>
		/// 预约名称
		/// </summary>
        public virtual string ReservationName
		{
			set{ _reservation_name=value;}
			get{return _reservation_name;}
		}
		/// <summary>
		/// 原型实体编号
		/// </summary>
        public virtual string EnityID
		{
			set{ _enity_id=value;}
			get{return _enity_id;}
		}
		/// <summary>
		/// 预约开始时间
		/// </summary>
        public virtual DateTime ReservationStartTime
		{
			set{ _reservation_starttime=value;}
			get{return _reservation_starttime;}
		}
		/// <summary>
		/// 预约结束时间
		/// </summary>
        public virtual DateTime ReservationEndTime
		{
			set{ _reservation_endtime=value;}
			get{return _reservation_endtime;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
        public virtual string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 预约审批(1-已审批、0-未审批)
		/// </summary>
        public virtual int IsExamine
		{
			set{ _is_examine=value;}
			get{return _is_examine;}
		}
		/// <summary>
		/// 审批状态(已通过、未通过、待定)
		/// </summary>
        public virtual string ExamineState
		{
			set{ _examine_state=value;}
			get{return _examine_state;}
		}
		/// <summary>
		/// 审批信息
		/// </summary>
        public virtual string ExamineMessage
		{
			set{ _examine_message=value;}
			get{return _examine_message;}
		}
		/// <summary>
		/// 申请人ID
		/// </summary>
        public virtual int ApplyUserInfoID
		{
			set{ _apply_u_id=value;}
			get{return _apply_u_id;}
		}
		/// <summary>
		/// 申请人角色
		/// </summary>
        public virtual string ApplyRoleName
		{
			set{ _apply_r_name=value;}
			get{return _apply_r_name;}
		}
		/// <summary>
		/// 申请人姓名
		/// </summary>
        public virtual string ApplyUserInfoTureName
		{
			set{ _apply_u_turename=value;}
			get{return _apply_u_turename;}
		}
		/// <summary>
		/// 审批人ID
		/// </summary>
        public virtual int ExamineUserInfoID
		{
			set{ _examine_u_id=value;}
			get{return _examine_u_id;}
		}
		/// <summary>
		/// 审批人角色
		/// </summary>
        public virtual string ExamineRoleName
		{
			set{ _examine_r_name=value;}
			get{return _examine_r_name;}
		}
		/// <summary>
		/// 审批人姓名
		/// </summary>
        public virtual string ExamineUserInfoTrueName
		{
			set{ _examine_u_truename=value;}
			get{return _examine_u_truename;}
		}
		/// <summary>
		/// 申请时间
		/// </summary>
        public virtual DateTime ApplyDatetime
		{
			set{ _apply_datetime=value;}
			get{return _apply_datetime;}
		}
		/// <summary>
		/// 审批时间
		/// </summary>
        public virtual DateTime? ExamineDatetime
		{
			set{ _examine_datetime=value;}
			get{return _examine_datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? ReservationNumber1
		{
			set{ _number1=value;}
			get{return _number1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? ReservationNumber2
		{
			set{ _number2=value;}
			get{return _number2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? ReservationNumber3
		{
			set{ _number3=value;}
			get{return _number3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? ReservationNumber4
		{
			set{ _number4=value;}
			get{return _number4;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? ReservationNumber5
		{
			set{ _number5=value;}
			get{return _number5;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? ReservationNumber6
		{
			set{ _number6=value;}
			get{return _number6;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? ReservationNumber7
		{
			set{ _number7=value;}
			get{return _number7;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? ReservationNumber8
		{
			set{ _number8=value;}
			get{return _number8;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString1
		{
			set{ _string1=value;}
			get{return _string1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString2
		{
			set{ _string2=value;}
			get{return _string2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString3
		{
			set{ _string3=value;}
			get{return _string3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString4
		{
			set{ _string4=value;}
			get{return _string4;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString5
		{
			set{ _string5=value;}
			get{return _string5;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString6
		{
			set{ _string6=value;}
			get{return _string6;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString7
		{
			set{ _string7=value;}
			get{return _string7;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string ReservationString8
		{
			set{ _string8=value;}
			get{return _string8;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? ReservationDatetime1
		{
			set{ _datetime1=value;}
			get{return _datetime1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? ReservationDatetime2
		{
			set{ _datetime2=value;}
			get{return _datetime2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? ReservationDatetime3
		{
			set{ _datetime3=value;}
			get{return _datetime3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? ReservationDatetime4
		{
			set{ _datetime4=value;}
			get{return _datetime4;}
		}
		#endregion Model

        public static string ToJsonString(DataRow reservation)
        {
            return Reservation.ToJsonString(reservation, true);
        }

        public static string ToJsonString(DataRow reservation, bool close)
        {
            return new StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"ReservationID\":\"").Append(reservation["ReservationID"]).Append("\",")
                .Append("\"ReservationCode\":\"").Append(reservation["ReservationCode"]).Append("\",")
                .Append("\"ReservationType\":\"").Append(reservation["ReservationType"]).Append("\",")
                .Append("\"ReservationName\":\"").Append(Uri.EscapeDataString(reservation["ReservationName"].ToString())).Append("\",")
                .Append("\"EnityID\":\"").Append(reservation["EnityID"]).Append("\",")
                .Append("\"ReservationStartTime\":\"").Append(Convert.ToDateTime(reservation["ReservationStartTime"]).ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"ReservationEndTime\":\"").Append(Convert.ToDateTime(reservation["ReservationEndTime"]).ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"Remark\":\"").Append(Uri.EscapeDataString(reservation["Remark"].ToString())).Append("\",")
                .Append("\"IsExamine\":\"").Append(reservation["IsExamine"]).Append("\",")
                .Append("\"ExamineState\":\"").Append(reservation["ExamineState"]).Append("\",")
                .Append("\"ExamineMessage\":\"").Append(Uri.EscapeDataString(reservation["ExamineMessage"].ToString())).Append("\",")
                .Append("\"ApplyUserInfoID\":\"").Append(reservation["ApplyUserInfoID"]).Append("\",")
                .Append("\"ApplyRoleName\":\"").Append(reservation["ApplyRoleName"]).Append("\",")
                .Append("\"ApplyUserInfoTureName\":\"").Append(Uri.EscapeDataString(reservation["ApplyUserInfoTureName"].ToString())).Append("\",")
                .Append("\"ExamineUserInfoID\":\"").Append(reservation["ExamineUserInfoID"] == null ? "" : reservation["ExamineUserInfoID"]).Append("\",")
                .Append("\"ExamineRoleName\":\"").Append(reservation["ExamineRoleName"] == null ? "" : reservation["ExamineRoleName"]).Append("\",")
                .Append("\"ExamineUserInfoTrueName\":\"").Append(Uri.EscapeDataString(reservation["ExamineUserInfoTrueName"] == null ? "" : reservation["ExamineUserInfoTrueName"].ToString())).Append("\",")
                .Append("\"ApplyDatetime\":\"").Append(Convert.ToDateTime(reservation["ApplyDatetime"]).ToString("yyyy-MM-dd HH:mm")).Append("\",")
                .Append("\"ExamineDatetime\":\"").Append(reservation["ExamineDatetime"] == null ? "" : Convert.ToDateTime(reservation["ExamineDatetime"]).ToString("yyyy-MM-dd HH:mm")).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

	}
}

