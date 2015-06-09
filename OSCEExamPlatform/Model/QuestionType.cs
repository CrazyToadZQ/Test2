using System;
namespace Tellyes.Model
{
	/// <summary>
	/// QuestionType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class QuestionType
	{
		public QuestionType()
		{}
		#region Model
		private int _qt_id;
		private string _qt_name;
		private int? _int1;
		private int? _int2;
		private int? _int3;
		private string _string1;
		private string _string2;
		private string _string3;
		/// <summary>
		/// 
		/// </summary>
		public int QT_ID
		{
			set{ _qt_id=value;}
			get{return _qt_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QT_Name
		{
			set{ _qt_name=value;}
			get{return _qt_name;}
		}
		/// <summary>
        /// 逻辑删除列（1-没有被删除，还存在；0-已经被删除）
		/// </summary>
		public int? int1
		{
			set{ _int1=value;}
			get{return _int1;}
		}
		/// <summary>
        /// 是否是系统自带试题类型（1-是系统自带，0-不是系统自带）
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
		#endregion Model

        /// <summary>
        ///  model To Jason 转换方法， 如果其他预留字段需要使用，则需要扩展该方法，2014-5-21 陶东利
        /// </summary>
        /// <returns></returns>

        public virtual string ToJsonString()
        {
            string jsonString = "{";
            jsonString += "\"QT_ID\":\"" + this.QT_ID + "\",";
            jsonString += "\"QT_Name\":\"" + Uri.EscapeDataString(this.QT_Name) + "\",";
            jsonString += "\"int1\":\"" + this.int1 + "\",";
            jsonString += "\"int2\":\"" + this.int2 + "\"";
            jsonString += "}";
            return jsonString;

        }

	}
}

