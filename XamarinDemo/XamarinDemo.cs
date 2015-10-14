using System;
using Xamarin.Forms;
using XamarinDemo.ViewModel;
using SQLite.Net;

namespace XamarinDemo
{
	public class App : Application
	{
		private static ViewModelLocator _locator;
		public static ViewModelLocator Locator
		{
			get { return _locator ?? (_locator = new ViewModelLocator()); }
		}

		SQLiteConnection _Database;
		public SQLiteConnection Database 
		{
			get
			{
				if(_Database == null)
				 	_Database = DependencyService.Get<ISQLite>().GetConnection();

				return _Database;
			}
		}


		public App ()
		{
			var xamlTab = new TabbedPage ();
			xamlTab.Children.Add(new MainContentPage { Title = "Main"});
			xamlTab.Children.Add(new MvvmPage {Title = "Mvvm"});
			xamlTab.Children.Add(new CustomButtonPage {Title = "Custom Button"});
			// The root page of your application	
			MainPage = xamlTab;

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

