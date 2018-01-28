namespace BirthdayCalendar
{
	partial class f_AddAlert
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.cb_DateSelect = new System.Windows.Forms.ComboBox();
			this.p_CustomDate = new System.Windows.Forms.Panel();
			this.num_Day = new System.Windows.Forms.NumericUpDown();
			this.cb_Month = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_ShowText = new System.Windows.Forms.CheckBox();
			this.cb_PlaySound = new System.Windows.Forms.CheckBox();
			this.tb_AlertMessage = new System.Windows.Forms.TextBox();
			this.btn_TestSound = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.cb_AlertSound = new System.Windows.Forms.ComboBox();
			this.p_CustomDate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Day)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Date: ";
			// 
			// cb_DateSelect
			// 
			this.cb_DateSelect.FormattingEnabled = true;
			this.cb_DateSelect.Items.AddRange(new object[] {
            "Set date manually",
            "1 day before Birthday",
            "2 days before Birthday",
            "4 days before Birthday",
            "1 week before Birthday",
            "2 weeks before Birthday"});
			this.cb_DateSelect.Location = new System.Drawing.Point(54, 6);
			this.cb_DateSelect.Name = "cb_DateSelect";
			this.cb_DateSelect.Size = new System.Drawing.Size(121, 21);
			this.cb_DateSelect.TabIndex = 1;
			this.cb_DateSelect.SelectedIndexChanged += new System.EventHandler(this.cb_DateSelect_SelectedIndexChanged);
			// 
			// p_CustomDate
			// 
			this.p_CustomDate.Controls.Add(this.num_Day);
			this.p_CustomDate.Controls.Add(this.cb_Month);
			this.p_CustomDate.Controls.Add(this.label3);
			this.p_CustomDate.Controls.Add(this.label2);
			this.p_CustomDate.Enabled = false;
			this.p_CustomDate.Location = new System.Drawing.Point(181, 6);
			this.p_CustomDate.Name = "p_CustomDate";
			this.p_CustomDate.Size = new System.Drawing.Size(267, 21);
			this.p_CustomDate.TabIndex = 2;
			// 
			// num_Day
			// 
			this.num_Day.Location = new System.Drawing.Point(204, 1);
			this.num_Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.num_Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_Day.Name = "num_Day";
			this.num_Day.Size = new System.Drawing.Size(59, 20);
			this.num_Day.TabIndex = 4;
			this.num_Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cb_Month
			// 
			this.cb_Month.FormattingEnabled = true;
			this.cb_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "Apryl",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
			this.cb_Month.Location = new System.Drawing.Point(43, 0);
			this.cb_Month.Name = "cb_Month";
			this.cb_Month.Size = new System.Drawing.Size(121, 21);
			this.cb_Month.TabIndex = 3;
			this.cb_Month.SelectedIndexChanged += new System.EventHandler(this.cb_Month_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(169, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Day:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Month: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Show text message: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Play sound alert: ";
			// 
			// cb_ShowText
			// 
			this.cb_ShowText.AutoSize = true;
			this.cb_ShowText.Location = new System.Drawing.Point(123, 46);
			this.cb_ShowText.Name = "cb_ShowText";
			this.cb_ShowText.Size = new System.Drawing.Size(15, 14);
			this.cb_ShowText.TabIndex = 5;
			this.cb_ShowText.UseVisualStyleBackColor = true;
			// 
			// cb_PlaySound
			// 
			this.cb_PlaySound.AutoSize = true;
			this.cb_PlaySound.Location = new System.Drawing.Point(123, 75);
			this.cb_PlaySound.Name = "cb_PlaySound";
			this.cb_PlaySound.Size = new System.Drawing.Size(15, 14);
			this.cb_PlaySound.TabIndex = 6;
			this.cb_PlaySound.UseVisualStyleBackColor = true;
			// 
			// tb_AlertMessage
			// 
			this.tb_AlertMessage.Location = new System.Drawing.Point(144, 44);
			this.tb_AlertMessage.Name = "tb_AlertMessage";
			this.tb_AlertMessage.Size = new System.Drawing.Size(304, 20);
			this.tb_AlertMessage.TabIndex = 7;
			// 
			// btn_TestSound
			// 
			this.btn_TestSound.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_TestSound.Location = new System.Drawing.Point(295, 70);
			this.btn_TestSound.Name = "btn_TestSound";
			this.btn_TestSound.Size = new System.Drawing.Size(61, 23);
			this.btn_TestSound.TabIndex = 9;
			this.btn_TestSound.Text = "Test ►";
			this.btn_TestSound.UseVisualStyleBackColor = true;
			this.btn_TestSound.Click += new System.EventHandler(this.btn_TestSound_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(15, 116);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 10;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(373, 116);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 11;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// cb_AlertSound
			// 
			this.cb_AlertSound.FormattingEnabled = true;
			this.cb_AlertSound.Items.AddRange(new object[] {
            "Sound 1",
            "Sound 2",
            "Sound 3",
            "Sound 4",
            "Sound 5",
            "Sound 6"});
			this.cb_AlertSound.Location = new System.Drawing.Point(144, 71);
			this.cb_AlertSound.Name = "cb_AlertSound";
			this.cb_AlertSound.Size = new System.Drawing.Size(145, 21);
			this.cb_AlertSound.TabIndex = 12;
			// 
			// f_AddAlert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 151);
			this.ControlBox = false;
			this.Controls.Add(this.cb_AlertSound);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_TestSound);
			this.Controls.Add(this.tb_AlertMessage);
			this.Controls.Add(this.cb_PlaySound);
			this.Controls.Add(this.cb_ShowText);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.p_CustomDate);
			this.Controls.Add(this.cb_DateSelect);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "f_AddAlert";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add reminder";
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.f_AddAlert_PreviewKeyDown);
			this.p_CustomDate.ResumeLayout(false);
			this.p_CustomDate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Day)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_DateSelect;
		private System.Windows.Forms.Panel p_CustomDate;
		private System.Windows.Forms.NumericUpDown num_Day;
		private System.Windows.Forms.ComboBox cb_Month;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox cb_ShowText;
		private System.Windows.Forms.CheckBox cb_PlaySound;
		private System.Windows.Forms.TextBox tb_AlertMessage;
		private System.Windows.Forms.Button btn_TestSound;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.ComboBox cb_AlertSound;
	}
}