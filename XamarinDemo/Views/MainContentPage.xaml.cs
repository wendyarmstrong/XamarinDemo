using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
	public partial class MainContentPage : ContentPage
	{
		public MainContentPage ()
		{
			InitializeComponent ();
		}

		async void OnButtonClicked(object sender, EventArgs e)
		{
			if(MyLabel.Text == "Hello World")
				MyLabel.Text = "Button Was Pressed!";
			else
				MyLabel.Text = "Hello World";
		}
	}
}

