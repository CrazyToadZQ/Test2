using System;
namespace Tellyes.Model
{
	/// <summary>
	/// QuestionInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class QuestionInfo
	{
		public QuestionInfo()
		{}
		#region Model
		private int _q_id;
		private int _eq_id;
		private string _q_score= "0";
		private int? _int1;
		private int? _int2;
		private int? _int3;
		private int? _int4;
		private int? _int5;
		private string _string1;
		private string _string2;
		private string _string3;
		private string _string4;
		private string _string5;
		private DateTime? _date1;
		private DateTime? _date2;
		private DateTime? _date3;
		/// <summary>
		/// 
		/// </summary>
		public int Q_ID
		{
			set{ _q_id=value;}
			get{return _q_id;}
		}
		/// <summary>
		/// 试题的ID
		/// </summary>
		public int EQ_ID
		{
			set{ _eq_id=value;}
			get{return _eq_id;}
		}
		/// <summary>
		/// 试题分数，
		/// </summary>
		public string Q_Score
		{
			set{ _q_score=value;}
			get{return _q_score;}
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
		public int? int4
		{
			set{ _int4=value;}
			get{return _int4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? int5
		{
			set{ _int5=value;}
			get{return _int5;}
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
		public string string5
		{
			set{ _string5=value;}
			get{return _string5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date1
		{
			set{ _date1=value;}
			get{return _date1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date2
		{
			set{ _date2=value;}
			get{return _date2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date3
		{
			set{ _date3=value;}
			get{return _date3;}
		}
		#endregion Model

	}
}

