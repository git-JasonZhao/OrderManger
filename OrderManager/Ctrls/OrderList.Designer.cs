﻿namespace OrderManager.Ctrls
{
	partial class OrderList
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dgv_OrderList = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_OrderList
			// 
			this.dgv_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_OrderList.Location = new System.Drawing.Point(0, 0);
			this.dgv_OrderList.Name = "dgv_OrderList";
			this.dgv_OrderList.RowTemplate.Height = 23;
			this.dgv_OrderList.Size = new System.Drawing.Size(778, 548);
			this.dgv_OrderList.TabIndex = 0;
			// 
			// OrderList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgv_OrderList);
			this.Name = "OrderList";
			this.Size = new System.Drawing.Size(778, 548);
			this.Load += new System.EventHandler(this.OrderList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_OrderList;
	}
}
