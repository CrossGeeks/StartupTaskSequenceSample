using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class PermissionRequestPage : StartupPage
    {
        public ICommand RequestPermissionCommand { get; }
        public PermissionRequestPage() : base()
        {
            InitializeComponent();

            RequestPermissionCommand = new Command(async()=> await RequestPermissionAsync());

            BindingContext = this;
        }

        async Task RequestPermissionAsync()
        {
            await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

            await CompleteAsync();
            // await Navigation.PushModalAsync(new LoginPage(), false);
        }

        protected override async Task<bool> CanRunAsync()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            return (status == PermissionStatus.Unknown || status == PermissionStatus.Restricted);
        }
    }
}
