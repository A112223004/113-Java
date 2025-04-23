//
//Project:A112223004_Library
//Date:  2025/02/19
//Author: A112223004
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//=========== Namespace A112223004_DS_Library ===========//
namespace A112223004_DS_Library
{
    //====== Class CommonMethod ========//
    public class CommonMethod
    {
        #region//------- Method: parser --------//
        public static E[] ParserStringBySplitter<E>(string source, char splitC=',')
        {
        List<E> result = new List<E>();
        string[] ss = source.Split(splitC);
        string temp;

            if (string.IsNullOrWhiteSpace(source)) { return Array.Empty<E>(); }
            foreach(var vv in ss)
            {
                temp = vv.Trim();

                if (typeof(E) == typeof(int))
                {
                    if (int.TryParse(temp, out int intVal))
                    { result.Add((E)(object)intVal); }
                }
                else if (typeof(E) == typeof(double))
                {
                    if (double.TryParse(temp, out double doubleVal))
                    { result.Add((E)(object)doubleVal); }
                }
                else if(typeof(E) == typeof(string))
                { result.Add((E)(object)temp); }
                else
                { throw new NotSupportedException($"Type {typeof(E)} is not supported"); }
            }
            return result.ToArray();
        }//End of  ParserStringBySplitter
        #endregion

    } //End of class

    public static class ShareMethod
    {
        // 泛型方法：將陣列轉為字串表示
        public static string printArray<T>(T[] arr)
        {
            if (arr == null || arr.Length == 0)
                return "[空陣列]";

            return string.Join(", ", arr);
        }

        public static T[] ParserStringBySplitter<T>(string input, char splitter = ',')
        {
            if (string.IsNullOrWhiteSpace(input))
                return Array.Empty<T>();

            string[] parts = input.Split(splitter);

            List<T> result = new List<T>();

            foreach (var part in parts)
            {
                try
                {
                    // 去除每個元素的多餘空白並轉型
                    T value = (T)Convert.ChangeType(part.Trim(), typeof(T));
                    result.Add(value);
                }
                catch
                {
                    // 轉型失敗就跳過或可拋出例外（視需求）
                    // throw new FormatException($"無法將 '{part}' 轉為 {typeof(T).Name}");
                }
            }

            return result.ToArray();
        }
    }

} //End of namespace
