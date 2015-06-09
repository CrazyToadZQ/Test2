using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [Serializable]
    public class SingleStationExam_IllnessCase
    {
        public SingleStationExam_IllnessCase()
        { }
        #region Model
        private int _singleexam_illnesscase_id;
        private Guid _e_id;
        private Guid _es_id;
        private int? _illness_case_id;
        private int? _illness_case_script_id;
        private int? _marksheetid;
        /// <summary>
        /// 
        /// </summary>
        public virtual int SingleExam_IllnessCase_ID
        {
            set { _singleexam_illnesscase_id = value; }
            get { return _singleexam_illnesscase_id; }
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
        public virtual int? Illness_Case_ID
        {
            set { _illness_case_id = value; }
            get { return _illness_case_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? Illness_Case_Script_ID
        {
            set { _illness_case_script_id = value; }
            get { return _illness_case_script_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? MarkSheetID
        {
            set { _marksheetid = value; }
            get { return _marksheetid; }
        }
        #endregion Model
    }
}
