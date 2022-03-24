using System.Threading.Tasks;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            LoadNextPage();
        }

        async Task LoadNextPage()
        {
            await Task.Delay(5000);
            await UpdateAppVersion();
            await Navigation.PushModalAsync(new OnboardingPage(), false);
        }

        private async Task UpdateAppVersion()
        {
            //TODO: Do Store version code here, can't do it since this app is not in the store
            await DisplayAlert("New Version", "There is a new version of this app available. Would you like to update now?", "Yes", "No");
        }
    }
}
