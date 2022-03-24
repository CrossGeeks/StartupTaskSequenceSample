using System.Windows.Input;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class OnboardingPage : ContentPage
    {
        public ICommand NextCommand { get; }
        public OnboardingPage()
        {
            InitializeComponent();
            NextCommand = new Command(async() =>
            {
                await Navigation.PushModalAsync(new PermissionRequestPage(), false);
            });

            BindingContext = this;
        }
    }
}
