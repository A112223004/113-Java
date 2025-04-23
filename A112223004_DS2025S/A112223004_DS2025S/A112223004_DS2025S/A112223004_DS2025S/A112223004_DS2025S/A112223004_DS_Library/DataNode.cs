//Data: 2025/03/12
//Author: A112223004
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

//===========Namespaece============//
namespace A112223004_DS_Library
{
    #region//======== Class LinearDataNode ===========//
    public class LinearDataNode<E>
    {
        #region //-------Global Data ---------//
        #region //----Private Global Varibales-------//
        private E pData;
        private LinearDataNode<E> pPrev = null;
        private LinearDataNode<E> pNext = null;
        #endregion

        #region//------Data Property ---------//
        //Public DataNode<E> prew {get ; set;}

        public LinearDataNode<E> prev { get { return pPrev; } set { pPrev = value; } }

        public LinearDataNode<E> next { get { return pNext; } set { pNext = value; } }

        public E data { get { return pData; } set { pData = value; } }
        #endregion
        #endregion

        
        #region //---------- Action ---------//
        #region //------Constructor ---------//
        public LinearDataNode() { }
        public LinearDataNode(E dd, LinearDataNode<E> pp, LinearDataNode<E> nn) { data = dd; prev = pp; next = nn; }
        public LinearDataNode(E dd, LinearDataNode<E> nn) { data = dd; prev = null; next = nn; }
        public LinearDataNode(E dd) { data = dd; prev = next = null; }

        #endregion

        //-------Accessor/Mutator -----------//
        #region//----- Accessor/Mutator -----//
        public E getData() { return data; }
        public LinearDataNode<E> getNext() {  return next; }
        public LinearDataNode<E> getPrev() { return prev; }
        public void setData(E dd) { data = dd; }
        public void setNext(LinearDataNode<E> nn) {  next = nn; }
        public void setPrev(LinearDataNode<E> pp) { prev = pp; }
        #endregion

        #region//-------Methods -------//
        //-----------Override ToString method
        public override string ToString()
        {
            string ss = "";
            ss += ("Data is" + data.ToString() + "\n");
            if (prev != null) ss += ("The previous data is" + prev.data.ToString() + "\n");
            if (next != null) ss += ("The next data is" + next.data.ToString() + "\n");
            return ss;
        }
        #endregion
        #endregion
    }//End of LinearDataNode    
    #endregion
}//End of Namespace
 