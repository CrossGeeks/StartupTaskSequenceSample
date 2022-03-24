using System.Windows.Input;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class LoginPage : ContentPage
    {
        public ICommand NextCommand { get; }
        public LoginPage()
        {
            InitializeComponent();
            NextCommand = new Command(async () =>
            {
                await Navigation.PushModalAsync(new AdvertisingPage(), false);
            });

            BindingContext = this;
        }
    }
}
