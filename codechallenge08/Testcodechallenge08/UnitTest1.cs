using codechallenge08;


namespace TestChallenge08
{
    public class UnitTest1
    {
        [Fact]
        public void TestTheMeargeItSelf()
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList();
            MyLinkedList list2 = new MyLinkedList();
            MyLinkedList list3 = new MyLinkedList();

            list1.Addlast(1);
            list1.Addlast(2);
            list1.Addlast(3);
            //  ____________________________________________________________
            list2.Addlast(4);
            list2.Addlast(5);
            list2.Addlast(6);
            //  ____________________________________________________________
            list3.Addlast(1);
            list3.Addlast(4);
            list3.Addlast(2);
            list3.Addlast(5);
            list3.Addlast(3);
            list3.Addlast(6);

            //Act
            MyLinkedList ziplist = Program.ziplists(list1, list2);

            //Assert
            Assert.Equal(list3.Print(), ziplist.Print());

        }

        [Fact]

        public void TestTheMergeIfTheFirstListIsShorterThanTheSecond()
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList();
            MyLinkedList list2 = new MyLinkedList();
            MyLinkedList list3 = new MyLinkedList();

            list1.Addlast(1);
            list1.Addlast(2);
            list1.Addlast(3);

            //  ____________________________________________________________
            list2.Addlast(4);
            list2.Addlast(5);
            list2.Addlast(6);
            list2.Addlast(7);
            list2.Addlast(8);
            //  ____________________________________________________________
            list3.Addlast(1);
            list3.Addlast(4);
            list3.Addlast(2);
            list3.Addlast(5);
            list3.Addlast(3);
            list3.Addlast(6);
            list3.Addlast(7);
            list3.Addlast(8);

            //Act
            MyLinkedList ziplist = Program.ziplists(list1, list2);

            //Assert
            Assert.Equal(list3.Print(), ziplist.Print());
        }

        [Fact]


        public void TestTheMergeIfTheSecondListIsShorterThanTheFirst()
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList();
            MyLinkedList list2 = new MyLinkedList();
            MyLinkedList list3 = new MyLinkedList();

            list1.Addlast(1);
            list1.Addlast(2);
            list1.Addlast(3);
            list1.Addlast(9);
            list1.Addlast(10);
            //  ____________________________________________________________
            list2.Addlast(4);
            list2.Addlast(5);
            list2.Addlast(6);
            //  ____________________________________________________________
            list3.Addlast(1);
            list3.Addlast(4);
            list3.Addlast(2);
            list3.Addlast(5);
            list3.Addlast(3);
            list3.Addlast(6);
            list3.Addlast(9);
            list3.Addlast(10);

            //Act
            MyLinkedList ziplist = Program.ziplists(list1, list2);

            //Assert
            Assert.Equal(list3.Print(), ziplist.Print());
        }


    }
}