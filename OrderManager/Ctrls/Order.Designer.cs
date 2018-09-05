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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lbl_CustomerName = new System.Windows.Forms.Label();
			this.txt_CustomerName = new System.Windows.Forms.TextBox();
			this.txt_Telephone = new System.Windows.Forms.TextBox();
			this.lbl_Telephone = new System.Windows.Forms.Label();
			this.txt_DeliveryDate = new System.Windows.Forms.TextBox();
			this.lbl_DeliveryDate = new System.Windows.Forms.Label();
			this.产品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_Print = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.产品名称,
            this.型号,
            this.单位,
            this.数量,
            this.单价,
            this.金额,
            this.备注});
			this.dataGridView1.Location = new System.Drawing.Point(0, 52);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(1039, 482);
			this.dataGridView1.TabIndex = 0;
			// 
			// lbl_CustomerName
			// 
			this.lbl_CustomerName.AutoSize = true;
			this.lbl_CustomerName.Location = new System.Drawing.Point(13, 18);
			this.lbl_CustomerName.Name = "lbl_CustomerName";
			this.lbl_CustomerName.Size = new System.Drawing.Size(65, 12);
			this.lbl_CustomerName.TabIndex = 1;
			this.lbl_CustomerName.Text = "客户名称：";
			// 
			// txt_CustomerName
			// 
			this.txt_CustomerName.Location = new System.Drawing.Point(84, 15);
			this.txt_CustomerName.Name = "txt_CustomerName";
			this.txt_CustomerName.Size = new System.Drawing.Size(100, 21);
			this.txt_CustomerName.TabIndex = 2;
			this.txt_CustomerName.Text = "假客户";
			// 
			// txt_Telephone
			// 
			this.txt_Telephone.Location = new System.Drawing.Point(334, 15);
			this.txt_Telephone.Name = "txt_Telephone";
			this.txt_Telephone.Size = new System.Drawing.Size(100, 21);
			this.txt_Telephone.TabIndex = 4;
			this.txt_Telephone.Text = "假电话";
			// 
			// lbl_Telephone
			// 
			this.lbl_Telephone.AutoSize = true;
			this.lbl_Telephone.Location = new System.Drawing.Point(263, 18);
			this.lbl_Telephone.Name = "lbl_Telephone";
			this.lbl_Telephone.Size = new System.Drawing.Size(41, 12);
			this.lbl_Telephone.TabIndex = 3;
			this.lbl_Telephone.Text = "电话：";
			// 
			// txt_DeliveryDate
			// 
			this.txt_DeliveryDate.Location = new System.Drawing.Point(605, 15);
			this.txt_DeliveryDate.Name = "txt_DeliveryDate";
			this.txt_DeliveryDate.Size = new System.Drawing.Size(100, 21);
			this.txt_DeliveryDate.TabIndex = 6;
			this.txt_DeliveryDate.Text = "2018-01-01";
			// 
			// lbl_DeliveryDate
			// 
			this.lbl_DeliveryDate.AutoSize = true;
			this.lbl_DeliveryDate.Location = new System.Drawing.Point(534, 18);
			this.lbl_DeliveryDate.Name = "lbl_DeliveryDate";
			this.lbl_DeliveryDate.Size = new System.Drawing.Size(65, 12);
			this.lbl_DeliveryDate.TabIndex = 5;
			this.lbl_DeliveryDate.Text = "送货日期：";
			// 
			// 产品名称
			// 
			this.产品名称.HeaderText = "产品名称";
			this.产品名称.Name = "产品名称";
			// 
			// 型号
			// 
			this.型号.HeaderText = "型号";
			this.型号.Name = "型号";
			// 
			// 单位
			// 
			this.单位.HeaderText = "单位";
			this.单位.Name = "单位";
			// 
			// 数量
			// 
			this.数量.HeaderText = "数量";
			this.数量.Name = "数量";
			// 
			// 单价
			// 
			this.单价.HeaderText = "单价";
			this.单价.Name = "单价";
			// 
			// 金额
			// 
			this.金额.HeaderText = "金额";
			this.金额.Name = "金额";
			// 
			// 备注
			// 
			this.备注.HeaderText = "备注";
			this.备注.Name = "备注";
			// 
			// btn_Print
			// 
			this.btn_Print.Location = new System.Drawing.Point(855, 12);
			this.btn_Print.Name = "btn_Print";
			this.btn_Print.Size = new System.Drawing.Size(75, 23);
			this.btn_Print.TabIndex = 7;
			this.btn_Print.Text = "打印";
			this.btn_Print.UseVisualStyleBackColor = true;
			this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
			// 
			// Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_Print);
			this.Controls.Add(this.txt_DeliveryDate);
			this.Controls.Add(this.lbl_DeliveryDate);
			this.Controls.Add(this.txt_Telephone);
			this.Controls.Add(this.lbl_Telephone);
			this.Controls.Add(this.txt_CustomerName);
			this.Controls.Add(this.lbl_CustomerName);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Order";
			this.Size = new System.Drawing.Size(1039, 534);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn 产品名称;
		private System.Windows.Forms.DataGridViewTextBoxColumn 型号;
		private System.Windows.Forms.DataGridViewTextBoxColumn 单位;
		private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
		private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
		private System.Windows.Forms.DataGridViewTextBoxColumn 金额;
		private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
		private System.Windows.Forms.Label lbl_CustomerName;
		private System.Windows.Forms.TextBox txt_CustomerName;
		private System.Windows.Forms.TextBox txt_Telephone;
		private System.Windows.Forms.Label lbl_Telephone;
		private System.Windows.Forms.TextBox txt_DeliveryDate;
		private System.Windows.Forms.Label lbl_DeliveryDate;
		private System.Windows.Forms.Button btn_Print;
	}
}
