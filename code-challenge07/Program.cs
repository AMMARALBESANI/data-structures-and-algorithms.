namespace linkedListImplementation
{


    public class Program
    {
       static void Main(string[] args)
        {
            try
            {
                MyLinkedList newlist = new MyLinkedList();
                newlist.Addfirst(1);
                newlist.Addfirst(2);
                newlist.Addfirst(3);
                Console.WriteLine(newlist.Print());
            
                Console.Write(newlist.kthFromEnd(2));
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }


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
            
            if(index>=Counter || index<0)
            {
               throw new Exception ("the index you put out of the linkedlist length");
            }
            while (h != null)
            {
                if ((Counter-1)-index==i)
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


