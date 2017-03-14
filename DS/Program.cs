using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int i)
            {
                Data = i;
                Next = null;
            }

            public void Print()
            {
                Console.Write("|" + Data + "|->");
                if (Next != null)
                {
                    Next.Print();
                }
            }

            public void AddSorted(int i)
            {
                if (Next == null)
                {
                    Next = new Node(i);
                }
                else if (Data < Next.Data)
                {
                    Node temp = new Node(i);
                    temp.Next = this.Next;
                    this.Next = temp;
                }
                else
                {
                    Next.AddSorted(i);
                }
            }

            public void AddToEnd(int i)
            {
                if (Next == null)
                {
                    Next = new Node(i);
                }
                else
                {
                    Next.AddToEnd(i);
                }
            }
        }

        public class MyList
        {
            public Node HeadNode;

            public MyList()
            {
                HeadNode = null;
            }

            public void AddSorted(int i)
            {
                if (HeadNode == null)
                {
                    HeadNode = new Node(i);
                }
                else if (i < HeadNode.Data)
                {
                    AddToBegiining(i);
                }
                else
                {
                    HeadNode.AddSorted(i);
                }
            }

            public void AddToEnd(int i)
            {
                if (HeadNode == null)
                {
                    HeadNode = new Node(i);
                }
                else
                {
                    HeadNode.AddToEnd(i);
                }
            }

            public void AddToBegiining(int i)
            {
                if (HeadNode == null)
                {
                    HeadNode = new Node(i);
                }
                else
                {
                    Node temp = new Node(i);
                    temp.Next = HeadNode;
                    HeadNode = temp;
                }
            }

       
            public void Print()
            {
                if (HeadNode != null)
                {
                    HeadNode.Print();
                }
            }
        }
        static void Main(string[] args)
        {
            MyList mList = new MyList();
            //mList.AddToEnd(5);
            //mList.AddToEnd(11);
            //mList.AddToEnd(4);

            //mList.AddToBegiining(5);
            //mList.AddToBegiining(11);
            //mList.AddToBegiining(4);

            mList.AddSorted(5);
            mList.AddSorted(11);
            mList.AddSorted(4);
            mList.Print();
            Console.ReadLine();
        }
    }
}
