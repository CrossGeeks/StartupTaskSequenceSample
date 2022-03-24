using System.Windows.Input;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class AdvertisingPage : ContentPage
    {
        public ICommand NextCommand { get; }
        public AdvertisingPage()
        {
            InitializeComponent();
            NextCommand = new Command(async () =>
            {
                await Navigation.PushModalAsync(new HomePage(), false);
            });

            BindingContext = this;
        }
    }
}
