
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

//====== namespace =======//
namespace A112223004_DS_Library
{
    //======= Class LinkedList =========//
    public class LinkedList<E> //:LinearDataNode<E>
    {
        #region//----- Global -------//
        protected LinearDataNode<E> pHead;
        protected LinearDataNode<E> pTail;
        protected int pSize = 0;
        #endregion

        #region//----- Action -------//
        //----- Properties -------//
        public LinearDataNode<E> head { get { return pHead; } set { pHead = value; } }
        public LinearDataNode<E> tail { get { return pTail; } set { pTail = value; } }
        public int size { get { return pSize; } set { pSize = value; } }

        #region//----- Accessor/Mutator -------//
        public LinearDataNode<E> getHead() { return head; }
        public LinearDataNode<E> getTail() { return tail; }
        public int getSize() {/*findSize();*/ return pSize; }
        public void setHead(LinearDataNode<E> hh) { head = hh; findSize(); }
        public void setTail(LinearDataNode<E> tt) { tail = tt; }
        #endregion

        //----- Method --------//
        //----- find size of LL
        public void findSize()
        {
            int count = 0;
            LinearDataNode<E> current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            size = count;
        }//findSize

        //----- find DataNode of data
        public LinearDataNode<E> findDataNode(E data)
        {
            LinearDataNode<E> current = head;
            while (current != null)
            {
                if (current.data.Equals(data))
                    return current;
                current = current.next;
                
            }
            return null;
        }

        //----- print the content of linked list
        public string toLLstring(LinearDataNode<E> dd)
        {
            string result = "";
            LinearDataNode<E> current = dd;
            while (current != null)
            {
                result += current.data.ToString() + "->";
                current = current.next;
            }
            result += "null";
            return result;
        }
        #endregion
    }//end of class LinkList

    //======== Class SinglyLL =======//
    public class SinglyLL<E> : LinkedList<E>
    {
    #region//------ Action --------//
    //-------- Consructor --------//
        public SinglyLL() { head = tail = null; size = 0; }
        public SinglyLL(LinearDataNode<E> hh)
        {
            head = tail = hh;
            findSize(); //size = 1
            //MessageBox.Show(hh.getData().ToString());
        }
        //public SinglyLL(LinearDataNode<E> hh, LinearDataNode<E> tt){head = tail = tt; findSize();}
        #endregion
        //------ Methods -----//
        #region// ------ addFirst
        public bool addFirst(LinearDataNode<E> dn)
        {
            if (dn == null) return false;
            dn.next = head;
            head = dn;
            if (tail == null)
                tail = dn; // 如果链表为空，尾节点也指向新节点
            size++;
            return true;
        }//end of addFirst
        #endregion

        #region //----- addLast
        public bool addLast(LinearDataNode<E> dn)
        {
            if (dn == null) return false;
            if (tail == null)
            {
                head = tail = dn;
            }
            else
            {
                tail.next = dn;
                tail = dn; // 如果链表为空，新节点成为头节点
            }
            size++;
            return true;
        }
        #endregion
        #region//----- addList
        public bool addNext(LinearDataNode<E> curNode, LinearDataNode<E> dn)
        {
            if (curNode == null || dn == null) return false;
            LinearDataNode<E> found = findDataNode(curNode.data);
            if (found == null) return false ;

            dn.next = found.next;
            found.next = dn;
            if (tail == found)
                tail = dn;
            size++;
            return true;
        }

        public E removeFirst()
        {
            if (head == null) return default(E); // 如果链表为空，返回默认值
            E data = head.data;
            head = head.next;
            if (head == null) tail = null; // 如果链表为空，尾节点也为null
            size--;
            return data;
        }

        public E removeLast()
        {
            if (head == null) return default(E); // 如果链表为空，返回默认值
            if (head == tail)
            {
                E data = tail.data; // 确保这里声明了 'removedData'
                head = tail = null;
                size--;
                return data;
            }
            LinearDataNode<E> current = head;
            while (current.next != tail)
            {
                current = current.next;
            }
            E removeData = tail.data;
            tail = current;
            current.next = null;
            size--;
            return removeData;
        }

        public bool removeAt(E dd)
        {
            LinearDataNode<E> current = head;
            LinearDataNode<E> prev = null;
            while (current != null)
            {
                if (current.data.Equals(dd))
                {
                    if (prev == null)
                        head = current.next;
                    else
                        prev.next = current.next;
                    if (current == tail)
                        tail = prev;

                    size--;
                    return true;
                }
                prev = current;
                current = current.next;
            }
            return false;
        }
        

        public bool removeAt(LinearDataNode<E> dn)
        {
            if(dn == null) return false;
            return removeAt(dn.data);
        }


        public override string ToString()
        {
            string result = "";
            LinearDataNode<E> currentNode = head;
            while (currentNode != null)
            {
                result += currentNode.ToString() + "\n";
                currentNode = currentNode.next;
            }
            return result;
        }
        #endregion
    }// end of class SinglyL

    //======== Class DoublyLL =======//

    public class DoublyLL<E> : LinkedList<E>
    {
        #region
        public DoublyLL() { head = tail = null; size = 0; }

        public DoublyLL(LinearDataNode<E> hh)
        {
            head = tail = hh;
            findSize();
        }

        public bool addFirst(LinearDataNode<E> dn)
        {
            if (dn == null) return false;
            dn.next = head;
            dn.prev = null;
            if (head != null)
                head.prev = dn;
            head = dn;
            if (tail == null)
                tail = dn;
            size++;
            return true;
        }

        public bool addLast(LinearDataNode<E> dn)
        {
            if (dn == null) return false;
            dn.prev = tail;
            dn.next = null;
            if (tail != null)
                tail.next = dn;
            tail = dn;
            if (head == null)
                head = dn;
            size++;
            return true;
        }

        public bool addNext(LinearDataNode<E> curNode, LinearDataNode<E> dn)
        {
            if (curNode == null || dn == null) return false;
            LinearDataNode<E> found = findDataNode(curNode.data);
            if (found == null) return false;

            dn.next = found.next;
            dn.prev = found;
            if (found.next != null)
                found.next.prev = dn;
            found.next = dn;
            if (tail == found)
                tail = dn;
            size++;
            return true;
        }

        public E removeFirst()
        {
            if (head == null) return default(E);
            E data = head.data;
            head = head.next;
            if (head != null)
                head.prev = null;
            else
                tail = null;
            size--;
            return data;
        }

        public E removeLast()
        {
            if (tail == null) return default(E);
            E data = tail.data;
            tail = tail.prev;
            if (tail != null)
                tail.next = null;
            else
                head = null;
            size--;
            return data;
        }

        public bool removeAt(E dd)
        {
            LinearDataNode<E> current = head;
            while (current != null)
            {
                if (current.data.Equals(dd))
                {
                    if (current.prev != null)
                        current.prev.next = current.next;
                    else
                        head = current.next;

                    if (current.next != null)
                        current.next.prev = current.prev;
                    else
                        tail = current.prev;

                    size--;
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public bool removeAt(LinearDataNode<E> dn)
        {
            if (dn == null) return false;
            return removeAt(dn.data);
        }

        public override string ToString()
        {
            return toLLstring(head);
        }
        #endregion
    } //end of class

    

}//end of namespace
