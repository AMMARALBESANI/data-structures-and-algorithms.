using StackAndQueue;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace TestStackAndQueue
{
    public class UnitTest1
    {
        [Fact]
        public void successfullyPushOntoAStack()
        {
            //Arrang
            MyStack myStack = new MyStack();
            string expexted = "{3}\n";
            

            //Act
            myStack.push(3);
            

            //Assert
            Assert.Equal(expexted, myStack.Print());
        }


        [Fact]  
        public void successfullyPushMulitableNodeOntoAStack() 
        {
            //Arrang
            MyStack myStack = new MyStack();
            string expexted = "{3}\n{2}\n{1}\n";

            //Act
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);

            //Assert
            Assert.Equal(expexted, myStack.Print());

        }

        [Fact]  
        public void successfullyPopOffTheStack()
        {
            //Arrang
            MyStack myStack = new MyStack();
            string expexted = "{2}\n{1}\n";
            //Act
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            myStack.pop();

            //Assert
            Assert.Equal(expexted, myStack.Print());
        }

        [Fact]
        public void emptyAStackAfterMultiplePops()
        {
            //Arrang
            MyStack myStack = new MyStack();
            string expexted = "";
            //Act
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            myStack.pop();
            myStack.pop();
            myStack.pop();

            //Assert
            Assert.Equal(expexted, myStack.Print());
        }

        [Fact]
        public void peekTheNextItemOnTheStack() 
        {
            //Arrang
            MyStack myStack = new MyStack();
            int expexted = 3;
            
            //Act
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            
           

            //Assert
            Assert.Equal(expexted, myStack.peek() );

        }

        [Fact]  

        public void instantiateAnEmptyStack()
        {
            //Arrang
            MyStack myStack = new MyStack();
            string expected = "";

            //Assert
            Assert.Equal(expected, myStack.Print());

        }

        [Fact]

        public void throwAnException1()
        {
            //Arrang
            MyStack myStack = new MyStack();
            string expected = "the stack is empty";

            //Assert
            Assert.Throws<Exception>(() => myStack.peek());

        }

        //_______________________________________________________________________________________________________//

        [Fact]

        public void successfullyEnqueueOntoAQueue()
        {
            //Assert
            MyQueue myQueue = new MyQueue();
            string expexted = "{3}";

            //Act
            myQueue.enqueue(3);

            //Assert
            Assert.Equal(expexted, myQueue.print());

        }


        [Fact]

        public void successfullyEnqueueMulitableNodeOntoAQueue()
        {
            MyQueue myQueue = new MyQueue();
            string expexted = "{3}{2}{1}";

            //Act
            myQueue.enqueue(3);
            myQueue.enqueue(2);
            myQueue.enqueue(1);

            //Assert
            Assert.Equal(expexted, myQueue.print());
        }

        [Fact]
        public void successfullydequeueMulitableNodeOntoAQueue()
        {
            MyQueue myQueue = new MyQueue();
            string expexted = "{2}{1}";

            //Act
            myQueue.enqueue(3);
            myQueue.enqueue(2);
            myQueue.enqueue(1);
            myQueue.dequeue();

            //Assert
            Assert.Equal(expexted, myQueue.print());

        }

        [Fact]

        public void emptyQueueAfterMultiplePops() 
        {
            MyQueue myQueue = new MyQueue();
            string expexted = "";

            //Act
            myQueue.enqueue(3);
            myQueue.enqueue(2);
            myQueue.enqueue(1);
            myQueue.dequeue();
            myQueue.dequeue();
            myQueue.dequeue();

            //Assert
            Assert.Equal(expexted, myQueue.print());

        }

        [Fact]

        public void peekTheNextItemOnTheQueue() 
        {
            MyQueue myQueue = new MyQueue();
            int expexted = 3;

            //Act
            myQueue.enqueue(3);
            myQueue.enqueue(2);
            myQueue.enqueue(1);

            //Assert
            Assert.Equal(expexted, myQueue.peek());

        }

        [Fact]  

        public void instantiateAnEmptyQueue()
        {
            MyQueue myQueue = new MyQueue();
            string expexted = "";

            //Assert
            Assert.Equal(expexted, myQueue.print());


        }


        [Fact]

        public void throwAnException2()
        {
            MyQueue myQueue = new MyQueue();
            string expected = "the stack is empty";

            //Assert
            Assert.Throws<Exception>(() => myQueue.peek());
        }





    }
}