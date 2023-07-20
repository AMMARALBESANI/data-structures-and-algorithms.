using codechallenge12;

namespace TestsAnimal_shelter
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueValidAnimalAddedToFrontAndBack()
        {
            // Arrange
            myQueue queue = new myQueue();
            Animals cat = new Animals { Species = "cat" };

            // Act
            queue.enqueue(cat);

            // Assert
            Assert.Same(cat, queue.front.Data);
            Assert.Same(cat, queue.back.Data);
        }

        [Fact]
        public void EnqueueInvalidAnimalNotAdded()
        {
            // Arrange
            myQueue queue = new myQueue();
            Animals bird = new Animals { Species = "bird" };

            // Act
            queue.enqueue(bird);

            // Assert
            Assert.Null(queue.front);
            Assert.Null(queue.back);
        }

        

        [Fact]
        public void DequeueNonExistingAnimalReturnsNull()
        {
            // Arrange
            myQueue queue = new myQueue();
            Animals cat = new Animals { Species = "cat" };
            queue.enqueue(cat);

            // Act
            Animals dequeuedDog = queue.dequeue("dog");

            // Assert
            Assert.Null(dequeuedDog);
            Assert.Same(cat, queue.front.Data);
            Assert.Same(cat, queue.back.Data);
        }


        [Fact]
        public void DequeueExistingAnimalReturnsCorrectAnimal()
        {
            myQueue queue = new myQueue();
            Animals cat = new Animals { Species = "cat" };
            Animals dog = new Animals { Species = "dog" };
            queue.enqueue(cat);
            queue.enqueue(dog);

            // Act
            string dequeuedSpecies = queue.dequeue("dog").Species;

            // Assert
            Assert.Equal("dog", dequeuedSpecies);
        }
    }
}