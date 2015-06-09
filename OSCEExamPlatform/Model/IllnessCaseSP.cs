using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class IllnessCaseSP
    {
        /// <summary>
        /// 病例SP信息主键
        /// </summary>		
        private int _illnesscasespid;
        public virtual int IllnessCaseSPID
        {
            get { return _illnesscasespid; }
            set { _illnesscasespid = value; }
        }
        /// <summary>
        /// 病例ID
        /// </summary>		
        private int _illnesscaseid;
        public virtual int IllnessCaseID
        {
            get { return _illnesscaseid; }
            set { _illnesscaseid = value; }
        }
        /// <summary>
        /// SP用户ID
        /// </summary>		
        private int _spuserinfoid;
        public virtual int SPUserInfoID
        {
            get { return _spuserinfoid; }
            set { _spuserinfoid = value; }
        }
    }
}
