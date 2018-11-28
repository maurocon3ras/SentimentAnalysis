using Android.App;
using Android.Content.PM;
using Android.OS;

namespace SentimentAnalysis.Droid
{
    [Activity (Label = "SentimentAnalysis", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (savedInstanceState);
            Microsoft.AppCenter.AppCenter.Start("2a162362-67d3-4f51-8f06-48695ee22242");
            global::Xamarin.Forms.Forms.Init (this, savedInstanceState);
			LoadApplication (new App());
		}
	}
}

