using System;
namespace Tellyes.Model
{
	/// <summary>
	/// ExamQuestionInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExamQuestionInfo
	{
		public ExamQuestionInfo()
		{}
		#region Model
		private int _eq_id;
		private string _eq_name;
		private int _qt_id;
		private int _eq_difficulty=0;
		private int _eq_type=0;
		private string _eq_stem;
		private string _eq_stemaccessory;
		private string _qo_id;
		private int _eq_classify=0;
		private int _eq_answernumber=0;
		private int _eq_kind=0;
		private int _eq_share=0;
		private int _eq_creater=0;
		private DateTime _eq_createtime;
		private DateTime? _eq_modifytime;
		private int _eq_oldid=0;
		private int? _int1;
		private int? _int2;
		private int? _int3;
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
		public int EQ_ID
		{
			set{ _eq_id=value;}
			get{return _eq_id;}
		}
		/// <summary>
		/// 试题名称
		/// </summary>
		public string EQ_Name
		{
			set{ _eq_name=value;}
			get{return _eq_name;}
		}
		/// <summary>
		/// QuestionType的主键
		/// </summary>
		public int QT_ID
		{
			set{ _qt_id=value;}
			get{return _qt_id;}
		}
		/// <summary>
		/// 试题难度系数,0：代表低难道题，1：代表低难度题，2：代表高难度题
		/// </summary>
		public int EQ_Difficulty
		{
			set{ _eq_difficulty=value;}
			get{return _eq_difficulty;}
		}
		/// <summary>
		/// 0:代表客观题，1：代表主观题
		/// </summary>
		public int EQ_Type
		{
			set{ _eq_type=value;}
			get{return _eq_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EQ_Stem
		{
			set{ _eq_stem=value;}
			get{return _eq_stem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EQ_StemAccessory
		{
			set{ _eq_stemaccessory=value;}
			get{return _eq_stemaccessory;}
		}
		/// <summary>
		/// QuestionOption表ID字符串
		/// </summary>
		public string QO_ID
		{
			set{ _qo_id=value;}
			get{return _qo_id;}
		}
		/// <summary>
		/// 0：代表自建试题，1：代表系统自带试题，2：代表共享试题（预留）
		/// </summary>
		public int EQ_Classify
		{
			set{ _eq_classify=value;}
			get{return _eq_classify;}
		}
		/// <summary>
		/// 0:代表单选题，1：代表多选题
		/// </summary>
		public int EQ_AnswerNumber
		{
			set{ _eq_answernumber=value;}
			get{return _eq_answernumber;}
		}
		/// <summary>
		/// 0:代表一般题，1:代表图片题，2：代表音频题，3：代表视频题
		/// </summary>
		public int EQ_Kind
		{
			set{ _eq_kind=value;}
			get{return _eq_kind;}
		}
		/// <summary>
		/// 试题共享，0：代表不共享，1：代表共享。
		/// </summary>
		public int EQ_Share
		{
			set{ _eq_share=value;}
			get{return _eq_share;}
		}
		/// <summary>
		/// 试题创建人账号,0:代表系统试题
		/// </summary>
		public int EQ_Creater
		{
			set{ _eq_creater=value;}
			get{return _eq_creater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EQ_CreateTime
		{
			set{ _eq_createtime=value;}
			get{return _eq_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EQ_ModifyTime
		{
			set{ _eq_modifytime=value;}
			get{return _eq_modifytime;}
		}
		/// <summary>
		/// 试题的原编号
		/// </summary>
		public int EQ_OldID
		{
			set{ _eq_oldid=value;}
			get{return _eq_oldid;}
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

