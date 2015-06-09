
using System;
namespace Tellyes.Model
{
	/// <summary>
	/// UserPhoto:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserPhoto
	{
		public UserPhoto()
		{}
		#region Model
		private int _up_id;
		private int _u_id;
		private byte[] _up_photo;
		private DateTime _up_createtime;
		private Guid _e_id;
		private int _room_id;
		private int _int1=0;
		private string _string1;
		/// <summary>
		/// 
		/// </summary>
		public int UP_ID
		{
			set{ _up_id=value;}
			get{return _up_id;}
		}
		/// <summary>
		/// userinfo主键
		/// </summary>
		public int U_ID
		{
			set{ _u_id=value;}
			get{return _u_id;}
		}
		/// <summary>
		/// 头像信息
		/// </summary>
		public byte[] UP_Photo
		{
			set{ _up_photo=value;}
			get{return _up_photo;}
		}
		/// <summary>
		/// 头像采集时间
		/// </summary>
		public DateTime UP_CreateTime
		{
			set{ _up_createtime=value;}
			get{return _up_createtime;}
		}
		/// <summary>
		/// 考试ID
		/// </summary>
		public Guid E_ID
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
		/// <summary>
		/// 房间ID
		/// </summary>
		public int Room_ID
		{
			set{ _room_id=value;}
			get{return _room_id;}
		}
		/// <summary>
		/// 预留
		/// </summary>
		public int int1
		{
			set{ _int1=value;}
			get{return _int1;}
		}
		/// <summary>
		/// 预留
		/// </summary>
		public string string1
		{
			set{ _string1=value;}
			get{return _string1;}
		}
		#endregion Model

	}
}

