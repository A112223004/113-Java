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
    }

} //End of namespace
