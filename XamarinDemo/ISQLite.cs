using System;
using SQLite.Net;

namespace XamarinDemo
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

