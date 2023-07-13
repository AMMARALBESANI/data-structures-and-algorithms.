using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class MyQueue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }

        public void enqueue(int Data)
        {
            Node newnode = new Node(Data);
            if (Front==null)
            {
                Front = newnode;
                Back = newnode;

            }
            else
            {
                Back.Next= newnode;
                Back = Back.Next;
                
            }
        }


        public void dequeue()
        {
            if (Front==null)
            {
                throw new Exception("The queue is empty");
            }
            else
            {
                Front = Front.Next;
                
            }

        }

        public int peek()
        {

            if (Front == null)
            {
                throw new Exception("the queue is empty");
            }
            else
            {
                return Front.Data;
            }
        }

        public bool isempty()
        {
            if (Front == null)
            {
                return false;
            }

            return true;

        }



        public string print()
        {
            string result = "";
            Node h = Front;
            while (h!=null)
            {
                result += $"{{{ h.Data}}}";
                h = h.Next;
            }

            return result;
        }
    }
}
