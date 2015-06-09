using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 分管班级表
	/// </summary>
	[Serializable]
	public partial class ManagementRelation
	{
		public ManagementRelation()
		{}
		#region Model
		private Guid _id;
        private int _u_id;
        private int _o_id;
		private int _flag;
        private DateTime _addtime;
        private DateTime _endtime;
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
        /// ID
        /// </summary>
        public virtual Guid ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 组织机构ID
        /// </summary>
        public virtual int U_ID
        {
            set { _u_id = value; }
            get { return _u_id; }
        }
		/// <summary>
		/// 组织机构ID
		/// </summary>
		public virtual int O_ID
		{
			set{ _o_id=value;}
			get{return _o_id;}
		}
		/// <summary>
		/// 机构名称
		/// </summary>
        public virtual int Flag
		{
            set { _flag = value; }
            get { return _flag; }
		}
		/// <summary>
		/// 描述
		/// </summary>
        public virtual DateTime AddTime
		{
            set { _addtime = value; }
            get { return _addtime; }
		}
		/// <summary>
		/// 上一级的ID标识（如果是顶级则为0）
		/// </summary>
        public virtual DateTime EndTime
		{
            set { _endtime = value; }
            get { return _endtime; }
		}
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
		#endregion Model

        private int _o_level;
        public virtual int O_Level
        {
            set { _o_level = value; }
            get { return _o_level; }
        }
        public virtual string ToJsonString()
        {
            string jsonString = "{";
            jsonString += "\"ID\":\"" + this.ID + "\",";
            jsonString += "\"U_ID\":\"" + this.U_ID + "\",";
            jsonString += "\"O_ID\":\"" + this.O_ID + "\",";
            jsonString += "\"Flag\":\"" + this.Flag + "\",";
            jsonString += "\"AddTime\":\"" + this.AddTime + "\",";
            jsonString += "\"EndTime\":\"" + this.EndTime + "\"";
            jsonString += "}";
            return jsonString;
        }

	}
}

