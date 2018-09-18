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
			return Context.DefaultContext.Orders.OrderByDescending(o => o.OrderTime.Value).ToList();
		}

		public Models.Order GetOrder(string orderId)
		{
			return Context.DefaultContext.Orders.Include("OrderProducts").Where(o => o.OrderId == orderId).FirstOrDefault();
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
			var maxOrderId = Context.DefaultContext.Orders.Select(o => o.OrderId).Max();
			if (string.IsNullOrWhiteSpace(maxOrderId))
			{
				maxOrderId = "0";
			}
			getNewOrderIdCount++;
			return (long.Parse(maxOrderId) + getNewOrderIdCount).ToString("00000000");
		}
	}
}
