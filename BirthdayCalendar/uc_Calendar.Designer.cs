namespace BirthdayCalendar
{
	partial class uc_Calendar
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
			this.mc_Cal = new System.Windows.Forms.MonthCalendar();
			this.btn_Year_Minus = new System.Windows.Forms.Button();
			this.btn_Year_Plus = new System.Windows.Forms.Button();
			this.btn_Month_Plus = new System.Windows.Forms.Button();
			this.btn_Month_Minus = new System.Windows.Forms.Button();
			this.tb_Month = new System.Windows.Forms.TextBox();
			this.tb_Year = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.tb_Year)).BeginInit();
			this.SuspendLayout();
			// 
			// mc_Cal
			// 
			this.mc_Cal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mc_Cal.Location = new System.Drawing.Point(0, 23);
			this.mc_Cal.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
			this.mc_Cal.Name = "mc_Cal";
			this.mc_Cal.TabIndex = 0;
			// 
			// btn_Year_Minus
			// 
			this.btn_Year_Minus.Location = new System.Drawing.Point(0, 1);
			this.btn_Year_Minus.Name = "btn_Year_Minus";
			this.btn_Year_Minus.Size = new System.Drawing.Size(17, 22);
			this.btn_Year_Minus.TabIndex = 3;
			this.btn_Year_Minus.Text = "<";
			this.btn_Year_Minus.UseVisualStyleBackColor = true;
			this.btn_Year_Minus.Click += new System.EventHandler(this.btn_Year_Minus_Click);
			// 
			// btn_Year_Plus
			// 
			this.btn_Year_Plus.Location = new System.Drawing.Point(53, 1);
			this.btn_Year_Plus.Name = "btn_Year_Plus";
			this.btn_Year_Plus.Size = new System.Drawing.Size(17, 22);
			this.btn_Year_Plus.TabIndex = 4;
			this.btn_Year_Plus.Text = ">";
			this.btn_Year_Plus.UseVisualStyleBackColor = true;
			this.btn_Year_Plus.Click += new System.EventHandler(this.btn_Year_Plus_Click);
			// 
			// btn_Month_Plus
			// 
			this.btn_Month_Plus.Location = new System.Drawing.Point(159, 1);
			this.btn_Month_Plus.Name = "btn_Month_Plus";
			this.btn_Month_Plus.Size = new System.Drawing.Size(17, 22);
			this.btn_Month_Plus.TabIndex = 7;
			this.btn_Month_Plus.Text = ">";
			this.btn_Month_Plus.UseVisualStyleBackColor = true;
			this.btn_Month_Plus.Click += new System.EventHandler(this.btn_Month_Plus_Click);
			// 
			// btn_Month_Minus
			// 
			this.btn_Month_Minus.Location = new System.Drawing.Point(72, 1);
			this.btn_Month_Minus.Name = "btn_Month_Minus";
			this.btn_Month_Minus.Size = new System.Drawing.Size(17, 22);
			this.btn_Month_Minus.TabIndex = 6;
			this.btn_Month_Minus.Text = "<";
			this.btn_Month_Minus.UseVisualStyleBackColor = true;
			this.btn_Month_Minus.Click += new System.EventHandler(this.btn_Month_Minus_Click);
			// 
			// tb_Month
			// 
			this.tb_Month.Location = new System.Drawing.Point(87, 2);
			this.tb_Month.Name = "tb_Month";
			this.tb_Month.Size = new System.Drawing.Size(73, 20);
			this.tb_Month.TabIndex = 5;
			this.tb_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_Month.TextChanged += new System.EventHandler(this.tb_Year_ValueChanged);
			// 
			// tb_Year
			// 
			this.tb_Year.Location = new System.Drawing.Point(15, 2);
			this.tb_Year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.tb_Year.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tb_Year.Name = "tb_Year";
			this.tb_Year.Size = new System.Drawing.Size(54, 20);
			this.tb_Year.TabIndex = 8;
			this.tb_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_Year.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
			this.tb_Year.ValueChanged += new System.EventHandler(this.tb_Year_ValueChanged);
			this.tb_Year.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Year_KeyUp);
			// 
			// uc_Calendar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_Month_Plus);
			this.Controls.Add(this.btn_Month_Minus);
			this.Controls.Add(this.tb_Month);
			this.Controls.Add(this.btn_Year_Plus);
			this.Controls.Add(this.btn_Year_Minus);
			this.Controls.Add(this.mc_Cal);
			this.Controls.Add(this.tb_Year);
			this.Name = "uc_Calendar";
			this.Size = new System.Drawing.Size(179, 185);
			this.Load += new System.EventHandler(this.Uc_Calendar_Load);
			((System.ComponentModel.ISupportInitialize)(this.tb_Year)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MonthCalendar mc_Cal;
		private System.Windows.Forms.Button btn_Year_Minus;
		private System.Windows.Forms.Button btn_Year_Plus;
		private System.Windows.Forms.Button btn_Month_Plus;
		private System.Windows.Forms.Button btn_Month_Minus;
		private System.Windows.Forms.TextBox tb_Month;
		private System.Windows.Forms.NumericUpDown tb_Year;
	}
}
