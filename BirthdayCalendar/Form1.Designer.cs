namespace BirthdayCalendar
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.sc_Main = new System.Windows.Forms.SplitContainer();
			this.sc_Secondary = new System.Windows.Forms.SplitContainer();
			this.lv_List = new System.Windows.Forms.ListView();
			this.ch_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_NumOfBirthdays = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_NextBirthday = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_AddBirthday = new System.Windows.Forms.ToolStripButton();
			this.btn_RemoveBirthday = new System.Windows.Forms.ToolStripButton();
			this.btn_EditBirthday = new System.Windows.Forms.ToolStripButton();
			this.p_Color = new System.Windows.Forms.Panel();
			this.lbl_Birthday = new System.Windows.Forms.Label();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.lv_Alerts = new System.Windows.Forms.ListView();
			this.ch_Alarm_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Alarm_Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Alarm_Sound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pb_Edit_Picture = new System.Windows.Forms.PictureBox();
			this.lv_ContactInfo = new System.Windows.Forms.ListView();
			this.ch_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.il_ContactImages = new System.Windows.Forms.ImageList(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.uc_CalendarPanel1 = new BirthdayCalendar.uc_CalendarPanel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_Main)).BeginInit();
			this.sc_Main.Panel1.SuspendLayout();
			this.sc_Main.Panel2.SuspendLayout();
			this.sc_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_Secondary)).BeginInit();
			this.sc_Secondary.Panel1.SuspendLayout();
			this.sc_Secondary.Panel2.SuspendLayout();
			this.sc_Secondary.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Edit_Picture)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 524);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(819, 31);
			this.panel1.TabIndex = 0;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(83, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "Close Window";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// sc_Main
			// 
			this.sc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_Main.Location = new System.Drawing.Point(0, 0);
			this.sc_Main.Name = "sc_Main";
			this.sc_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc_Main.Panel1
			// 
			this.sc_Main.Panel1.Controls.Add(this.sc_Secondary);
			// 
			// sc_Main.Panel2
			// 
			this.sc_Main.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.sc_Main.Panel2.Controls.Add(this.p_Color);
			this.sc_Main.Panel2.Controls.Add(this.lbl_Birthday);
			this.sc_Main.Panel2.Controls.Add(this.lbl_Name);
			this.sc_Main.Panel2.Controls.Add(this.lv_Alerts);
			this.sc_Main.Panel2.Controls.Add(this.pb_Edit_Picture);
			this.sc_Main.Panel2.Controls.Add(this.lv_ContactInfo);
			this.sc_Main.Panel2.Controls.Add(this.label2);
			this.sc_Main.Panel2.Controls.Add(this.label1);
			this.sc_Main.Size = new System.Drawing.Size(819, 524);
			this.sc_Main.SplitterDistance = 394;
			this.sc_Main.TabIndex = 1;
			// 
			// sc_Secondary
			// 
			this.sc_Secondary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_Secondary.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.sc_Secondary.Location = new System.Drawing.Point(0, 0);
			this.sc_Secondary.Name = "sc_Secondary";
			// 
			// sc_Secondary.Panel1
			// 
			this.sc_Secondary.Panel1.Controls.Add(this.lv_List);
			this.sc_Secondary.Panel1.Controls.Add(this.statusStrip1);
			this.sc_Secondary.Panel1.Controls.Add(this.toolStrip1);
			// 
			// sc_Secondary.Panel2
			// 
			this.sc_Secondary.Panel2.AutoScroll = true;
			this.sc_Secondary.Panel2.Controls.Add(this.uc_CalendarPanel1);
			this.sc_Secondary.Size = new System.Drawing.Size(819, 394);
			this.sc_Secondary.SplitterDistance = 334;
			this.sc_Secondary.TabIndex = 0;
			this.sc_Secondary.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_Secondary_SplitterMoved);
			// 
			// lv_List
			// 
			this.lv_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Id,
            this.ch_Name,
            this.ch_Birthday,
            this.ch_Color});
			this.lv_List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_List.FullRowSelect = true;
			this.lv_List.GridLines = true;
			this.lv_List.Location = new System.Drawing.Point(0, 25);
			this.lv_List.MultiSelect = false;
			this.lv_List.Name = "lv_List";
			this.lv_List.Size = new System.Drawing.Size(334, 347);
			this.lv_List.TabIndex = 2;
			this.lv_List.UseCompatibleStateImageBehavior = false;
			this.lv_List.View = System.Windows.Forms.View.Details;
			this.lv_List.SelectedIndexChanged += new System.EventHandler(this.lv_List_SelectedIndexChanged);
			this.lv_List.DoubleClick += new System.EventHandler(this.lv_List_DoubleClick);
			// 
			// ch_Id
			// 
			this.ch_Id.Text = "#";
			this.ch_Id.Width = 31;
			// 
			// ch_Name
			// 
			this.ch_Name.Text = "Name";
			this.ch_Name.Width = 192;
			// 
			// ch_Birthday
			// 
			this.ch_Birthday.Text = "Birthday";
			this.ch_Birthday.Width = 58;
			// 
			// ch_Color
			// 
			this.ch_Color.Text = "";
			this.ch_Color.Width = 14;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_NumOfBirthdays,
            this.lbl_NextBirthday});
			this.statusStrip1.Location = new System.Drawing.Point(0, 372);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(334, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_NumOfBirthdays
			// 
			this.lbl_NumOfBirthdays.Name = "lbl_NumOfBirthdays";
			this.lbl_NumOfBirthdays.Size = new System.Drawing.Size(230, 17);
			this.lbl_NumOfBirthdays.Spring = true;
			this.lbl_NumOfBirthdays.Text = "0 Birthdays";
			this.lbl_NumOfBirthdays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_NextBirthday
			// 
			this.lbl_NextBirthday.Name = "lbl_NextBirthday";
			this.lbl_NextBirthday.Size = new System.Drawing.Size(89, 17);
			this.lbl_NextBirthday.Text = "Next Birthday: •";
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddBirthday,
            this.btn_RemoveBirthday,
            this.btn_EditBirthday});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(334, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_AddBirthday
			// 
			this.btn_AddBirthday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_AddBirthday.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddBirthday.Image")));
			this.btn_AddBirthday.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_AddBirthday.Name = "btn_AddBirthday";
			this.btn_AddBirthday.Size = new System.Drawing.Size(23, 22);
			this.btn_AddBirthday.Text = "Add Birthday";
			this.btn_AddBirthday.Click += new System.EventHandler(this.btn_AddBirthday_Click);
			// 
			// btn_RemoveBirthday
			// 
			this.btn_RemoveBirthday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_RemoveBirthday.Image = ((System.Drawing.Image)(resources.GetObject("btn_RemoveBirthday.Image")));
			this.btn_RemoveBirthday.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_RemoveBirthday.Name = "btn_RemoveBirthday";
			this.btn_RemoveBirthday.Size = new System.Drawing.Size(23, 22);
			this.btn_RemoveBirthday.Text = "Remove Birthday";
			this.btn_RemoveBirthday.Click += new System.EventHandler(this.btn_RemoveBirthday_Click);
			// 
			// btn_EditBirthday
			// 
			this.btn_EditBirthday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_EditBirthday.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditBirthday.Image")));
			this.btn_EditBirthday.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_EditBirthday.Name = "btn_EditBirthday";
			this.btn_EditBirthday.Size = new System.Drawing.Size(23, 22);
			this.btn_EditBirthday.Text = "Edit Birthday";
			this.btn_EditBirthday.Click += new System.EventHandler(this.btn_EditBirthday_Click);
			// 
			// p_Color
			// 
			this.p_Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.p_Color.Location = new System.Drawing.Point(0, -1);
			this.p_Color.Name = "p_Color";
			this.p_Color.Size = new System.Drawing.Size(819, 8);
			this.p_Color.TabIndex = 16;
			// 
			// lbl_Birthday
			// 
			this.lbl_Birthday.AutoSize = true;
			this.lbl_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_Birthday.Location = new System.Drawing.Point(112, 54);
			this.lbl_Birthday.Name = "lbl_Birthday";
			this.lbl_Birthday.Size = new System.Drawing.Size(14, 20);
			this.lbl_Birthday.TabIndex = 15;
			this.lbl_Birthday.Text = "|";
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_Name.Location = new System.Drawing.Point(112, 17);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(14, 20);
			this.lbl_Name.TabIndex = 14;
			this.lbl_Name.Text = "|";
			// 
			// lv_Alerts
			// 
			this.lv_Alerts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_Alerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Alarm_Date,
            this.ch_Alarm_Message,
            this.ch_Alarm_Sound});
			this.lv_Alerts.FullRowSelect = true;
			this.lv_Alerts.GridLines = true;
			this.lv_Alerts.Location = new System.Drawing.Point(599, 14);
			this.lv_Alerts.Name = "lv_Alerts";
			this.lv_Alerts.Size = new System.Drawing.Size(208, 101);
			this.lv_Alerts.TabIndex = 13;
			this.lv_Alerts.UseCompatibleStateImageBehavior = false;
			this.lv_Alerts.View = System.Windows.Forms.View.Details;
			// 
			// ch_Alarm_Date
			// 
			this.ch_Alarm_Date.Text = "Reminder";
			this.ch_Alarm_Date.Width = 73;
			// 
			// ch_Alarm_Message
			// 
			this.ch_Alarm_Message.Text = "Message";
			this.ch_Alarm_Message.Width = 84;
			// 
			// ch_Alarm_Sound
			// 
			this.ch_Alarm_Sound.Text = "Sound";
			this.ch_Alarm_Sound.Width = 45;
			// 
			// pb_Edit_Picture
			// 
			this.pb_Edit_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_Edit_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb_Edit_Picture.Location = new System.Drawing.Point(270, 14);
			this.pb_Edit_Picture.Name = "pb_Edit_Picture";
			this.pb_Edit_Picture.Size = new System.Drawing.Size(109, 101);
			this.pb_Edit_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Edit_Picture.TabIndex = 9;
			this.pb_Edit_Picture.TabStop = false;
			// 
			// lv_ContactInfo
			// 
			this.lv_ContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_ContactInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Type,
            this.ch_Contact});
			this.lv_ContactInfo.FullRowSelect = true;
			this.lv_ContactInfo.GridLines = true;
			this.lv_ContactInfo.Location = new System.Drawing.Point(385, 14);
			this.lv_ContactInfo.Name = "lv_ContactInfo";
			this.lv_ContactInfo.Size = new System.Drawing.Size(208, 101);
			this.lv_ContactInfo.SmallImageList = this.il_ContactImages;
			this.lv_ContactInfo.TabIndex = 5;
			this.lv_ContactInfo.UseCompatibleStateImageBehavior = false;
			this.lv_ContactInfo.View = System.Windows.Forms.View.Details;
			// 
			// ch_Type
			// 
			this.ch_Type.Text = "Method";
			// 
			// ch_Contact
			// 
			this.ch_Contact.Text = "Contact";
			this.ch_Contact.Width = 142;
			// 
			// il_ContactImages
			// 
			this.il_ContactImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_ContactImages.ImageStream")));
			this.il_ContactImages.TransparentColor = System.Drawing.Color.Transparent;
			this.il_ContactImages.Images.SetKeyName(0, "aim.png");
			this.il_ContactImages.Images.SetKeyName(1, "discord.png");
			this.il_ContactImages.Images.SetKeyName(2, "gmail.png");
			this.il_ContactImages.Images.SetKeyName(3, "facebook.png");
			this.il_ContactImages.Images.SetKeyName(4, "googleplus.png");
			this.il_ContactImages.Images.SetKeyName(5, "icq.png");
			this.il_ContactImages.Images.SetKeyName(6, "irc.png");
			this.il_ContactImages.Images.SetKeyName(7, "kik.png");
			this.il_ContactImages.Images.SetKeyName(8, "mobile.png");
			this.il_ContactImages.Images.SetKeyName(9, "msn.png");
			this.il_ContactImages.Images.SetKeyName(10, "other.png");
			this.il_ContactImages.Images.SetKeyName(11, "phone.png");
			this.il_ContactImages.Images.SetKeyName(12, "psn.png");
			this.il_ContactImages.Images.SetKeyName(13, "skype.png");
			this.il_ContactImages.Images.SetKeyName(14, "snapchat.png");
			this.il_ContactImages.Images.SetKeyName(15, "steam.png");
			this.il_ContactImages.Images.SetKeyName(16, "telegram.png");
			this.il_ContactImages.Images.SetKeyName(17, "trillian.png");
			this.il_ContactImages.Images.SetKeyName(18, "twitter.png");
			this.il_ContactImages.Images.SetKeyName(19, "viber.png");
			this.il_ContactImages.Images.SetKeyName(20, "www.png");
			this.il_ContactImages.Images.SetKeyName(21, "wow.png");
			this.il_ContactImages.Images.SetKeyName(22, "xbox.png");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Birthday: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name: ";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// uc_CalendarPanel1
			// 
			this.uc_CalendarPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.uc_CalendarPanel1.Birthdays = null;
			this.uc_CalendarPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uc_CalendarPanel1.Location = new System.Drawing.Point(0, 0);
			this.uc_CalendarPanel1.Name = "uc_CalendarPanel1";
			this.uc_CalendarPanel1.Size = new System.Drawing.Size(481, 394);
			this.uc_CalendarPanel1.sqlc = null;
			this.uc_CalendarPanel1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(819, 555);
			this.Controls.Add(this.sc_Main);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Birthday Calendar";
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.panel1.ResumeLayout(false);
			this.sc_Main.Panel1.ResumeLayout(false);
			this.sc_Main.Panel2.ResumeLayout(false);
			this.sc_Main.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_Main)).EndInit();
			this.sc_Main.ResumeLayout(false);
			this.sc_Secondary.Panel1.ResumeLayout(false);
			this.sc_Secondary.Panel1.PerformLayout();
			this.sc_Secondary.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_Secondary)).EndInit();
			this.sc_Secondary.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Edit_Picture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer sc_Main;
		private System.Windows.Forms.SplitContainer sc_Secondary;
		private System.Windows.Forms.ListView lv_List;
		private System.Windows.Forms.ColumnHeader ch_Id;
		private System.Windows.Forms.ColumnHeader ch_Name;
		private System.Windows.Forms.ColumnHeader ch_Birthday;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_AddBirthday;
		private System.Windows.Forms.ToolStripButton btn_RemoveBirthday;
		private System.Windows.Forms.ToolStripButton btn_EditBirthday;
		private System.Windows.Forms.ListView lv_ContactInfo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader ch_Type;
		private System.Windows.Forms.ColumnHeader ch_Contact;
		private System.Windows.Forms.PictureBox pb_Edit_Picture;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ListView lv_Alerts;
		private System.Windows.Forms.ColumnHeader ch_Alarm_Date;
		private System.Windows.Forms.ToolStripStatusLabel lbl_NumOfBirthdays;
		private System.Windows.Forms.ToolStripStatusLabel lbl_NextBirthday;
		private System.Windows.Forms.Label lbl_Birthday;
		private System.Windows.Forms.Label lbl_Name;
		private uc_CalendarPanel uc_CalendarPanel1;
		private System.Windows.Forms.ImageList il_ContactImages;
		private System.Windows.Forms.ColumnHeader ch_Alarm_Message;
		private System.Windows.Forms.ColumnHeader ch_Alarm_Sound;
		private System.Windows.Forms.Panel p_Color;
		private System.Windows.Forms.ColumnHeader ch_Color;
	}
}

