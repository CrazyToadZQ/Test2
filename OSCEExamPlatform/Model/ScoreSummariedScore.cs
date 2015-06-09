using System;
namespace Tellyes.Model
{
    /// <summary>
    /// 已汇总成绩
    /// </summary>
    [Serializable]
    public partial class ScoreSummariedScore
    {
        public ScoreSummariedScore()
        { }
        #region Model
        private int _id;
        private int _student_id;
        private Guid _e_id;
        private Guid _es_id;
        private int _room_id;
        private decimal _score = 0M;
        private string _timestamp;
        private string _latescoreid = "";
        private int? _estu_examnumber;
        
        private int? _scoreType;
        private int? _scoreModifyUserInfoID;
        private DateTime? _lastScoreModifyDate;


        /// <summary>
        /// 
        /// </summary>
        public virtual int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int Student_ID
        {
            set { _student_id = value; }
            get { return _student_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual Guid E_ID
        {
            set { _e_id = value; }
            get { return _e_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual Guid ES_ID
        {
            set { _es_id = value; }
            get { return _es_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int Room_ID
        {
            set { _room_id = value; }
            get { return _room_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual decimal score
        {
            set { _score = value; }
            get { return _score; }
        }
        /// <summary>
        /// RealTimeScroe_ID_DateTime
        /// </summary>
        public virtual string timeStamp
        {
            set { _timestamp = value; }
            get { return _timestamp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string lateScoreID
        {
            set { _latescoreid = value; }
            get { return _latescoreid; }
        }
        /// <summary>
        /// 考号
        /// </summary>
        public virtual int? EStu_ExamNumber
        {
            set { _estu_examnumber = value; }
            get { return _estu_examnumber; }
        }

        /// <summary>
        /// 成绩来源类型（1-手持评分提交成绩，2-系统录入或修改成绩，3-远程评分提交成绩，4-客观评分提交成绩）
        /// </summary>
        public virtual int? ScoreType
        {
            set { _scoreType = value; }
            get { return _scoreType; }
        }
        /// <summary>
        /// 最后一次修改成绩的用户ID
        /// </summary>
        public virtual int? ScoreModifyUserInfoID
        {
            set { _scoreModifyUserInfoID = value; }
            get { return _scoreModifyUserInfoID; }
        }
        /// <summary>
        /// 成绩的最后修改时间
        /// </summary>
        public virtual DateTime? LastScoreModifyDate
        {
            set { _lastScoreModifyDate = value; }
            get { return _lastScoreModifyDate; }
        } 
        #endregion Model

    }
}

