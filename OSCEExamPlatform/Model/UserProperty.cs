using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [Serializable]
    public class UserProperty
    {

        /// <summary>
        /// 属性ID
        /// </summary>
        public virtual int UserPropertyID
        {
            get;
            set;
        }
        /// <summary>
        /// 属性名称
        /// </summary>
        public virtual string UserPropertyName
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyNumber1
        /// </summary>
        public virtual int? UserPropertyNumber1
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyNumber2
        /// </summary>
        public virtual int? UserPropertyNumber2
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyNumber3
        /// </summary>
        public virtual int? UserPropertyNumber3
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyNumber4
        /// </summary>
        public virtual int? UserPropertyNumber4
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyString1
        /// </summary>
        public virtual string UserPropertyString1
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyString2
        /// </summary>
        public virtual string UserPropertyString2
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyString3
        /// </summary>
        public virtual string UserPropertyString3
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyString4
        /// </summary>
        public virtual string UserPropertyString4
        {
            get;
            set;
        }
        /// <summary>
        /// UserPropertyString5
        /// </summary>
        public virtual string UserPropertyString5
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new StringBuilder()
                .Append(close ? "{" : "")
                .Append("\"UserPropertyID\":\"" + this.UserPropertyID + "\",")
                .Append("\"UserPropertyName\":\"" + Uri.EscapeDataString(this.UserPropertyName) + "\"")
                .Append(close ? "}" : "")
                .ToString();
        }


    }
}
