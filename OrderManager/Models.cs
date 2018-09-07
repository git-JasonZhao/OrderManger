using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace OrderManager
{
	public class Order
	{
		[Key]
		public string OrderId { get; set; }
		public string CustomerId { get; set; }
		public string CustomerAddressId { get; set; }
		public decimal Amount { get; set; }
		public decimal FinalAmount { get; set; }
		public DateTime OrderTime { get; set; }
		public DateTime DeliveryDate { get; set; }
	}
}
