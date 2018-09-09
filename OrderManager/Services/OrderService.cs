using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Services
{
	public class OrderService
	{
		private int getNewOrderIdCount = 0;

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

		public Models.Order NewOrder()
		{
			var newOrder = new Models.Order();
			newOrder.RStatus = true;
			newOrder.RIDate = DateTime.Now;
			newOrder.OrderId = GetNewOrderId();
			return newOrder;
		}

		public string GetNewOrderId()
		{
			using (var context = new Context())
			{
				var maxOrderId = context.Orders.Select(o => o.OrderId).Max();
				getNewOrderIdCount++;
				return (long.Parse(maxOrderId) + getNewOrderIdCount).ToString("00000000");
			}
		}
	}
}
