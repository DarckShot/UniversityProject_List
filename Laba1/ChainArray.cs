using System;

namespace ChainArrayClass
{
    public class ChainArray
    {
        private class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private int count = 0;
        private Node StartNode = null;
        private Node Find(int pos)
        {
            Node current = StartNode;
            int index = 0;
            while (current != null && index < pos)
            {
                current = current.Next;
                index++;
            }
            return current;
        }
        public int this[int i]
        {
            set { if (i < count)
                    Find(i).Data = value;
            }
            get { if (i < count)
                    return Find(i).Data;
                else
                    return 0;
            }
        }
        public void Add(int data)
        {
            Node NewNode = new Node(data);

            if (StartNode == null)
            {
                StartNode = NewNode;
            }
            else 
            {
                Node current = StartNode;

                while (current.Next != null) 
                {
                    current = current.Next;
                }
                current.Next = NewNode;
            }
            count++;
        }
        public void Insert(int data, int pos) 
        {
            Node NewNode = new Node(data);

            if (pos > count)
            {
                return;
            }
            if (StartNode == null)
            {
                StartNode = NewNode;
            }
            if (pos == 0)
            {
                NewNode.Next = StartNode;
                StartNode = NewNode;
            }
            else
            {
                Node current = StartNode;
                for (int i = 0; i < pos - 1; i++)
                {
                    current = current.Next;
                }
                NewNode.Next = current.Next;
                current.Next = NewNode;

            }
            count++;
        }
        public void Delete(int pos) 
        {
            if (pos > count) 
            {
                return;
            }
            if (pos == 0)
            {
                StartNode = StartNode.Next;
            }
            else
            {
                Node current = StartNode;
                for (int i = 0; i < pos-1; i++) 
                { 
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
            count--;
        }
        public void Clear() 
        {
            StartNode = null;
            count = 0;
        }
        public void Print()
        {
            Node corrent = StartNode;
            while ( corrent != null )
            {
                Console.WriteLine( corrent.Data );
                corrent = corrent.Next;
            }
        }
        public int Count()
        {
            return count;
        }
    }
}
