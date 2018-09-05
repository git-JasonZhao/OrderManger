namespace OrderManager
{
	partial class FormMain
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.split_Layot = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.split_Layot)).BeginInit();
			this.split_Layot.SuspendLayout();
			this.SuspendLayout();
			// 
			// split_Layot
			// 
			this.split_Layot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.split_Layot.Location = new System.Drawing.Point(0, 0);
			this.split_Layot.Name = "split_Layot";
			this.split_Layot.Size = new System.Drawing.Size(1031, 590);
			this.split_Layot.SplitterDistance = 750;
			this.split_Layot.TabIndex = 0;
			// 
			// Form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 590);
			this.Controls.Add(this.split_Layot);
			this.Name = "Form_Main";
			this.Text = "發票打印";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.split_Layot)).EndInit();
			this.split_Layot.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer split_Layot;
	}
}

