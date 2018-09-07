namespace OrderManager.Ctrls
{
	partial class Order
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_OrderProd = new System.Windows.Forms.DataGridView();
			this.lbl_CustomerName = new System.Windows.Forms.Label();
			this.txt_CustomerName = new System.Windows.Forms.TextBox();
			this.txt_Telephone = new System.Windows.Forms.TextBox();
			this.lbl_Telephone = new System.Windows.Forms.Label();
			this.txt_DeliveryDate = new System.Windows.Forms.TextBox();
			this.lbl_DeliveryDate = new System.Windows.Forms.Label();
			this.btn_Print = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.lbl_TextAmtWords = new System.Windows.Forms.Label();
			this.lbl_AmtWords = new System.Windows.Forms.Label();
			this.lbl_TextAmtFigures = new System.Windows.Forms.Label();
			this.lbl_AmtFigures = new System.Windows.Forms.Label();
			this.lbl_TextOrderNo = new System.Windows.Forms.Label();
			this.lbl_OrderNo = new System.Windows.Forms.Label();
			this.SeqNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.产品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderProd)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_OrderProd
			// 
			this.dgv_OrderProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_OrderProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_OrderProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_OrderProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeqNo,
            this.产品名称,
            this.型号,
            this.单位,
            this.Qty,
            this.Price,
            this.Amt,
            this.备注});
			this.dgv_OrderProd.Location = new System.Drawing.Point(0, 33);
			this.dgv_OrderProd.Name = "dgv_OrderProd";
			this.dgv_OrderProd.RowTemplate.Height = 23;
			this.dgv_OrderProd.Size = new System.Drawing.Size(1000, 467);
			this.dgv_OrderProd.TabIndex = 0;
			this.dgv_OrderProd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_OrderProd_RowsRemoved);
			this.dgv_OrderProd.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OrderProd_RowValidated);
			// 
			// lbl_CustomerName
			// 
			this.lbl_CustomerName.AutoSize = true;
			this.lbl_CustomerName.Location = new System.Drawing.Point(3, 10);
			this.lbl_CustomerName.Name = "lbl_CustomerName";
			this.lbl_CustomerName.Size = new System.Drawing.Size(65, 12);
			this.lbl_CustomerName.TabIndex = 1;
			this.lbl_CustomerName.Text = "客户名称：";
			// 
			// txt_CustomerName
			// 
			this.txt_CustomerName.Location = new System.Drawing.Point(74, 6);
			this.txt_CustomerName.Name = "txt_CustomerName";
			this.txt_CustomerName.Size = new System.Drawing.Size(100, 21);
			this.txt_CustomerName.TabIndex = 2;
			this.txt_CustomerName.Text = "假客户";
			// 
			// txt_Telephone
			// 
			this.txt_Telephone.Location = new System.Drawing.Point(227, 6);
			this.txt_Telephone.Name = "txt_Telephone";
			this.txt_Telephone.Size = new System.Drawing.Size(100, 21);
			this.txt_Telephone.TabIndex = 4;
			this.txt_Telephone.Text = "假电话";
			// 
			// lbl_Telephone
			// 
			this.lbl_Telephone.AutoSize = true;
			this.lbl_Telephone.Location = new System.Drawing.Point(180, 10);
			this.lbl_Telephone.Name = "lbl_Telephone";
			this.lbl_Telephone.Size = new System.Drawing.Size(41, 12);
			this.lbl_Telephone.TabIndex = 3;
			this.lbl_Telephone.Text = "电话：";
			// 
			// txt_DeliveryDate
			// 
			this.txt_DeliveryDate.Location = new System.Drawing.Point(404, 6);
			this.txt_DeliveryDate.Name = "txt_DeliveryDate";
			this.txt_DeliveryDate.Size = new System.Drawing.Size(100, 21);
			this.txt_DeliveryDate.TabIndex = 6;
			// 
			// lbl_DeliveryDate
			// 
			this.lbl_DeliveryDate.AutoSize = true;
			this.lbl_DeliveryDate.Location = new System.Drawing.Point(333, 10);
			this.lbl_DeliveryDate.Name = "lbl_DeliveryDate";
			this.lbl_DeliveryDate.Size = new System.Drawing.Size(65, 12);
			this.lbl_DeliveryDate.TabIndex = 5;
			this.lbl_DeliveryDate.Text = "送货日期：";
			// 
			// btn_Print
			// 
			this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Print.Location = new System.Drawing.Point(922, 5);
			this.btn_Print.Name = "btn_Print";
			this.btn_Print.Size = new System.Drawing.Size(75, 23);
			this.btn_Print.TabIndex = 7;
			this.btn_Print.Text = "打印";
			this.btn_Print.UseVisualStyleBackColor = true;
			this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save.Location = new System.Drawing.Point(841, 5);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 8;
			this.btn_Save.Text = "保存";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// lbl_TextAmtWords
			// 
			this.lbl_TextAmtWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_TextAmtWords.AutoSize = true;
			this.lbl_TextAmtWords.Location = new System.Drawing.Point(3, 510);
			this.lbl_TextAmtWords.Name = "lbl_TextAmtWords";
			this.lbl_TextAmtWords.Size = new System.Drawing.Size(113, 12);
			this.lbl_TextAmtWords.TabIndex = 9;
			this.lbl_TextAmtWords.Text = "金额合计（大写）：";
			// 
			// lbl_AmtWords
			// 
			this.lbl_AmtWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_AmtWords.AutoSize = true;
			this.lbl_AmtWords.Location = new System.Drawing.Point(122, 510);
			this.lbl_AmtWords.Name = "lbl_AmtWords";
			this.lbl_AmtWords.Size = new System.Drawing.Size(0, 12);
			this.lbl_AmtWords.TabIndex = 10;
			// 
			// lbl_TextAmtFigures
			// 
			this.lbl_TextAmtFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_TextAmtFigures.AutoSize = true;
			this.lbl_TextAmtFigures.Location = new System.Drawing.Point(425, 510);
			this.lbl_TextAmtFigures.Name = "lbl_TextAmtFigures";
			this.lbl_TextAmtFigures.Size = new System.Drawing.Size(65, 12);
			this.lbl_TextAmtFigures.TabIndex = 11;
			this.lbl_TextAmtFigures.Text = "小写金额：";
			// 
			// lbl_AmtFigures
			// 
			this.lbl_AmtFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_AmtFigures.AutoSize = true;
			this.lbl_AmtFigures.Location = new System.Drawing.Point(496, 510);
			this.lbl_AmtFigures.Name = "lbl_AmtFigures";
			this.lbl_AmtFigures.Size = new System.Drawing.Size(0, 12);
			this.lbl_AmtFigures.TabIndex = 12;
			// 
			// lbl_TextOrderNo
			// 
			this.lbl_TextOrderNo.AutoSize = true;
			this.lbl_TextOrderNo.Location = new System.Drawing.Point(510, 10);
			this.lbl_TextOrderNo.Name = "lbl_TextOrderNo";
			this.lbl_TextOrderNo.Size = new System.Drawing.Size(29, 12);
			this.lbl_TextOrderNo.TabIndex = 13;
			this.lbl_TextOrderNo.Text = "NO：";
			// 
			// lbl_OrderNo
			// 
			this.lbl_OrderNo.AutoSize = true;
			this.lbl_OrderNo.Location = new System.Drawing.Point(545, 10);
			this.lbl_OrderNo.Name = "lbl_OrderNo";
			this.lbl_OrderNo.Size = new System.Drawing.Size(0, 12);
			this.lbl_OrderNo.TabIndex = 14;
			// 
			// SeqNo
			// 
			this.SeqNo.DataPropertyName = "SeqNo";
			this.SeqNo.HeaderText = "序号";
			this.SeqNo.Name = "SeqNo";
			this.SeqNo.ReadOnly = true;
			this.SeqNo.Width = 60;
			// 
			// 产品名称
			// 
			this.产品名称.HeaderText = "产品名称";
			this.产品名称.Name = "产品名称";
			this.产品名称.Width = 150;
			// 
			// 型号
			// 
			this.型号.HeaderText = "型号";
			this.型号.Name = "型号";
			this.型号.Width = 150;
			// 
			// 单位
			// 
			this.单位.HeaderText = "单位";
			this.单位.Name = "单位";
			// 
			// Qty
			// 
			this.Qty.HeaderText = "数量";
			this.Qty.Name = "Qty";
			// 
			// Price
			// 
			this.Price.HeaderText = "单价";
			this.Price.Name = "Price";
			// 
			// Amt
			// 
			this.Amt.HeaderText = "金额";
			this.Amt.Name = "Amt";
			this.Amt.ReadOnly = true;
			// 
			// 备注
			// 
			this.备注.HeaderText = "备注";
			this.备注.Name = "备注";
			this.备注.Width = 150;
			// 
			// Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbl_OrderNo);
			this.Controls.Add(this.lbl_TextOrderNo);
			this.Controls.Add(this.lbl_AmtFigures);
			this.Controls.Add(this.lbl_TextAmtFigures);
			this.Controls.Add(this.lbl_AmtWords);
			this.Controls.Add(this.lbl_TextAmtWords);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Print);
			this.Controls.Add(this.txt_DeliveryDate);
			this.Controls.Add(this.lbl_DeliveryDate);
			this.Controls.Add(this.txt_Telephone);
			this.Controls.Add(this.lbl_Telephone);
			this.Controls.Add(this.txt_CustomerName);
			this.Controls.Add(this.lbl_CustomerName);
			this.Controls.Add(this.dgv_OrderProd);
			this.Name = "Order";
			this.Size = new System.Drawing.Size(1000, 533);
			this.Load += new System.EventHandler(this.Order_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderProd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_OrderProd;
		private System.Windows.Forms.Label lbl_CustomerName;
		private System.Windows.Forms.TextBox txt_CustomerName;
		private System.Windows.Forms.TextBox txt_Telephone;
		private System.Windows.Forms.Label lbl_Telephone;
		private System.Windows.Forms.TextBox txt_DeliveryDate;
		private System.Windows.Forms.Label lbl_DeliveryDate;
		private System.Windows.Forms.Button btn_Print;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Label lbl_TextAmtWords;
		private System.Windows.Forms.Label lbl_AmtWords;
		private System.Windows.Forms.Label lbl_TextAmtFigures;
		private System.Windows.Forms.Label lbl_AmtFigures;
		private System.Windows.Forms.Label lbl_TextOrderNo;
		private System.Windows.Forms.Label lbl_OrderNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn SeqNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn 产品名称;
		private System.Windows.Forms.DataGridViewTextBoxColumn 型号;
		private System.Windows.Forms.DataGridViewTextBoxColumn 单位;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amt;
		private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
	}
}
