using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [Serializable]
    public class PropertyValue 
    {
        /// <summary>
        /// 属性值ID
        /// </summary>
        public virtual int PropertyValueID
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值ID
        /// </summary>
        public virtual int UserPropertyID
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值名称
        /// </summary>
        public virtual string PropertyValueName
        {
            get;
            set;
        }
        /// <summary>
        /// 排序字段
        /// </summary>
        public virtual string PropertyValueOrderNumber
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueNumber1
        /// </summary>
        public virtual int? PropertyValueNumber1
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueNumber2
        /// </summary>
        public virtual int? PropertyValueNumber2
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueNumber3
        /// </summary>
        public virtual int? PropertyValueNumber3
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueNumber4
        /// </summary>
        public virtual int? PropertyValueNumber4
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueString1
        /// </summary>
        public virtual string PropertyValueString1
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueString2
        /// </summary>
        public virtual string PropertyValueString2
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueString3
        /// </summary>
        public virtual string PropertyValueString3
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueString4
        /// </summary>
        public virtual string PropertyValueString4
        {
            get;
            set;
        }
        /// <summary>
        /// PropertyValueString5
        /// </summary>
        public virtual string PropertyValueString5
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
                .Append("\"PropertyValueID\":\"" + this.PropertyValueID + "\",")
                .Append("\"UserPropertyID\":\"" + this.UserPropertyID + "\",")
                .Append("\"PropertyValueName\":\"" + Uri.EscapeDataString(this.PropertyValueName) + "\",")
                .Append("\"PropertyValueOrderNumber\":\"" + this.PropertyValueOrderNumber + "\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        //int IComparer<Tellyes.Model.PropertyValue>.Compare(Tellyes.Model.PropertyValue x, Tellyes.Model.PropertyValue y) 
        //{
        //    if (string.Compare(x.PropertyValueOrderNumber, y.PropertyValueOrderNumber) > 0)
        //    {
        //        return 1;
        //    }
        //    else if (string.Compare(x.PropertyValueOrderNumber, y.PropertyValueOrderNumber) == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}

    }
}
