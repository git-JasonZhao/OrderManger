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

		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			split_Layot.Panel2.Hide();
			split_Layot.Panel1.Controls.Add(ctrl_OrderList);
		}
	}
}
