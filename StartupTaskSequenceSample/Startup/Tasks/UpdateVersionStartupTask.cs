using System.Threading.Tasks;

namespace StartupTaskSequenceSample.Startup.Tasks
{
    public class UpdateVersionStartupTask : IStartupTask
    {
        public Task<bool> CanRunAsync() => Task.FromResult(true);

        public async Task<IStartupTaskParameters> RunAsync(IStartupTaskParameters parameters)
        {
            //TODO: Do Store version code here, can't do it since this app is not in the store
           await  App.Current.MainPage.DisplayAlert("New Version", "There is a new version of this app available. Would you like to update now?", "Yes", "No");

            return StartupTaskParameters.None;
        }
    }
}
