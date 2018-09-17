using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;

namespace OrderManager
{
	public class Context : DbContext
	{
		private static Context context;

		public Context() : base("OrderMangerDB") { }

		public static Context DefaultContext
		{
			get
			{
				if (context == null) { context = new Context(); }
				return context;
			}
		}

		public DbSet<Models.Customer> Customers { get; set; }

		public DbSet<Models.Product> Products { get; set; }

		public DbSet<Models.Order> Orders { get; set; }

		public DbSet<Models.OrderProduct> OrderProducts { get; set; }
	}
}
