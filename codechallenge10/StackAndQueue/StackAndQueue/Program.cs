namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            MyQueue myQueue = new MyQueue();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
           Console.WriteLine( myStack.Print());
            myStack.pop();
            Console.WriteLine(myStack.Print());
           Console.WriteLine( myStack.peek());

            Console.WriteLine();
            myQueue.enqueue(4);
            myQueue.enqueue(5);
            myQueue.enqueue(6);
           Console.WriteLine( myQueue.print());
            myQueue.dequeue();
            Console.WriteLine(myQueue.print());
            Console.WriteLine(myQueue.peek());

        }
    }
}