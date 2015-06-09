using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class MultiStationExamArrangement
    {
        private int _msea_id;
        private Guid _e_id;
        private Guid _es_id;
        private int _room_id;
        private Guid _estu_id;
        private int _u_id;
        private DateTime _exam_starttime;
        private DateTime _exam_endtime;
        private Guid? _esr_id;

        /// <summary>
        /// 多站式考试排考信息ID
        /// </summary>		
        public virtual int MSEA_ID
        {
            get { return _msea_id; }
            set { _msea_id = value; }
        }
        /// <summary>
        /// 考试ID
        /// </summary>		
        public virtual Guid E_ID
        {
            get { return _e_id; }
            set { _e_id = value; }
        }
        /// <summary>
        /// 考站ID
        /// </summary>		
        public virtual Guid ES_ID
        {
            get { return _es_id; }
            set { _es_id = value; }
        }
        /// <summary>
        /// 房间ID
        /// </summary>		
        public virtual int Room_ID
        {
            get { return _room_id; }
            set { _room_id = value; }
        }
        /// <summary>
        /// 考生考号信息ID
        /// </summary>		
        public virtual Guid EStu_ID
        {
            get { return _estu_id; }
            set { _estu_id = value; }
        }
        /// <summary>
        /// 考生用户ID
        /// </summary>		
        public virtual int U_ID
        {
            get { return _u_id; }
            set { _u_id = value; }
        }
        /// <summary>
        /// 考试开始时间
        /// </summary>		
        public virtual DateTime Exam_StartTime
        {
            get { return _exam_starttime; }
            set { _exam_starttime = value; }
        }
        /// <summary>
        /// 考试结束时间
        /// </summary>		
        public virtual DateTime Exam_EndTime
        {
            get { return _exam_endtime; }
            set { _exam_endtime = value; }
        }
        /// <summary>
        /// 董阳，2014-10-21，考试房间ID（ESR_ID）
        /// </summary>
        public virtual Guid? ESR_ID
        {
            get { return _esr_id; }
            set { _esr_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return new StringBuilder()
                .Append("{")
                .Append("\"MSEA_ID\":\"" + this.MSEA_ID + "\",")
                .Append("\"E_ID\":\"" + this.E_ID + "\",")
                .Append("\"ES_ID\":\"" + this.ES_ID + "\",")
                .Append("\"Room_ID\":\"" + this.Room_ID + "\",")
                .Append("\"EStu_ID\":\"" + this.EStu_ID + "\",")
                .Append("\"U_ID\":\"" + this.U_ID + "\",")
                .Append("\"Exam_StartTime\":\"" + this.Exam_StartTime.ToString("yyyy-MM-dd HH:mm") + "\",")
                .Append("\"Exam_EndTime\":\"" + this.Exam_EndTime.ToString("yyyy-MM-dd HH:mm") + "\",")
                .Append("\"ESR_ID\":\"" + (this.ESR_ID == null ? "" : this.ESR_ID.ToString()) + "\",")
                .Append("}")
                .ToString();
        }
    }
}
