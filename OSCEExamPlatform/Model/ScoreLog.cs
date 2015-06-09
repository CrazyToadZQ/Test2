using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class ScoreLog
    {
        #region Model

        /// <summary>
        /// ScoreLogID
        /// </summary>
        public virtual int ScoreLogID
        {
            get;
            set;
        }
        /// <summary>
        /// 成绩修改的用户ID（手持评分成绩提交的用户ID或者是成绩修改的用户ID）
        /// </summary>
        public virtual int LogUserInfoID
        {
            get;
            set;
        }
        /// <summary>
        /// 成绩修改的时间
        /// </summary>
        public virtual DateTime LogDatetime
        {
            get;
            set;
        }
        /// <summary>
        /// 成绩修改日志类型（1-手持评分提交成绩，2-系统录入或修改成绩，3-中央评分提交成绩，4-客观评分提交成绩）
        /// </summary>
        public virtual int LogType
        {
            get;
            set;
        }
        /// <summary>
        /// 成绩汇总表ID（ScoreSummariedScoreID）
        /// </summary>
        public virtual int ScoreSummariedScoreID
        {
            get;
            set;
        }
        /// <summary>
        /// 考试ID
        /// </summary>
        public virtual Guid E_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 考站ID
        /// </summary>
        public virtual Guid ES_ID
        {
            get;
            set;
        }
        /// <summary>
        /// Room_ID
        /// </summary>
        public virtual int Room_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 考生用户ID（考生在UserInfo表中的ID）
        /// </summary>
        public virtual int StudentUserInfoID
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-11-29，考生现场得分（评分评分、客观得分等）
        /// </summary>
        public virtual decimal Score
        {
            get;
            set;
        }
        /// <summary>
        /// ScoreLogNumber1
        /// </summary>
        public virtual int? ScoreLogNumber1
        {
            get;
            set;
        }
        /// <summary>
        /// ScoreLogNumber2
        /// </summary>
        public virtual decimal? ScoreLogNumber2
        {
            get;
            set;
        }
        /// <summary>
        /// ScoreLogString1
        /// </summary>
        public virtual string ScoreLogString1
        {
            get;
            set;
        }
        /// <summary>
        /// ScoreLogString2
        /// </summary>
        public virtual string ScoreLogString2
        {
            get;
            set;
        }
        /// <summary>
        /// ScoreLogDatetime1
        /// </summary>
        public virtual DateTime? ScoreLogDatetime1
        {
            get;
            set;
        }
        /// <summary>
        /// ScoreLogDatetime2
        /// </summary>
        public virtual DateTime? ScoreLogDatetime2
        {
            get;
            set;
        }
        /// <summary>
        /// 评分表ID 苗 2014-11-28
        /// </summary>
        public virtual int? MS_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳。2014-11-29，评分权重
        /// </summary>
        public virtual int? ScorePercent
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-11-29，考生考站得分
        /// </summary>
        public virtual decimal? ExamStationScore
        {
            get;
            set;
        }
        /// <summary>
        /// 考站成绩权重
        /// </summary>
        public virtual int? ExamStationPercent
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-11-29，考生考试得分
        /// </summary>
        public virtual decimal? ExamScore
        {
            get;
            set;
        }

        #endregion

        #region ToJsonString

        /// <summary>
        /// 生成闭合结构的json结构
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 生成json结构
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new System.Text.StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"ScoreLogID\":\"").Append(Uri.EscapeDataString(this.ScoreLogID.ToString())).Append("\",")
                .Append("\"LogUserInfoID\":\"").Append(Uri.EscapeDataString(this.LogUserInfoID.ToString())).Append("\",")
                .Append("\"LogDatetime\":\"").Append(Uri.EscapeDataString(this.LogDatetime.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"LogType\":\"").Append(Uri.EscapeDataString(this.LogType.ToString())).Append("\",")
                .Append("\"ScoreSummariedScoreID\":\"").Append(Uri.EscapeDataString(this.ScoreSummariedScoreID.ToString())).Append("\",")
                .Append("\"E_ID\":\"").Append(Uri.EscapeDataString(this.E_ID.ToString())).Append("\",")
                .Append("\"ES_ID\":\"").Append(Uri.EscapeDataString(this.ES_ID.ToString())).Append("\",")
                .Append("\"Room_ID\":\"").Append(Uri.EscapeDataString(this.Room_ID.ToString())).Append("\",")
                .Append("\"StudentUserInfoID\":\"").Append(Uri.EscapeDataString(this.StudentUserInfoID.ToString())).Append("\",")
                .Append("\"Score\":\"").Append(Uri.EscapeDataString(this.Score.ToString())).Append("\",")
                .Append("\"ScoreLogNumber1\":\"").Append(Uri.EscapeDataString(this.ScoreLogNumber1 == null ? "" : this.ScoreLogNumber1.ToString())).Append("\",")
                .Append("\"ScoreLogNumber2\":\"").Append(Uri.EscapeDataString(this.ScoreLogNumber2 == null ? "" : this.ScoreLogNumber2.ToString())).Append("\",")
                .Append("\"ScoreLogString1\":\"").Append(Uri.EscapeDataString(this.ScoreLogString1 == null ? "" : this.ScoreLogString1.ToString())).Append("\",")
                .Append("\"ScoreLogString2\":\"").Append(Uri.EscapeDataString(this.ScoreLogString2 == null ? "" : this.ScoreLogString2.ToString())).Append("\",")
                .Append("\"ScoreLogDatetime1\":\"").Append(Uri.EscapeDataString(this.ScoreLogDatetime1 == null ? "" : Convert.ToDateTime(this.ScoreLogDatetime1).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"ScoreLogDatetime2\":\"").Append(Uri.EscapeDataString(this.ScoreLogDatetime2 == null ? "" : Convert.ToDateTime(this.ScoreLogDatetime2).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"MS_ID\":\"").Append(Uri.EscapeDataString(this.MS_ID == null ? "" : this.MS_ID.ToString())).Append("\",")
                .Append("\"ScorePercent\":\"").Append(Uri.EscapeDataString(this.ScorePercent == null ? "" : this.ScorePercent.ToString())).Append("\",")
                .Append("\"ExamStationScore\":\"").Append(Uri.EscapeDataString(this.ExamStationScore == null ? "" : this.ExamStationScore.ToString())).Append("\",")
                .Append("\"ExamStationPercent\":\"").Append(Uri.EscapeDataString(this.ExamStationPercent == null ? "" : this.ExamStationPercent.ToString())).Append("\",")
                .Append("\"ExamScore\":\"").Append(Uri.EscapeDataString(this.ExamScore == null ? "" : this.ExamScore.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
