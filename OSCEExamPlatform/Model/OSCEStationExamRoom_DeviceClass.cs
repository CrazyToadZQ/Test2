using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [Serializable]
    public class OSCEStationExamRoom_DeviceClass
    {
        public OSCEStationExamRoom_DeviceClass()
        { }

        #region Model
        private int _id;
        /// <summary>
        /// ID
        /// </summary>
        public virtual int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private Guid _e_id;
        /// <summary>
        /// E_ID
        /// </summary>
        public virtual Guid E_ID
        {
            get { return _e_id; }
            set { _e_id = value; }
        }

        private int _dc_id;
        /// <summary>
        /// DC_ID
        /// </summary>
        public virtual int DC_ID
        {
            get { return _dc_id; }
            set { _dc_id = value; }
        }

        private int _d_count;
        /// <summary>
        /// D_Count
        /// </summary>
        public virtual int D_Count
        {
            get { return _d_count; }
            set { _d_count = value; }
        }

        private Guid _es_id;
        /// <summary>
        /// ES_ID
        /// </summary>
        public virtual Guid ES_ID
        {
            get { return _es_id; }
            set { _es_id = value; }
        }     
        #endregion
    }
}
