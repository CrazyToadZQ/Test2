using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class Role
	{
		public Role()
		{}
		#region Model
		private int _r_id;
		private string _r_name;
		private string _r_content;
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
		public int R_ID
		{
			set{ _r_id=value;}
			get{return _r_id;}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string R_Name
		{
			set{ _r_name=value;}
			get{return _r_name;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string R_Content
		{
			set{ _r_content=value;}
			get{return _r_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? int1
		{
			set{ _int1=value;}
			get{return _int1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? int2
		{
			set{ _int2=value;}
			get{return _int2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? int3
		{
			set{ _int3=value;}
			get{return _int3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string string1
		{
			set{ _string1=value;}
			get{return _string1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string string2
		{
			set{ _string2=value;}
			get{return _string2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string string3
		{
			set{ _string3=value;}
			get{return _string3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date1
		{
			set{ _date1=value;}
			get{return _date1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date2
		{
			set{ _date2=value;}
			get{return _date2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date3
		{
			set{ _date3=value;}
			get{return _date3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? float1
		{
			set{ _float1=value;}
			get{return _float1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? float2
		{
			set{ _float2=value;}
			get{return _float2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? float3
		{
			set{ _float3=value;}
			get{return _float3;}
		}
		#endregion Model

	}
}

