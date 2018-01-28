using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayCalendar
{
	public partial class f_AddAlert : Form
	{
		public bool ok = false;
		public bool edit = false;
		public Birthday bday { get; set; }
		public Alert alert { get; set; }

		public f_AddAlert()
		{
			InitializeComponent();

			Load += F_AddAlert_Load;
		}

		private void F_AddAlert_Load(object sender, EventArgs e)
		{
			if (edit)
			{
				cb_DateSelect.SelectedIndex = 0;
				cb_Month.SelectedIndex = alert.alert.Month - 1;
				num_Day.Value = alert.alert.Day;
				cb_ShowText.Checked = alert.showText;
				cb_PlaySound.Checked = alert.makeSound;
				tb_AlertMessage.Text = alert.text;
				cb_AlertSound.SelectedIndex = alert.sound < 0 ? 0 : alert.sound;
				if (alert.sound < 0) { cb_AlertSound.Text = ""; }
			}
		}

		private void cb_Month_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cb_Month.SelectedIndex)
			{
				case 1:
					num_Day.Maximum = 28;
					if(DateTime.Now.Year % 4 == 0 && (DateTime.Now.Year % 100 != 0 || DateTime.Now.Year % 400 == 0)) { num_Day.Maximum = 29; }
					break;

				case 0:
				case 2:
				case 4:
				case 6:
				case 8:
				case 10:
					num_Day.Maximum = 31;
					break;

				default:
					num_Day.Maximum = 30;
					break;
			}
		}

		private void cb_DateSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			p_CustomDate.Enabled = false;
			if(cb_DateSelect.SelectedIndex == 0) { p_CustomDate.Enabled = true; }
			else
			{
				var b = bday.birthday;

				switch (cb_DateSelect.SelectedIndex)
				{
					case 1:
						b = b.Subtract(new TimeSpan(1, 0, 0, 0));
						break;

					case 2:
						b = b.Subtract(new TimeSpan(2, 0, 0, 0));
						break;

					case 3:
						b = b.Subtract(new TimeSpan(4, 0, 0, 0));
						break;

					case 4:
						b = b.Subtract(new TimeSpan(7, 0, 0, 0));
						break;

					case 5:
						b = b.Subtract(new TimeSpan(14, 0, 0, 0));
						break;
				}

				cb_Month.SelectedIndex = b.Month - 1;
				num_Day.Value = b.Day;
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			ok = true;
			alert = new Alert() {
				alert = new DateTime(DateTime.Now.Year, cb_Month.SelectedIndex + 1, (int)num_Day.Value),
				makeSound = cb_PlaySound.Checked,
				showText = cb_ShowText.Checked,
				sound = cb_AlertSound.SelectedIndex,
				text = tb_AlertMessage.Text
			};
			this.Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to cancel adding a new reminder?","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				ok = false;
				this.Close();
			}
		}

		private void btn_TestSound_Click(object sender, EventArgs e)
		{
			//TODO: Add sounds and set up testSound function
		}

		private void f_AddAlert_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btn_Save_Click(null, null);
			}
			else if (e.KeyCode == Keys.Escape)
			{
				btn_Cancel_Click(null, null);
			}
		}
	}
}
