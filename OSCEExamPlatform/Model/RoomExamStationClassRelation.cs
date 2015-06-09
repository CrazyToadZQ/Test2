using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class RoomExamStationClassRelation
    {
        /// <summary>
        /// 主键编号
        /// </summary>		
        private int _id;
        public virtual int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 房间ID
        /// </summary>		
        private int _room_id;
        public virtual int Room_ID
        {
            get { return _room_id; }
            set { _room_id = value; }
        }
        /// <summary>
        /// 考站类型ID
        /// </summary>		
        private int _exam_station_class_id;
        public virtual int Exam_Station_Class_ID
        {
            get { return _exam_station_class_id; }
            set { _exam_station_class_id = value; }
        }
    }
}
