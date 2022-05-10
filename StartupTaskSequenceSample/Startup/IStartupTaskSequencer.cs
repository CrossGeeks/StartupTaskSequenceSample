using System.Threading.Tasks;
using StartupTaskSequenceSample.Startup.Tasks;

namespace StartupTaskSequenceSample.Startup
{
    public interface IStartupTaskSequencer
    {
        Task StartAsync();

        Task StartAsync(IStartupTask task, IStartupTaskParameters parameters = null);
    }
}
