using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Tellyes.Common
{
    public enum ExamClass_LongAndShort
    {
        
    }

    public static class EnumHelper<T>
    {
        /// <summary>
        /// 获得枚举的名称信息
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string GetDescription(Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }

        /// <summary>
        /// 根据值，获得枚举（比如：枚举内容为：red=1，bule=2,则此方法，可以传入字符串类型的变量 “red”或者传入“1”，则均会返回名为“red”的枚举类型）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T Parse(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        /// <summary>
        /// 获得枚举的集合
        /// </summary>
        /// <returns></returns>
        public static IList<T> GetValues()
        {
            IList<T> list = new List<T>();
            foreach (object value in Enum.GetValues(typeof(T)))
            {
                list.Add((T)value);
            }

            return list;
        }

        /// <summary>
        /// 获得枚举字典，包含值
        /// </summary>
        /// <returns></returns>
        public static Dictionary<T, string> GetValueDescriptionDictionary()
        {
            Dictionary<T, string> dictionary = new Dictionary<T, string>();
            foreach (object value in Enum.GetValues(typeof(T)))
            {
                dictionary.Add((T)value, GetDescription((Enum)value));
            }
            return dictionary;
        }

    }

}
