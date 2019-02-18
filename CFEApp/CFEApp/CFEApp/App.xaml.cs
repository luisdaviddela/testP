using Plugin.Connectivity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AndroidSpecific = Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CFEApp
{
    public partial class App : Application
    {
        public static CustomMaster MasterDetail { get; set; }
        public App()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("IsLoggedIn"))
            {
                var LogedAppProp = Application.Current.Properties["IsLoggedIn"];
                bool isLoggedIn = Convert.ToBoolean(LogedAppProp);
                if (isLoggedIn)
                {
                    MainPage = new NavigationPage(new CustomMaster());
                }
                else
                {
                    MainPage = new LoginPage();
                }
            }
            else
            {

                MainPage = new LoginPage();
            }
            AndroidSpecific.Application.SetWindowSoftInputModeAdjust(this,AndroidSpecific.WindowSoftInputModeAdjust.Resize);
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
