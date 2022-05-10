using System.Collections.Generic;

namespace StartupTaskSequenceSample.Startup.Tasks
{
    public interface IStartupTaskParameters : IDictionary<string, object> {}

    public class StartupTaskParameters : Dictionary<string, object>, IStartupTaskParameters
    {
        public static IStartupTaskParameters None => _none ??= new StartupTaskParameters();

        private static IStartupTaskParameters _none;
    }
}
