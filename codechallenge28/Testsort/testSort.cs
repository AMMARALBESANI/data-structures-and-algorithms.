using codechallenge28;

namespace Testsort
{
	public class testSort
	{
		[Fact]
		public void TestInsertionSortByYear()
		{
			// Arrange
			Movie[] movies = new Movie[]
			{
				new Movie { title = "Movie A", year = 2020 },
				new Movie { title = "Movie B", year = 2010 },
				new Movie { title = "Movie C", year = 2015 },
			};

			Movie sortedYear = new Movie();
			// Act
			var sortedMovies = sortedYear.InsertionSortByYear(movies);

			// Assert
			Assert.Equal(2010, sortedMovies[0].year);
			Assert.Equal(2015, sortedMovies[1].year);
			Assert.Equal(2020, sortedMovies[2].year);
		}

		[Fact]
		public void TestInsertionSortByTitle()
		{
			Movie[] movies = new Movie[]
	{
		new Movie { title = "The Movie A", year = 2020 },
		new Movie { title = "An Awesome Movie B", year = 2010 },
		new Movie { title = "A Cool Movie C", year = 2015 },
	};

			Movie sortedTitle = new Movie();
			// Act
			var sortedMovies = sortedTitle.InsertionSortByTitle(movies);

			// Assert
			Assert.Equal("An Awesome Movie B", sortedMovies[0].title);
			Assert.Equal("A Cool Movie C", sortedMovies[1].title);
			Assert.Equal("The Movie A", sortedMovies[2].title);
		}

	}
}
