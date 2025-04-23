//
//Project: Test DS
//Date:    2025/03/19
//Author:  A112223004
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using A112223004_DS_Library; //CommonMethod.cs/ShowArray
using A112223004_DS_Application;
//using A112223004_DS_Library.DS_Tree;
using System.Diagnostics.Eventing.Reader;//DS2025S

//========== Namespace TestWinForm ============//
namespace TestWinForm
{
    //============= Class  ==============//
    public partial class frmMainEntrance : Form
    {
        #region// ---------Data ----------//
        //------- Difine ---------//
        enum TreeType { MultiTree, BinaryTree};

        //------- Declare ---------//
        //------- Linked List 
        A112223004_DS_Library.SinglyLL<string> sll = new A112223004_DS_Library.SinglyLL<string>();
        A112223004_DS_Library.DoublyLL<string> dll = new A112223004_DS_Library.DoublyLL<string>();

        //------Tree
        Stopwatch stopwatch = new Stopwatch(); // start(), stop(). reset()
        //TreeNode<char> mTreeC = new TreeNode<char>();
        //TreeNode<int> mTreeI = new TreeNode<int();
        //TreeNode<double> mTreeD = new TreeNode<double>();
        //TreeNode<string> mTreeS = new TreeNode<string>();

        //TreeNode<char> bTreeC = new TreeNode<char>();
        //TreeNode<int> bTreeI = new TreeNode<int();
        //TreeNode<double> bTreeD = new TreeNode<double>();
        //TreeNode<string> bTreeS = new TreeNode<string>();
        TreeType drawType = TreeType.MultiTree;

        List<char> heapC;
        List<int> heapI;
        List<double> heapD;
        List<string> heapS;
        #endregion


        //------ Action ---------//
        #region//------- Constructor ---------//
        public frmMainEntrance()
        {
            InitializeComponent();
        }
        #endregion

        #region//----- Methods ----------//
        //--------Display Array
        void displayArray(int[] arr, TextBox tbx, string title = "")
        {
            string ss = title;
            ss += (A112223004_DS_Library.ShareMethod.printArray<int>(arr));
            tbx.Text = ss;
        }

        void displayArray(double[] arr, TextBox tbx, string title = "")
        {
            string ss = title;
            ss += (A112223004_DS_Library.ShareMethod.printArray<double>(arr));
            tbx.Text = ss;
        }

        // ----- Find data in linked list

        private void findDataInLL()
        {
            A112223004_DS_Library.LinearDataNode<string> findNode;
            string ss = tbxFindind.Text.Trim();

            tbxSearchResult.Text = "";

            if (rbtDoubleLL.Checked)
            {
                findNode = dll.findDataNode(ss);
                tbxSearchResult.Text = $"Find {ss} in DLL\r\n\r\n" + dll.ToString();
            }
            else
            {
                findNode = sll.findDataNode(ss);
                tbxSearchResult.Text = $"Find {ss} in SLL\r\n\r\n" + sll.ToString();
            }

            if (findNode == null) { tbxSearchResult.Text += "\r\r\r\nNot Found!!"; }
            else { tbxSearchResult.Text += "\r\r\r\nFound!!"; }
        }//End of findData

        //----- Test binary search

        void testBinarySearch()
        {
            int[] intData = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            double[] doubleData = { 10.5, 20.5, 30.5, 40.5, 50.5, 60.5, 70.5, 80.5, 90.5, 100.5 };
            String[] stringData = { "Adam", "Bob", "Candy", "Daniel", "Jane", "Keresa", "Lily", "Mary" };
            int result, findInt;
            double findDouble;
            displayArray(intData, tbxAddResult);

            if (int.TryParse(tbxFindind.Text, out findInt))
            {
                //result = A112223004_DS_Application.Loop.binarySearch<int>(intData, findInt);
                result = A112223004_DS_Application.Recursive.binarySearch<int>(intData, findInt, 0, intData.Length - 1);
                tbxAddResult.Text = "[" + string.Join(".", intData) + "]";
                //displayArray(intData, tbxData);
            }
            else if (double.TryParse(tbxFindind.Text, out findDouble))
            {
                result = A112223004_DS_Application.Recursive.binarySearch<double>(doubleData, findDouble, 0, doubleData.Length - 1);
                tbxAddResult.Text = "[" + string.Join(".", doubleData) + "]";
                //displayArray(doubleData, tbxData);
            }
            else
            {
                result = A112223004_DS_Application.Recursive.binarySearch<String>(stringData, tbxFindind.Text, 0, stringData.Length - 1);
                tbxAddResult.Text = "[" + string.Join(".", stringData) + "]";
            }
            if (result < 0) { tbxSearchResult.Text = "Not found:" + tbxFindind.Text; }
            else { tbxSearchResult.Text = tbxFindind.Text + "is in index" + result; }
        }
        #endregion

