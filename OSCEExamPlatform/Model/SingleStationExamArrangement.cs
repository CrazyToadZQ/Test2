using System;
namespace Tellyes.Model
{
	/// <summary>
	/// SingleStationExamArrangement:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class SingleStationExamArrangement
	{
		public SingleStationExamArrangement()
		{}
		#region Model
		private int _se_id;
		private Guid _e_id;
		private int _u_id;
		private int _room_id;
		private DateTime _se_starttime;
        private DateTime _se_endtime;
		private Guid _es_id;
        private Guid _esr_id;
        private Guid _examStudent_ID;
		/// <summary>
		/// 
		/// </summary>
		public virtual int SE_ID
		{
			set{ _se_id=value;}
			get{return _se_id;}
		}
		/// <summary>
		/// ����Id��ExamTable���
		/// </summary>
        public virtual Guid E_ID
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
		/// <summary>
		/// ����ID��UserInfo�����
		/// </summary>
        public virtual int U_ID
		{
			set{ _u_id=value;}
			get{return _u_id;}
		}
		/// <summary>
		/// ����ţ�Room�����
		/// </summary>
        public virtual int Room_ID
		{
			set{ _room_id=value;}
			get{return _room_id;}
		}
		/// <summary>
        /// �����ڸ÷���Ľ�������ʱ��
		/// </summary>
        public virtual DateTime SE_EndTime
		{
            set { _se_endtime = value; }
            get { return _se_endtime; }
		}
        /// <summary>
        /// �����ڸ÷���Ŀ�ʼ����ʱ��
        /// </summary>
        public virtual DateTime SE_StartTime
        {
            set { _se_starttime = value; }
            get { return _se_starttime; }
        }
		/// <summary>
		/// ��վ�����,��վID
		/// </summary>
        public virtual Guid ES_ID
		{
			set{ _es_id=value;}
			get{return _es_id;}
		}
        /// <summary>
        /// ���Է���ID
        /// </summary>
        public virtual Guid ESR_ID
        {
            set { _esr_id = value; }
            get { return _esr_id; }
        }
        /// <summary>
        /// ���Կ���ID
        /// </summary>
        public virtual Guid ExamStudent_ID
        {
            set { _examStudent_ID = value; }
            get { return _examStudent_ID; }
        }
		#endregion Model

	}
}

