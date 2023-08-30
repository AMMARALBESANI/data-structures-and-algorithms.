using System.Collections;

namespace stack_queue_brackets
{
    public class Program
    {
        static void Main(string[] args)
        {

            string x = "{}{Code}[Fellows](())";
          Console.WriteLine(Valivalidatebrackets(x));

         

        }

       public static bool Valivalidatebrackets(string str)
        {

            Stack stack = new Stack();
            foreach (char item in str)

            {
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item.ToString());
                }

                if (item == ')' || item == ']' || item == '}')
                {
                    string x;

                    if (item == ')')
                    {
                        x = "(";
                    }
                    else if (item == ']')
                    {
                        x = "[";
                    }
                    else
                    {
                        x = "{";
                    }

                    if ((string)stack.Peek() == x)
                    {
                        stack.Pop();
                    } 
                    else
                    {
                        return false; 
                    }
                }

            }
           

            if (stack.Count ==0)
            {
                return true;
            }
            
            return false;
          
        }
        
    }


}

