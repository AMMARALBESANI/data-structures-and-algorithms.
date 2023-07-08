namespace codechallenge08
{
    
        public class Program
        {
            static void Main(string[] args)
            {
                MyLinkedList list1 = new MyLinkedList();
                MyLinkedList list2 = new MyLinkedList();
                MyLinkedList list3 = new MyLinkedList();

                list1.Addlast(1);
                list1.Addlast(2);
                list1.Addlast(3);
                //  ____________________________________________________________
                list2.Addlast(4);
                list2.Addlast(5);
                list2.Addlast(6);
                //  ____

                list3.Addlast(1);
                list3.Addlast(4);
                list3.Addlast(2);
                list3.Addlast(5);
                list3.Addlast(3);
                list3.Addlast(6);





                MyLinkedList ziplist = ziplists(list1, list2);

                Node newnode = ziplist.Head;

                while (newnode != null)
                {
                    Console.WriteLine(newnode.Data);
                    newnode = newnode.Next;
                }


            }
            public static MyLinkedList ziplists(MyLinkedList list1, MyLinkedList list2)
            {
                MyLinkedList list3 = new MyLinkedList();
                Node h1 = list1.Head;
                Node h2 = list2.Head;

                while (h1 != null || h2 != null)
                {
                    if (h1 != null)
                    {
                        list3.Addlast(h1.Data);
                        h1 = h1.Next;

                    }

                    if (h2 != null)
                    {
                        list3.Addlast(h2.Data);
                        h2 = h2.Next;
                    }

                }
                return list3;

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

            public Node? Head { get; set; }
            public Node? Tail { get; set; }
            public int Counter { get; set; }

            public void Addlast(int data)
            {

                Node newnode = new Node(data);
                if (Head == null)
                {
                    Head = newnode;
                    Tail = newnode;
                }
                else
                {
                    Tail.Next = newnode;
                    Tail = Tail.Next;
                }

                Counter++;
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
                return list + "null";
            }

            public bool Find(int value)
            {
                Node h = Head;
                while (h != null)
                {
                    if (h.Data == value)
                    {
                        return true;
                    }
                    h = h.Next;
                }
                return false;
            }

            public int kthFromEnd(int index)
            {
                int i = 0;
                Node h = Head;

                if (index >= Counter || index < 0)
                {
                    throw new Exception("the index you put out of the linkedlist length");
                }
                while (h != null)
                {
                    if ((Counter - 1) - index == i)
                    {
                        return h.Data;

                    };
                    i++;
                    h = h.Next;
                }
                return 0;
            }


        }



    
}