using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XamarinDemo;
using XamarinDemo.Droid;

[assembly: ExportRenderer (typeof (CustomButton), typeof (CustomButtonRenderer))]
namespace XamarinDemo.Droid
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		public CustomButtonRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.SetBackgroundColor (global::Android.Graphics.Color.Azure);
			}
		}
	}
}

