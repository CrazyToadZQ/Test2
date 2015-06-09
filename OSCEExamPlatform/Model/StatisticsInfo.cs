using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class StatisticsInfo
    {
        private int totalstudentnum;
        private int statisticsstudentnum;
        private int examstationnum;
        private decimal totalscore;
        private decimal averagescore;
        private decimal singlestationscore_max;
        private decimal singlestationscore_min;
        private decimal totalstudentscore_max;
        private decimal totalstudentscore_min;

        /// <summary>
        /// 总人数
        /// </summary>
        public int TotalStudentNum
        {
            get { return this.totalstudentnum; }
            set { this.totalstudentnum = value; }
        }
        /// <summary>
        /// 统计人数
        /// </summary>
        public int StatisticsStudentNum
        {
            get { return this.statisticsstudentnum; }
            set { this.statisticsstudentnum = value; }
        }
        /// <summary>
        /// 考站数
        /// </summary>
        public int ExamStationNum
        {
            get { return this.examstationnum; }
            set { this.examstationnum = value; }
        }
        /// <summary>
        /// 总分数
        /// </summary>
        public decimal TotalScore
        {
            get { return this.totalscore; }
            set { this.totalscore = value; }
        }
        /// <summary>
        /// 平均分
        /// </summary>
        public decimal AverageScore
        {
            get { return this.averagescore; }
            set { this.averagescore = value; }
        }
        /// <summary>
        /// 单站最高分
        /// </summary>
        public decimal SingleStationScore_Max 
        {
            get { return this.singlestationscore_max; }
            set { this.singlestationscore_max = value; }
        }
        /// <summary>
        /// 单站最低分
        /// </summary>
        public decimal SingleStationScore_Min 
        {
            get { return this.singlestationscore_min; }
            set { this.singlestationscore_min = value; }
        }
        /// <summary>
        /// 总分最高分
        /// </summary>
        public decimal TotalStudentScore_Max 
        {
            get { return this.totalstudentscore_max; }
            set { this.totalstudentscore_max = value; }
        }
        /// <summary>
        /// 总分最低分
        /// </summary>
        public decimal TotalStudentScore_Min 
        {
            get { return this.totalstudentscore_min; }
            set { this.totalstudentscore_min = value; }
        }
    }
}
