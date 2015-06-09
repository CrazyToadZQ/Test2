using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Tellyes.Model
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class TableRelationShipAtrribute : Attribute
    {
        /// <summary>
        /// 数据库中，表名称
        /// </summary>
        public IDictionary<PropertyInfo, String> RelationShip { get; set; }
    }
}
