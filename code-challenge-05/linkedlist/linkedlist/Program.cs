namespace linkedListImplementation
{


    public class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList newlist = new MyLinkedList();
            newlist.Addfirst(1);
            newlist.Addfirst(2);
            newlist.Addfirst(3);
            newlist.Addfirst(4);
            Console.WriteLine(newlist.Print());

            Console.WriteLine(newlist.Find(8));
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
        public int counter { get; set; }

        public void Addfirst(int data)
        {

            Node newnode = new Node(data);
            if (Head == null)
            {
                Head = newnode;
                Tail = newnode;
            }
            else
            {
                newnode.Next = Head;
                Head = newnode;
            }

            counter++;
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

    }
}


