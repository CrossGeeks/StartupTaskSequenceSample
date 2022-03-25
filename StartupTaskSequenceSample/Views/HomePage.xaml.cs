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

        public Task RunAsync() => App.Current.MainPage.Navigation.PushModalAsync(this);

    }
}
