using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class MyStack
    {
        Node Top { get; set; }
       

        public void push(int Data)
        {
           
            Node newnode = new Node(Data);
            if (Top == null)
            {
                Top = newnode;
               
            }
            else
            {
                newnode.Next = Top;
                Top = newnode;
            }
        }

        public void pop() 
        {

            if (Top==null)
            {
                throw new Exception("the stack is empty");
            }
            else
            {
                Top=Top.Next;
            }
        }


        public int peek()
        {

            if (Top == null)
            {
                throw new Exception("the stack is empty");
            }
            else
            {
                return Top.Data;
            }
        }

        public bool isempty()
        {
            if(Top == null)
            {
                return false;
            }
           
                return true;
            
        }

        public string Print()
        {
            string list = "";
            Node h = Top;
            while (h != null)
            {
                list += $"{{{h.Data}}}\n";
                h = h.Next;
            }
             return list;
        }
    }
}
