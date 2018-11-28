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
            Microsoft.AppCenter.AppCenter.Start("android=491b6faf-4f53-4bc9-bae9-83b0c4e5ca34;" + typeof(Analytics), typeof(Crashes));
            MainPage = new SentimentPage();

        }

        
    }
}
