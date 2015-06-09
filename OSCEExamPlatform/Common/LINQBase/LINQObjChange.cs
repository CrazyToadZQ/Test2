using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace Tellyes.Common.LINQBase
{
    /// <summary>
    /// LINQ对象转换类
    /// </summary>
    public static class LINQObjChange
    {
        /// DataTable 转换为List 集合  
        /// </summary>  
        /// <typeparam name="TResult">类型</typeparam>  
        /// <param name="dt">DataTable</param>  
        /// <returns></returns>  
        //<类型参数必须是类并且具有无参数的公共构造函数。当与其他约束一起使用时，new()约束必须最后指定。<  
        public static List<T> ToList<T>(this DataTable dt) where T : class,new()
        {


            //创建一个属性的列表  
            List<PropertyInfo> prlist = new List<PropertyInfo>();
            //获取TResult的类型实例  反射的入口  
            Type t = typeof(T);
            //获得TResult 的所有的Public 属性 并找出TResult属性和DataTable的列名称相同的属性(PropertyInfo) 并加入到属性列表  
            Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dt.Columns.IndexOf(p.Name) != -1) prlist.Add(p); });
            //创建返回的集合  
            List<T> oblist = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                //创建TResult的实例  
                T ob = new T();
                //找到对应的数据,并赋值  
                foreach (PropertyInfo p in prlist) 
                {
                    try
                    {
                        if (row[p.Name] != DBNull.Value)
                        {
                            p.SetValue(ob, row[p.Name], null);
                        }
                    }
                    catch (Exception ee)
                    {
                        if (p.PropertyType.FullName.Contains("System.DateTime"))
                        {
                            p.SetValue(ob, Convert.ToDateTime(row[p.Name]), null);
                        }
                        if (ee.Message.Contains("System.Double") && ee.Message.Contains("System.String") && p.Name.ToLower().Trim().Equals("u_name"))
                        {
                            p.SetValue(ob, Convert.ToString(Convert.ToInt32(row[p.Name])), null);
                        }
                    }
                }
                //放入到返回的集合中.  
                oblist.Add(ob);
            }
            return oblist;
        }
    }
}
