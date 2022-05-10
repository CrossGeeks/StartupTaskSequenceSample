using System.Threading.Tasks;
using StartupTaskSequenceSample.Startup.Tasks;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class HomePage : TabbedPage, IStartupTask
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public Task<bool> CanRunAsync() => Task.FromResult(true);

        public async Task<IStartupTaskParameters> RunAsync(IStartupTaskParameters parameters)
        {
            if (parameters.TryGetValue("Name", out var name))
            {
                await App.Current.MainPage.DisplayAlert("Welcome!", name?.ToString(), "Ok");
            }

            await App.Current.MainPage.Navigation.PushModalAsync(this);

            return StartupTaskParameters.None;
        }
    }
}
