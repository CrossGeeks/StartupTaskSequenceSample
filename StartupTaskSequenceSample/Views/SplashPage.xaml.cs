using StartupTaskSequenceSample.Startup;
using StartupTaskSequenceSample.Startup.Tasks;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class SplashPage : ContentPage
    {
        IStartupTaskSequencer sequencer;
        HomePage homePage = new HomePage();

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
                               .Add(homePage)
                               .Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //Uncomment this line to start in Home page
            //await sequencer.StartAsync(homePage);

            await sequencer.StartAsync();
        }
    }
}
