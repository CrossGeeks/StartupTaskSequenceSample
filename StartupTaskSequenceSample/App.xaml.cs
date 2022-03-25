using StartupTaskSequenceSample.Views;
using Xamarin.Forms;

namespace StartupTaskSequenceSample
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new SplashPage();
        }
    }
}
