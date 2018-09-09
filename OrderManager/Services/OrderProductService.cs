using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Services
{
	public class OrderProductService
	{
		public List<Models.OrderProduct> GetOrderProducts(string orderId)
		{
			using (var context = new Context())
			{
				return context.OrderProducts.Include("Product").Where(op => op.OrderId == orderId).OrderBy(op => op.SeqNo).ToList();
			}
		}

		public Models.OrderProduct NewOrderProduct()
		{
			var newOrderProduct = new Models.OrderProduct();
			newOrderProduct.RStatus = true;
			newOrderProduct.RIDate = DateTime.Now;
			newOrderProduct.OrderProductId = GetNewOrderProductId();
			return newOrderProduct;
		}

		public string GetNewOrderProductId()
		{
			return Guid.NewGuid().ToString();
		}
	}
}
