using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoubleList_Consola
{
    internal class Node
    {
        private int data;
        private Node? next;
        private Node? back;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node? Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node? Back
        {
            get { return back; }
            set { back = value; }
        }

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.back = null;
        }

        public override string ToString()
        {
            return "Data:" + data;
        }
    }
}
