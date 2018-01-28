namespace BirthdayCalendar
{
	partial class uc_CalendarPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btn_Today = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Week = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Month = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Year = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Today,
            this.btn_Week,
            this.btn_Month,
            this.btn_Year});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(660, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btn_Today
			// 
			this.btn_Today.Name = "btn_Today";
			this.btn_Today.Size = new System.Drawing.Size(52, 20);
			this.btn_Today.Tag = "0";
			this.btn_Today.Text = "Today";
			this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
			// 
			// btn_Week
			// 
			this.btn_Week.Name = "btn_Week";
			this.btn_Week.Size = new System.Drawing.Size(73, 20);
			this.btn_Week.Tag = "1";
			this.btn_Week.Text = "This Week";
			this.btn_Week.Click += new System.EventHandler(this.btn_Today_Click);
			// 
			// btn_Month
			// 
			this.btn_Month.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Month.Name = "btn_Month";
			this.btn_Month.Size = new System.Drawing.Size(80, 20);
			this.btn_Month.Tag = "2";
			this.btn_Month.Text = "This Month";
			this.btn_Month.Click += new System.EventHandler(this.btn_Today_Click);
			// 
			// btn_Year
			// 
			this.btn_Year.Name = "btn_Year";
			this.btn_Year.Size = new System.Drawing.Size(67, 20);
			this.btn_Year.Tag = "3";
			this.btn_Year.Text = "This Year";
			this.btn_Year.Click += new System.EventHandler(this.btn_Today_Click);
			// 
			// uc_CalendarPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.menuStrip1);
			this.Name = "uc_CalendarPanel";
			this.Size = new System.Drawing.Size(660, 496);
			this.SizeChanged += new System.EventHandler(this.uc_CalendarPanel_SizeChanged);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btn_Today;
		private System.Windows.Forms.ToolStripMenuItem btn_Week;
		private System.Windows.Forms.ToolStripMenuItem btn_Month;
		private System.Windows.Forms.ToolStripMenuItem btn_Year;
	}
}
