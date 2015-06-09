using System;
namespace Tellyes.Model
{
	/// <summary>
	/// ObjectiveMarkSheet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjectiveMarkSheet
	{
		public ObjectiveMarkSheet()
		{}
		#region Model
		private int _oms_id;
		private string _oms_name;
		private string _oms_kind;
		private DateTime _oms_createdate;
		private DateTime? _oms_modifydate;
		private string _string1;
		private string _string2;
		private string _string3;
		private string _string4;
		private int? _int1;
		private int? _int2;
		/// <summary>
		/// 主键，标志位
		/// </summary>
		public int OMS_ID
		{
			set{ _oms_id=value;}
			get{return _oms_id;}
		}
		/// <summary>
		/// 客观评分表名称
		/// </summary>
		public string OMS_Name
		{
			set{ _oms_name=value;}
			get{return _oms_name;}
		}
		/// <summary>
		/// 预留：客观评分表类型
		/// </summary>
		public string OMS_Kind
		{
			set{ _oms_kind=value;}
			get{return _oms_kind;}
		}
		/// <summary>
		/// 创建日期
		/// </summary>
		public DateTime OMS_CreateDate
		{
			set{ _oms_createdate=value;}
			get{return _oms_createdate;}
		}
		/// <summary>
		/// 修改日期
		/// </summary>
		public DateTime? OMS_ModifyDate
		{
			set{ _oms_modifydate=value;}
			get{return _oms_modifydate;}
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
		public string string4
		{
			set{ _string4=value;}
			get{return _string4;}
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
		#endregion Model

	}
}

