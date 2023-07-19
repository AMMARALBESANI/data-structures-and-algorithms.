using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePseudo
{
    public class pseudoQueue
    {
        int count = 0;
        Stack<int> stack = new Stack<int>();
        Stack<int> nstack = new Stack<int>();
        public Stack<int> enqueue(int value)
        {
            stack.Push(value);
            count++;
            return stack;

        }


        public int dequeue()
        {
            int b;
            if (stack.Count==0)
            {
                throw new Exception("You can't remove from empty queue");
            }
            for (int i = 0; i < count; i++)
            {
                int a = stack.Pop();
                nstack.Push(a);

            }
            b = nstack.Pop();
            for (int i = 0; i < count-1; i++)
            {
                int a = nstack.Pop();
                stack.Push(a);
            }

            return b;

        }

        public string print()

        {

            string s = "";
            foreach (var item in stack)
            {
                s += $"{{{item}}} ";

            }
            return s;


        }
    }

}

