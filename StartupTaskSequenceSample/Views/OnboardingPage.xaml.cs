using System.Windows.Input;
using StartupTaskSequenceSample.Startup.Tasks;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class OnboardingPage : StartupPage
    {
        public ICommand NextCommand { get; }
        public OnboardingPage()
        {
            InitializeComponent();
            NextCommand = new Command(async() =>
            {
                await CompleteAsync();
            });

            BindingContext = this;
        }
    }
}
