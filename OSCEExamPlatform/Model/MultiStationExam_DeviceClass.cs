using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class MultiStationExam_DeviceClass
    {
        /// <summary>
        /// 多站式考试与设备分类关系ID
        /// </summary>		
        private int _mse_dc_id;
        public virtual int MSE_DC_ID
        {
            get { return _mse_dc_id; }
            set { _mse_dc_id = value; }
        }
        /// <summary>
        /// 考试ID
        /// </summary>		
        private Guid _e_id;
        public virtual Guid E_ID
        {
            get { return _e_id; }
            set { _e_id = value; }
        }
        /// <summary>
        /// 考站ID
        /// </summary>		
        private Guid _es_id;
        public virtual Guid ES_ID
        {
            get { return _es_id; }
            set { _es_id = value; }
        }
        /// <summary>
        /// 考站使用房间ID
        /// </summary>		
        private int _room_id;
        public virtual int Room_ID
        {
            get { return _room_id; }
            set { _room_id = value; }
        }
        /// <summary>
        /// 设备分类ID
        /// </summary>		
        private int _dc_id;
        public virtual int DC_ID
        {
            get { return _dc_id; }
            set { _dc_id = value; }
        }
        /// <summary>
        /// 需要设备数量
        /// </summary>		
        private int _dc_count;
        public virtual int DC_Count
        {
            get { return _dc_count; }
            set { _dc_count = value; }
        }
    }
}
