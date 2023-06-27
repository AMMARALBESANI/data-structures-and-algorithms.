using System.ComponentModel;

namespace LINKEDLIST02
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList mylist = new MyLinkedList();
            mylist.AddToLast(1);
            mylist.AddToLast(2);
            mylist.AddToLast(3);
            mylist.AddToLast(4);
            mylist.Delete(2);
           Console.WriteLine( mylist.Print());
           
        }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }
    }

    public class MyLinkedList
    {
       public  Node Head { get; set; }
       public  Node Tail { get; set; }
       public int Count { get; set; }

        public void  AddToLast( int Data )
        {
            Node newnode = new Node(Data);
            if (Head==null)
            {
                Head = newnode;
                Tail = newnode;
               
            }
            else
            {
                Tail.Next = newnode;
                Tail=Tail.Next;
            }
            Count++;

        }

        public void AddAfter(int current , int adding)
        {
            Node newnode = new Node(adding);
            
            Node h = Head;
            while(h!=null)
            {
                if (h.Data== current)
                {
                    newnode.Next= h.Next ;

                   h.Next = newnode;

                    break;

                }
                else
                {
                    h = h.Next;

                }

            }
            Count++;        
        
        }

        public void AddBefor(int current, int adding)
        {
            Node newnode = new Node(adding);

            Node h = Head;
            while (h != null)
            {
                if (h.Data == current)
                {
                    h.Data=newnode.Data;
                    newnode.Next = h.Next;
                    h.Next= newnode;
                    newnode.Data = current;
                     break;

                }
                else
                {
                    h = h.Next;

                }

            }
            Count++;


        }

        public void Delete (int Data)
        {
            Node newnode = new Node(Data);
            Node h = Head;
            if (h.Data==Data)
            {
                h.Data = h.Next.Data;
            }
            else
            {
                while (h.Next.Data != Data)
                {
                    h = h.Next;

                }
            }
            
            h.Next = h.Next.Next;
            Count--;
        }


        public string Print()
        {
            string list = "";
            Node h = Head;
            while (h != null)
            {
                list += $"{{{h.Data}}} -> ";
                h = h.Next;
            }
            return list;
        }

    }
}