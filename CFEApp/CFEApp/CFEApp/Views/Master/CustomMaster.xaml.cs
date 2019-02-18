using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace CFEApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomMaster : MasterDetailPage
    {
        public CustomMaster()
        {
            InitializeComponent();
            App.MasterDetail = this;
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}