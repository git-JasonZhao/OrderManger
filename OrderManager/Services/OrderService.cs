using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Services
{
	public class OrderService
	{
		public List<Models.Order> GetOrders()
		{
			using (var context = new Context())
			{
				return context.Orders.Include("Customer").OrderByDescending(o => o.OrderTime).ToList();
			}
		}

		public Models.Order GetOrder(string orderId)
		{
			using (var context = new Context())
			{
				return context.Orders.Include("Customer").Include("OrderProducts.Product").Where(o => o.OrderId == orderId).FirstOrDefault();
			}
		}
	}
}
