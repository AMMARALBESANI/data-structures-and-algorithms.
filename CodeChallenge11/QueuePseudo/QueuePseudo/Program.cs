namespace QueuePseudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pseudoQueue pseudoQueue = new pseudoQueue();
           
            pseudoQueue.enqueue(2);
            pseudoQueue.enqueue(3);
            pseudoQueue.enqueue(4);
            pseudoQueue.enqueue(5);
            pseudoQueue.print();
            Console.WriteLine($"the deleted element is : {pseudoQueue.dequeue()}");
            pseudoQueue.print();
        }
    }
}