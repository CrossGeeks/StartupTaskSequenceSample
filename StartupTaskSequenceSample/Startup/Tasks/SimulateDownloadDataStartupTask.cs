using System;
using System.Threading.Tasks;

namespace StartupTaskSequenceSample.Startup.Tasks
{
    public class SimulateDownloadDataStartupTask : IStartupTask
    {
        public Task<bool> CanRunAsync() => Task.FromResult(true);

        public async Task<IStartupTaskParameters> RunAsync(IStartupTaskParameters parameters)
        {
            await Task.Delay(5000);

            return StartupTaskParameters.None;
        }
    }
}
