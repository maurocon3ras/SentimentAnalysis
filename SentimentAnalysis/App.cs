using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SentimentAnalysis
{
    public class App : Application
    {
        public App()
        {
            Microsoft.AppCenter.AppCenter.Start(typeof(Analytics), typeof(Crashes));
            MainPage = new SentimentPage();

        }

        
    }
}
