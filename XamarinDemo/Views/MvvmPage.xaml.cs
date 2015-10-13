using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
	public partial class MvvmPage : ContentPage
	{
		public MvvmPage ()
		{
			InitializeComponent ();
			BindingContext = App.Locator.Main;
		}
	}
}

