using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;

namespace OrderManager
{
	public class Context : DbContext
	{
		public Context() : base("OrderMangerDB") { }

		public DbSet<Models.Customer> Customers { get; set; }

		public DbSet<Models.Product> Products { get; set; }

		public DbSet<Models.Order> Orders { get; set; }

		public DbSet<Models.OrderProduct> OrderProducts { get; set; }
	}
}
