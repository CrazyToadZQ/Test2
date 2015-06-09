using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class Room1
    {
        public Room1()
		{}
		#region Model
		private int _room_id;
		private int _parent_room_id;
		private string _room_name;
		private string _room_area;
		private int _room_people_number;
		private int _room_station_number;
		private int _room_is_binding_device;
		private string _room_device_name;
		private string _room_describe;
		private int? _number1=0;
		private int? _number2=0;
		private int? _number3=0;
		private int? _number4=0;
		private int? _number5=0;
		private decimal? _number6=0;
		private decimal? _number7=0;
		private decimal? _number8=0;
		private string _string1= "NULL";
		private string _string2= "NULL";
		private string _string3= "NULL";
		private string _string4= "NULL";
		private string _string5= "NULL";
		private string _string6= "NULL";
		private string _string7= "NULL";
		private string _string8= "NULL";
		private DateTime? _datetime1= new DateTime();
        private DateTime? _datetime2 = new DateTime();
        private DateTime? _datetime3 = new DateTime();
        private DateTime? _datetime4 = new DateTime();
		/// <summary>
		/// 主键编号
		/// </summary>
		public int Room_ID
		{
			set{ _room_id=value;}
			get{return _room_id;}
		}
		/// <summary>
		/// 父房间ID(房间只允许分两级，第一级房间的父房间ID默认为0，第二级房间的父房间ID为对应上一级房间的Room_ID)
		/// </summary>
		public int Parent_Room_ID
		{
			set{ _parent_room_id=value;}
			get{return _parent_room_id;}
		}
		/// <summary>
		/// 房间名称
		/// </summary>
		public string Room_Name
		{
			set{ _room_name=value;}
			get{return _room_name;}
		}
		/// <summary>
		/// 房间面积
		/// </summary>
		public string Room_Area
		{
			set{ _room_area=value;}
			get{return _room_area;}
		}
		/// <summary>
		/// 房间人数
		/// </summary>
		public int Room_People_Number
		{
			set{ _room_people_number=value;}
			get{return _room_people_number;}
		}
		/// <summary>
		/// 房间考站数量
		/// </summary>
		public int Room_Station_Number
		{
			set{ _room_station_number=value;}
			get{return _room_station_number;}
		}
		/// <summary>
		/// 房间是否绑定设备(‘0’不绑定设备，‘1’绑定设备)
		/// </summary>
		public int Room_IS_Binding_Device
		{
			set{ _room_is_binding_device=value;}
			get{return _room_is_binding_device;}
		}
		/// <summary>
		/// 房间绑定设备名称
		/// </summary>
		public string Room_Device_Name
		{
			set{ _room_device_name=value;}
			get{return _room_device_name;}
		}
		/// <summary>
		/// 房间描述
		/// </summary>
		public string Room_Describe
		{
			set{ _room_describe=value;}
			get{return _room_describe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number1
		{
			set{ _number1=value;}
			get{return _number1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number2
		{
			set{ _number2=value;}
			get{return _number2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number3
		{
			set{ _number3=value;}
			get{return _number3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number4
		{
			set{ _number4=value;}
			get{return _number4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number5
		{
			set{ _number5=value;}
			get{return _number5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Number6
		{
			set{ _number6=value;}
			get{return _number6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Number7
		{
			set{ _number7=value;}
			get{return _number7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Number8
		{
			set{ _number8=value;}
			get{return _number8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String1
		{
			set{ _string1=value;}
			get{return _string1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String2
		{
			set{ _string2=value;}
			get{return _string2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String3
		{
			set{ _string3=value;}
			get{return _string3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String4
		{
			set{ _string4=value;}
			get{return _string4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String5
		{
			set{ _string5=value;}
			get{return _string5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String6
		{
			set{ _string6=value;}
			get{return _string6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String7
		{
			set{ _string7=value;}
			get{return _string7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string String8
		{
			set{ _string8=value;}
			get{return _string8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Datetime1
		{
			set{ _datetime1=value;}
			get{return _datetime1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Datetime2
		{
			set{ _datetime2=value;}
			get{return _datetime2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Datetime3
		{
			set{ _datetime3=value;}
			get{return _datetime3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Datetime4
		{
			set{ _datetime4=value;}
			get{return _datetime4;}
		}
		#endregion Model
    }
}
