using System.Threading.Tasks;

namespace StartupTaskSequenceSample.Startup
{
    public interface IStartupTaskSequencer
    {
        Task StartAsync();
    }
}
