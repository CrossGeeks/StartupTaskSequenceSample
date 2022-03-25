using System.Collections.Generic;
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

            public async Task StartAsync()
            {
                foreach(var next in _tasks)
                {
                    if (await next.CanRunAsync())
                    {
                       await next.RunAsync();
                    }
                }
            }

            private readonly Queue<IStartupTask> _tasks;
        }
    }
}
