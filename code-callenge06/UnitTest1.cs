using LINKEDLIST02;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit.Sdk;

namespace TestLinkedList02
{
    public class UnitTest1
    {
        [Fact]
        public void AddOneNodeToTheEnd()
        {
            //Arrang
            MyLinkedList newlist = new MyLinkedList();
            int expected = 1;

            //Act
            newlist.AddToLast(1);

            //Assert
            Assert.Equal(expected,newlist.Head.Data);


        }


        [Fact]  
        public void AddMoreThanOneNode() 
        {
            //Arrang
            MyLinkedList newlist = new MyLinkedList();
            int expected = 3;

            //Act
            newlist.AddToLast(1);
            newlist.AddToLast(2);
            newlist.AddToLast(3);

            //Assert
            Assert.Equal(expected, newlist.Count);

        }


        [Fact]  

        public void AddNodeBeforNodeInTheMiddel()
        {
            //Arrang
            MyLinkedList newlist = new MyLinkedList();
            string expected ="" ;

            //Act
            newlist.AddToLast(1);
            newlist.AddToLast(2);
            newlist.AddToLast(3);
            newlist.AddBefor(3, 5);
            Node h = newlist.Head;
            while (h != null)
            {
                expected += $"{{{h.Data}}} -> ";
                h = h.Next;
            }
            //Assert
            Assert.Equal(expected, newlist.Print());


        }


        [Fact]

        public void AddNodeBeforTheFirst()
        {
            //Arrang
            MyLinkedList newlist = new MyLinkedList();
            string expected = "";

            //Act
            newlist.AddToLast(1);
            newlist.AddToLast(2);
            newlist.AddToLast(3);
            newlist.AddBefor(1, 5);
            Node h = newlist.Head;
            while (h != null)
            {
                expected += $"{{{h.Data}}} -> ";
                h = h.Next;
            }
            //Assert
            Assert.Equal(expected, newlist.Print());


        }

        [Fact]
        public void AddNodeAterNodeInTheMiddel()
        {
            //Arrang
            MyLinkedList newlist = new MyLinkedList();
            string expected = "";

            //Act
            newlist.AddToLast(1);
            newlist.AddToLast(2);
            newlist.AddToLast(3);
            newlist.AddAfter(3, 5);
            Node h = newlist.Head;
            while (h != null)
            {
                expected += $"{{{h.Data}}} -> ";
                h = h.Next;
            }
            //Assert
            Assert.Equal(expected, newlist.Print());


        }


        [Fact]
        public void AddNodeAfterTheLastNode()
        { 
            //Arrang
            MyLinkedList newlist = new MyLinkedList();
            string expected = "";

            //Act
            newlist.AddToLast(1);
            newlist.AddToLast(2);
            newlist.AddToLast(3);
            newlist.AddAfter(1, 3);
            Node h = newlist.Head;
            while (h != null)
            {
                expected += $"{{{h.Data}}} -> ";
                h = h.Next;
            }
            //Assert
            Assert.Equal(expected, newlist.Print());


        }
    }
}