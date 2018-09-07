using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;

namespace OrderManager
{
	public class Context : DbContext
	{
		public Context() : base("DefaultConnection") { }

		public DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
