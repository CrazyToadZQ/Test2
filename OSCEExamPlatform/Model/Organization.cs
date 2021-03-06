﻿using System;
namespace Tellyes.Model
{
	/// <summary>
	/// 组织机构表
	/// </summary>
	[Serializable]
	public partial class Organization
	{
		public Organization()
		{}
		#region Model
		private int _o_id;
		private string _o_name;
		private string _o_contont;
		private int _o_parentid;
		private int _ol_id;
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
        public virtual string O_Name
		{
			set{ _o_name=value;}
			get{return _o_name;}
		}
		/// <summary>
		/// 描述
		/// </summary>
        public virtual string O_Contont
		{
			set{ _o_contont=value;}
			get{return _o_contont;}
		}
		/// <summary>
		/// 上一级的ID标识（如果是顶级则为0）
		/// </summary>
        public virtual int O_ParentID
		{
			set{ _o_parentid=value;}
			get{return _o_parentid;}
		}
		/// <summary>
		/// 所属级别
		/// </summary>
        public virtual int OL_ID
		{
			set{ _ol_id=value;}
			get{return _ol_id;}
		}
		/// <summary>
		/// 
		/// </summary>
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
            jsonString += "\"O_ID\":\"" + this.O_ID + "\",";
            jsonString += "\"O_Name\":\"" + Uri.EscapeDataString(this.O_Name) + "\",";
            jsonString += "\"O_ParentID\":\"" + this.O_ParentID + "\",";
            jsonString += "\"O_Contont\":\"" + Uri.EscapeDataString(this.O_Contont == null ? "" : this.O_Contont) + "\",";
            jsonString += "\"OL_ID\":\"" + this.OL_ID + "\",";
            jsonString += "\"O_Level\":\"" + this.O_Level + "\"";
            jsonString += "}";
            return jsonString;
        }

	}
}

