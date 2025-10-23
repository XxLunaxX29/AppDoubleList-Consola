using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoubleList_Consola
{
    internal class DoubleList
    {
        private Node? head;

        public Node? Head
        {
            get { return head; }
            set { head = value; }
        }
       
        public DoubleList()
        {
            this.head = null;
        }

        public void Add(Node n)
        {

            if (head == null)
            {
                head = n;
                return;
            }

            if (n.Data < head.Data)
            {
                n.Next = head;
                head.Back = n;
                head = n;
                return;
            }

            Node? h = head;
            while (h.Next != null)
            {
                if (n.Data < h.Next.Data)
                {
                    n.Next = h.Next;
                    n.Back = h;
                    h.Next = n;
                    n.Next.Back = n;
                    return;
                }
                h = h.Next;

            }
            h.Next = n;
            n.Back = h;
        }
        public void Remove(int data)
        {
            if (head == null)
            {
                return;
            }
            if (data < head.Data)
            {
                return;
            }
            if (head.Data == data)
            {
                head.Next.Back = null;
                head = head.Next;
                return;
            }


            Node? h = head;
            while (h.Next != null)
            {
                if (data < h.Next.Data)
                {
                    return;
                }
                if (h.Next.Data == data)
                {
                    h.Next = h.Next.Next;
                    h.Next.Back = h;
                    return;
                }
                h = h.Next;
            }
            return;

        }

        public bool Exists(int data)
        {
            if (head == null)
            {
                return false;
            }
            if (data < head.Data)
            {
                return false;
            }
            if (head.Data == data)
            {
                return true;
            }

            Node? h = head;
            while (h != null)
            {
                if (data < h.Data)
                {
                    return false;
                }
                if (h.Data == data)
                {
                    return true;
                }
                h = h.Next;
            }
            return false;
        }

        public int Count()
        {
            int count = 0;
            Node? h = head;
            while (h != null)
            {
                count++;
                h = h.Next;
            }
            return count;
        }

        public string Show()
        {
            if (head == null)
            {
                return "Empty List";
            }
            int i = 0;
            Node? h = head;
            string datas = "";
            while (h != null)
            {
                datas += $"Node [{i}] and: " + h + Environment.NewLine;
                h = h.Next;
                i++;

            }
            return datas;

        }
        public string ReverseShow()
        {
            if (head == null)
            {
                return "Empty List";
            }
            Node? h = head;
            Node? last = null;
            int i = 0;
            string datas = "";
            while (h != null)
            {
                last = h;
                h = h.Next;
                i++;
            }
            h = last;
            i--;
            while (h != null)
            {
                datas += $"Node [{i}] {h} " + Environment.NewLine;
                h = h.Back;
                i--;
            }

            return datas;
        }

        public void Clear()
        {
            head = null;
        }

        public override string ToString()
        {
            string i = "";
            Node? h = head;
            while (h != null)
            {
                i += h.ToString() + Environment.NewLine;
                h = h.Next;
            }
            return i;
        }
    }
}

