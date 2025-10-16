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
        private Node? lastnode;

        public Node? Head
        {
            get { return head; }
            set { head = value; }
        }
        public Node? LastNode
        {
            get { return lastnode; }
            set { lastnode = value; }
        }
        public DoubleList()
        {
            this.head = null;
            this.lastnode = null;
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
            lastnode = n;
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
            Node? l = lastnode;
            int i = 0;
            string datas = "";
            do
            {
                datas += $"Node [{i}] and " + l + Environment.NewLine;
                l = l.Back;
                i++;

            } while (l != null);
            return datas;
        }

        public void Clear()
        {
            head = null;
            lastnode = null;
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

