using System;
using System.IO;
using Xamarin.Forms;
using XamarinDemo.iOS;
using SQLite.Net;

[assembly: Dependency (typeof (SQLiteIOS))]
namespace XamarinDemo.iOS
{
	public class SQLiteIOS : ISQLite
	{
		public SQLiteIOS ()
		{
		}

		public SQLite.Net.SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "MyDataBase.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);

			#if DEBUG

			Console.WriteLine("Documents directory = {0}", path);

			#endif

			// Create the connection
			var plat = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
			var conn = new SQLite.Net.SQLiteConnection(plat, path);
			// Return the database connection
			return conn;
		}
	}
}

