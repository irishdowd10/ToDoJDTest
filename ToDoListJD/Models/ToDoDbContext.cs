using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoListJD.Models
{
	public class ToDoDbContext : DbContext
	{
		public ToDoDbContext()
		{
		}


		public virtual DbSet<Item> Items { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoListJD;integrated security=True");
		}

		public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
