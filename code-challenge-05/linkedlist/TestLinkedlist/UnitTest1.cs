
using linkedListImplementation;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;

namespace TestLinkeList
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyLinkedList()
        {
            //Arrange
            MyLinkedList newlist = new MyLinkedList();



            //Assert
            Assert.Equal(null, newlist.Head);
            Assert.Equal(null, newlist.Tail);

        }


        [Fact]
        public void InsertIntoLinkedListAndTheHeadPointToFirstNode()
        {
            //Arrange
            MyLinkedList newlist = new MyLinkedList();
            int expected = 2;

            //Act
            newlist.Addfirst(expected);
            newlist.Addfirst(3);

            //Assert
            Assert.Equal(expected, newlist.Head.Next.Data);
            Assert.Equal(3, newlist.Head.Data);


        }

        [Fact]
        public void InsertMulitableNodes()
        {
            //Arrange
            MyLinkedList newlist = new MyLinkedList();
            int expected = 3;
            //Act
            newlist.Addfirst(1);
            newlist.Addfirst(2);
            newlist.Addfirst(3);


            //Assert
            Assert.Equal(3, newlist.counter);
        }

        [Fact]
        public void ReturnTrueIfTheValueExist()
        {
            //Arrange
            MyLinkedList newlist = new MyLinkedList();

            //Act
            newlist.Addfirst(1);
            newlist.Addfirst(2);
            newlist.Addfirst(3);

            //Assert
            Assert.True(newlist.Find(2));

        }

        [Fact]
        public void ReturnTrueIfTheValueNotExist()
        {

            //Arrange
            MyLinkedList newlist = new MyLinkedList();

            //Act
            newlist.Addfirst(1);
            newlist.Addfirst(2);
            newlist.Addfirst(3);

            //Assert
            Assert.True(!newlist.Find(5));

        }

        [Fact]
        public void PrintCollectionOfValue()
        {

            //Assert
            MyLinkedList newlist = new MyLinkedList();
            string expected = "";


            //Act
            newlist.Addfirst(1);
            newlist.Addfirst(2);
            newlist.Addfirst(3);
            Node h = newlist.Head;
            while (h != null)
            {
                expected += $"{{{h.Data}}} -> ";
                h = h.Next;
            }
            expected = expected + "null";

            //Assert
            Assert.Equal(expected, newlist.Print());
        }



    }
}