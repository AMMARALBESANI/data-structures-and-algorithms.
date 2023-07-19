using QueuePseudo;
namespace TestQueuePseudo
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueuMethod()
        {

            //Arrange
            pseudoQueue pseudoQueue = new pseudoQueue();
            string expexted = "{3} {2} ";
            //Act
            pseudoQueue.enqueue(2);
            pseudoQueue.enqueue(3);

            string actual = pseudoQueue.print();
            //Assert
            Assert.Equal(expexted,actual);
        }

        [Fact]  
        public void TestDequeuMethod() 
        {
            pseudoQueue pseudoQueue = new pseudoQueue();
            int expexted = 2;
            //Act
            pseudoQueue.enqueue(2);
            pseudoQueue.enqueue(3);
            pseudoQueue.enqueue(4);

            //Assert

            Assert.Equal(2, pseudoQueue.dequeue());

        }


        [Fact]
        public void TestDequeuMethodFromEmoty()
        {
            pseudoQueue queue = new pseudoQueue();

            // Act and Assert
            Assert.Throws<Exception>(() => queue.dequeue());


        }
    }
}