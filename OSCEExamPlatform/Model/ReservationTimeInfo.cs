using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class ReservationTimeInfo
    {
        private int _reservationtimeinfoid;
        /// <summary>
        /// ReservationTimeInfoID
        /// </summary>
        public virtual int ReservationTimeInfoID
        {
            get { return _reservationtimeinfoid; }
            set { _reservationtimeinfoid = value; }
        }

        private string _enity_id;
        /// <summary>
        /// 在考试中，相当于E_ID
        /// </summary>
        public virtual string EnityID
        {
            get { return _enity_id; }
            set { _enity_id = value; }
        }

        private string _reservationtimeinfodateinfo;
        /// <summary>
        /// ReservationTimeInfoDateInfo
        /// </summary>
        public virtual string ReservationTimeInfoDateInfo
        {
            get { return _reservationtimeinfodateinfo; }
            set { _reservationtimeinfodateinfo = value; }
        }

        private string _reservationtimeinfostarttime;
        /// <summary>
        /// ReservationTimeInfoStartTime
        /// </summary>
        public virtual string ReservationTimeInfoStartTime
        {
            get { return _reservationtimeinfostarttime; }
            set { _reservationtimeinfostarttime = value; }
        }

        private string _reservationtimeinfoendtime;
        /// <summary>
        /// ReservationTimeInfoEndTime
        /// </summary>
        public virtual string ReservationTimeInfoEndTime
        {
            get { return _reservationtimeinfoendtime; }
            set { _reservationtimeinfoendtime = value; }
        }

        private int _reservationid;
        /// <summary>
        /// ReservationID
        /// </summary>
        public virtual int ReservationID
        {
            get { return _reservationid; }
            set { _reservationid = value; }
        }

    }
}
