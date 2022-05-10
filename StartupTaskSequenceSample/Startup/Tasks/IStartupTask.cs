using System.Threading.Tasks;

namespace StartupTaskSequenceSample.Startup.Tasks
{
    public interface IStartupTask
    {
        Task<bool> CanRunAsync();

        Task<IStartupTaskParameters> RunAsync(IStartupTaskParameters parameters);
    }
}
