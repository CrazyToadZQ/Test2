
using System;
namespace Tellyes.Model
{
	/// <summary>
	/// ExamPageInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExamPageInfo
	{
		public ExamPageInfo()
		{}
		#region Model
		private int _e_id;
		private string _e_name;
		private int _e_totalscore=0;
		private int _e_totalnumber=0;
		private int _e_isshare=0;
		private int _e_answertime=0;
		private int _e_isrollback=0;
		private int _e_oldorder=0;
		private int _e_aoldorder=0;
		private int _e_creater;
		private DateTime _e_createtime;
		private DateTime? _e_modifytime;
		private string _e_remarks;
		private int _e_oldid=0;
		private int? _int1;
		private int? _int2;
		private int? _int3;
		private int? _int4;
		private int? _int5;
		private int? _int6;
		private string _string1;
		private string _string2;
		private string _string3;
		private string _string4;
		private string _string5;
		private string _string6;
		private DateTime? _date1;
		private DateTime? _date2;
		private DateTime? _date3;
		/// <summary>
		/// 主键，自增
		/// </summary>
		public int E_ID
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
		/// <summary>
		/// 试卷名称
		/// </summary>
		public string E_Name
		{
			set{ _e_name=value;}
			get{return _e_name;}
		}
		/// <summary>
		/// 试卷总分
		/// </summary>
		public int E_TotalScore
		{
			set{ _e_totalscore=value;}
			get{return _e_totalscore;}
		}
		/// <summary>
		/// 试卷中试题总数
		/// </summary>
		public int E_TotalNumber
		{
			set{ _e_totalnumber=value;}
			get{return _e_totalnumber;}
		}
		/// <summary>
		/// 是否共享，0：代表不共享，1：代表共享
		/// </summary>
		public int E_IsShare
		{
			set{ _e_isshare=value;}
			get{return _e_isshare;}
		}
		/// <summary>
		/// 试题答题限时（单位：秒）
		/// </summary>
		public int E_AnswerTime
		{
			set{ _e_answertime=value;}
			get{return _e_answertime;}
		}
		/// <summary>
		/// 试卷是否支持试题回滚，0：代表不支持回滚，1：代表支持回滚
		/// </summary>
		public int E_IsRollback
		{
			set{ _e_isrollback=value;}
			get{return _e_isrollback;}
		}
		/// <summary>
		/// 试题顺序,0：固定顺序，1：试题乱序
		/// </summary>
		public int E_OldOrder
		{
			set{ _e_oldorder=value;}
			get{return _e_oldorder;}
		}
		/// <summary>
		/// 选项乱序,0：代表固定顺序，1：代表答案选项乱序
		/// </summary>
		public int E_AOldOrder
		{
			set{ _e_aoldorder=value;}
			get{return _e_aoldorder;}
		}
		/// <summary>
		/// 试卷创建人账号,0:代表系统试题
		/// </summary>
		public int E_Creater
		{
			set{ _e_creater=value;}
			get{return _e_creater;}
		}
		/// <summary>
		/// 试卷创建时间
		/// </summary>
		public DateTime E_CreateTime
		{
			set{ _e_createtime=value;}
			get{return _e_createtime;}
		}
		/// <summary>
		/// 试卷修改时间
		/// </summary>
		public DateTime? E_ModifyTime
		{
			set{ _e_modifytime=value;}
			get{return _e_modifytime;}
		}
		/// <summary>
		/// 试卷备注信息
		/// </summary>
		public string E_Remarks
		{
			set{ _e_remarks=value;}
			get{return _e_remarks;}
		}
		/// <summary>
		/// 试卷的原编号。针对共享试卷另存为，防止进行二次另存为操作。
		/// </summary>
		public int E_OldID
		{
			set{ _e_oldid=value;}
			get{return _e_oldid;}
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
		public int? int6
		{
			set{ _int6=value;}
			get{return _int6;}
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
		public string string6
		{
			set{ _string6=value;}
			get{return _string6;}
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

