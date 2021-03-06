﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListJD.Models
{
	public class EFItemRepository : IItemRepository
	{
		public EFItemRepository(ToDoDbContext connection = null)
		{
			if (connection == null)
			{
				this.db = new ToDoDbContext();
			}
			else
			{
				this.db = connection;
			}
		}

		ToDoDbContext db = new ToDoDbContext();

		public IQueryable<Item> Items
		{ get { return db.Items; } }

		public Item Save(Item item)
		{
			db.Items.Add(item);
			db.SaveChanges();
			return item;
		}

		public Item Edit(Item item)
		{
			db.Entry(item).State = EntityState.Modified;
			db.SaveChanges();
			return item;
		}

		public void Remove(Item item)
		{
			db.Items.Remove(item);
			db.SaveChanges();
		}

		public void Dispose()
		{
			db.RemoveRange();
			db.SaveChanges();
		}
	}
}