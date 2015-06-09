using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 预约资源表
	/// </summary>
	[Serializable]
	public partial class ReservationResource
	{
		public ReservationResource()
		{}
		#region Model
		private int _reservation_res_id;
		private int _reservation_id;
		private string _resource_type;
		private string _resource_id;
		private string _resource_code;
		private string _resource_name;
        private string _enity_id;
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
        public virtual int Reservation_Res_ID
		{
			set{ _reservation_res_id=value;}
			get{return _reservation_res_id;}
		}
		/// <summary>
		/// 预约信息编号
		/// </summary>
        public virtual int Reservation_ID
		{
			set{ _reservation_id=value;}
			get{return _reservation_id;}
		}
		/// <summary>
		/// 资源类型
		/// </summary>
        public virtual string Resource_Type
		{
			set{ _resource_type=value;}
			get{return _resource_type;}
		}
		/// <summary>
		/// 资源ID
		/// </summary>
        public virtual string ResourceID
		{
			set{ _resource_id=value;}
			get{return _resource_id;}
		}
		/// <summary>
		/// 资源编号
		/// </summary>
        public virtual string Resource_Code
		{
			set{ _resource_code=value;}
			get{return _resource_code;}
		}
		/// <summary>
		/// 资源名称
		/// </summary>
        public virtual string Resource_Name
		{
			set{ _resource_name=value;}
			get{return _resource_name;}
		}
        /// <summary>
        ///  在考试中相当于E_ID
        /// </summary>
        public virtual string EnityID
        {
            set { _enity_id = value; }
            get { return _enity_id; }
        }
		/// <summary>
		/// 
		/// </summary>
        public virtual int? Number1
		{
			set{ _number1=value;}
			get{return _number1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? Number2
		{
			set{ _number2=value;}
			get{return _number2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? Number3
		{
			set{ _number3=value;}
			get{return _number3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? Number4
		{
			set{ _number4=value;}
			get{return _number4;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? Number5
		{
			set{ _number5=value;}
			get{return _number5;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? Number6
		{
			set{ _number6=value;}
			get{return _number6;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? Number7
		{
			set{ _number7=value;}
			get{return _number7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public virtual decimal? Number8
		{
			set{ _number8=value;}
			get{return _number8;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String1
		{
			set{ _string1=value;}
			get{return _string1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String2
		{
			set{ _string2=value;}
			get{return _string2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String3
		{
			set{ _string3=value;}
			get{return _string3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String4
		{
			set{ _string4=value;}
			get{return _string4;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String5
		{
			set{ _string5=value;}
			get{return _string5;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String6
		{
			set{ _string6=value;}
			get{return _string6;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String7
		{
			set{ _string7=value;}
			get{return _string7;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string String8
		{
			set{ _string8=value;}
			get{return _string8;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? Datetime1
		{
			set{ _datetime1=value;}
			get{return _datetime1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? Datetime2
		{
			set{ _datetime2=value;}
			get{return _datetime2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? Datetime3
		{
			set{ _datetime3=value;}
			get{return _datetime3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? Datetime4
		{
			set{ _datetime4=value;}
			get{return _datetime4;}
		}
		#endregion Model

	}
}

