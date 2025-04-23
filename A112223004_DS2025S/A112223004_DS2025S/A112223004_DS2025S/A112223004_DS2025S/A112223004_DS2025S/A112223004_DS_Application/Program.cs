//
//Project:Related DS Application
//Date:  2025/02/19
//Author: A112223004
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//=========== Namespace A112223004_DS_Application ===========//
namespace A112223004_DS_Application
{
    //====== Class ========//
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DS_Application());
        } //End of Main



    } //End of class

    public class Recursive
    {
        // 泛型遞迴二元搜尋法
        public static int binarySearch<T>(T[] data, T target, int left, int right) where T : IComparable<T>
        {
            if (left > right)
            {
                return -1; // 找不到
            }

            int mid = (left + right) / 2;
            int comparison = target.CompareTo(data[mid]);

            if (comparison == 0)
            {
                return mid; // 找到目標
            }
            else if (comparison < 0)
            {
                // 目標比中間值小，往左邊繼續找
                return binarySearch(data, target, left, mid - 1);
            }
            else
            {
                // 目標比中間值大，往右邊繼續找
                return binarySearch(data, target, mid + 1, right);
            }
        }
    }
} //End of namespace
