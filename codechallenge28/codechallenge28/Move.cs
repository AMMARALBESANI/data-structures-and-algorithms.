using System;
using System.Collections.Generic;
using System.Linq;

namespace codechallenge28
{
	public class Movie
	{
		public string title { get; set; }
		public int year { get; set; }
		public List<string> genres { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Movie other = (Movie)obj;
			return title == other.title && year == other.year;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(title, year);
		}

		public Movie[] InsertionSortByYear(Movie[] unsorted)
		{
			for (int i = 1; i < unsorted.Length; i++)
			{
				Movie key = unsorted[i];
				int j = i - 1;

				while (j >= 0 && unsorted[j].year > key.year)
				{
					unsorted[j + 1] = unsorted[j];
					j = j - 1;
				}
				unsorted[j + 1] = key;
			}
			return unsorted;
		}

		public Movie[] InsertionSortByTitle(Movie[] unsorted)
		{
			for (int i = 1; i < unsorted.Length; i++)
			{
				Movie key = unsorted[i];
				int j = i - 1;

				while (j >= 0 && string.Compare(GetSortableTitle(unsorted[j].title), GetSortableTitle(key.title)) > 0)
				{
					unsorted[j + 1] = unsorted[j];
					j = j - 1;
				}
				unsorted[j + 1] = key;
			}
			return unsorted;
		}

		private string GetSortableTitle(string title)
		{
			string[] prefixes = { "A ", "An ", "The " };
			foreach (string prefix in prefixes)
			{
				if (title.StartsWith(prefix))
				{
					// Remove the prefix and add it to the end of the title
					title = title.Substring(prefix.Length) + ", " + prefix.Trim();
					break; // Exit the loop once a prefix is found.
				}
			}
			return title;
		}
	}
}
