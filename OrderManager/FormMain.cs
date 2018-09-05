using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
	public partial class FormMain : Form
	{
		Ctrls.OrderList ctrl_OrderList = new Ctrls.OrderList() { Dock = DockStyle.Fill };
		Ctrls.Order ctrl_Order = new Ctrls.Order() { Dock = DockStyle.Fill };

		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			this.Controls.Clear();
			this.Controls.Add(ctrl_Order);

			//split_Layot.Panel2.Hide();
			//split_Layot.Panel1.Controls.Add(ctrl_Order);
		}
	}
}
