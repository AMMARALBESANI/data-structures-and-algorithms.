
using linkedListImplementation;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using System;

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
            int actual = newlist.Counter;


            //Assert
            Assert.Equal(3, actual);
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
        //----------------------------------------------------------code challenge 07-------------------------------------------------//

        [Fact]
        public void greaterthanthelengthofthelinkedlist()
        {
            //Arrange
            MyLinkedList newlist = new MyLinkedList();
            string expected = "The index you put out of the linkedlist length";
            string actual;

            //Act
            newlist.Addfirst(0);
            newlist.Addfirst(1);
            newlist.Addfirst(3);

            try
            {
                newlist.kthFromEnd(4);
                actual = "";
            }
            catch (Exception ex)
            {
                actual = ex.Message; 
            }

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public  void indexandthelengthofthelistarethesame()
        {

            //Arrange
            MyLinkedList newlist = new MyLinkedList();
            string expected = "The index you put out of the linkedlist length";
            string actual;
            newlist.Addfirst(0);
            newlist.Addfirst(1);
            newlist.Addfirst(3);

            //Act
            try
            {
                newlist.kthFromEnd(3);
                actual = "";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void indexisnegative()
        {

            //Arrange
            MyLinkedList newlist = new MyLinkedList();
            string expected = "The index you put out of the linkedlist length";
            string actual;
            newlist.Addfirst(0);
            newlist.Addfirst(1);
            newlist.Addfirst(3);

            //Act
            try
            {
                newlist.kthFromEnd(-1);
                actual = "";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Wherethelinkedlistisofasize1() 
        {
            //Arrange
            MyLinkedList newlist = new MyLinkedList();
            int expected =3 ;
            string actual;
          
            newlist.Addfirst(3);

            //Act
            try
            {
                newlist.kthFromEnd(0);
                actual = "";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }

            //Assert
            Assert.Equal(expected, newlist.kthFromEnd(0));
        }

        [Fact]
        public void indexinthemiddel()
        {

            //Arrange
            MyLinkedList newlist = new MyLinkedList();
            int expected = 3;
            string actual;
            newlist.Addfirst(0);
            newlist.Addfirst(1);
            newlist.Addfirst(3);
            newlist.Addfirst(4);

            //Act
            try
            {
                newlist.kthFromEnd(2);
                actual = "";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }

            //Assert
            Assert.Equal(expected, newlist.kthFromEnd(2));
        }


    }
}