using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//========== Namespace ============//
namespace A112223004_DS_Library
{
    //============= Class ==============//
    public partial class DS_Sorting
    {
        //------------Global Data--------------//
        //------------Action--------------//
        //------Method---------//
        //----- insertion Sort-------//
        public static void insertionSort<E>(E[] data, out E[] dataTarget) where E : IComparable  //generic
        {

            // Create a copy of the original array to sort
            dataTarget = (E[])data.Clone();

            int n = dataTarget.Length;
            for (int i = 1; i < n; i++)
            {
                E key = dataTarget[i];
                int j = i - 1;

                // Move elenents that are greater than key one position ahead
                while (j >= 0 && dataTarget[j].CompareTo(key) > 0)
                {
                    dataTarget[j + 1] = dataTarget[j];
                    j--;
                }
                dataTarget[j + 1] = key;
            }

        }//End of insertionSort
        public static void selectionSort<T>(T[] source, out T[] target) where T : IComparable<T>
        {
                    target = new T[source.Length];
                    source.CopyTo(target, 0);
                    int n = source.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++) //find the minmum one location
                {

                    if (target[j].CompareTo(target[minIndex]) < 0) //find index of minmum number
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i) //swap
                {
                    T temp = target[minIndex];
                    target[minIndex] = target[i];
                    target[i] = temp;
                }

            }
        } //End of selectionSort
    } //End of class
} //End of namespace

