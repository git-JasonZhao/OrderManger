namespace OrderManager.Ctrls
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_New = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.dgv_Order = new System.Windows.Forms.DataGridView();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ViewDetail = new System.Windows.Forms.DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_New
			// 
			this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_New.Location = new System.Drawing.Point(841, 8);
			this.btn_New.Name = "btn_New";
			this.btn_New.Size = new System.Drawing.Size(75, 23);
			this.btn_New.TabIndex = 23;
			this.btn_New.Text = "新建";
			this.btn_New.UseVisualStyleBackColor = true;
			this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Delete.Location = new System.Drawing.Point(922, 8);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 23);
			this.btn_Delete.TabIndex = 22;
			this.btn_Delete.Text = "删除";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// dgv_Order
			// 
			this.dgv_Order.AllowUserToAddRows = false;
			this.dgv_Order.AllowUserToDeleteRows = false;
			this.dgv_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.CustomerName,
            this.Telephone,
            this.Amount,
            this.DeliveryDate,
            this.ViewDetail});
			this.dgv_Order.Location = new System.Drawing.Point(0, 36);
			this.dgv_Order.Name = "dgv_Order";
			this.dgv_Order.ReadOnly = true;
			this.dgv_Order.RowTemplate.Height = 23;
			this.dgv_Order.Size = new System.Drawing.Size(1000, 467);
			this.dgv_Order.TabIndex = 15;
			this.dgv_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellContentClick);
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Refresh.Location = new System.Drawing.Point(760, 8);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
			this.btn_Refresh.TabIndex = 24;
			this.btn_Refresh.Text = "刷新";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// OrderId
			// 
			this.OrderId.DataPropertyName = "OrderId";
			this.OrderId.HeaderText = "OrderNO";
			this.OrderId.Name = "OrderId";
			this.OrderId.ReadOnly = true;
			// 
			// CustomerName
			// 
			this.CustomerName.DataPropertyName = "CustomerName";
			this.CustomerName.HeaderText = "客户姓名";
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.ReadOnly = true;
			// 
			// Telephone
			// 
			this.Telephone.DataPropertyName = "Telephone";
			this.Telephone.HeaderText = "客户电话";
			this.Telephone.Name = "Telephone";
			this.Telephone.ReadOnly = true;
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "Amount";
			this.Amount.HeaderText = "金额";
			this.Amount.Name = "Amount";
			this.Amount.ReadOnly = true;
			// 
			// DeliveryDate
			// 
			this.DeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.DeliveryDate.DataPropertyName = "DeliveryDate";
			this.DeliveryDate.HeaderText = "送货日期";
			this.DeliveryDate.Name = "DeliveryDate";
			this.DeliveryDate.ReadOnly = true;
			this.DeliveryDate.Width = 78;
			// 
			// ViewDetail
			// 
			dataGridViewCellStyle2.NullValue = "查看";
			this.ViewDetail.DefaultCellStyle = dataGridViewCellStyle2;
			this.ViewDetail.HeaderText = "查看";
			this.ViewDetail.Name = "ViewDetail";
			this.ViewDetail.ReadOnly = true;
			this.ViewDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ViewDetail.Text = "查看";
			this.ViewDetail.VisitedLinkColor = System.Drawing.Color.Blue;
			// 
			// OrderList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.btn_New);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.dgv_Order);
			this.Name = "OrderList";
			this.Size = new System.Drawing.Size(1000, 533);
			this.Load += new System.EventHandler(this.OrderList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_New;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.DataGridView dgv_Order;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
		private System.Windows.Forms.DataGridViewLinkColumn ViewDetail;
	}
}
