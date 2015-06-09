using System;
using System.Text;
namespace Tellyes.Model
{
	/// <summary>
	/// 组织机构级别名称管理表
	/// </summary>
	[Serializable]
	public partial class Organization_Level
	{
		public Organization_Level()
		{}
		#region Model
		private int _ol_id;
		private string _ol_name;
		private string _ol_content;
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
		/// 组织机构级别ID
		/// </summary>
		public virtual int OL_ID
		{
			set{ _ol_id=value;}
			get{return _ol_id;}
		}
		/// <summary>
		/// 组织机构级别名称
		/// </summary>
        public virtual string OL_Name
		{
			set{ _ol_name=value;}
			get{return _ol_name;}
		}
		/// <summary>
		/// 描述
		/// </summary>
        public virtual string OL_Content
		{
			set{ _ol_content=value;}
			get{return _ol_content;}
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

        public virtual string ToJsonString()
        {
            return new StringBuilder()
                .Append("{")
                .Append("\"OL_ID\":\"" + this.OL_ID + "\",")
                .Append("\"OL_Name\":\"" + Uri.EscapeDataString(this.OL_Name) + "\",")
                .Append("\"OL_Content\":\"" + (this.OL_Content == null ? "" : Uri.EscapeDataString(this.OL_Content)) + "\"")
                .Append("}")
                .ToString();
        }
	}
}

