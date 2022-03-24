using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class PermissionRequestPage : ContentPage
    {
        public ICommand RequestPermissionCommand { get; }
        public PermissionRequestPage()
        {
            InitializeComponent();

            RequestPermissionCommand = new Command(async()=> await RequestPermissionAsync());

            BindingContext = this;
        }

        async Task RequestPermissionAsync()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status != PermissionStatus.Granted)
            {
                await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }
            await Navigation.PushModalAsync(new LoginPage(), false);
        }
    }
}
