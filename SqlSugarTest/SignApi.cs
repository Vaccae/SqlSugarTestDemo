using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarTest
{
    public class SignApi
    {
        private static string _attrnamespace = "SqlSugar";

        /// <summary>
        /// 拼接类属性和值的字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string GetClassSignStr<T>(T t)
        {
            string retstr = "";
            //定义PropertyInfo的List
            List<PropertyInfo> proplist = new List<PropertyInfo>();
            //遍历泛型类的每个属性加入到List里面
            Array.ForEach<PropertyInfo>(typeof(T).GetProperties(),
                p =>
                {
                    Type colType = p.PropertyType;
                    //判断是否有特性，如果有的话就算进签名列里
                    if (p.CustomAttributes.Any())
                    {
                        CustomAttributeData attribute = p.CustomAttributes.First();
                        if (_attrnamespace == "")
                        {
                            proplist.Add(p);
                        }
                        else
                        {
                            if (attribute.AttributeType.Namespace != null
                                && attribute.AttributeType.Namespace.Contains(_attrnamespace))
                            {
                                proplist.Add(p);
                            }
                        }
                    }
                });
            //根据参数进行排序
            if (proplist.Count > 0)
            {
                proplist = proplist.OrderBy(k => k.Name).ToList();

                //遍历List泛型生成我们要签名的字符串
                StringBuilder sb = new StringBuilder();
                proplist.ForEach(p =>
                {
                    sb.Append(p.Name).Append("=").Append(p.GetValue(t, null)).Append("&");
                });
                //把字符串最后一位截断
                sb.Remove(sb.Length - 1, 1);
                retstr = sb.ToString();
            }
            //输出字符串
            return retstr;
        }

    }
}
