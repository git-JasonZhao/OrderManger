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
	public partial class OrderList : UserControl
	{
		private List<Models.Order> dataOrders;
		private Order ctrl_Order = new Order() { Dock = DockStyle.Fill };
		private Form OrderForm = new Form();

		public OrderList()
		{
			InitializeComponent();
			this.dgv_Order.AutoGenerateColumns = false;
			OrderForm.Size = ctrl_Order.Size;
			OrderForm.Controls.Add(ctrl_Order);
		}

		private void OrderList_Load(object sender, EventArgs e)
		{
			var orderService = new OrderService();
			dataOrders = orderService.GetOrders();
			var bindingList = new BindingList<Models.Order>(dataOrders);
			this.dgv_Order.DataSource = bindingList;
		}

		private void btn_New_Click(object sender, EventArgs e)
		{
			ctrl_Order.Init();
			OrderForm.ShowDialog();
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			var orderService = new OrderService();
			dataOrders = orderService.GetOrders();
			this.dgv_Order.Refresh();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			var selectRows = this.dgv_Order.SelectedRows;
			if (selectRows != null)
			{
				foreach (DataGridViewRow row in selectRows)
				{
					dataOrders.RemoveAt(row.Index);
				}
				using (var context = new Context())
				{
					context.SaveChanges();
					MessageBox.Show("保存成功。");
				}
			}
		}
	}
}
