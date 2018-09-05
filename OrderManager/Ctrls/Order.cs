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

		private void btn_Print_Click(object sender, EventArgs e)
		{
			Lib.PrintHelper ph = new Lib.PrintHelper();
			ph.TextCustomerName = this.lbl_CustomerName.Text.Trim();
			ph.TextTelephone = this.lbl_Telephone.Text.Trim();
			ph.TextDeliveryDate = this.lbl_DeliveryDate.Text.Trim();
			ph.CustomerName = this.txt_CustomerName.Text.Trim();
			ph.Telephone = this.txt_Telephone.Text.Trim();
			ph.DeliveryDate = this.txt_DeliveryDate.Text.Trim();
			ph.Print(this.dataGridView1);
		}
	}
}
