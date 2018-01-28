using System;
using System.Collections.Generic;

using System.Data.SQLite;
using Newtonsoft.Json;
using System.IO;
using System.Drawing;

namespace BirthdayCalendar
{
	class c_DBHandler
	{
		public SQLiteConnection createDBFile()
		{
			File.Create("bd.db").Close();
			var sqlc = connect();
			checkTables(sqlc);
			return sqlc;
		}

		public void checkTables(SQLiteConnection sqlc)
		{
			if (checkConnection(sqlc))
			{
				SQLiteCommand sql = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='birthdays'", sqlc);
				if (sql.ExecuteScalar() is null)
				{
					sql = new SQLiteCommand("CREATE TABLE birthdays (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, birthday TEXT, connections TEXT, alerts TEXT, color INTEGER)", sqlc);
					sql.ExecuteNonQuery();
				}

				sql = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='images'", sqlc);
				if (sql.ExecuteScalar() is null)
				{
					sql = new SQLiteCommand("CREATE TABLE images (id INTEGER PRIMARY KEY AUTOINCREMENT, birthday_id INTEGER, image TEXT)", sqlc);
					sql.ExecuteNonQuery();
				}
			}
		}

		public SQLiteConnection connect()
		{
			SQLiteConnection sqlc = new SQLiteConnection("Data Source=bd.db;Version=3;");
			sqlc.Open();
			return sqlc;
		}

		public void disconnect(SQLiteConnection sqlc)
		{
			sqlc.Close();
			sqlc.Dispose();
		}

		public bool checkConnection(SQLiteConnection sqlc)
		{
			return (sqlc != null && sqlc.State == System.Data.ConnectionState.Open);
		}

		public int getNextId(SQLiteConnection sqlc)
		{
			if (checkConnection(sqlc))
			{
				SQLiteCommand sql = new SQLiteCommand("SELECT max(id) FROM birthdays", sqlc);
				object o = sql.ExecuteScalar();
				int i = 0;
				int.TryParse(o.ToString(), out i);
				return i + 1;
			}
			else
			{
				return -1;
			}
		}

		public void addEntry(SQLiteConnection sqlc, Birthday bday)
		{
			if (checkConnection(sqlc))
			{
				int nextid = getNextId(sqlc);
				string command = string.Format("INSERT INTO birthdays " +
													" (id, name, birthday, connections, alerts, color) " +
													" VALUES " +
													" ({4},'{0}','{1}','{2}','{3}', {5}); ",
													bday.name,
													bday.birthday.ToShortDateString(),
													JsonConvert.SerializeObject(bday.connections),
													JsonConvert.SerializeObject(bday.alerts),
													nextid,
													bday.birthdayColor.ToArgb()
												);
				if (bday.image != null)
				{
					command += string.Format("INSERT INTO images " +
												" (birthday_id, image) " +
												" VALUES " +
												" ({0}, '{1}');",
												nextid,
												c_ImageConverter.ConvertToHex(bday.image)
											);
				}

				SQLiteCommand sql = new SQLiteCommand(command, sqlc);
				sql.ExecuteNonQuery();
			}
		}

		public void editEntry(SQLiteConnection sqlc, Birthday bday)
		{
			if (checkConnection(sqlc))
			{
				string command = string.Format("UPDATE birthdays SET" +
													" name='{0}', birthday='{1}', connections='{2}', alerts='{3}', color={5} " +
													" WHERE id={4}; ",
													bday.name,
													bday.birthday.ToShortDateString(),
													JsonConvert.SerializeObject(bday.connections),
													JsonConvert.SerializeObject(bday.alerts),
													bday.id,
													bday.birthdayColor.ToArgb()
												);
				if (bday.image != null)
				{
					SQLiteCommand sqlkk = new SQLiteCommand("SELECT id FROM images WHERE birthday_id=" + bday.id,sqlc);
					var v = sqlkk.ExecuteScalar();

					if (v == null)
					{
						command += string.Format("INSERT INTO images " +
												" (birthday_id, image) " +
												" VALUES " +
												" ({0}, '{1}');",
												bday.id,
												c_ImageConverter.ConvertToHex(bday.image)
											);
					}
					else
					{
						command += string.Format("UPDATE images " +
													" SET image='{1}' " +
													" WHERE birthday_id = {0}; ",
													bday.id,
													c_ImageConverter.ConvertToHex((Bitmap)bday.image)
												);
					}
				}
				else
				{
					command += string.Format("DELETE FROM images " + 
												" WHERE birthday_id={0};",
												bday.id
											);
				}

				SQLiteCommand sql = new SQLiteCommand(command, sqlc);
				sql.ExecuteNonQuery();

				sql.CommandText = "vacuum;";
				sql.ExecuteNonQuery();
			}
		}

		public void deleteEntry(SQLiteConnection sqlc, int id)
		{
			if (checkConnection(sqlc))
			{
				SQLiteCommand sql = new SQLiteCommand(sqlc);
				sql.CommandText = "DELETE FROM birthdays where id=" + id;
				sql.ExecuteNonQuery();

				sql.CommandText = "DELETE from images where birthday_id=" + id;
				sql.ExecuteNonQuery();

				sql.CommandText = "vacuum;";
				sql.ExecuteNonQuery();
			}
		}

