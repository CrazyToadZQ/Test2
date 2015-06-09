using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class IllnessCaseScriptMarkSheet
    {
        /// <summary>
        /// 病例脚本信息主键
        /// </summary>		
        private int _illnesscasescriptmarksheetid;
        public virtual int IllnessCaseScriptMarkSheetID
        {
            get { return _illnesscasescriptmarksheetid; }
            set { _illnesscasescriptmarksheetid = value; }
        }
        /// <summary>
        /// 病例脚本ID
        /// </summary>		
        private int _illnesscasescriptid;
        public virtual int IllnessCaseScriptID
        {
            get { return _illnesscasescriptid; }
            set { _illnesscasescriptid = value; }
        }
        /// <summary>
        /// 评分表ID
        /// </summary>		
        private int _marksheetid;
        public virtual int MarkSheetID
        {
            get { return _marksheetid; }
            set { _marksheetid = value; }
        }
    }
}
