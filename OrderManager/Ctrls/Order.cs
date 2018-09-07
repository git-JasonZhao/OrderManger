using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager.Ctrls
{
	public partial class Order : UserControl
	{
		public Order()
		{
			InitializeComponent();
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
			if (e.RowIndex != this.dgv_OrderProd.Rows.Count - 1)
			{
				this.dgv_OrderProd.Rows[e.RowIndex].Cells["SeqNo"].Value = e.RowIndex + 1;
				float qty = 0, price = 0;
				if (this.dgv_OrderProd.Rows[e.RowIndex].Cells["Qty"].Value != null)
				{
					float.TryParse(this.dgv_OrderProd.Rows[e.RowIndex].Cells["Qty"].Value.ToString(), out qty);
				}
				if (this.dgv_OrderProd.Rows[e.RowIndex].Cells["Price"].Value != null)
				{
					float.TryParse(this.dgv_OrderProd.Rows[e.RowIndex].Cells["Price"].Value.ToString(), out price);
				}
				this.dgv_OrderProd.Rows[e.RowIndex].Cells["Amt"].Value = qty * price;
				SumAmt();
			}
		}

		private void dgv_OrderProd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			for (int i = 0; i < this.dgv_OrderProd.Rows.Count - 1; i++)
			{
				this.dgv_OrderProd.Rows[i].Cells["SeqNo"].Value = i + 1;
			}
		}

		private void SumAmt()
		{
			float amtTotal = 0, amt = 0;
			foreach (DataGridViewRow row in this.dgv_OrderProd.Rows)
			{
				if (row.Cells["Amt"].Value != null)
				{
					float.TryParse(row.Cells["Amt"].Value.ToString(), out amt);
					amtTotal += amt;
				}
			}
			this.lbl_AmtWords.Text = Lib.AmtHelper.ToCHAmt(amtTotal);
			this.lbl_AmtFigures.Text = string.Format("￥{0:0.00}", amtTotal);
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			using (var context = new Context())
			{
				var order = new Models.Order() { RStatus = true, RIDate = DateTime.Now, OrderId = "0000004" };
				order.CustomerId = "C001";
				order.DeliveryDate = DateTime.Now;
				order.OrderTime = DateTime.Now;
				for (int i = 0; i < this.dgv_OrderProd.Rows.Count - 1; i++)
				{
					DataGridViewRow row = this.dgv_OrderProd.Rows[i];
					var orderprod = new Models.OrderProduct { RStatus = true, RIDate = DateTime.Now, OrderProductId = Guid.NewGuid().ToString() };
					orderprod.Amt = row.Cells["Amt"] == null || row.Cells["Amt"].Value == null ? 0 : decimal.Parse(row.Cells["Amt"].Value.ToString());
					orderprod.OrderId = order.OrderId;
					orderprod.Price = row.Cells["Price"] == null || row.Cells["Price"].Value == null ? 0 : decimal.Parse(row.Cells["Price"].Value.ToString());
					orderprod.ProductId = "P001";
					orderprod.Qty = row.Cells["Qty"] == null || row.Cells["Qty"].Value == null ? 0 : decimal.Parse(row.Cells["Qty"].Value.ToString());
					orderprod.Remark = row.Cells["Remark"] == null || row.Cells["Remark"].Value == null ? "" : row.Cells["Remark"].Value.ToString();
					orderprod.SeqNo = row.Cells["SeqNo"] == null || row.Cells["SeqNo"].Value == null ? 0 : int.Parse(row.Cells["SeqNo"].Value.ToString());
					context.OrderProducts.Add(orderprod);
				}
				context.Orders.Add(order);
				context.SaveChanges();
				MessageBox.Show("保存成功。");
			}
		}
	}
}