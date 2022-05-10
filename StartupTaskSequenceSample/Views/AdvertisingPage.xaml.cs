using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class AdvertisingPage : StartupPage
    {
        public ICommand NextCommand { get; }
        public AdvertisingPage()
        {
            InitializeComponent();
            NextCommand = new Command(async () =>
            {
                await CompleteAsync();
            });

            BindingContext = this;
        }

        protected override Task<bool> CanRunAsync() => Task.FromResult(App.VersionType == VersionType.Free);
    }
}
