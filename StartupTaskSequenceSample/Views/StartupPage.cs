using System.Threading.Tasks;
using StartupTaskSequenceSample.Startup.Tasks;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public abstract class StartupPage : ContentPage, IStartupTask
    {
        protected virtual Task<bool> CanRunAsync() => Task.FromResult(true);

        protected async Task CompleteAsync()
        {
            await Navigation.PopModalAsync(false);

            _tcs?.SetResult(true);

        }

        Task<bool> IStartupTask.CanRunAsync() => CanRunAsync();

        async Task IStartupTask.RunAsync()
        {
            _tcs = new TaskCompletionSource<bool>();

            await App.Current.MainPage.Navigation.PushModalAsync(this);

            await _tcs.Task;
        }

        private TaskCompletionSource<bool> _tcs;
    }
}
