//
//Project:Linked List Application
//Date:  2025/03/05
//Author: A112223004
//
//using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A112223004_DS_Library;

//======== namespace ===========//
namespace A112223004_DS_Application
{
    //======== class PolyData ===========//
    public class PolyData
    {
        //======== Global Data ===========//
        private int pExpo;
        private double pCoef;

        //------- Property --------//
        public int expo { get { return pExpo; } set { pExpo = value; } }
        public double coef { get { return pCoef; } set { pCoef = value; } }

        //------- Action --------//
        //------- Constructor --------//
        public PolyData() { }
        public PolyData(double coef, int expo) { this.coef = coef; this.expo = expo; }

        //------- Override --------//
        public override string ToString()
        {
            string ss = "";
            if (expo == 0) { ss = coef.ToString("n2"); }
            else if (expo == 1) { ss = coef.ToString("n2") + "X"; }
            else { ss = coef.ToString("n2") + "X^" + expo; }
            return ss;
        }
    } //End of class
    
    
    //============ Class PolyOperation ===========//
    public class PolyOperation
    {
        //------- Action --------//
        //------- Methodr --------//
        //------- Check legal polynomial --------//
        public static bool legalPoly(DoublyLL<PolyData> dll)
        {
            LinearDataNode<PolyData> cur = dll.getHead();
            bool flag = true;
            if (dll == null) { flag = false; }
            else
            {
                while (cur.next != null)
                {
                    if (cur.data.expo <= cur.next.data.expo)
                    {
                        flag = false; 
                        break;
                    }
                    cur = cur.next;
                }
            }
            return flag;
        }// End of leagalPoly

        //----Sorting the polynomial terms according its exponential in descending order and
        //    confirm unique term of exponential

        public static void sortPoly(DoublyLL<PolyData> dll)
        {

        }// End of sortPoly

        //------- Poly Operation:+, -,*

        public static A112223004_DS_Library.DoublyLL<PolyData> polyAdd(
            A112223004_DS_Library.DoublyLL<PolyData> dll1,
            A112223004_DS_Library.DoublyLL<PolyData> dll2)
        {
            return (polyAddMinus(dll1, dll2, '+'));
        }

        static A112223004_DS_Library.DoublyLL<PolyData> polyAddMinus(
            A112223004_DS_Library.DoublyLL<PolyData> dll1,
            A112223004_DS_Library.DoublyLL<PolyData> dll2)
        {
            return (polyAddMinus(dll1, dll2, '+'));
        }


        static A112223004_DS_Library.DoublyLL<PolyData> polyAddMinus(
            A112223004_DS_Library.DoublyLL<PolyData> dll1,
            A112223004_DS_Library.DoublyLL<PolyData> dll2, char op='+')
        //public static L polyAdd<L>(L dll1, L dll2)
        {
            A112223004_DS_Library.DoublyLL<PolyData> result = new A112223004_DS_Library.DoublyLL<PolyData>();
            A112223004_DS_Library.LinearDataNode<PolyData> p1Cur = dll1.getHead();
            A112223004_DS_Library.LinearDataNode<PolyData> p2Cur = dll2.getHead();
            A112223004_DS_Library.LinearDataNode<PolyData> dNode;
            PolyData pp;
            double tempCoef;
            if(legalPoly(dll1)&& legalPoly(dll2))
            {
                while((p1Cur != null) && (p2Cur != null)) //both poly still have items to be processed
                {
                    if(p1Cur.data.expo == p2Cur.data.expo) //approach p1 and p2
                }
            }
        }
    }

    internal class App_LinkedList
    {
    }
}
