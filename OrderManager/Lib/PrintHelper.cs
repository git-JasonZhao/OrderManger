using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace OrderManager.Lib
{
	/// <summary>
	/// 打印
	/// 开心懒人
	/// 2014-10-10
	/// </summary>
	public class PrintHelper
	{
		DataGridView dgv;

		public string Title { get { return "成都明辉顺达机电设备送货单"; } }
		public string Tel { get { return "TEL：028-66157317  13981844820  183822602909"; } }
		public string Address { get { return " 金府路万贯机电城12大厅7号"; } }
		public string CompanyDesc { get { return "公司主营：配电箱 成套 电器电线 强磁铁 电热水箱 烘房 烤房 电炉 烘箱 蒸饭机 开水器  电加热管 电阻丝 高温线 温控仪 热电偶 压力表 压力变送器 液位变送器 电磁流量计 涡轮流量计"; } }
		public string Signature { get { return "客户签字"; } }
		public string OrderTime { get { return string.Format("HH:mm:ss", DateTime.Now); } }

		public string OrderNo { get { return " AS2011-"; } }

		public string TextCustomerName { get; set; }

		public string TextTelephone { get; set; }

		public string TextDeliveryDate { get; set; }

		/// <summary>
		/// 客户姓名
		/// </summary>
		public string CustomerName { get; set; }

		/// <summary>
		/// 联系电话
		/// </summary>
		public string Telephone { get; set; }

		/// <summary>
		/// 送货日期
		/// </summary>
		public string DeliveryDate { get; set; }

		/// <summary>
		/// 打印DataGridView
		/// </summary>
		/// <param name="dataGridView">要打印的DataGridView</param>
		/// <param name="title">标题</param>
		/// <param name="title2">第二标题,可以为null</param>
		public void Print(DataGridView dataGridView)
		{
			try
			{
				if (dataGridView == null) { return; }
				dgv = dataGridView;
				PrintPreviewDialog ppvw = new PrintPreviewDialog();
				ppvw.PrintPreviewControl.Zoom = 1.0; //显示比例为100%
				PrintDocument printDoc = new PrintDocument();
				PrintDialog MyDlg = new PrintDialog();
				MyDlg.Document = printDoc;
				printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 850, 1000);
				printDoc.DefaultPageSettings.Margins = new Margins(60, 60, 60, 60); //设置边距 
				ppvw.Document = printDoc; //设置要打印的文档 
				((Form)ppvw).WindowState = FormWindowState.Maximized; //最大化 
				printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage); //打印事件 
				ppvw.Document.DefaultPageSettings.Landscape = true;// 设置打印为横向 
				ppvw.ShowDialog(); //打开预览
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
		{
			Font textFont;
			SizeF textSize;
			int x;
			int y = e.MarginBounds.Top;
			float pagerWidth = e.MarginBounds.Width;

			#region 标题
			textFont = new Font("微软雅黑", 18, FontStyle.Bold);
			textSize = e.Graphics.MeasureString(Title, textFont, e.MarginBounds.Width);
			//x坐标
			x = Convert.ToInt32((pagerWidth - textSize.Width) / 2 + e.MarginBounds.Left);
			//y坐标
			y = Convert.ToInt32(y - textSize.Height);
			//画标题
			e.Graphics.DrawString(Title, textFont, Brushes.Black, x, y);
			#endregion

			y += (int)textSize.Height;

			#region 电话
			textFont = new Font("微软雅黑", 12);
			textSize = e.Graphics.MeasureString(Tel, textFont, e.MarginBounds.Width);
			//x坐标
			x = e.MarginBounds.Left;
			//画标题
			e.Graphics.DrawString(Tel, textFont, Brushes.Black, x, y);
			#endregion

			#region 地址
			textFont = new Font("微软雅黑", 12);
			textSize = e.Graphics.MeasureString(Address, textFont, e.MarginBounds.Width);
			//x坐标
			x = Convert.ToInt32(e.MarginBounds.Right - textSize.Width);
			//画标题
			e.Graphics.DrawString(Address, textFont, Brushes.Black, x, y);
			#endregion

			y += (int)textSize.Height;

			#region 客户姓名
			textFont = new Font("微软雅黑", 12);
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextCustomerName, CustomerName), textFont, e.MarginBounds.Width);
			//x坐标
			x = e.MarginBounds.Left;
			//画标题
			e.Graphics.DrawString(string.Format("{0}{1}", TextCustomerName, CustomerName), textFont, Brushes.Black, x, y);
			#endregion

			#region 联系电话
			textFont = new Font("微软雅黑", 12);
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextTelephone, Telephone), textFont, e.MarginBounds.Width);
			//x坐标
			x = Convert.ToInt32((pagerWidth - textSize.Width) / 2 + e.MarginBounds.Left);
			//边距以内纸张宽度
			pagerWidth = e.MarginBounds.Width;
			//画标题
			e.Graphics.DrawString(string.Format("{0}{1}", TextTelephone, Telephone), textFont, Brushes.Black, x, y);
			#endregion

			#region 送货日期
			textFont = new Font("微软雅黑", 12);
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextDeliveryDate, DeliveryDate), textFont, e.MarginBounds.Width);
			//x坐标
			x = Convert.ToInt32(e.MarginBounds.Right - textSize.Width);
			//边距以内纸张宽度
			pagerWidth = e.MarginBounds.Width;
			//画标题
			e.Graphics.DrawString(string.Format("{0}{1}", TextDeliveryDate, DeliveryDate), textFont, Brushes.Black, x, y);
			#endregion

			y += (int)textSize.Height;

			//表头高度
			int headerHeight = 0;
			//纵轴上 内容与线的距离
			int padding = 6;
			//所有显示列的宽度
			int columnsWidth = 0;
			//计算所有显示列的宽度
			foreach (DataGridViewColumn column in dgv.Columns)
			{
				//隐藏列返回
				if (!column.Visible) continue;
				//所有显示列的宽度
				columnsWidth += column.Width;
			}
			//计算表头高度
			foreach (DataGridViewColumn column in dgv.Columns)
			{
				//列宽
				int columnWidth = (int)(Math.Floor((double)column.Width / (double)columnsWidth * (double)pagerWidth));
				//表头高度
				int temp = (int)e.Graphics.MeasureString(column.HeaderText, column.InheritedStyle.Font, columnWidth).Height + 2 * padding;
				if (temp > headerHeight) headerHeight = temp;
			}

			x = e.MarginBounds.Left;

			//画表头
			foreach (DataGridViewColumn column in dgv.Columns)
			{
				//隐藏列返回
				if (!column.Visible) continue;
				//列宽
				int columnWidth = (int)(Math.Floor((double)column.Width / (double)columnsWidth * (double)pagerWidth));
				//内容居中要加的宽度
				float cenderWidth = (columnWidth - e.Graphics.MeasureString(column.HeaderText, column.InheritedStyle.Font, columnWidth).Width) / 2;
				if (cenderWidth < 0) cenderWidth = 0;
				//内容居中要加的高度
				float cenderHeight = (headerHeight + padding - e.Graphics.MeasureString(column.HeaderText, column.InheritedStyle.Font, columnWidth).Height) / 2;
				if (cenderHeight < 0) cenderHeight = 0;
				//画背景
				e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(x, y, columnWidth, headerHeight));
				//画边框
				e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, columnWidth, headerHeight));
				////画上边线
				//e.Graphics.DrawLine(Pens.Black, x, y, x + columnWidth, y);
				////画下边线
				//e.Graphics.DrawLine(Pens.Black, x, y + headerHeight, x + columnWidth, y + headerHeight);
				////画右边线
				//e.Graphics.DrawLine(Pens.Black, x + columnWidth, y, x + columnWidth, y + headerHeight);
				//if (x == e.MarginBounds.Left)
				//{
				////画左边线
				//e.Graphics.DrawLine(Pens.Black, x, y, x, y + headerHeight);
				//}
				//画内容
				e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF(x + cenderWidth, y + cenderHeight, columnWidth, headerHeight));
				x += columnWidth;
			}
			x = e.MarginBounds.Left;
			y += headerHeight;
			int rowIndex = 0;
			while (rowIndex < dgv.Rows.Count)
			{
				DataGridViewRow row = dgv.Rows[rowIndex];
				if (row.Visible)
				{
					int rowHeight = 0;
					foreach (DataGridViewCell cell in row.Cells)
					{
						DataGridViewColumn column = dgv.Columns[cell.ColumnIndex];
						if (!column.Visible || cell.Value == null) continue;
						int tmpWidth = (int)(Math.Floor((double)column.Width / (double)columnsWidth * (double)pagerWidth));
						int temp = (int)e.Graphics.MeasureString(cell.Value.ToString(), column.InheritedStyle.Font, tmpWidth).Height + 2 * padding;
						if (temp > rowHeight) rowHeight = temp;
					}
					foreach (DataGridViewCell cell in row.Cells)
					{
						DataGridViewColumn column = dgv.Columns[cell.ColumnIndex];
						if (!column.Visible) continue;
						int columnWidth = (int)(Math.Floor((double)column.Width / (double)columnsWidth * (double)pagerWidth));
						e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, columnWidth, rowHeight));
						if (cell.Value != null)
						{
							//内容居中要加的宽度
							float cenderWidth = (columnWidth - e.Graphics.MeasureString(cell.Value.ToString(), cell.InheritedStyle.Font, columnWidth).Width) / 2;
							if (cenderWidth < 0) cenderWidth = 0;
							//内容居中要加的高度
							float cenderHeight = (rowHeight + padding - e.Graphics.MeasureString(cell.Value.ToString(), cell.InheritedStyle.Font, columnWidth).Height) / 2;
							if (cenderHeight < 0) cenderHeight = 0;
							////画下边线
							//e.Graphics.DrawLine(Pens.Black, x, y + rowHeight, x + columnWidth, y + rowHeight);
							////画右边线
							//e.Graphics.DrawLine(Pens.Black, x + columnWidth, y, x + columnWidth, y + rowHeight);
							//if (x == e.MarginBounds.Left)
							//{
							////画左边线
							//e.Graphics.DrawLine(Pens.Black, x, y, x, y + rowHeight);
							//}
							//画内容
							e.Graphics.DrawString(cell.Value.ToString(), column.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF(x + cenderWidth, y + cenderHeight, columnWidth, rowHeight));
						}
						x += columnWidth;
					}
					x = e.MarginBounds.Left;
					y += rowHeight;
					//打印下一页
					if (y + rowHeight > e.MarginBounds.Bottom)
					{
						e.HasMorePages = true;
						break;
					}
				}
				rowIndex++;
			}

			#region 公司描述
			textFont = new Font("微软雅黑", 12);
			//x坐标
			StringFormat strformat = new StringFormat() { LineAlignment = StringAlignment.Near, FormatFlags = StringFormatFlags.LineLimit };//左对齐、自动换行
			Rectangle rectangle = new Rectangle(x, y, e.MarginBounds.Width, e.MarginBounds.Height);
			textSize = e.Graphics.MeasureString(CompanyDesc, textFont, e.MarginBounds.Width, strformat);
			//画标题
			e.Graphics.DrawString(CompanyDesc, textFont, Brushes.Black, rectangle, strformat);
			#endregion

			y += (int)textSize.Height;

			#region 客户签字
			textFont = new Font("微软雅黑", 16);
			textSize = e.Graphics.MeasureString(string.Format("{0}名字名字名字名字名字", Signature), textFont, e.MarginBounds.Width);
			//x坐标
			x = e.MarginBounds.Right - (int)textSize.Width;
			//画标题
			e.Graphics.DrawString(string.Format("{0}", Signature), textFont, Brushes.Black, x, y);
			#endregion
		}
	}
}