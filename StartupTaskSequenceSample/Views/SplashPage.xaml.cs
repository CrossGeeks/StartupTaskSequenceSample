using StartupTaskSequenceSample.Startup;
using StartupTaskSequenceSample.Startup.Tasks;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class SplashPage : ContentPage
    {
        IStartupTaskSequencer sequencer;

        public SplashPage()
        {
            InitializeComponent();

            sequencer = new StartupTaskBuilder()
                               .Add(new SimulateDownloadDataStartupTask())
                               .Add(new UpdateVersionStartupTask())
                               .Add(new OnboardingPage())
                               .Add(new PermissionRequestPage())
                               .Add(new LoginPage())
                               .Add(new AdvertisingPage())
                               .Add(new HomePage())
                               .Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await sequencer.StartAsync();
        }
    }
}
