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
		private const string FamilyName = "微软雅黑";
		private const int EMSize = 9;

		DataGridView dgv;

		public string Title { get { return "成都明辉顺达机电设备送货单"; } }
		public string Tel { get { return "TEL：028-66157317   13981844820   183822602909"; } }
		public string Address { get { return " 地址：金府路万贯机电城12大厅7号"; } }
		public string CompanyDesc { get { return "公司主营：配电箱 成套 电器电线 强磁铁 磁棒 除铁器 橡胶磁 电热水箱 烘房 烤房 电炉 烘箱 蒸饭机 开水器 电加热管 电阻丝 高温线 温控仪 热电偶 压力表 压力变送器 液位变送器 电磁流量计 涡轮流量计"; } }
		public string Signature { get { return "客户签字"; } }

		public string TextOrderNo { get; set; }

		public string TextCustomerName { get; set; }

		public string TextTelephone { get; set; }

		public string TextDeliveryDate { get; set; }

		public string TextAmtWords { get; set; }

		public string TextAmtFigures { get; set; }

		public string OrderNo { get; set; }

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

		public string AmtWords { get; set; }

		public string AmtFigures { get; set; }

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
				ppvw.Document.DefaultPageSettings.Landscape = false;// 设置打印为横向 
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
			int y;
			int textLineSpacing = 2;
			int padding = 5;
			int borderWidth = 1;

			#region 标题
			textFont = new Font(FamilyName, 14);
			textSize = e.Graphics.MeasureString(Title, textFont, e.MarginBounds.Width);
			//float titleHeight = textSize.Height;
			x = e.MarginBounds.Left + (e.MarginBounds.Width - (int)textSize.Width) / 2;
			y = e.MarginBounds.Top - (int)textSize.Height;
			//画 标题
			e.Graphics.DrawString(Title, textFont, Brushes.Black, x, y);
			#endregion

			#region 单号
			y = y + (int)(textSize.Height / 2);
			textFont = new Font(FamilyName, EMSize);
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextOrderNo, OrderNo), textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Right - (int)textSize.Width;
			y = y - (int)(textSize.Height / 2);
			//画 标题
			e.Graphics.DrawString(string.Format("{0}{1}", TextOrderNo, OrderNo), textFont, Brushes.Black, x, y);
			#endregion

			y = e.MarginBounds.Top + textLineSpacing;

			#region 客户姓名
			textFont = new Font(FamilyName, EMSize);
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextCustomerName, CustomerName), textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Left;
			//画 客户姓名
			e.Graphics.DrawString(string.Format("{0}{1}", TextCustomerName, CustomerName), textFont, Brushes.Black, x, y);
			#endregion

			#region 联系电话
			textFont = new Font(FamilyName, EMSize);
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextTelephone, Telephone), textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Left + (e.MarginBounds.Width - (int)textSize.Width) / 2;
			//画 联系电话
			e.Graphics.DrawString(string.Format("{0}{1}", TextTelephone, Telephone), textFont, Brushes.Black, x, y);
			#endregion

			#region 送货日期
			textFont = new Font(FamilyName, EMSize);
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextDeliveryDate, DeliveryDate), textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Right - (int)textSize.Width;
			//画 送货日期
			e.Graphics.DrawString(string.Format("{0}{1}", TextDeliveryDate, DeliveryDate), textFont, Brushes.Black, x, y);
			#endregion

			y += (int)textSize.Height + textLineSpacing;

			#region 表格
			//计算DataGridView所有显示列的宽度
			int dgvAllColsWidth = 0;
			int visibleColumnNo = 0;
			foreach (DataGridViewColumn column in dgv.Columns)
			{
				if (column.Visible)
				{
					visibleColumnNo++;
					dgvAllColsWidth += column.Width;
				}
			}
			//计算打印出的表头的高度
			int tableHeaderHeight = 0;
			int tableHeaderWidth = 0;
			int halftableHeaderWidth = 0;
			int columnIndex = 0;
			List<int> cellHeaderWidths = new List<int>();
			foreach (DataGridViewColumn column in dgv.Columns)
			{
				if (column.Visible)
				{
					columnIndex++;
					int cellHeaderWidth = columnIndex < visibleColumnNo ? (int)((double)column.Width / (double)dgvAllColsWidth * (double)e.MarginBounds.Width) : e.MarginBounds.Width - tableHeaderWidth;
					cellHeaderWidths.Add(cellHeaderWidth);
					int hHeight = (int)e.Graphics.MeasureString(column.HeaderText, column.InheritedStyle.Font, cellHeaderWidth).Height + 2 * padding;
					if (hHeight > tableHeaderHeight)
					{
						tableHeaderHeight = hHeight;
					}
					tableHeaderWidth += cellHeaderWidth;
					if (columnIndex <= visibleColumnNo / 2)
					{
						halftableHeaderWidth += cellHeaderWidth;
					}
				}
			}

			#region 画表头
			x = e.MarginBounds.Left;
			columnIndex = 0;
			foreach (DataGridViewColumn column in dgv.Columns)
			{
				//隐藏列返回
				if (column.Visible)
				{
					textFont = column.InheritedStyle.Font;
					textSize = e.Graphics.MeasureString(column.HeaderText, textFont, cellHeaderWidths[columnIndex]);
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
					////画背景
					//e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(x, y, columnWidth, headerHeight));
					//画边框
					e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cellHeaderWidths[columnIndex], tableHeaderHeight));
					//画内容
					e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, Brushes.Black, new RectangleF(x + (cellHeaderWidths[columnIndex] - textSize.Width) / 2, y + borderWidth + (tableHeaderHeight - textSize.Height) / 2, cellHeaderWidths[columnIndex], tableHeaderHeight));
					x += cellHeaderWidths[columnIndex];
					columnIndex++;
				}
			}
			#endregion

			#region 话表格数据
			x = e.MarginBounds.Left;
			y += tableHeaderHeight;

			int tableRowHeight = tableHeaderHeight;
			columnIndex = 0;
			foreach (DataGridViewRow row in dgv.Rows)
			{
				if (row.Visible && row.Cells["SeqNo"].Value != null && row.Cells["SeqNo"].Value.ToString().Length > 0)
				{
					foreach (DataGridViewCell cell in row.Cells)
					{
						DataGridViewColumn column = dgv.Columns[cell.ColumnIndex];
						if (column.Visible)
						{
							e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cellHeaderWidths[columnIndex], tableRowHeight));
							if (cell.Value != null)
							{
								textFont = column.InheritedStyle.Font;
								textSize = e.Graphics.MeasureString(cell.Value.ToString(), textFont, cellHeaderWidths[columnIndex]);
								////画下边线
								//e.Graphics.DrawLine(Pens.Black, x, y + tableRowHeight, x + columnWidth, y + tableRowHeight);
								////画右边线
								//e.Graphics.DrawLine(Pens.Black, x + columnWidth, y, x + columnWidth, y + tableRowHeight);
								//if (x == e.MarginBounds.Left)
								//{
								////画左边线
								//e.Graphics.DrawLine(Pens.Black, x, y, x, y + tableRowHeight);
								//}
								//画内容
								e.Graphics.DrawString(cell.Value.ToString(), textFont, Brushes.Black, new RectangleF(x + (cellHeaderWidths[columnIndex] - textSize.Width) / 2, y + borderWidth + (tableRowHeight - textSize.Height) / 2, cellHeaderWidths[columnIndex], tableRowHeight));
							}
							x += cellHeaderWidths[columnIndex];
							columnIndex++;
						}
					}
					x = e.MarginBounds.Left;
					y += tableRowHeight;
					columnIndex = 0;
				}
			}
			#endregion

			#region 大写金额
			x = e.MarginBounds.Left;
			e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, halftableHeaderWidth, tableHeaderHeight));
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextAmtWords, AmtWords), textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Left + padding;
			e.Graphics.DrawString(string.Format("{0}{1}", TextAmtWords, AmtWords), textFont, Brushes.Black, x, y + borderWidth + (tableRowHeight - (int)textSize.Height) / 2);
			#endregion

			#region 小写金额
			x = e.MarginBounds.Left + halftableHeaderWidth;
			e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, e.MarginBounds.Width - halftableHeaderWidth, tableHeaderHeight));
			textSize = e.Graphics.MeasureString(string.Format("{0}{1}", TextAmtFigures, AmtFigures), textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Left + halftableHeaderWidth + padding;
			e.Graphics.DrawString(string.Format("{0}{1}", TextAmtFigures, AmtFigures), textFont, Brushes.Black, x, y + borderWidth + (tableRowHeight - (int)textSize.Height) / 2);
			#endregion

			#endregion

			y += tableRowHeight + textLineSpacing * 2;

			#region 电话
			textFont = new Font(FamilyName, EMSize);
			textSize = e.Graphics.MeasureString(Tel, textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Left;
			//画 电话
			e.Graphics.DrawString(Tel, textFont, Brushes.Black, x, y);
			#endregion

			#region 地址
			textFont = new Font(FamilyName, EMSize);
			textSize = e.Graphics.MeasureString(Address, textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Right - (int)textSize.Width;
			//画 地址
			e.Graphics.DrawString(Address, textFont, Brushes.Black, x, y);
			#endregion

			y += (int)textSize.Height + textLineSpacing;

			#region 公司描述
			textFont = new Font(FamilyName, EMSize);
			x = e.MarginBounds.Left;
			StringFormat strformat = new StringFormat() { LineAlignment = StringAlignment.Near, FormatFlags = StringFormatFlags.LineLimit };//左对齐、自动换行
			Rectangle rectangle = new Rectangle(x, y, e.MarginBounds.Width, e.MarginBounds.Height);
			textSize = e.Graphics.MeasureString(CompanyDesc, textFont, e.MarginBounds.Width, strformat);
			//画 公司描述
			e.Graphics.DrawString(CompanyDesc, textFont, Brushes.Black, rectangle, strformat);
			#endregion

			y += (int)textSize.Height + textLineSpacing;

			#region 客户签字
			textFont = new Font(FamilyName, 12);
			textSize = e.Graphics.MeasureString(string.Format("{0}名字名字名字名字名字", Signature), textFont, e.MarginBounds.Width);
			x = e.MarginBounds.Right - (int)textSize.Width;
			//画 客户签字
			e.Graphics.DrawString(string.Format("{0}", Signature), textFont, Brushes.Black, x, y);
			#endregion
		}
	}
}