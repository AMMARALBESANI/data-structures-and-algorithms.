namespace codechallenge12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           myQueue myqueue = new myQueue();
            myqueue.enqueue(new Animals { Species = "cat", Name = "gg" }); 
            myqueue.enqueue(new Animals { Species = "cat", Name = "tog" }); 
            myqueue.enqueue(new Animals { Species="dog", Name="ghg"});
              var x = myqueue.dequeue("dog");
           Console.WriteLine($"name is: {x.Name} species is: {x. Species}" );
           // Console.WriteLine(myqueue.print());

        }
    }
}