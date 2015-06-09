using System;
namespace Tellyes.Model
{
	/// <summary>
	/// QuestionOption:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class QuestionOption
	{
		public QuestionOption()
		{}
		#region Model
		private int _qo_id;
        private int _eq_id = 0;
		private string _qo_option;
		private string _qo_accessory;
		private string _qo_subjectanswer;
		private string _qo_explain;
		private int _qo_objectanswer=0;
		private int? _int1;
		private int? _int2;
		private int? _int3;
		private string _string1;
		private string _string2;
		private string _string3;
		private string _string4;
		private string _string5;
		/// <summary>
		/// 
		/// </summary>
		public int QO_ID
		{
			set{ _qo_id=value;}
			get{return _qo_id;}
		}
		/// <summary>
		/// 试题信息表ID
		/// </summary>
		public int EQ_ID
		{
			set{ _eq_id=value;}
			get{return _eq_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QO_Option
		{
			set{ _qo_option=value;}
			get{return _qo_option;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QO_Accessory
		{
			set{ _qo_accessory=value;}
			get{return _qo_accessory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QO_SubjectAnswer
		{
			set{ _qo_subjectanswer=value;}
			get{return _qo_subjectanswer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QO_Explain
		{
			set{ _qo_explain=value;}
			get{return _qo_explain;}
		}
		/// <summary>
		/// 是否是客观题正确答案，0:代表不是正确答案，1:代表是正确答案。
		/// </summary>
		public int QO_ObjectAnswer
		{
			set{ _qo_objectanswer=value;}
			get{return _qo_objectanswer;}
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
		#endregion Model

	}
}

