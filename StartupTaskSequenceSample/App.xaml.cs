using StartupTaskSequenceSample.Views;
using Xamarin.Forms;

namespace StartupTaskSequenceSample
{
    public partial class App : Application
    {
        public static VersionType VersionType => VersionType.Paid;

        public App ()
        {
            InitializeComponent();

            MainPage = new SplashPage();
        }
    }


    public enum VersionType
    {
        Free,
        Paid
    }


}
