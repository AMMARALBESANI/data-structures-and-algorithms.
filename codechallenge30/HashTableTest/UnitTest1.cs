using codechallenge30;

namespace HashTableTest
{
	public class UnitTest1
	{
		[Fact]
		public void SetAndGet()
		{
			var hashtable = new HashTable<string, int>();
			hashtable.Set("one", 1);
			hashtable.Set("two", 2);

			Assert.Equal(1, hashtable.Get("one"));
			Assert.Equal(2, hashtable.Get("two"));
		}

		[Fact]
		public void SetWithCollisionAndGet()
		{
			var hashtable = new HashTable<string, int>(2);
			hashtable.Set("one", 1);
			hashtable.Set("neo", 11); // Collision
			hashtable.Set("two", 2);

			Assert.Equal(1, hashtable.Get("one"));
			Assert.Equal(11, hashtable.Get("neo"));
			Assert.Equal(2, hashtable.Get("two"));
		}

		[Fact]
		public void ReplaceExistingKey()
		{
			var hashtable = new HashTable<string, int>();
			hashtable.Set("one", 1);
			hashtable.Set("one", 100); // Replace value

			Assert.Equal(100, hashtable.Get("one"));
		}

		[Fact]
		public void KeyExists()
		{
			var hashtable = new HashTable<string, int>();
			hashtable.Set("one", 1);

			Assert.True(hashtable.Has("one"));
			Assert.False(hashtable.Has("two"));
		}

		[Fact]
		public void GetNonexistentKeyThrowsException()
		{
			var hashtable = new HashTable<string, int>();

			Assert.Throws<KeyNotFoundException>(() => hashtable.Get("nonexistent"));
		}

		[Fact]
		public void GetKeys()
		{
			var hashtable = new HashTable<string, int>();
			hashtable.Set("one", 1);
			hashtable.Set("two", 2);

			var keys = hashtable.Keys();

			Assert.Contains("one", keys);
			Assert.Contains("two", keys);
		}
	}
}