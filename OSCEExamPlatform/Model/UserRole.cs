using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 用户的角色分派表
	/// </summary>
	[Serializable]
	public partial class UserRole
	{
		public UserRole()
		{}
		#region Model
		private int _r_id;
		private int _u_id;
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
		/// 角色ID
		/// </summary>
		public virtual int R_ID
		{
			set{ _r_id=value;}
			get{return _r_id;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
        public virtual int U_ID
		{
			set{ _u_id=value;}
			get{return _u_id;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? int1
		{
			set{ _int1=value;}
			get{return _int1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? int2
		{
			set{ _int2=value;}
			get{return _int2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int? int3
		{
			set{ _int3=value;}
			get{return _int3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string string1
		{
			set{ _string1=value;}
			get{return _string1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string string2
		{
			set{ _string2=value;}
			get{return _string2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual string string3
		{
			set{ _string3=value;}
			get{return _string3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? date1
		{
			set{ _date1=value;}
			get{return _date1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? date2
		{
			set{ _date2=value;}
			get{return _date2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime? date3
		{
			set{ _date3=value;}
			get{return _date3;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? float1
		{
			set{ _float1=value;}
			get{return _float1;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? float2
		{
			set{ _float2=value;}
			get{return _float2;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual decimal? float3
		{
			set{ _float3=value;}
			get{return _float3;}
		}

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
		#endregion Model

        
	}
}