		public List<Birthday> getEntry(int id, SQLiteConnection sqlc)
		{
			if (checkConnection(sqlc))
			{
				List<Birthday> lb = new List<Birthday>();
				SQLiteCommand sql = new SQLiteCommand("SELECT b.*, i.image FROM birthdays b LEFT JOIN images i on (i.birthday_id = b.id) WHERE ", sqlc);

				if (id == -1)
				{
					sql.CommandText += "1=1";
				}
				else
				{
					sql.CommandText += "b.id=" + id;
				}

				SQLiteDataReader r = sql.ExecuteReader();

				while (r.Read())
				{
					Birthday b = new Birthday();
					b.id = r.GetInt32(0);
					b.name = r.GetString(1);
					b.birthday = Convert.ToDateTime(r.GetString(2));

					b.connections = JsonConvert.DeserializeObject<List<Connection>>(r.GetString(3));
					b.alerts = JsonConvert.DeserializeObject<List<Alert>>(r.GetString(4));

					if (r.GetValue(6).ToString() != "")
					{
						string img = r.GetString(6);
						b.image = c_ImageConverter.ConvertToImg(img);
					}
					else
					{
						b.image = null;
					}

					b.birthdayColor = Color.FromArgb(r.GetInt32(5));

					lb.Add(b);
				}
				
				return lb;
			}
			else
			{
				return null;
			}
		}

		
	}

	public class Birthday
	{
		public int id { get; set; }
		public string name { get; set; }
		public DateTime birthday { get; set; }
		public List<Connection> connections { get; set; }
		public List<Alert> alerts { get; set; }
		public Bitmap image { get; set; }
		public Color birthdayColor { get; set; }

		public Connection getConnectionById(int id)
		{
			foreach(var c in connections)
			{
				if(c.id == id) { return c; }
			}

			return null;
		}

		public bool setConnectionById(int id, Connection conn)
		{
			foreach (var c in connections)
			{
				if (c.id == id)
				{
					c.type = conn.type;
					c.orderer = conn.orderer;
					c.contactstring = conn.contactstring;
					return true;
				}

			}

			return false;
		}
	}

	public class Connection
	{
		public int id { get; set; }
		public int orderer { get; set; }
		public ConnectionType type { get; set; }
		public string contactstring { get; set; }	
	}

	public class Alert
	{
		public DateTime alert { get; set; }
		public bool showText { get; set; }
		public string text { get; set; }
		public bool makeSound { get; set; }
		public int sound { get; set; }
	}

	public enum ConnectionType
	{
		email,
		phone,
		mobile,
		skype,
		steam,
		discord,
		telegram,
		msn,
		irc,
		twitter,
		facebook,
		aim,
		trillian,
		icq,
		xboxlive,
		wow,
		playstationnetwork,
		kik,
		snapchat,
		website,
		googleplus,
		viber,
		other
	}

	public class connToImg
	{
		public Dictionary<ConnectionType, int> conntype = new Dictionary<ConnectionType, int>();

		public connToImg()
		{
			conntype.Add(ConnectionType.aim, 0);
			conntype.Add(ConnectionType.discord, 1);
			conntype.Add(ConnectionType.email, 2);
			conntype.Add(ConnectionType.facebook, 3);
			conntype.Add(ConnectionType.googleplus, 4);
			conntype.Add(ConnectionType.icq, 5);
			conntype.Add(ConnectionType.irc, 6);
			conntype.Add(ConnectionType.kik, 7);
			conntype.Add(ConnectionType.mobile, 8);
			conntype.Add(ConnectionType.msn, 9);
			conntype.Add(ConnectionType.other, 10);
			conntype.Add(ConnectionType.phone, 11);
			conntype.Add(ConnectionType.playstationnetwork, 12);
			conntype.Add(ConnectionType.skype, 13);
			conntype.Add(ConnectionType.snapchat, 14);
			conntype.Add(ConnectionType.steam, 15);
			conntype.Add(ConnectionType.telegram, 16);
			conntype.Add(ConnectionType.trillian, 17);
			conntype.Add(ConnectionType.twitter, 18);
			conntype.Add(ConnectionType.viber, 19);
			conntype.Add(ConnectionType.website, 20);
			conntype.Add(ConnectionType.wow, 21);
			conntype.Add(ConnectionType.xboxlive, 22);
		}

		public int getIndex(ConnectionType c)
		{
			return conntype[c];
		}

		public int getIndex(string s)
		{
			ConnectionType c = new ConnectionType();

			foreach(var v in conntype)
			{
				if(v.Key.ToString() == s) { c = v.Key; break; }
			}

			return conntype[c];
		}

		public ConnectionType getConntypeFromString(string s)
		{
			ConnectionType c = new ConnectionType();

			foreach (var v in conntype)
			{
				if (v.Key.ToString() == s) { c = v.Key; break; }
			}

			return c;
		}



	}
}
