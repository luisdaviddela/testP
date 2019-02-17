using Plugin.Connectivity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CFEApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                MainPage = new NavigationPage(new OffLineApp());
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                MainPage = new NavigationPage(new OffLineApp());
            }
        }
    }
}
