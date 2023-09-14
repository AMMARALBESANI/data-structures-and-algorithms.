using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechallenge30
{
	public class HashTable<TKey, TValue>
	{
		private const int DefaultCapacity = 16;
		private readonly LinkedList<HashEntry>[] items;

		public HashTable(int capacity = DefaultCapacity)
		{
			items = new LinkedList<HashEntry>[capacity];
		}

		public void Set(TKey key, TValue value)
		{
			int index = Hash(key);
			if (items[index] == null)
			{
				items[index] = new LinkedList<HashEntry>();
			}

			LinkedList<HashEntry> bucket = items[index];
			foreach (var entry in bucket)
			{
				if (entry.Key.Equals(key))
				{
					entry.Value = value; // Key exists, replace value
					return;
				}
			}

			// Key does not exist in this bucket, add it
			bucket.AddLast(new HashEntry(key, value));
		}

		public TValue Get(TKey key)
		{
			int index = Hash(key);
			if (items[index] != null)
			{
				LinkedList<HashEntry> bucket = items[index];
				foreach (var entry in bucket)
				{
					if (entry.Key.Equals(key))
					{
						return entry.Value; // Key found, return its value
					}
				}
			}
			throw new KeyNotFoundException($"Key '{key}' not found.");
		}

		public bool Has(TKey key)
		{
			int index = Hash(key);
			if (items[index] != null)
			{
				LinkedList<HashEntry> bucket = items[index];
				foreach (var entry in bucket)
				{
					if (entry.Key.Equals(key))
					{
						return true; // Key found
					}
				}
			}
			return false; // Key not found
		}

		public IEnumerable<TKey> Keys()
		{
			List<TKey> keys = new List<TKey>();
			foreach (var bucket in items)
			{
				if (bucket != null)
				{
					foreach (var entry in bucket)
					{
						keys.Add(entry.Key);
					}
				}
			}
			return keys;
		}

		private int Hash(TKey key)
		{
			int hashCode = key.GetHashCode();
			// Ensure the hash code is non-negative by taking its absolute value
			int index = Math.Abs(hashCode) % items.Length;
			return index;
		}

		private class HashEntry
		{
			public TKey Key { get; }
			public TValue Value { get; set; }

			public HashEntry(TKey key, TValue value)
			{
				Key = key;
				Value = value;
			}
		}
	}

}
