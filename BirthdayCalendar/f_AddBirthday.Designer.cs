namespace BirthdayCalendar
{
	partial class f_AddBirthday
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_AddBirthday));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.tb_Birthday = new System.Windows.Forms.TextBox();
			this.lv_Contacts = new System.Windows.Forms.ListView();
			this.ch_ContactID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_ContactType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.il_ContactImages = new System.Windows.Forms.ImageList(this.components);
			this.lv_Alerts = new System.Windows.Forms.ListView();
			this.ch_AlertID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_AlertDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_AlertText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_AlertSound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_BrowseImage = new System.Windows.Forms.Button();
			this.btn_RemoveImage = new System.Windows.Forms.Button();
			this.btn_Up = new System.Windows.Forms.Button();
			this.btn_Down = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_BrowseBday = new System.Windows.Forms.Button();
			this.btn_Alerts_Remove = new System.Windows.Forms.Button();
			this.btn_Alerts_Add = new System.Windows.Forms.Button();
			this.btn_Contacts_Remove = new System.Windows.Forms.Button();
			this.btn_Contacts_Add = new System.Windows.Forms.Button();
			this.pb_Image = new System.Windows.Forms.PictureBox();
			this.mc_Calendar = new BirthdayCalendar.uc_Calendar();
			this.label6 = new System.Windows.Forms.Label();
			this.p_Color = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Birthday: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contacts: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Reminders: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 317);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Picture: ";
			// 
			// tb_Name
			// 
			this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Name.Location = new System.Drawing.Point(74, 15);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(185, 20);
			this.tb_Name.TabIndex = 5;
			// 
			// tb_Birthday
			// 
			this.tb_Birthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Birthday.Location = new System.Drawing.Point(74, 40);
			this.tb_Birthday.Name = "tb_Birthday";
			this.tb_Birthday.Size = new System.Drawing.Size(280, 20);
			this.tb_Birthday.TabIndex = 6;
			this.tb_Birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_Birthday.TextChanged += new System.EventHandler(this.tb_Birthday_TextChanged);
			// 
			// lv_Contacts
			// 
			this.lv_Contacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_Contacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ContactID,
            this.ch_ContactType,
            this.ch_Contact});
			this.lv_Contacts.FullRowSelect = true;
			this.lv_Contacts.GridLines = true;
			this.lv_Contacts.HideSelection = false;
			this.lv_Contacts.Location = new System.Drawing.Point(73, 83);
			this.lv_Contacts.Name = "lv_Contacts";
			this.lv_Contacts.Size = new System.Drawing.Size(285, 106);
			this.lv_Contacts.SmallImageList = this.il_ContactImages;
			this.lv_Contacts.TabIndex = 7;
			this.lv_Contacts.UseCompatibleStateImageBehavior = false;
			this.lv_Contacts.View = System.Windows.Forms.View.Details;
			this.lv_Contacts.DoubleClick += new System.EventHandler(this.lv_Contacts_DoubleClick);
			// 
			// ch_ContactID
			// 
			this.ch_ContactID.Text = "#";
			this.ch_ContactID.Width = 35;
			// 
			// ch_ContactType
			// 
			this.ch_ContactType.Text = "Type";
			this.ch_ContactType.Width = 72;
			// 
			// ch_Contact
			// 
			this.ch_Contact.Text = "Contact";
			this.ch_Contact.Width = 141;
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
			// lv_Alerts
			// 
			this.lv_Alerts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_Alerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_AlertID,
            this.ch_AlertDate,
            this.ch_AlertText,
            this.ch_AlertSound});
			this.lv_Alerts.FullRowSelect = true;
			this.lv_Alerts.GridLines = true;
			this.lv_Alerts.Location = new System.Drawing.Point(73, 197);
			this.lv_Alerts.Name = "lv_Alerts";
			this.lv_Alerts.Size = new System.Drawing.Size(285, 106);
			this.lv_Alerts.TabIndex = 8;
			this.lv_Alerts.UseCompatibleStateImageBehavior = false;
			this.lv_Alerts.View = System.Windows.Forms.View.Details;
			this.lv_Alerts.DoubleClick += new System.EventHandler(this.lv_Alerts_DoubleClick);
			// 
			// ch_AlertID
			// 
			this.ch_AlertID.Text = "#";
			this.ch_AlertID.Width = 26;
			// 
			// ch_AlertDate
			// 
			this.ch_AlertDate.Text = "Date";
			this.ch_AlertDate.Width = 63;
			// 
			// ch_AlertText
			// 
			this.ch_AlertText.Text = "Message";
			this.ch_AlertText.Width = 149;
			// 
			// ch_AlertSound
			// 
			this.ch_AlertSound.Text = "Sound";
			this.ch_AlertSound.Width = 43;
			// 
			// btn_BrowseImage
			// 
			this.btn_BrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_BrowseImage.Location = new System.Drawing.Point(73, 496);
			this.btn_BrowseImage.Name = "btn_BrowseImage";
			this.btn_BrowseImage.Size = new System.Drawing.Size(133, 23);
			this.btn_BrowseImage.TabIndex = 10;
			this.btn_BrowseImage.Text = "Select Picture";
			this.btn_BrowseImage.UseVisualStyleBackColor = true;
			this.btn_BrowseImage.Click += new System.EventHandler(this.btn_BrowseImage_Click);
			// 
			// btn_RemoveImage
			// 
			this.btn_RemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveImage.Location = new System.Drawing.Point(225, 496);
			this.btn_RemoveImage.Name = "btn_RemoveImage";
			this.btn_RemoveImage.Size = new System.Drawing.Size(133, 23);
			this.btn_RemoveImage.TabIndex = 11;
			this.btn_RemoveImage.Text = "Remove Picture";
			this.btn_RemoveImage.UseVisualStyleBackColor = true;
			this.btn_RemoveImage.Click += new System.EventHandler(this.btn_RemoveImage_Click);
			// 
			// btn_Up
			// 
			this.btn_Up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Up.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Up.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Up.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Up.Location = new System.Drawing.Point(360, 113);
			this.btn_Up.Name = "btn_Up";
			this.btn_Up.Size = new System.Drawing.Size(28, 22);
			this.btn_Up.TabIndex = 18;
			this.btn_Up.Text = "↑";
			this.btn_Up.UseVisualStyleBackColor = true;
			this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
			// 
			// btn_Down
			// 
			this.btn_Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Down.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Down.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Down.Location = new System.Drawing.Point(360, 137);
			this.btn_Down.Name = "btn_Down";
			this.btn_Down.Size = new System.Drawing.Size(28, 22);
			this.btn_Down.TabIndex = 19;
			this.btn_Down.Text = "↓";
			this.btn_Down.UseVisualStyleBackColor = true;
			this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Save.Location = new System.Drawing.Point(15, 550);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(100, 23);
			this.btn_Save.TabIndex = 20;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.Location = new System.Drawing.Point(288, 550);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(100, 23);
			this.btn_Cancel.TabIndex = 21;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_BrowseBday
			// 
			this.btn_BrowseBday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_BrowseBday.BackgroundImage = global::BirthdayCalendar.Properties.Resources.calendar;
			this.btn_BrowseBday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_BrowseBday.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_BrowseBday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_BrowseBday.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_BrowseBday.Location = new System.Drawing.Point(360, 40);
			this.btn_BrowseBday.Name = "btn_BrowseBday";
			this.btn_BrowseBday.Size = new System.Drawing.Size(28, 20);
			this.btn_BrowseBday.TabIndex = 16;
			this.btn_BrowseBday.UseVisualStyleBackColor = true;
			this.btn_BrowseBday.Click += new System.EventHandler(this.btn_BrowseBday_Click);
			// 
			// btn_Alerts_Remove
			// 
			this.btn_Alerts_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Alerts_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alerts_Remove.BackgroundImage")));
			this.btn_Alerts_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Alerts_Remove.Enabled = false;
			this.btn_Alerts_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Alerts_Remove.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Alerts_Remove.Location = new System.Drawing.Point(360, 255);
			this.btn_Alerts_Remove.Name = "btn_Alerts_Remove";
			this.btn_Alerts_Remove.Size = new System.Drawing.Size(28, 48);
			this.btn_Alerts_Remove.TabIndex = 15;
			this.btn_Alerts_Remove.UseVisualStyleBackColor = true;
			this.btn_Alerts_Remove.Click += new System.EventHandler(this.btn_Alerts_Remove_Click);
			// 
			// btn_Alerts_Add
			// 
			this.btn_Alerts_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Alerts_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alerts_Add.BackgroundImage")));
			this.btn_Alerts_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Alerts_Add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Alerts_Add.Enabled = false;
			this.btn_Alerts_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Alerts_Add.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Alerts_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alerts_Add.Image")));
			this.btn_Alerts_Add.Location = new System.Drawing.Point(360, 197);
			this.btn_Alerts_Add.Name = "btn_Alerts_Add";
			this.btn_Alerts_Add.Size = new System.Drawing.Size(28, 48);
			this.btn_Alerts_Add.TabIndex = 14;
			this.btn_Alerts_Add.UseVisualStyleBackColor = true;
			this.btn_Alerts_Add.Click += new System.EventHandler(this.btn_Alerts_Add_Click);
			// 
			// btn_Contacts_Remove
			// 
			this.btn_Contacts_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Contacts_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Contacts_Remove.BackgroundImage")));
			this.btn_Contacts_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Contacts_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Contacts_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Contacts_Remove.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Contacts_Remove.Location = new System.Drawing.Point(360, 161);
			this.btn_Contacts_Remove.Name = "btn_Contacts_Remove";
			this.btn_Contacts_Remove.Size = new System.Drawing.Size(28, 28);
			this.btn_Contacts_Remove.TabIndex = 13;
			this.btn_Contacts_Remove.UseVisualStyleBackColor = true;
			this.btn_Contacts_Remove.Click += new System.EventHandler(this.btn_Contacts_Remove_Click);
			// 
			// btn_Contacts_Add
			// 
			this.btn_Contacts_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Contacts_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Contacts_Add.BackgroundImage")));
			this.btn_Contacts_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Contacts_Add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Contacts_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Contacts_Add.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Contacts_Add.Location = new System.Drawing.Point(360, 83);
			this.btn_Contacts_Add.Name = "btn_Contacts_Add";
			this.btn_Contacts_Add.Size = new System.Drawing.Size(28, 28);
			this.btn_Contacts_Add.TabIndex = 12;
			this.btn_Contacts_Add.UseVisualStyleBackColor = true;
			this.btn_Contacts_Add.Click += new System.EventHandler(this.button3_Click);
			// 
			// pb_Image
			// 
			this.pb_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb_Image.Location = new System.Drawing.Point(73, 317);
			this.pb_Image.Name = "pb_Image";
			this.pb_Image.Size = new System.Drawing.Size(285, 173);
			this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Image.TabIndex = 9;
			this.pb_Image.TabStop = false;
			// 
			// mc_Calendar
			// 
			this.mc_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mc_Calendar.Location = new System.Drawing.Point(209, 64);
			this.mc_Calendar.Name = "mc_Calendar";
			this.mc_Calendar.SelectionStart = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
			this.mc_Calendar.Size = new System.Drawing.Size(179, 185);
			this.mc_Calendar.TabIndex = 17;
			this.mc_Calendar.Visible = false;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(265, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "Color: ";
			// 
			// p_Color
			// 
			this.p_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.p_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p_Color.Cursor = System.Windows.Forms.Cursors.Hand;
			this.p_Color.Location = new System.Drawing.Point(311, 15);
			this.p_Color.Name = "p_Color";
			this.p_Color.Size = new System.Drawing.Size(43, 20);
			this.p_Color.TabIndex = 23;
			this.p_Color.Click += new System.EventHandler(this.p_Color_Click);
			// 
			// f_AddBirthday
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 576);
			this.Controls.Add(this.p_Color);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.mc_Calendar);
			this.Controls.Add(this.btn_Down);
			this.Controls.Add(this.btn_Up);
			this.Controls.Add(this.btn_BrowseBday);
			this.Controls.Add(this.btn_Alerts_Remove);
			this.Controls.Add(this.btn_Alerts_Add);
			this.Controls.Add(this.btn_Contacts_Remove);
			this.Controls.Add(this.btn_Contacts_Add);
			this.Controls.Add(this.btn_RemoveImage);
			this.Controls.Add(this.btn_BrowseImage);
			this.Controls.Add(this.pb_Image);
			this.Controls.Add(this.lv_Alerts);
			this.Controls.Add(this.lv_Contacts);
			this.Controls.Add(this.tb_Birthday);
			this.Controls.Add(this.tb_Name);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "f_AddBirthday";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Birthday";
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_Name;
		private System.Windows.Forms.TextBox tb_Birthday;
		private System.Windows.Forms.ListView lv_Contacts;
		private System.Windows.Forms.ListView lv_Alerts;
		private System.Windows.Forms.PictureBox pb_Image;
		private System.Windows.Forms.Button btn_BrowseImage;
		private System.Windows.Forms.Button btn_RemoveImage;
		private System.Windows.Forms.Button btn_Contacts_Add;
		private System.Windows.Forms.Button btn_Contacts_Remove;
		private System.Windows.Forms.Button btn_Alerts_Remove;
		private System.Windows.Forms.Button btn_Alerts_Add;
		private System.Windows.Forms.Button btn_BrowseBday;
		private System.Windows.Forms.ColumnHeader ch_ContactID;
		private System.Windows.Forms.ColumnHeader ch_ContactType;
		private System.Windows.Forms.ColumnHeader ch_Contact;
		private System.Windows.Forms.ImageList il_ContactImages;
		private uc_Calendar mc_Calendar;
		private System.Windows.Forms.Button btn_Up;
		private System.Windows.Forms.Button btn_Down;
		private System.Windows.Forms.ColumnHeader ch_AlertID;
		private System.Windows.Forms.ColumnHeader ch_AlertDate;
		private System.Windows.Forms.ColumnHeader ch_AlertText;
		private System.Windows.Forms.ColumnHeader ch_AlertSound;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel p_Color;
	}
}