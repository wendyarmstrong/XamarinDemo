using System;
using Xamarin.Forms;
using XamarinDemo.ViewModel;

namespace XamarinDemo
{
	public class App : Application
	{
		private static ViewModelLocator _locator;

		public static ViewModelLocator Locator
		{
			get { return _locator ?? (_locator = new ViewModelLocator()); }
		}

		public App ()
		{
			// The root page of your application
			MainPage = new MainContentPage ();
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

