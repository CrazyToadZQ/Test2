using System;
namespace Tellyes.Model
{
	/// <summary>
	/// DeviceClass:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DeviceClassOriginal
	{
        public DeviceClassOriginal()
		{}
		#region Model
		private int _dc_id;
		private string _dc_name;
		private int _dc_parentid;
		private string _dc_content;
		private int _dc_isdelete;
		private int? _dc_int;
		private string _dc_string;
		/// <summary>
		/// 设备分类ID
		/// </summary>
		public int DC_ID
		{
			set{ _dc_id=value;}
			get{return _dc_id;}
		}
		/// <summary>
		/// 设备分类名称
		/// </summary>
		public string DC_Name
		{
			set{ _dc_name=value;}
			get{return _dc_name;}
		}
		/// <summary>
		/// 父节点ID
		/// </summary>
		public int DC_ParentID
		{
			set{ _dc_parentid=value;}
			get{return _dc_parentid;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string DC_Content
		{
			set{ _dc_content=value;}
			get{return _dc_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DC_IsValid
		{
			set{ _dc_isdelete=value;}
			get{return _dc_isdelete;}
		}
		/// <summary>
		/// 预留
		/// </summary>
		public int? DC_int
		{
			set{ _dc_int=value;}
			get{return _dc_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DC_string
		{
			set{ _dc_string=value;}
			get{return _dc_string;}
		}
		#endregion Model

	}
}

