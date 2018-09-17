using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OrderManager.Services;

namespace OrderManager.Ctrls
{
	public partial class Order : UserControl
	{
		private Models.Order dataOrder;
		private bool IsNew = false;

		public Order()
		{
			InitializeComponent();
			this.dgv_OrderProd.AutoGenerateColumns = false;
		}

		public void Init(Models.Order order = null)
		{
			IsNew = false;
			if (order == null)
			{
				order = new OrderService().NewOrder();
				IsNew = true;
			}
			if (order.OrderProducts == null)
			{
				order.OrderProducts = new List<Models.OrderProduct>();
			}
			this.lbl_OrderNo.Text = order.OrderId;
			this.txt_CustomerName.Text = order.CustomerName;
			this.txt_Telephone.Text = order.Telephone;
			this.txt_DeliveryDate.Text = string.Format("{0:yyyy-MM-dd}", order.DeliveryDate ?? DateTime.Now);
			this.lbl_AmtFigures.Text = string.Format("￥{0:0.00}", order.Amount);

			dataOrder = order;
			var bindingList = new BindingList<Models.OrderProduct>(dataOrder.OrderProducts) { AllowNew = true, AllowEdit = true, AllowRemove = true };
			this.dgv_OrderProd.DataSource = bindingList;
			this.dgv_OrderProd.Refresh();
		}

		private void Order_Load(object sender, EventArgs e)
		{
			this.txt_DeliveryDate.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
		}

		private void btn_Print_Click(object sender, EventArgs e)
		{
			Lib.PrintHelper ph = new Lib.PrintHelper();
			ph.TextOrderNo = this.lbl_TextOrderNo.Text.Trim();
			ph.TextCustomerName = this.lbl_CustomerName.Text.Trim();
			ph.TextTelephone = this.lbl_Telephone.Text.Trim();
			ph.TextDeliveryDate = this.lbl_DeliveryDate.Text.Trim();
			ph.TextAmtWords = this.lbl_TextAmtWords.Text;
			ph.TextAmtFigures = this.lbl_TextAmtFigures.Text;
			ph.OrderNo = this.lbl_OrderNo.Text.Trim();
			ph.CustomerName = this.txt_CustomerName.Text.Trim();
			ph.Telephone = this.txt_Telephone.Text.Trim();
			ph.DeliveryDate = this.txt_DeliveryDate.Text.Trim();
			ph.AmtWords = this.lbl_AmtWords.Text;
			ph.AmtFigures = this.lbl_AmtFigures.Text;
			ph.Print(this.dgv_OrderProd);
		}

		private void dgv_OrderProd_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (dataOrder.OrderProducts == null
				|| dataOrder.OrderProducts.Count != this.dgv_OrderProd.Rows.Count - 1
				|| this.dgv_OrderProd.Rows.Count == e.RowIndex + 1)
			{ return; }
			DataGridViewRow row = this.dgv_OrderProd.Rows[e.RowIndex];
			Models.OrderProduct orderProduct = dataOrder.OrderProducts[e.RowIndex];
			if (string.IsNullOrWhiteSpace(orderProduct.OrderProductId))
			{
				orderProduct.OrderProductId = new OrderProductService().GetNewOrderProductId();
			}
			orderProduct.OrderId = dataOrder.OrderId;
			orderProduct.SeqNo = e.RowIndex + 1;
			orderProduct.ProductName = row.Cells["ProductName"] == null || row.Cells["ProductName"].Value == null ? "" : row.Cells["ProductName"].Value.ToString();
			orderProduct.ProductModel = row.Cells["ProductModel"] == null || row.Cells["ProductModel"].Value == null ? "" : row.Cells["ProductModel"].Value.ToString();
			orderProduct.ProductUnit = row.Cells["ProductUnit"] == null || row.Cells["ProductUnit"].Value == null ? "" : row.Cells["ProductUnit"].Value.ToString();
			decimal qty = 0, price = 0;
			if (row.Cells["Qty"].Value != null)
			{
				decimal.TryParse(row.Cells["Qty"].Value.ToString(), out qty);
			}
			if (row.Cells["Price"].Value != null)
			{
				decimal.TryParse(row.Cells["Price"].Value.ToString(), out price);
			}
			orderProduct.Qty = qty;
			orderProduct.Price = price;
			orderProduct.Amt = qty * price;
			orderProduct.Remark = row.Cells["Remark"] == null || row.Cells["Remark"].Value == null ? "" : row.Cells["Remark"].Value.ToString();
			SumAmt();

			this.dgv_OrderProd.Refresh();
		}

		private void dgv_OrderProd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if (dataOrder.OrderProducts == null
				|| dataOrder.OrderProducts.Count == 0
				|| dataOrder.OrderProducts.Count != this.dgv_OrderProd.Rows.Count - 1
				|| dataOrder.OrderProducts.Count < e.RowIndex + 1)
			{ return; }
			dataOrder.OrderProducts.RemoveAt(e.RowIndex);
			for (int i = 0; i < this.dgv_OrderProd.Rows.Count - 1; i++)
			{
				dataOrder.OrderProducts[i].SeqNo = i + 1;
			}
			SumAmt();

			this.dgv_OrderProd.Refresh();
		}

		private void SumAmt()
		{
			var amtTotal = dataOrder.OrderProducts.Sum(op => op.Amt);
			this.lbl_AmtWords.Text = Lib.AmtHelper.ToCHAmt(amtTotal);
			this.lbl_AmtFigures.Text = string.Format("￥{0:0.00}", amtTotal);
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			dataOrder.CustomerName = this.txt_CustomerName.Text.Trim();
			dataOrder.Telephone = this.txt_Telephone.Text.Trim();
			dataOrder.Amount = string.IsNullOrWhiteSpace(this.lbl_AmtFigures.Text) ? 0 : decimal.Parse(this.lbl_AmtFigures.Text.Substring(1));
			dataOrder.DeliveryDate = DateTime.Today;
			dataOrder.OrderTime = DateTime.Now;
			if (IsNew)
			{
				Context.DefaultContext.Orders.Add(dataOrder);
			}
			Context.DefaultContext.SaveChanges();
			MessageBox.Show("保存成功。");
		}
	}
}