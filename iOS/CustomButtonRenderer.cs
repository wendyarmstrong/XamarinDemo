using System;
using Xamarin.Forms;
using XamarinDemo;
using XamarinDemo.iOS;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;

[assembly: ExportRenderer (typeof (CustomButton), typeof (CustomButtonRenderer))]
namespace XamarinDemo.iOS
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		public CustomButtonRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				// do whatever you want to the Button here!
				Control.BackgroundColor = UIColor.LightGray;
			}
		}
	}
}

