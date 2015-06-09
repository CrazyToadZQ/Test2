using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 角色功能模块分配表
	/// </summary>
	[Serializable]
	public partial class ModuleRole
	{
		public ModuleRole()
		{}
		#region Model
		private int _m_id;
		private int _r_id;
		private int _mr_isadd=1;
		private int _mr_isdel=1;
		private int _mr_isupd=1;
		private int _mr_isque=1;
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
		/// 功能模块ID
		/// </summary>
		public int M_ID
		{
			set{ _m_id=value;}
			get{return _m_id;}
		}
		/// <summary>
		/// 角色ID
		/// </summary>
		public int R_ID
		{
			set{ _r_id=value;}
			get{return _r_id;}
		}
		/// <summary>
		/// 是否具有增的权限
		/// </summary>
		public int MR_IsAdd
		{
			set{ _mr_isadd=value;}
			get{return _mr_isadd;}
		}
		/// <summary>
		/// 是否具有删的权限
		/// </summary>
		public int MR_IsDel
		{
			set{ _mr_isdel=value;}
			get{return _mr_isdel;}
		}
		/// <summary>
		/// 是否具有改的权限
		/// </summary>
		public int MR_IsUpd
		{
			set{ _mr_isupd=value;}
			get{return _mr_isupd;}
		}
		/// <summary>
		/// 是否具有查的权限
		/// </summary>
		public int MR_IsQue
		{
			set{ _mr_isque=value;}
			get{return _mr_isque;}
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

