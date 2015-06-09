using System;
namespace Tellyes.Model
{
	/// <summary>
	/// SingleStationExamRoom_DeviceClass:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SingleStationExamRoom_DeviceClass
	{
		public SingleStationExamRoom_DeviceClass()
		{}
		#region Model
		private int _id;
		private Guid? _e_id;
        private Guid? _es_id;
		private int _dc_id;
		private int _d_count=1;
		/// <summary>
		/// 
		/// </summary>
        public virtual int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual Guid? E_ID
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
        /// <summary>
        /// 
        /// </summary>
        public virtual Guid? ES_ID
        {
            set { _es_id = value; }
            get { return _es_id; }
        }
		/// <summary>
		/// 
		/// </summary>
        public virtual int DC_ID
		{
			set{ _dc_id=value;}
			get{return _dc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
        public virtual int D_Count
		{
			set{ _d_count=value;}
			get{return _d_count;}
		}
		#endregion Model

	}
}

