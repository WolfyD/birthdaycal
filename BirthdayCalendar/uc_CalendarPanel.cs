using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BirthdayCalendar
{
	public partial class uc_CalendarPanel : UserControl
	{
		public int mode = 3;
		private List<Birthday> birthdays = null;
		public List<Birthday> Birthdays { get { return birthdays; } set { birthdays = value; refreshBirthdays(); } }
		public SQLiteConnection sqlc { get; set; }

		public uc_CalendarPanel()
		{
			InitializeComponent();

			Load += Uc_CalendarPanel_Load;
		}

		private void Uc_CalendarPanel_Load(object sender, EventArgs e)
		{

		}

		private void btn_Today_Click(object sender, EventArgs e)
		{
			int i = -1;
			int.TryParse(((ToolStripMenuItem)sender).Tag.ToString(), out i);
			if(i > -1)
			{
				mode = i;
				Refresh();
			}
		}

		public void refreshBirthdays()
		{
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);


			switch (mode)
			{
				case 0:
					int hour = DateTime.Now.Hour;
					int min = DateTime.Now.Minute;

					float fmin = ((hour * 1.0f) / 60.0f) * min;


					int height = Height - menuStrip1.Height;
					int hourHeight = height / 24;
					Font hourFont = new Font("Arial", hourHeight / 2, FontStyle.Bold);

					for(int i = 0; i < 24; i++)
					{
						int lnTop = (height % 24) + menuStrip1.Height + (i * hourHeight);

						if(i % 2 == 0)
						{
							e.Graphics.FillRectangle(Brushes.White, new Rectangle(new Point(0, lnTop), new Size(Width, hourHeight)));
						}

						if(i == hour)
						{
							e.Graphics.FillRectangle(Brushes.LightYellow, new Rectangle(new Point(0, lnTop), new Size(Width, hourHeight)));
							e.Graphics.DrawLine(Pens.LightPink, new Point(0, lnTop + (int)fmin), new Point(Width, lnTop + (int)fmin));
							e.Graphics.DrawLine(Pens.LightPink, new Point(0, lnTop + (int)fmin + 1), new Point(Width, lnTop + (int)fmin + 1));
						}

						List<Birthday> bd = new List<Birthday>();

						if(i == 12)
						{
							foreach(Birthday b in Birthdays)
							{
								if(b.birthday.Date == DateTime.Now.Date)
								{
									bd.Add(b);
								}
							}
							if (bd.Count > 0)
							{
								int ii = Width / bd.Count;
								for(int x = 0; x < bd.Count; x++)
								{
									e.Graphics.FillRectangle(new SolidBrush(bd[x].birthdayColor), new Rectangle(new Point(x * ii, lnTop), new Size(ii, hourHeight)));
								}
							}
						}

						e.Graphics.DrawString(i.ToString().PadLeft(2, '0'), hourFont, Brushes.Black, new Point(10, (height % 24) + menuStrip1.Height + hourHeight / 2 + (i * hourHeight) - 5));
						e.Graphics.DrawLine(Pens.Black, new Point(0, lnTop), new Point(Width, lnTop));
					}

					break;

				case 1:
					int dayWid = Width / 7;

					DateTime sow = DateTime.Now;

					while(sow.DayOfWeek != DayOfWeek.Monday) { sow = sow.Subtract(new TimeSpan(1, 0, 0, 0)); }

					for(int day = 0; day < 7; day++)
					{

						hour = DateTime.Now.Hour;
						min = DateTime.Now.Minute;

						fmin = ((hour * 1.0f) / 60.0f) * min;


						height = Height - menuStrip1.Height;
						hourHeight = height / 24;
						hourFont = new Font("Arial", hourHeight / 2, FontStyle.Bold);

						

						for (int i = 0; i < 24; i++)
						{
							int lnTop = (height % 24) + menuStrip1.Height + 20 + (i * hourHeight);

							if (i % 2 == 0)
							{
								e.Graphics.FillRectangle(Brushes.White, new Rectangle(new Point(day * dayWid, lnTop), new Size(dayWid, hourHeight)));
							}

							int nowday = (int)DateTime.Now.DayOfWeek - 1;
							if(nowday < 0) { nowday = 6; }

							if (i == hour && day == nowday)
							{
								e.Graphics.FillRectangle(Brushes.LightYellow, new Rectangle(new Point(day * dayWid, lnTop), new Size(dayWid, hourHeight)));
								e.Graphics.DrawLine(Pens.LightPink, new Point(nowday * dayWid, lnTop + (int)fmin), new Point((dayWid * nowday) + dayWid, lnTop + (int)fmin));
								e.Graphics.DrawLine(Pens.LightPink, new Point(nowday * dayWid, lnTop + (int)fmin + 1), new Point((dayWid * nowday) + dayWid, lnTop + (int)fmin + 1));
							}

							List<Birthday> bd = new List<Birthday>();

							if (i == 12)
							{
								foreach (Birthday b in Birthdays)
								{
									if (Convert.ToInt32(b.birthday.Month + "" + b.birthday.Day) == Convert.ToInt32(sow.Add(new TimeSpan(day * 1, 0, 0, 0)).Month + "" + sow.Add(new TimeSpan(day * 1, 0, 0, 0)).Day)) 
									{
										bd.Add(b);
									}
								}
								if (bd.Count > 0)
								{
									int ii = dayWid / bd.Count;
									for (int x = 0; x < bd.Count; x++)
									{
										e.Graphics.FillRectangle(new SolidBrush(bd[x].birthdayColor), new Rectangle(new Point((day * dayWid) + (x * ii), lnTop), new Size(ii, hourHeight)));
									}
								}
							}

							e.Graphics.DrawString(i.ToString().PadLeft(2, '0'), new Font(hourFont.FontFamily, hourFont.Size, FontStyle.Bold), Brushes.Black, new Point(10, (height % 24) + menuStrip1.Height + hourHeight / 2 + (i * hourHeight) - 5));
							e.Graphics.DrawLine(Pens.Black, new Point(0, lnTop), new Point(Width, lnTop));
						}

						e.Graphics.DrawLine(Pens.Black, new Point(day * dayWid, menuStrip1.Height + 20), new Point(day * dayWid, height));
						e.Graphics.DrawString(getDayName("EN", day), new Font(hourFont.FontFamily, hourFont.Size - 2, FontStyle.Regular), Brushes.Black, new Point(dayWid / 2 + (day * dayWid), menuStrip1.Height + 10), new StringFormat() { Alignment = StringAlignment.Center });
					}


					break;

				case 2:
					break;

				case 3:
					break;

				default:
					break;
			}


		}

		public string getDayName(string lang, int day)
		{
			string[] days = new string[1];

			if (lang == "EN")
			{
				days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
			}

			return days[day];
		}

		private void uc_CalendarPanel_SizeChanged(object sender, EventArgs e)
		{
			Refresh();
		}
	}
}
