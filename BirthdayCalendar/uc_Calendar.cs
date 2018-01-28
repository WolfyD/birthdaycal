using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayCalendar
{
	public partial class uc_Calendar : UserControl
	{
		public DateTime SelectionStart { get { return mc_Cal.SelectionStart; } set { try { mc_Cal.SelectionStart = value; } catch { } } }
		public MonthCalendar mcc { get; set; }


		string[] months = new string[] {"", "January","February","March","Apryl","May","June","July","August","September","October","November","December" };

		public uc_Calendar()
		{
			InitializeComponent();

			Load += Uc_Calendar_Load;
		}

		private void Uc_Calendar_Load(object sender, EventArgs e)
		{
			tb_Year.Value = mc_Cal.SelectionStart.Year;
			int i = mc_Cal.SelectionStart.Month;
			if(i == 12) { i = 1; }
			tb_Month.Text = months[i];

			mcc = mc_Cal;

			if (mcc.Right > Width)
			{
				Width = mcc.Right + (mcc.Left * 2);
				mcc.Width = Width - (mcc.Left * 2);
			}
		}

		private void btn_Year_Minus_Click(object sender, EventArgs e)
		{
			tb_Year.Value--;
		}

		private void btn_Year_Plus_Click(object sender, EventArgs e)
		{
			tb_Year.Value++;
		}

		private void tb_Year_ValueChanged(object sender, EventArgs e)
		{
			int i = 0;
			for(i = 0; i < months.Length; i++)
			{
				if(tb_Month.Text != "" && tb_Month.Text == months[i]) { break; }
			}

			i = (i == 13 ? 1 : i);

			if (tb_Year.Value.ToString().Length == 4 && tb_Year.Value >= mc_Cal.MinDate.Year)
			{
				mc_Cal.SetDate(new DateTime((int)tb_Year.Value, i, 1));
			}
		}

		private void btn_Month_Minus_Click(object sender, EventArgs e)
		{
			int i = 0;
			for (i = 0; i < months.Length; i++)
			{
				if (months[i] == tb_Month.Text) { break; }
			}

			i--;

			if(i == 0) { i = 12; }

			tb_Month.Text = months[i];
		}

		private void btn_Month_Plus_Click(object sender, EventArgs e)
		{
			int i = 0;
			for (i = 0; i < months.Length; i++)
			{
				if (months[i] == tb_Month.Text) { break; }
			}

			if (i > 11) { i = 0; }
			tb_Month.Text = months[i + 1];
		}

		private void tb_Year_KeyUp(object sender, KeyEventArgs e)
		{
			if(tb_Year.Value.ToString().Length == 4)
			{
				int i = 0;
				for (i = 0; i < months.Length; i++)
				{
					if (tb_Month.Text != "" && tb_Month.Text == months[i]) { break; }
				}

				i = (i == 13 ? 1 : i);

				mc_Cal.SetDate(new DateTime((int)tb_Year.Value, i, 1));
			}
		}

		private void uc_Calendar_Load_1(object sender, EventArgs e)
		{
			
		}
	}
}
