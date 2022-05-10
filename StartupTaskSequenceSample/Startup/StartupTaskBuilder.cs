using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StartupTaskSequenceSample.Startup.Tasks;

namespace StartupTaskSequenceSample.Startup
{
    public class StartupTaskBuilder
    {
        public StartupTaskBuilder() => _tasks = new Queue<IStartupTask>();

        public StartupTaskBuilder Add(IStartupTask task)
        {
            QueueTask(task);

            return this;
        }

        public IStartupTaskSequencer Build() => new StartupTaskSequencer(_tasks);

        private void QueueTask(IStartupTask task) => _tasks.Enqueue(task);

        private readonly Queue<IStartupTask> _tasks;

        private class StartupTaskSequencer : IStartupTaskSequencer
        {
            public StartupTaskSequencer(Queue<IStartupTask> tasks) => _tasks = tasks;

            public async Task StartAsync(IStartupTask task, IStartupTaskParameters parameters = null)
            {
                parameters ??= StartupTaskParameters.None;

                foreach (var next in _tasks.SkipWhile(x => x != task))
                {
                    if (await next.CanRunAsync())
                    {
                        parameters = await next.RunAsync(parameters);
                    }
                }
            }

            public Task StartAsync() => StartAsync(_tasks.FirstOrDefault());

            private readonly Queue<IStartupTask> _tasks;
        }
    }
}
