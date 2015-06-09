using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
 public  class GlobalParametersSetting
    {
        #region Model

        /// <summary>
        /// Global_Parameters_Setting_ID
        /// </summary>
        public virtual int Global_Parameters_Setting_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 评委是否支持绑定多个评分表（0-不支持，1-支持）
        /// </summary>
        public virtual int Judge_Is_Support_Binding_Multi_Mark_Sheet
        {
            get;
            set;
        }
        /// <summary>
        /// SP是否支持绑定评分表（0-不支持，1-支持）
        /// </summary>
        public virtual int SP_Is_Support_Binding_Mark_Sheet
        {
            get;
            set;
        }
        /// <summary>
        /// 硬件品牌设定（1-SONY，2-海康威视，3-天地伟业，4-浙江大华，5-锐可科技）
        /// </summary>
        public virtual int? Global_Parameter1
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter2
        /// </summary>
        public virtual int? Global_Parameter2
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter3
        /// </summary>
        public virtual int? Global_Parameter3
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter4
        /// </summary>
        public virtual int? Global_Parameter4
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter5
        /// </summary>
        public virtual int? Global_Parameter5
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter6
        /// </summary>
        public virtual int? Global_Parameter6
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter7
        /// </summary>
        public virtual int? Global_Parameter7
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter8
        /// </summary>
        public virtual int? Global_Parameter8
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter9
        /// </summary>
        public virtual int? Global_Parameter9
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter10
        /// </summary>
        public virtual int? Global_Parameter10
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter11
        /// </summary>
        public virtual decimal? Global_Parameter11
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter12
        /// </summary>
        public virtual decimal? Global_Parameter12
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter13
        /// </summary>
        public virtual decimal? Global_Parameter13
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter14
        /// </summary>
        public virtual string Global_Parameter14
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter15
        /// </summary>
        public virtual string Global_Parameter15
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter16
        /// </summary>
        public virtual string Global_Parameter16
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter17
        /// </summary>
        public virtual string Global_Parameter17
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter18
        /// </summary>
        public virtual string Global_Parameter18
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-12-05，网站加密数据第2段100个字符
        /// </summary>
        public virtual string Global_Parameter19
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter20
        /// </summary>
        public virtual string Global_Parameter20
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter21
        /// </summary>
        public virtual string Global_Parameter21
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-12-05，网站加密数据第1段100个字符
        /// </summary>
        public virtual string Global_Parameter22
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter23
        /// </summary>
        public virtual string Global_Parameter23
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter24
        /// </summary>
        public virtual string Global_Parameter24
        {
            get;
            set;
        }
        /// <summary>
        /// 董阳，2014-12-05，网站加密数据第3段字符
        /// </summary>
        public virtual string Global_Parameter25
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter26
        /// </summary>
        public virtual DateTime? Global_Parameter26
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter27
        /// </summary>
        public virtual DateTime? Global_Parameter27
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter28
        /// </summary>
        public virtual DateTime? Global_Parameter28
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter29
        /// </summary>
        public virtual DateTime? Global_Parameter29
        {
            get;
            set;
        }
        /// <summary>
        /// Global_Parameter30
        /// </summary>
        public virtual DateTime? Global_Parameter30
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
                .Append("\"Global_Parameters_Setting_ID\":\"").Append(Uri.EscapeDataString(this.Global_Parameters_Setting_ID.ToString())).Append("\",")
                .Append("\"Judge_Is_Support_Binding_Multi_Mark_Sheet\":\"").Append(Uri.EscapeDataString(this.Judge_Is_Support_Binding_Multi_Mark_Sheet.ToString())).Append("\",")
                .Append("\"SP_Is_Support_Binding_Mark_Sheet\":\"").Append(Uri.EscapeDataString(this.SP_Is_Support_Binding_Mark_Sheet.ToString())).Append("\",")
                .Append("\"Global_Parameter1\":\"").Append(Uri.EscapeDataString(this.Global_Parameter1 == null ? "" : this.Global_Parameter1.ToString())).Append("\",")
                .Append("\"Global_Parameter2\":\"").Append(Uri.EscapeDataString(this.Global_Parameter2 == null ? "" : this.Global_Parameter2.ToString())).Append("\",")
                .Append("\"Global_Parameter3\":\"").Append(Uri.EscapeDataString(this.Global_Parameter3 == null ? "" : this.Global_Parameter3.ToString())).Append("\",")
                .Append("\"Global_Parameter4\":\"").Append(Uri.EscapeDataString(this.Global_Parameter4 == null ? "" : this.Global_Parameter4.ToString())).Append("\",")
                .Append("\"Global_Parameter5\":\"").Append(Uri.EscapeDataString(this.Global_Parameter5 == null ? "" : this.Global_Parameter5.ToString())).Append("\",")
                .Append("\"Global_Parameter6\":\"").Append(Uri.EscapeDataString(this.Global_Parameter6 == null ? "" : this.Global_Parameter6.ToString())).Append("\",")
                .Append("\"Global_Parameter7\":\"").Append(Uri.EscapeDataString(this.Global_Parameter7 == null ? "" : this.Global_Parameter7.ToString())).Append("\",")
                .Append("\"Global_Parameter8\":\"").Append(Uri.EscapeDataString(this.Global_Parameter8 == null ? "" : this.Global_Parameter8.ToString())).Append("\",")
                .Append("\"Global_Parameter9\":\"").Append(Uri.EscapeDataString(this.Global_Parameter9 == null ? "" : this.Global_Parameter9.ToString())).Append("\",")
                .Append("\"Global_Parameter10\":\"").Append(Uri.EscapeDataString(this.Global_Parameter10 == null ? "" : this.Global_Parameter10.ToString())).Append("\",")
                .Append("\"Global_Parameter11\":\"").Append(Uri.EscapeDataString(this.Global_Parameter11 == null ? "" : this.Global_Parameter11.ToString())).Append("\",")
                .Append("\"Global_Parameter12\":\"").Append(Uri.EscapeDataString(this.Global_Parameter12 == null ? "" : this.Global_Parameter12.ToString())).Append("\",")
                .Append("\"Global_Parameter13\":\"").Append(Uri.EscapeDataString(this.Global_Parameter13 == null ? "" : this.Global_Parameter13.ToString())).Append("\",")
                .Append("\"Global_Parameter14\":\"").Append(Uri.EscapeDataString(this.Global_Parameter14 == null ? "" : this.Global_Parameter14.ToString())).Append("\",")
                .Append("\"Global_Parameter15\":\"").Append(Uri.EscapeDataString(this.Global_Parameter15 == null ? "" : this.Global_Parameter15.ToString())).Append("\",")
                .Append("\"Global_Parameter16\":\"").Append(Uri.EscapeDataString(this.Global_Parameter16 == null ? "" : this.Global_Parameter16.ToString())).Append("\",")
                .Append("\"Global_Parameter17\":\"").Append(Uri.EscapeDataString(this.Global_Parameter17 == null ? "" : this.Global_Parameter17.ToString())).Append("\",")
                .Append("\"Global_Parameter18\":\"").Append(Uri.EscapeDataString(this.Global_Parameter18 == null ? "" : this.Global_Parameter18.ToString())).Append("\",")
                .Append("\"Global_Parameter19\":\"").Append(Uri.EscapeDataString(this.Global_Parameter19 == null ? "" : this.Global_Parameter19.ToString())).Append("\",")
                .Append("\"Global_Parameter20\":\"").Append(Uri.EscapeDataString(this.Global_Parameter20 == null ? "" : this.Global_Parameter20.ToString())).Append("\",")
                .Append("\"Global_Parameter21\":\"").Append(Uri.EscapeDataString(this.Global_Parameter21 == null ? "" : this.Global_Parameter21.ToString())).Append("\",")
                .Append("\"Global_Parameter22\":\"").Append(Uri.EscapeDataString(this.Global_Parameter22 == null ? "" : this.Global_Parameter22.ToString())).Append("\",")
                .Append("\"Global_Parameter23\":\"").Append(Uri.EscapeDataString(this.Global_Parameter23 == null ? "" : this.Global_Parameter23.ToString())).Append("\",")
                .Append("\"Global_Parameter24\":\"").Append(Uri.EscapeDataString(this.Global_Parameter24 == null ? "" : this.Global_Parameter24.ToString())).Append("\",")
                .Append("\"Global_Parameter25\":\"").Append(Uri.EscapeDataString(this.Global_Parameter25 == null ? "" : this.Global_Parameter25.ToString())).Append("\",")
                .Append("\"Global_Parameter26\":\"").Append(Uri.EscapeDataString(this.Global_Parameter26 == null ? "" : Convert.ToDateTime(this.Global_Parameter26).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"Global_Parameter27\":\"").Append(Uri.EscapeDataString(this.Global_Parameter27 == null ? "" : Convert.ToDateTime(this.Global_Parameter27).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"Global_Parameter28\":\"").Append(Uri.EscapeDataString(this.Global_Parameter28 == null ? "" : Convert.ToDateTime(this.Global_Parameter28).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"Global_Parameter29\":\"").Append(Uri.EscapeDataString(this.Global_Parameter29 == null ? "" : Convert.ToDateTime(this.Global_Parameter29).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"Global_Parameter30\":\"").Append(Uri.EscapeDataString(this.Global_Parameter30 == null ? "" : Convert.ToDateTime(this.Global_Parameter30).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
