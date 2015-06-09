using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [Serializable]
    public class ExamStudent
    {
        public ExamStudent()
        { }
        #region Model
        private Guid _estu_id;
        private int _u_id;
        private Guid _e_id;
        private int _estu_examnumber;
        private int? _estu_int;
        private string _estu_string;
        private bool _estu_bool;
        /// <summary>
        /// 
        /// </summary>
        public virtual Guid EStu_ID
        {
            set { _estu_id = value; }
            get { return _estu_id; }
        }
        /// <summary>
        /// 外键,用户ID,关联用户表
        /// </summary>
        public virtual int U_ID
        {
            set { _u_id = value; }
            get { return _u_id; }
        }
        /// <summary>
        /// 外键,考试ID,关联考试表
        /// </summary>
        public virtual Guid E_ID
        {
            set { _e_id = value; }
            get { return _e_id; }
        }
        /// <summary>
        /// 考号，考号是针对每场考试的，从1到N的数字
        /// </summary>
        public virtual int EStu_ExamNumber
        {
            set { _estu_examnumber = value; }
            get { return _estu_examnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? EStu_int
        {
            set { _estu_int = value; }
            get { return _estu_int; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string EStu_string
        {
            set { _estu_string = value; }
            get { return _estu_string; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual bool EStu_bool
        {
            set { _estu_bool = value; }
            get { return _estu_bool; }
        }
        #endregion Model
    }
}
