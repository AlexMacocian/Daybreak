using Daybreak.Configuration.Models;
using Daybreak.Utils;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Slim;
using System;
using System.IO;
using System.Windows.Extensions;

namespace Daybreak.PostUpdateJobs
{
    public sealed class MigrateConfigurationToOptions : PostUpdateJobBase
    {
        private const string ConfigPath = "Daybreak.config.json";
        private readonly IOptionsManager optionsManager;

        public MigrateConfigurationToOptions(IServiceManager serviceManager, ILogger logger) : base(serviceManager, logger)
        {
            this.optionsManager = serviceManager.GetService<IOptionsManager>();
        }

        public override string Name => nameof(MigrateConfigurationToOptions);

        public override void Execute()
        {
            if (File.Exists(ConfigPath))
            {
                this.Logger.LogInformation($"Loading options from {ConfigPath}");
                var config = File.ReadAllText(ConfigPath).Deserialize<JObject>();
                this.LoadUpdaterConfig(config);
            }
        }

        private void LoadUpdaterConfig(JObject jObject)
        {
            var option = new ApplicationUpdaterOptions();
            if (jObject.TryGetValue("AutoCheckUpdate", out var autoCheckUpdate))
            {
                option.AutoUpdate = autoCheckUpdate.ToObject<bool>();
            }

            this.optionsManager.UpdateOptions(option);
        }
    }
}
