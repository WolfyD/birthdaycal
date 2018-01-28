using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayCalendar
{
	public partial class Form1 : Form
	{
		SQLiteConnection sqlc = null;
		c_DBHandler cd = new c_DBHandler();


		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
		}

		public void setToRunOnStart()
		{

		}




		private void Form1_Load(object sender, EventArgs e)
		{
			if (File.Exists("bd.db"))
			{
				sqlc = cd.connect();
				cd.checkTables(sqlc);
			}
			else
			{
				sqlc = cd.createDBFile();
			}

			sc_Main.Panel2Collapsed = true;

			lv_List.Font = Properties.Settings.Default.f_ListFont;

			loadBirthdays();
		}

		public void loadBirthdays()
		{
			int i = -1;
			if (lv_List.FocusedItem != null) { i = lv_List.FocusedItem.Index; }

			lv_List.Items.Clear();
			List<Birthday> bdl = cd.getEntry(-1, sqlc);

			int now = Convert.ToInt32(DateTime.Now.Month.ToString().PadLeft(2, '0') + "" + DateTime.Now.Day.ToString().PadLeft(2, '0'));
			int smallestdate = 9999;

			foreach (Birthday b in bdl)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.UseItemStyleForSubItems = false;
				lvi.Text = lv_List.Items.Count + 1 + "";
				lvi.SubItems.Add(b.name);
				lvi.SubItems.Add(b.birthday.ToShortDateString());
				lvi.Tag = b;

				lvi.BackColor = lv_List.Items.Count % 2 == 0 ? Color.WhiteSmoke : Color.LightYellow;
				lvi.SubItems[1].BackColor = lvi.BackColor;
				lvi.SubItems[2].BackColor = lvi.BackColor;


				lvi.SubItems.Add("");
				lvi.SubItems[3].BackColor = b.birthdayColor;

				int date = Convert.ToInt32(b.birthday.Month.ToString().PadLeft(2,'0') + "" + b.birthday.Day.ToString().PadLeft(2, '0'));
				if (date > now && date < smallestdate)
				{
					lbl_NextBirthday.Text = "Next Birthday: " + b.name + " - " + b.birthday.Month.ToString().PadLeft(2, '0') + ". " + b.birthday.Day.ToString().PadLeft(2, '0') + ".";
					smallestdate = date;
				}

				lv_List.Items.Add(lvi);
			}

			realignHeaders();

			lbl_NumOfBirthdays.Text = lv_List.Items.Count + " Birthdays";


			if (i > -1 && lv_List.Items.Count > i)
			{
				lv_List.FocusedItem = lv_List.Items[i];
				lv_List.Items[i].Selected = true;
			}

			uc_CalendarPanel1.Birthdays = bdl;

			//lv_List_SelectedIndexChanged(null, null);
		}

		public void realignHeaders()
		{
			ch_Id.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
			ch_Birthday.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
			ch_Birthday.Width += 20;
			ch_Color.Width = 15;
			ch_Name.Width = lv_List.Width - (ch_Id.Width + ch_Birthday.Width + ch_Color.Width) - 4;

			ch_Birthday.TextAlign = HorizontalAlignment.Center;
		}

		private void btn_AddBirthday_Click(object sender, EventArgs e)
		{
			f_AddBirthday fb = new f_AddBirthday();
			fb.sqlc = sqlc;
			fb.ShowDialog();
			loadBirthdays();
		}

		private void btn_RemoveBirthday_Click(object sender, EventArgs e)
		{
			if (lv_List.FocusedItem != null)
			{
				if (MessageBox.Show("Warning!\r\n\r\nYou are about to delete an entry.\r\nThis action can not be undone.\r\n\r\nAre you sure you wish to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					cd.deleteEntry(sqlc, (lv_List.FocusedItem.Tag as Birthday).id);
					loadBirthdays();
				}
			}
		}

		private void lv_List_DoubleClick(object sender, EventArgs e)
		{
			if(lv_List.FocusedItem != null)
			{
				f_AddBirthday _fa = new f_AddBirthday();
				_fa.bday = lv_List.FocusedItem.Tag as Birthday;
				_fa.edit = true;
				_fa.sqlc = sqlc;
				_fa.ShowDialog();
				loadBirthdays();
			}
		}

		public void loadBdayData(Birthday b)
		{
			try
			{
				lbl_Name.Text = b.name;
				lbl_Birthday.Text = b.birthday.ToShortDateString();
				connToImg cti = new connToImg();

				lv_ContactInfo.Items.Clear();

				foreach (Connection c in b.connections)
				{
					ListViewItem lvi = new ListViewItem();

					lvi.ImageIndex = cti.getIndex(c.type);

					lvi.Tag = c.id;
					lvi.Text = (c.type.ToString());
					lvi.SubItems.Add(c.contactstring);
					lv_ContactInfo.Items.Add(lvi);
				}

				lv_Alerts.Items.Clear();

				foreach(Alert a in b.alerts)
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = a.alert.Month + ". " + a.alert.Day + ".";
					lvi.SubItems.Add(a.showText ? a.text : "--");
					lvi.SubItems.Add(a.makeSound ? a.sound + "" : "--");
					lv_Alerts.Items.Add(lvi);
				}

				pb_Edit_Picture.Image = b.image;
				p_Color.BackColor = b.birthdayColor;

				sc_Main.Panel2Collapsed = false;
			}
			catch
			{

			}
		}

		private void lv_List_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = 0;

			if (lv_List.SelectedItems.Count > 0) { loadBdayData(lv_List.FocusedItem.Tag as Birthday); }
			else { sc_Main.Panel2Collapsed = true; }
		}

		private void btn_EditBirthday_Click(object sender, EventArgs e)
		{
			lv_List_DoubleClick(null, null);
		}

		private void sc_Secondary_SplitterMoved(object sender, SplitterEventArgs e)
		{
			realignHeaders();
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			realignHeaders();
		}
	}
}
