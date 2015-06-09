using System;
using System.Text;
namespace Tellyes.Model
{
    /// <summary>
    /// MarkSheet:父评分表
    /// </summary>
    [Serializable]
    public partial class MarkSheet
    {
        #region Model

        /// <summary>
        /// 主键，标志位
        /// </summary>
        public virtual int MS_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 外键，创建者id（注：0表示Admin；-1表示系统评分表）
        /// </summary>
        public virtual int User_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 外键，评分表类型id
        /// </summary>
        public virtual int MSK_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 评分表名称
        /// </summary>
        public virtual string MS_Name
        {
            get;
            set;
        }
        /// <summary>
        /// 共享权限：0代表不共享，1代表共享
        /// </summary>
        public virtual int MS_Share
        {
            get;
            set;
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime MS_CreateDate
        {
            get;
            set;
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime? MS_ModifyDate
        {
            get;
            set;
        }
        /// <summary>
        /// 修改人id
        /// </summary>
        public virtual int? MS_ModifyPerson
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳。2014-11-28，评分表总分
        /// </summary>
        public virtual decimal? MS_Score
        {
            get;
            set;
        }
        /// <summary>
        /// 逻辑删除列（0-目前还存在，1-已经删除）
        /// </summary>
        public virtual string string1
        {
            get;
            set;
        }
        /// <summary>
        /// string2
        /// </summary>
        public virtual string string2
        {
            get;
            set;
        }
        /// <summary>
        /// string3
        /// </summary>
        public virtual string string3
        {
            get;
            set;
        }
        /// <summary>
        /// string4
        /// </summary>
        public virtual string string4
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-11-18，预留数字字段
        /// </summary>
        public virtual int? MarkSheetNumber1
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-11-18，预留数字字段
        /// </summary>
        public virtual int? MarkSheetNumber2
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-11-18，预留数字字段
        /// </summary>
        public virtual decimal? MarkSheetNumber3
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-11-18，预留数字字段
        /// </summary>
        public virtual decimal? MarkSheetNumber4
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
                .Append("\"MS_ID\":\"").Append(Uri.EscapeDataString(this.MS_ID.ToString())).Append("\",")
                .Append("\"User_ID\":\"").Append(Uri.EscapeDataString(this.User_ID.ToString())).Append("\",")
                .Append("\"MSK_ID\":\"").Append(Uri.EscapeDataString(this.MSK_ID.ToString())).Append("\",")
                .Append("\"MS_Name\":\"").Append(Uri.EscapeDataString(this.MS_Name.ToString())).Append("\",")
                .Append("\"MS_Share\":\"").Append(Uri.EscapeDataString(this.MS_Share.ToString())).Append("\",")
                .Append("\"MS_CreateDate\":\"").Append(Uri.EscapeDataString(this.MS_CreateDate.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"MS_ModifyDate\":\"").Append(Uri.EscapeDataString(this.MS_ModifyDate == null ? "" : Convert.ToDateTime(this.MS_ModifyDate).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"MS_ModifyPerson\":\"").Append(Uri.EscapeDataString(this.MS_ModifyPerson == null ? "" : this.MS_ModifyPerson.ToString())).Append("\",")
                .Append("\"MS_Score\":\"").Append(Uri.EscapeDataString(this.MS_Score == null ? "" : this.MS_Score.ToString())).Append("\",")
                .Append("\"string1\":\"").Append(Uri.EscapeDataString(this.string1 == null ? "" : this.string1.ToString())).Append("\",")
                .Append("\"string2\":\"").Append(Uri.EscapeDataString(this.string2 == null ? "" : this.string2.ToString())).Append("\",")
                .Append("\"string3\":\"").Append(Uri.EscapeDataString(this.string3 == null ? "" : this.string3.ToString())).Append("\",")
                .Append("\"string4\":\"").Append(Uri.EscapeDataString(this.string4 == null ? "" : this.string4.ToString())).Append("\",")
                .Append("\"MarkSheetNumber1\":\"").Append(Uri.EscapeDataString(this.MarkSheetNumber1 == null ? "" : this.MarkSheetNumber1.ToString())).Append("\",")
                .Append("\"MarkSheetNumber2\":\"").Append(Uri.EscapeDataString(this.MarkSheetNumber2 == null ? "" : this.MarkSheetNumber2.ToString())).Append("\",")
                .Append("\"MarkSheetNumber3\":\"").Append(Uri.EscapeDataString(this.MarkSheetNumber3 == null ? "" : this.MarkSheetNumber3.ToString())).Append("\",")
                .Append("\"MarkSheetNumber4\":\"").Append(Uri.EscapeDataString(this.MarkSheetNumber4 == null ? "" : this.MarkSheetNumber4.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}

