namespace QueuePseudo
{
    public class Program
    {
        static void Main(string[] args)
        {
            pseudoQueue pseudoQueue = new pseudoQueue();
           
            pseudoQueue.enqueue(2);
            pseudoQueue.enqueue(3);
            pseudoQueue.enqueue(4);
            pseudoQueue.enqueue(5);
            Console.WriteLine(pseudoQueue.print());
            Console.WriteLine($"the deleted element is : {pseudoQueue.dequeue()}");
            Console.WriteLine(pseudoQueue.print());
        }
    }
}