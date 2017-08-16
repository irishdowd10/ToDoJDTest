using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ToDoListJD.Models
{
    class TestDbContext : ToDoDbContext
    {
		public override DbSet<Item> Items { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoListJDTest;integrated security = True");
		}
	}
}