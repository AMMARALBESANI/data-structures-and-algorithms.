using Buybook.Models;
using Microsoft.EntityFrameworkCore;

namespace Buybook.Data
{
	public class BookDbContext : DbContext
	{
		public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
		{

		}

		public DbSet<Category> categories { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData
				(
				  new Category { Id=1,Name="Action",DisplayOrder=1},
				 new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
				 new Category { Id = 3, Name = "History", DisplayOrder = 3 }


				);
		}

	}

}
