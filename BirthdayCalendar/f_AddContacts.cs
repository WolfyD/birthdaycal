using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayCalendar
{
	public partial class f_AddContacts : Form
	{
		public Connection conn { get; set; }
		public bool edit = false;
		Dictionary<ConnectionType, int> ct = new connToImg().conntype;
		connToImg cti = new connToImg();
		public bool ok = false;
		public Birthday bday { get; set; }

		public f_AddContacts()
		{
			InitializeComponent();

			Load += F_AddContacts_Load;
		}

		private void F_AddContacts_Load(object sender, EventArgs e)
		{
			foreach(var v in ct.OrderBy(x => x.Value))
			{
				comboBox1.Items.Add(v.Key);
			}

			if (edit)
			{
				comboBox1.Text = conn.type.ToString();
				textBox1.Text = conn.contactstring;
				btn_Add.Text = "Save Changes";
				btn_Add.Width = 120;
			}
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex >= 0 && textBox1.Text != "")
			{
				if (edit)
				{
					conn.type = cti.getConntypeFromString(comboBox1.Text);
					conn.contactstring = textBox1.Text;
				}
				else
				{
					int i = new Random().Next(1000, 10000);
					int[] connids = new int[bday.connections.Count];
					int ii = 0;
					foreach (Connection c in bday.connections) { connids[ii] = c.id; ii++; }

					while (connids.Contains(i))
					{
						Thread.Sleep(1);
						i = new Random(Environment.TickCount).Next(1000, 10000);
					}

					conn = new Connection()
					{
						id = i,
						type = cti.getConntypeFromString(comboBox1.Text),
						contactstring = textBox1.Text
					};
				}
			}

			ok = true;

			this.Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox1.Focus();
		}

		private void f_AddContacts_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btn_Add_Click(null, null);
			}else if(e.KeyCode == Keys.Escape)
			{
				btn_Cancel_Click(null, null);
			}
		}
	}
}
