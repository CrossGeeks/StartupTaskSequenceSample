using System.Windows.Input;
using StartupTaskSequenceSample.Startup.Tasks;
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
                await CompleteAsync(new StartupTaskParameters()
                {
                    {"Name" , userNameEntry.Text }
                });
            });

            BindingContext = this;
        }
    }
}
