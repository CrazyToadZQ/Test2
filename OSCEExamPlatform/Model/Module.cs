using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 功能模块表
	/// </summary>
	[Serializable]
	public partial class Module
	{
		public Module()
		{}
		#region Model
		private int _m_id;
		private string _m_name;
		private string _m_content;
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
        public virtual int M_ID
		{
			set{ _m_id=value;}
			get{return _m_id;}
		}
		/// <summary>
		/// 功能模块名称
		/// </summary>
        public virtual string M_Name
		{
			set{ _m_name=value;}
			get{return _m_name;}
		}
		/// <summary>
		/// 描述
		/// </summary>
        public virtual string M_Content
		{
			set{ _m_content=value;}
			get{return _m_content;}
		}
		/// <summary>
		/// 2014-3-7范国斌修改，此列用于连接外键MG_ID，代表模块分组的ID
		/// </summary>
        public virtual int? int1
		{
			set{ _int1=value;}
			get{return _int1;}
		}
		/// <summary>
		/// 2014-3-7范国斌修改，此列用于表示ParentID，即顶级的Module此列为0，那么属于其他Module的“子Module”，则此列引用“父Module”的ID
		/// </summary>
        public virtual  int? int2
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
		/// 2014-3-10范国斌修改，此列用于存储改功能模块的主页面的引用Url。
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
		#endregion Model

	}
}

