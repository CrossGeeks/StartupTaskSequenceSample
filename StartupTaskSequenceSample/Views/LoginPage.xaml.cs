using System.Windows.Input;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public partial class LoginPage : StartupPage
    {
        public ICommand NextCommand { get; }

        public LoginPage() : base()
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
