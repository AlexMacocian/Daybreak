using Microsoft.Extensions.Logging;
using Slim;
using System.Extensions;

namespace Daybreak.PostUpdateJobs
{
    public abstract class PostUpdateJobBase
    {
        protected IServiceManager ServiceManager { get; }
        protected ILogger Logger { get; }
        public abstract string Name { get; }
        
        public PostUpdateJobBase(IServiceManager serviceManager, ILogger logger)
        {
            this.ServiceManager = serviceManager.ThrowIfNull(nameof(serviceManager));
            this.Logger = logger.ThrowIfNull(nameof(logger));
        }

        public abstract void Execute();
    }
}
