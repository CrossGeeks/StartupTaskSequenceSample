using System;
using System.Threading.Tasks;

namespace StartupTaskSequenceSample.Startup.Tasks
{
    public class SimulateDownloadDataStartupTask : IStartupTask
    {
        public Task<bool> CanRunAsync() => Task.FromResult(true);

        public Task RunAsync() => Task.Delay(5000);
    }
}
