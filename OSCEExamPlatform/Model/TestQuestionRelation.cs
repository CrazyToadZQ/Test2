
using System;
namespace Tellyes.Model
{
	/// <summary>
	/// TestQuestionRelation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TestQuestionRelation
	{
		public TestQuestionRelation()
		{}
		#region Model
		private int _tqr_id;
		private int _e_id;
		private int _q_id;
		private int _tqr_number=0;
		private string _tqr_score;
		/// <summary>
		/// 
		/// </summary>
		public int TQR_ID
		{
			set{ _tqr_id=value;}
			get{return _tqr_id;}
		}
		/// <summary>
		/// 试卷信息表主键
		/// </summary>
		public int E_ID
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
		/// <summary>
		/// 试卷试题表主键
		/// </summary>
		public int Q_ID
		{
			set{ _q_id=value;}
			get{return _q_id;}
		}
		/// <summary>
		/// 试题在该试卷中的题号
		/// </summary>
		public int TQR_Number
		{
			set{ _tqr_number=value;}
			get{return _tqr_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TQR_Score
		{
			set{ _tqr_score=value;}
			get{return _tqr_score;}
		}
		#endregion Model

	}
}

