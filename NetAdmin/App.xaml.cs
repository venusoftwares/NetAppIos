using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetAdmin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();      
        }

        protected override async void OnStart()
        {
            MainPage = new SplashScreen();
            // simple wait or initialize some services
           await Task.Delay(5000);
           MainPage = new XamWebView();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
