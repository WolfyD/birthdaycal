namespace BirthdayCalendar
{
	partial class f_AddContacts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_AddContacts));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.il_ContactImages = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(122, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.f_AddContacts_PreviewKeyDown);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(140, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(179, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.f_AddContacts_PreviewKeyDown);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(12, 39);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 2;
			this.btn_Add.Text = "Add";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			this.btn_Add.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.f_AddContacts_PreviewKeyDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(244, 39);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 3;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.f_AddContacts_PreviewKeyDown);
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
			// f_AddContacts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 71);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "f_AddContacts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Contact";
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.f_AddContacts_PreviewKeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.ImageList il_ContactImages;
	}
}