        //------- Events -----//
        #region// --------- test sort : insertion, selection, mergesort
        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            int[] data1 = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            double[] data2 = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };

            if (rbnInt.Checked)
            {
                var data = data1;
                if (tbxBefore.Text.Trim().Length > 0)
                    data = A112223004_DS_Library.ShareMethod.ParserStringBySplitter<int>(tbxBefore.Text);
                tbxBefore.Text = string.Join(", ", data);
                A112223004_DS_Library.DS_Sorting.insertionSort(data, out var dataTarget);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
            else if (rbnDouble.Checked)//double
            {
                var data = data2;
                if (tbxBefore.Text.Trim().Length > 0)
                    data = A112223004_DS_Library.ShareMethod.ParserStringBySplitter<double>(tbxBefore.Text);
                tbxBefore.Text = string.Join(", ", data);
                A112223004_DS_Library.DS_Sorting.insertionSort(data, out var dataTarget);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
            else //string
            {
                var data = data3;
                if (tbxBefore.Text.Trim().Length > 0)
                    data = A112223004_DS_Library.ShareMethod.ParserStringBySplitter<string>(tbxBefore.Text);
                tbxBefore.Text = string.Join(", ", data);
                A112223004_DS_Library.DS_Sorting.insertionSort(data, out var dataTarget);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
        }
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int[] data1 = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            double[] data2 = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };

            if (rbnInt.Checked)
            {
                var data = data1;
                if (tbxBefore.Text.Trim().Length > 0)
                    data = A112223004_DS_Library.ShareMethod.ParserStringBySplitter<int>(tbxBefore.Text);
                tbxBefore.Text = string.Join(", ", data);
                var dataTarget = A112223004_DS_Library.DS_Sorting.mergeSort<int>(data, true);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
            else if (rbnDouble.Checked)//double
            {
                var data = data2;
                if (tbxBefore.Text.Trim().Length > 0)
                    data = A112223004_DS_Library.ShareMethod.ParserStringBySplitter<double>(tbxBefore.Text);
                tbxBefore.Text = string.Join(", ", data);
                var dataTarget = A112223004_DS_Library.DS_Sorting.mergeSort<double>(data, true);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
            else if (rbnString.Checked)
            {
                tbxBefore.Text = "[" + string.Join(", ", data3) + "]";
                A112223004_DS_Library.DS_Sorting.selectionSort(data3, out var dataTarget);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
        }
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            int[] data1 = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            double[] data2 = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };

            if (rbnInt.Checked)
            {
                var data = data1;
                if(tbxBefore.Text.Trim().Length > 0 )
                    data = A112223004_DS_Library.ShareMethod.ParserStringBySplitter<int>(tbxBefore.Text);
                tbxBefore.Text = string.Join(", ", data);
                var dataTarget = A112223004_DS_Library.DS_Sorting.mergeSort<int>(data, true);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
            else if (rbnDouble.Checked)//double
            {
                var data = data2;
                if (tbxBefore.Text.Trim().Length > 0)
                    data = A112223004_DS_Library.ShareMethod.ParserStringBySplitter<double>(tbxBefore.Text);
                tbxBefore.Text = string.Join(", ", data);
                var dataTarget = A112223004_DS_Library.DS_Sorting.mergeSort<double>(data, true);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";
            }
            else if (rbnString.Checked)
            {
                tbxBefore.Text = "[" + string.Join(", ", data3) + "]";
                A112223004_DS_Library.DS_Sorting.selectionSort(data3, out var dataTarget);
                tbxAfter.Text = "[" + string.Join(", ", dataTarget) + "]";

            }
        }

        #endregion






        #region//------ linked list : sll, dll, poly
        #region//----- Linled list type change

        #endregion

        #region//----- Create
        private void cbxCreate_SelectedIndexChanded(object sender, EventArgs e)
        {
            //-------- initial setting
            int[] data1 = { 3, 8, 7, 5, 2, 1, 9, 6, 4, };
            double[] data2 = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };


            string[] data = null;
            A112223004_DS_Library.LinearDataNode<string> node;
            /*A112223004_DS_Library.SinglyLL<string>*/ sll = new A112223004_DS_Library.SinglyLL<string>();
            /*A112223004_DS_Library.SinglyLL<string>*/ dll = new A112223004_DS_Library.DoublyLL<string>();


            //------- get data according the specified data type
            if (rbtLLint.Checked) // 整型数据
            {
                data = Array.ConvertAll(data1, x => x.ToString()); // 将整数数组转换为字符串数组
            }
            else if (rbtLLdouble.Checked) // 双精度数据
            {
                data = Array.ConvertAll(data2, x => x.ToString()); // 将浮点数数组转换为字符串数组
            }
            else if (rbtLLstring.Checked) // 字符串数据
            {
                data = data3; // 直接使用字符串数组
            }

            // ------ create11
            foreach (var vv in data)// int, double can treated as string
            {
                node = new A112223004_DS_Library.LinearDataNode<string>(vv);
                //sll.addFirst(node);
                if(cbxCreate.SelectedIndex == 0) // creating LL by add first
                    { sll.addFirst(node); dll.addFirst(node); }
                else if (cbxCreate.SelectedIndex == 1)// creating LL by add last
                     { sll.addFirst(node); dll.addFirst(node); }
            }

            // --------- display content of linked list
            if (rbtSinglyLL.Checked) { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
            else                     { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
        } //End of cbxCreate
        #endregion

        #region//------ Find
        
        
        #endregion

        #region//--------Add
        private void cbxAdd_SelectedIndexChanded(object sender, EventArgs e)
        {
            //-------- initial setting
            int[] data1 = { 3, 8, 7, 5, 2, 1, 9, 6, 4, };
            double[] data2 = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };


            string[] data = null;
            A112223004_DS_Library.LinearDataNode<string> node;
            /*A112223004_DS_Library.SinglyLL<string>*/
            sll = new A112223004_DS_Library.SinglyLL<string>();
            /*A112223004_DS_Library.SinglyLL<string>*/
            dll = new A112223004_DS_Library.DoublyLL<string>();


            //------- get data according the specified data type
            if (rbtLLint.Checked)
            {
                data = Array.ConvertAll(data1, x => x.ToString()); // 将整数数组转换为字符串数组
            }
            else if (rbtLLdouble.Checked)
            {
                data = Array.ConvertAll(data2, x => x.ToString()); // 将浮点数数组转换为字符串数组
            }
            else if(rbtLLstring.Checked) // 字符串数据
            {
                data = data3; // 直接使用字符串数组
            }

            // ------ create11
            foreach (var vv in data)// int, double can treated as string
            {
                node = new A112223004_DS_Library.LinearDataNode<string>(vv);
                 //sll.addFirst(node);
                if (cbxCreate.SelectedIndex == 0) // creating LL by add first
                {  
                    sll.addFirst(node); 
                    dll.addFirst(node); 
                }
                else if (cbxCreate.SelectedIndex == 1)// creating LL by add last
                { 
                    sll.addFirst(node);
                    dll.addFirst(node); 
                }
            }

            // --------- display content of linked list
            if (rbtSinglyLL.Checked) { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
            else { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
        } //End of cbxAdd in LL
        #endregion

        #region//-------Remove
        private void cbxRemove_SelectedIndexChanded(object sender, EventArgs e)
        {
            //-------- initial setting
            int[] data1 = { 3, 8, 7, 5, 2, 1, 9, 6, 4, };
            double[] data2 = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };


            string[] data = null;
            A112223004_DS_Library.LinearDataNode<string> node;
            /*A112223004_DS_Library.SinglyLL<string>*/
            sll = new A112223004_DS_Library.SinglyLL<string>();
            /*A112223004_DS_Library.SinglyLL<string>*/
            dll = new A112223004_DS_Library.DoublyLL<string>();


            //------- get data according the specified data type
            if (rbtLLint.Checked)
            {
                data = Array.ConvertAll(data1, x => x.ToString());
            }
            else if (rbtLLdouble.Checked)
            {
                data = Array.ConvertAll(data2, x => x.ToString());
            }
            else if(rbtLLstring.Checked)
            {
                data = data3;
            }

            // ------ create11
            foreach (var vv in data)// int, double can treated as string
            {
               node = new A112223004_DS_Library.LinearDataNode<string>(vv);
               //sll.addFirst(node);
               if (cbxCreate.SelectedIndex == 0) // creating LL by add first
               { 
                    sll.addFirst(node);
                    dll.addFirst(node); 
               }
               else if (cbxCreate.SelectedIndex == 1)// creating LL by add last
               { 
                    sll.addFirst(node); 
                    dll.addFirst(node); 
               }
            }

            // --------- display content of linked list
            if (rbtSinglyLL.Checked) { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
            else { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
        } //End of cbxRemove in LL
        #endregion

        #region//------Poly, operation

        #endregion
        #endregion

        #region//------recursive and loop

        #endregion

        #region//------stack: parenthesis. palindrome, base, in/pre/postfix,maze

        #endregion

        #region//------queue: pq

        #endregion

        #region//------tree

        #endregion

        

        



        private void insertionSort<T>(T[] array, out T[] dataTarget) where T : IComparable
        {
            // 克隆数组，避免修改原数组
            dataTarget = (T[])array.Clone();

            // 插入排序算法
            for (int i = 1; i < dataTarget.Length; i++)
            {
                T key = dataTarget[i];
                int j = i - 1;

                // 将大于 key 的元素移动到后面
                while (j >= 0 && dataTarget[j].CompareTo(key) > 0)
                {
                    dataTarget[j + 1] = dataTarget[j];
                    j = j - 1;
                }
                dataTarget[j + 1] = key;
            }
        }

        void insertionSort(String[] data, out String[] dataTarget)
        {
            dataTarget = (String[])data.Clone();

            int n = dataTarget.Length;
            for (int i = 1; i < n; i++)
            {
                String key = dataTarget[i];
                int j = i - 1;

                // Move elenents that are greater than key one position ahead
                while (j >= 0 && dataTarget[j].CompareTo(key) > 0)
                {
                    dataTarget[j + 1] = dataTarget[j];
                    j--;
                }
                dataTarget[j + 1] = key;
            }
        }

        public static void selectionSort<T>(T[] source, out T[] target) where T : IComparable<T>
        {
            target = new T[source.Length];
            source.CopyTo(target, 0);
            int n = source.Length;

            for (int i = 0; i < n -1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++) //find the minmum one location
                {

                    if (target[j].CompareTo(target[minIndex]) <0) //find index of minmum number
                    {
                        minIndex = j;
                    }
                }

                if(minIndex != i) //swap
                {
                    T temp = target[minIndex];
                    target[minIndex] = target[i];
                    target[i] = temp;
                }
            }

        } //End of selectionSort


        
        

        

        
        private void dtChange(object sender, EventArgs e)
        {
            tbxBefore.Text = tbxAfter.Text = "";
        }//End of dtChange for sorting
        private void linkedListChange(object sender, EventArgs e)
        {

        }//End of linkedListChange
        private void cbxCreate_SelectedIndexChanged(object sender, EventArgs e)
        {

        } //End of cbxCreate
        private void btnFind_keyDown(object sender, KeyEventArgs e)
        {
            //for KeyPress using e.KeyChar
            //if (e.KeyChar == 13) { findDataInLL(); } //Enter
            //if (e.KeyChar == (char)Keys.Enter) { findDataInLL(); }

            //for KeyDown using e.KeyChar
            if (e.KeyCode == Keys.Enter) { findDataInLL(); }
        }//End of key Enter
        private void btnFind_Click(object sender, EventArgs e)
        {
            findDataInLL();
        }// End of btnFind in LL
        private void add(int mode)
        {
            A112223004_DS_Library.LinearDataNode<string> node, findNode;
            string ss1 = tbxAdd.Text.Trim();
            string ss2 = tbxAddAfter.Text.Trim();

            //show current LL
            if (rbtDoubleLL.Checked) { tbxOriginal.Text = "DLL-->\r\n" + dll.ToString(); }
            else { tbxOriginal.Text = "SLL-->\r\n" + sll.ToString(); }

            //perform adding
            if(ss1 == null || ss1.Length == 0) { tbxRemoveResult.Text = "Please input data to be removed in LL!!"; }
            else // have data to be add
            {
                node = new A112223004_DS_Library.LinearDataNode<string>(ss1); //data to be added
                if(mode == 2) //add after
                {
                    if(rbtDoubleLL.Checked) //DLL
                    {
                        findNode = dll.findDataNode(ss2);
                        if(findNode == null) { tbxAddResult.Text = $"{ss2} not in DLL, cannot add next to it!!";}
                        else
                        {
                            dll.addNext(findNode, node);
                            tbxAddResult.Text = $"Add{ss1} after{ss2} in DLL\r\n\r\n" + dll.ToString();
                        }
                    }
                    else //SLL
                    {
                        findNode = sll.findDataNode(ss2);
                        if (findNode == null) { tbxAddResult.Text = $"{ss2} not in SLL, cannot add next to it!!"; }
                        else
                        {
                            sll.addNext(findNode, node);
                            tbxAddResult.Text = $"Add{ss1} after{ss2} in SLL\r\n\r\n" + sll.ToString();
                        }
                    }
                } //End of add after
                else if(mode == 1) //add last
                {
                    if(rbtDoubleLL.Checked) //DLL
                    {
                        dll.addLast(node);
                        tbxAddResult.Text = $"Add last{ss1} in DLL\r\n\r\n" + dll.ToString();
                    }// End of add last for DLL
                    else //SLL
                    {
                        sll.addLast(node);
                        tbxAddResult.Text = $"Add last{ss1} in SLL\r\n\r\n" + sll.ToString();
                    }// End of add last for SLL
                }//End of add Last
                else// add first, mode==0
                {
                    if (rbtDoubleLL.Checked) //DLL
                    {
                        dll.addFirst(node);
                        tbxAddResult.Text = $"Add first{ss1} in DLL\r\n\r\n" + dll.ToString();
                    }// End of add first for DLL
                    else //SLL
                    {
                        sll.addFirst(node);
                        tbxAddResult.Text = $"Add first{ss1} in SLL\r\n\r\n" + sll.ToString();
                    }// End of add first for SLL
                }//End of add first
            }// End of having data to be added
        }
        private void cbxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            add(cbxAdd.SelectedIndex);
        }//End of cbxAdd in LL
        private void remove(int mode)
        {
            //show current LL
            if (rbtDoubleLL.Checked) { tbxOriginal.Text = "DLL-->\r\n" + dll.ToString(); }
            else { tbxOriginal.Text = "SLL-->\r\n" + sll.ToString(); }

            //perform removing
            if(mode == 0) // remove first
            {
                if (rbtDoubleLL.Checked)
                {
                    dll.removeLast();
                    tbxRemoveResult.Text = "Remove first in DLL\r\n\r\n" + dll.ToString();
                }
                else
                {
                    sll.removeLast();
                    tbxRemoveResult.Text = "Remove first in SLL\r\n\r\n" + sll.ToString();
                }
            }// End of remove first
            else if(mode == 1) // remove last
            {
                if (rbtDoubleLL.Checked)
                {
                    dll.removeLast();
                    tbxRemoveResult.Text = "Remove last in DLL\r\n\r\n" + dll.ToString();
                }
                else
                {
                    sll.removeLast();
                    tbxRemoveResult.Text = "Remove last in SLL\r\n\r\n" + sll.ToString();
                }
            }// End of remove last
            else // remove at, mode == 2
            {
                string ss = tbxRemove.Text.Trim();
                if (ss == null || ss.Length == 0) { tbxRemoveResult.Text = "Please input data to be removed in LL!!"; }
                else
                {
                    if (rbtDoubleLL.Checked)//DLL
                    {
                        dll.removeAt(dll.findDataNode(ss));
                        tbxRemoveResult.Text = $"Remove{ss} int DLL\r\n\r\n" + dll.ToString();
                    }
                    else//SLL
                    {
                        sll.removeAt(sll.findDataNode(ss));
                        tbxRemoveResult.Text = $"Remove{ss} int SLL\r\n\r\n" + sll.ToString();
                    }
                }
            }//End of remove At
        }

        private void cbxRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove(cbxRemove.SelectedIndex);
        }//End of cbxRemove in LL

        private void btnPoly_Click(object sender, EventArgs e)
        {

        }
        private void btnCreatFirst_Clink(object sender, EventArgs e)
        {
            //------ initial setting
            int[] data = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            //double[] data = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            //string[] data = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };

            sll = new A112223004_DS_Library.SinglyLL<string>();
            dll = new A112223004_DS_Library.DoublyLL<string>();
            A112223004_DS_Library.LinearDataNode<string> node;
            for (int ii = 0; ii < data.Length; ii++)
            {
                node = new A112223004_DS_Library.LinearDataNode<string>(data[ii].ToString());
                sll.addFirst(node);
                dll.addFirst(node);
            }
            if (rbtSinglyLL.Checked) { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
            else { tbxOriginal.Text = "DLL -- >\r\n" + dll.ToString(); }
        }

        private void btnCreatLast_Click(object sender, EventArgs e)
        {
            //------ initial setting
            //int[] data = { 3, 8, 7, 5, 2, 1, 9, 6, 4, };
            //double[] data = { 3.5, 8.5, 7.5, 5.5, 2.5, 1.5, 9.5, 6.5, 4.5 };
            string[] data = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };

            sll = new A112223004_DS_Library.SinglyLL<string>();
            dll = new A112223004_DS_Library.DoublyLL<string>();
            A112223004_DS_Library.LinearDataNode<string> node;
            for (int ii = 0; ii < data.Length; ii++)
            {
                node = new A112223004_DS_Library.LinearDataNode<string>(data[ii]);
                sll.addFirst(node);
                dll.addFirst(node);
            }
            if (rbtSinglyLL.Checked) { tbxOriginal.Text = "SLL -- >\r\n" + sll.ToString(); }
            else { tbxOriginal.Text = "DLL -- >\r\n" + dll.ToString(); }
        }
        private void btnInsertFirst_Click(object sender, EventArgs e)
        {
            add(0);
        }

        private void btnInsertLast_Click(object sender, EventArgs e)
        {
            add(1);
        }
        private void btnInsertAfter_Click(object sender, EventArgs e)
        {
            add(2);
        }
        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            //remove(0);
            //show current LL
            if (rbtDoubleLL.Checked) { tbxOriginal.Text = "DLL-->\r\n" + dll.ToString(); }
            else { tbxOriginal.Text = "SLL-->\r\n" + sll.ToString(); }

            if (rbtDoubleLL.Checked)
            {
                dll.removeLast();
                tbxRemoveResult.Text = "Remove first in DLL\r\n\r\n" + dll.ToString();
            }
            else
            {
                sll.removeLast();
                tbxRemoveResult.Text = "Remove first in SLL\r\n\r\n" + sll.ToString();
            }
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            //remove(1);

            //show current LL
            if(rbtDoubleLL.Checked) { tbxOriginal.Text = "DLL-->\r\n" + dll.ToString(); }
            else { tbxOriginal.Text = "SLL-->\r\n" + sll.ToString(); }

            if(rbtDoubleLL.Checked)
            {
                dll.removeLast();
                tbxRemoveResult.Text = "Remove last in DLL\r\n\r\n" + dll.ToString();
            }
            else
            {
                sll.removeLast();
                tbxRemoveResult.Text = "Remove last in SLL\r\n\r\n" + sll.ToString();
            }
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            //remove(2);
            //show current LL
            if (rbtDoubleLL.Checked) { tbxOriginal.Text = "DLL-->\r\n" + dll.ToString(); }
            else { tbxOriginal.Text = "SLL-->\r\n" + sll.ToString(); }

            string ss = tbxRemove.Text.Trim();
            if(ss == null || ss.Length == 0){ tbxRemoveResult.Text = "Please input data to be removed in LL!!"; }
            else
            {
                if(rbtDoubleLL.Checked)//DLL
                {
                    dll.removeAt(dll.findDataNode(ss));
                    tbxRemoveResult.Text = $"Remove{ss} int DLL\r\n\r\n" + dll.ToString();
                }
                else//SLL
                {
                    sll.removeAt(sll.findDataNode(ss));
                    tbxRemoveResult.Text = $"Remove{ss} int SLL\r\n\r\n" + sll.ToString();
                }
            }
        }

        private void Origianl_lbl_Click(object sender, EventArgs e)
        {

        }
    } // End of class
} //End of namespace
