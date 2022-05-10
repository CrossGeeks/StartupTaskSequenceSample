using System.Threading.Tasks;
using StartupTaskSequenceSample.Startup.Tasks;
using Xamarin.Forms;

namespace StartupTaskSequenceSample.Views
{
    public abstract class StartupPage : ContentPage, IStartupTask
    {
        protected virtual Task<bool> CanRunAsync() => Task.FromResult(true);

        protected async Task CompleteAsync(IStartupTaskParameters parameters = null)
        {
            await Navigation.PopModalAsync(false);

            _tcs?.SetResult(parameters ?? StartupTaskParameters.None);

        }

        Task<bool> IStartupTask.CanRunAsync() => CanRunAsync();

        protected virtual Task OnStartAsync(IStartupTaskParameters parameters)
        {
            return Task.CompletedTask;
        }

        async Task<IStartupTaskParameters> IStartupTask.RunAsync(IStartupTaskParameters parameters)
        {
            _tcs = new TaskCompletionSource<IStartupTaskParameters>();

            await OnStartAsync(parameters);

            await App.Current.MainPage.Navigation.PushModalAsync(this);

            return await _tcs.Task;
        }

        private TaskCompletionSource<IStartupTaskParameters> _tcs;
    }
}
