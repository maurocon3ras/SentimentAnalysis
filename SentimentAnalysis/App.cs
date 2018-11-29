using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SentimentAnalysis
{
    public class App : Application
    {
        public App()
        { 
            AppCenter.Start("android=491b6faf-4f53-4bc9-bae9-83b0c4e5ca34;", typeof(Analytics), typeof(Crashes));
            MainPage = new SentimentPage();
        }

        
    }
}
