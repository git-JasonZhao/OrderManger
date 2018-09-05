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
	public partial class OrderList : UserControl
	{
		public OrderList()
		{
			InitializeComponent();
		}

		private void OrderList_Load(object sender, EventArgs e)
		{
			var sql = @"
SELECT	b.CustomerName, b.Company AS CustomerCompany, c.AddressName,
			a.FinalAmount, a.Amount, Format(a.OrderTime,'yyyy-MM-dd HH:mm') AS OrderTime, Format(a.DeliveryDate,'yyyy-MM-dd') AS DeliveryDate
FROM 
(
	[Order] a
	LEFT JOIN [Customer] b ON b.CustomerId = a.CustomerId
)
LEFT JOIN [CustomerAddress] c ON c.CustomerAddressId = a.CustomerAddressId
";
			var datalist = Lib.DataHelper.GetData(sql);
			this.dgv_OrderList.AutoGenerateColumns = true;
			this.dgv_OrderList.DataSource = datalist;
		}
	}
}
