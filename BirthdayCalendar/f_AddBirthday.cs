using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayCalendar
{
	public partial class f_AddBirthday : Form
	{
		connToImg cti = new connToImg();
		c_DBHandler dbh = new c_DBHandler();
		public Birthday bday { get; set; }
		public SQLiteConnection sqlc { get; set; }
		public bool edit = false;
		public bool ok = false;
		int itemNewId = -1;
		bool pictureChanged = false;


		public f_AddBirthday()
		{
			InitializeComponent();
			Load += F_AddBirthday_Load;
		}

		public Color getRandomColor()
		{
			return Color.FromArgb(new Random().Next(-16777216, 1));
		}

		private void F_AddBirthday_Load(object sender, EventArgs e)
		{
			if (!edit) { bday = new Birthday() { connections = new List<Connection>(), alerts = new List<Alert>() }; p_Color.BackColor = getRandomColor();  }
			else { fillData(); }

			mc_Calendar.Load += Mc_Calendar_Load;
		}

		public void fillData()
		{
			tb_Name.Text = bday.name;
			tb_Birthday.Text = bday.birthday.ToShortDateString();
			fillAlerts();
			fillContacts();
			pb_Image.Image = bday.image;
			p_Color.BackColor = bday.birthdayColor;
		}

		private void Mc_Calendar_Load(object sender, EventArgs e)
		{
			mc_Calendar.mcc.DateSelected += Mcc_DateSelected;
		}

		private void Mcc_DateSelected(object sender, DateRangeEventArgs e)
		{
			tb_Birthday.Text = mc_Calendar.SelectionStart.ToShortDateString();
			mc_Calendar.Hide();
		}


		#region contacts
		public void fillContacts()
		{
			lv_Contacts.Items.Clear();

			bday.connections.Sort((a, b) => a.orderer.CompareTo(b.orderer));

			foreach (Connection c in bday.connections)
			{
				ListViewItem lvi = new ListViewItem();

				lvi.ImageIndex = cti.getIndex(c.type);

				lvi.Tag = c.id;

				lvi.Text = c.orderer + "";
				lvi.SubItems.Add(c.type.ToString());
				lvi.SubItems.Add(c.contactstring);
				lv_Contacts.Items.Add(lvi);
			}

			if (itemNewId != -1) { lv_Contacts.FocusedItem = lv_Contacts.Items[itemNewId]; lv_Contacts.Items[itemNewId].Selected = true; lv_Contacts.EnsureVisible(itemNewId); }
		}

		private void button3_Click(object sender, EventArgs e)
		{
			f_AddContacts fa = new f_AddContacts();
			fa.bday = bday;
			fa.ShowDialog();

			if (fa.ok)
			{
				fa.conn.orderer = bday.connections.Count;
				bday.connections.Add(fa.conn);
			}

			fillContacts();
		}

		private void btn_BrowseBday_Click(object sender, EventArgs e)
		{
			if (tb_Birthday.Text != "" && Convert.ToDateTime(tb_Birthday.Text) != null)
			{
				mc_Calendar.SelectionStart = Convert.ToDateTime(tb_Birthday.Text);
			}
			mc_Calendar.Visible = !mc_Calendar.Visible;

			if (mc_Calendar.Visible)
			{
				mc_Calendar.Left = Width - (mc_Calendar.Width + 20);
			}
		}

		private void btn_Up_Click(object sender, EventArgs e)
		{
			if (lv_Contacts.FocusedItem != null && lv_Contacts.FocusedItem.Tag != null)
			{
				ListViewItem l = lv_Contacts.FocusedItem;
				int i = Convert.ToInt32(l.Tag);
				if (l.Index != 0)
				{
					ListViewItem ll = lv_Contacts.Items[l.Index - 1];
					if (ll.Tag != null)
					{
						int tmp_id = Convert.ToInt32(ll.Tag);
						int tmpIndex = 0;

						Connection main = bday.getConnectionById(i);
						Connection second = bday.getConnectionById(tmp_id);

						tmpIndex = main.orderer;
						main.orderer = second.orderer;
						second.orderer = tmpIndex;
						itemNewId = ll.Index;
					}
				}
			}

			fillContacts();
		}

		private void btn_Down_Click(object sender, EventArgs e)
		{
			if (lv_Contacts.FocusedItem != null && lv_Contacts.FocusedItem.Tag != null)
			{
				ListViewItem l = lv_Contacts.FocusedItem;
				int i = Convert.ToInt32(l.Tag);
				if (l.Index < lv_Contacts.Items.Count - 1)
				{
					ListViewItem ll = lv_Contacts.Items[l.Index + 1];
					if (ll.Tag != null)
					{
						int tmp_id = Convert.ToInt32(ll.Tag);
						int tmpIndex = 0;

						Connection main = bday.getConnectionById(i);
						Connection second = bday.getConnectionById(tmp_id);

						tmpIndex = main.orderer;
						main.orderer = second.orderer;
						second.orderer = tmpIndex;
						itemNewId = ll.Index;
					}
				}
			}

			fillContacts();
		}

		private void btn_Contacts_Remove_Click(object sender, EventArgs e)
		{
			if (lv_Contacts.FocusedItem != null && lv_Contacts.FocusedItem.Tag != null)
			{
				ListViewItem l = lv_Contacts.FocusedItem;
				int i = Convert.ToInt32(l.Tag);
				Connection main = bday.getConnectionById(i);
				bday.connections.Remove(main);
			}

			fillContacts();
		}

		#endregion

		#region alerts
		public void fillAlerts()
		{
			lv_Alerts.Items.Clear();

			foreach(Alert a in bday.alerts)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = "" + lv_Alerts.Items.Count + 1;
				lvi.SubItems.Add(a.alert.Month + ". " + a.alert.Day + ".");
				lvi.SubItems.Add(a.showText ? a.text : "--");
				lvi.SubItems.Add(a.makeSound ? a.sound + "" : "--");
				lvi.Tag = a;
				lv_Alerts.Items.Add(lvi);
			}

			if(lv_Alerts.Items.Count > 0)
			{
				btn_Alerts_Remove.Enabled = true;
			}
			else
			{
				btn_Alerts_Remove.Enabled = false;
			}

			lv_Alerts.Sorting = SortOrder.Ascending;
			lv_Alerts.Sort();
		}

		private void btn_Alerts_Add_Click(object sender, EventArgs e)
		{
			f_AddAlert faa = new f_AddAlert();
			faa.bday = bday;
			faa.ShowDialog();
			if (faa.ok)
			{
				bday.alerts.Add(faa.alert);
			}

			fillAlerts();
		}

		private void btn_Alerts_Remove_Click(object sender, EventArgs e)
		{
			if (lv_Alerts.FocusedItem != null && lv_Alerts.FocusedItem.Tag != null)
			{
				ListViewItem l = lv_Contacts.FocusedItem;
				Alert a = l.Tag as Alert;
				bday.alerts.Remove(a);
			}

			fillAlerts();
		}

		#endregion

		private void btn_Save_Click(object sender, EventArgs e)
		{
			bday.name = tb_Name.Text;
			bday.birthdayColor = p_Color.BackColor;

			if (edit)
			{
				if (MessageBox.Show("You are about to modify an existing entry.\r\nAre you sure you wish to continue?","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
				{
					dbh.editEntry(sqlc, bday);
				}
			}
			else
			{
				dbh.addEntry(sqlc, bday);
			}

			this.Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_BrowseImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Images|*.bmp;*.png;*.gif;*.tiff|All Files|*.*";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (ofd.FileName.ToLower().EndsWith("jpg") || ofd.FileName.ToLower().EndsWith("jpeg"))
				{
					MessageBox.Show("You have selected a JPG file.\r\nJPG is not supported by this process. It has a tendency to cause errors later on and may cause data loss!\r\nYou are advised against using JPG images!\r\n\r\nIf you really want to use this image, you should convert it to a different format.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

				pictureChanged = true;

				using (FileStream ms = File.Open(ofd.FileName, FileMode.Open))
				{
					pb_Image.Image = Image.FromStream(ms);
				}
				
				bday.image = pb_Image.Image as Bitmap;
			}
		}

		private void btn_RemoveImage_Click(object sender, EventArgs e)
		{
			pb_Image.Image = null;
			bday.image = null;
		}

		private void tb_Birthday_TextChanged(object sender, EventArgs e)
		{
			DateTime test = default(DateTime);
			DateTime.TryParse(tb_Birthday.Text, out test);

			if (tb_Birthday.Text != "" && test.ToShortDateString() != default(DateTime).ToShortDateString())
			{
				btn_Alerts_Add.Enabled = true;
				bday.birthday = Convert.ToDateTime(tb_Birthday.Text);
			}
			else
			{
				btn_Alerts_Add.Enabled = false;
				bday.birthday = default(DateTime);
			}
		}

		private void p_Color_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			cd.Color = p_Color.BackColor;
			if(cd.ShowDialog() == DialogResult.OK)
			{
				p_Color.BackColor = cd.Color;
			}
		}

		private void lv_Contacts_DoubleClick(object sender, EventArgs e)
		{
			if(lv_Contacts.FocusedItem != null)
			{
				f_AddContacts fa = new f_AddContacts();
				fa.edit = true;
				fa.conn = bday.getConnectionById(Convert.ToInt32(lv_Contacts.FocusedItem.Tag.ToString()));
				fa.ShowDialog();
				if (fa.ok) { bday.setConnectionById(fa.conn.id, fa.conn); }
				fillContacts();
			}
		}

		private void lv_Alerts_DoubleClick(object sender, EventArgs e)
		{
			if (lv_Alerts.FocusedItem != null)
			{
				f_AddAlert fa = new f_AddAlert();
				fa.edit = true;
				fa.bday = bday;
				fa.alert = lv_Alerts.FocusedItem.Tag as Alert;
				fa.ShowDialog();
				if (fa.ok)
				{
					bday.alerts.Remove(lv_Alerts.FocusedItem.Tag as Alert);
					bday.alerts.Add(fa.alert);
				}
				fillAlerts();
			}
		}
	}
}
