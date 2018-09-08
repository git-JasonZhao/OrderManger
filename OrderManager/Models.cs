using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManager.Models
{
	/// <summary>
	/// 基础Model
	/// </summary>
	public class BaseModel
	{
		/// <summary>
		/// 数据是否有效
		/// </summary>
		public bool RStatus { get; set; }

		/// <summary>
		/// 新增时间
		/// </summary>
		public DateTime? RIDate { get; set; }

		/// <summary>
		/// 最后一次修改时间
		/// </summary>
		public DateTime? RMDate { get; set; }

		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? RDDate { get; set; }
	}

	/// <summary>
	/// 客户
	/// </summary>
	public class Customer : BaseModel
	{
		/// <summary>
		/// 客户编码
		/// </summary>
		[Key]
		public string CustomerId { get; set; }

		/// <summary>
		/// 客户姓名
		/// </summary>
		public string CustomerName { get; set; }

		/// <summary>
		/// 客户电话
		/// </summary>
		public string Telephone { get; set; }
	}

	/// <summary>
	/// 产品
	/// </summary>
	public class Product : BaseModel
	{
		/// <summary>
		/// 产品编码
		/// </summary>
		[Key]
		public string ProductId { get; set; }

		/// <summary>
		/// 产品名称
		/// </summary>
		public string ProductName { get; set; }

		/// <summary>
		/// 产品型号
		/// </summary>
		public string Model { get; set; }

		/// <summary>
		/// 产品单位
		/// </summary>
		public string Unit { get; set; }

		/// <summary>
		/// 产品标准价格
		/// </summary>
		public decimal Price { get; set; }
	}

	/// <summary>
	/// 订单
	/// </summary>
	public class Order : BaseModel
	{
		/// <summary>
		/// 订单编号
		/// </summary>
		[Key]
		public string OrderId { get; set; }

		/// <summary>
		/// 客户编码
		/// </summary>
		public string CustomerId { get; set; }

		/// <summary>
		/// 客户
		/// </summary>
		[ForeignKey("CustomerId")]
		public Customer Customer { get; set; }

		/// <summary>
		/// 订单总金额
		/// </summary>
		public decimal? Amount { get; set; }

		/// <summary>
		/// 送货日期
		/// </summary>
		public DateTime? DeliveryDate { get; set; }

		/// <summary>
		/// 订单时间
		/// </summary>
		public DateTime OrderTime { get; set; }

		public List<OrderProduct> OrderProducts { get; set; }
	}

	/// <summary>
	/// 订单产品
	/// </summary>
	public class OrderProduct : BaseModel
	{
		/// <summary>
		/// 订单产品编码（主键）
		/// </summary>
		[Key]
		public string OrderProductId { get; set; }

		/// <summary>
		/// 序号
		/// </summary>
		public int SeqNo { get; set; }

		/// <summary>
		/// 订单编码
		/// </summary>
		public string OrderId { get; set; }

		/// <summary>
		/// 订单
		/// </summary>
		[ForeignKey("OrderId")]
		public Order Order { get; set; }

		/// <summary>
		/// 产品
		/// </summary>
		[ForeignKey("ProductId")]
		public Product Product { get; set; }

		/// <summary>
		/// 产品编码
		/// </summary>
		public string ProductId { get; set; }

		/// <summary>
		/// 产品名称
		/// </summary>
		public string ProductName
		{
			get { return Product == null ? null : Product.ProductName; }
		}

		/// <summary>
		/// 产品型号
		/// </summary>
		public string ProductModel
		{
			get { return Product == null ? null : Product.Model; }
		}

		/// <summary>
		/// 产品单位
		/// </summary>
		public string ProductUnit
		{
			get { return Product == null ? null : Product.Unit; }
		}

		/// <summary>
		/// 数量
		/// </summary>
		public decimal Qty { get; set; }

		/// <summary>
		/// 单价
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// 金额
		/// </summary>
		public decimal Amt { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; }
	}
}
