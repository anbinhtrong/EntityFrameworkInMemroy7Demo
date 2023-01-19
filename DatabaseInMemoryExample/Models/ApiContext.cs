using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseInMemoryExample.Models
{
	public class ApiContext: DbContext
	{
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public ApiContext(DbContextOptions<ApiContext>
options) : base(options)
		{

		}

	}
}
