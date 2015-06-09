using System;
namespace Tellyes.Model
{
	/// <summary>
	/// ExamRoomDevice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExamRoomDevice
	{
		public ExamRoomDevice()
		{}
		#region Model
		private int _erd_id;
		private int _e_id;
		private int _room_id;
		private int _dc_id;
		private int _d_id;
		private int? _int1;
		private int? _int2;
		private int? _int3;
		private string _string1;
		private string _string2;
		private string _string3;
		/// <summary>
		/// 
		/// </summary>
		public int ERD_ID
		{
			set{ _erd_id=value;}
			get{return _erd_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int E_ID
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Room_ID
		{
			set{ _room_id=value;}
			get{return _room_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DC_ID
		{
			set{ _dc_id=value;}
			get{return _dc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int D_ID
		{
			set{ _d_id=value;}
			get{return _d_id;}
		}
		/// <summary>
		/// D_Count
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
		#endregion Model

	}
}

