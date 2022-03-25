using System.Threading.Tasks;

namespace StartupTaskSequenceSample.Startup.Tasks
{
    public class UpdateVersionStartupTask : IStartupTask
    {
        public Task<bool> CanRunAsync() => Task.FromResult(true);

        public Task RunAsync()
        {
            //TODO: Do Store version code here, can't do it since this app is not in the store
            return App.Current.MainPage.DisplayAlert("New Version", "There is a new version of this app available. Would you like to update now?", "Yes", "No");
        }
    }
}
