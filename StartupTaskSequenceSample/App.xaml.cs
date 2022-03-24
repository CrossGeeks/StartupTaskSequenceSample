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

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
