using Daybreak.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Extensions;
using System.IO;
using System.Windows.Extensions;
using System.Windows.Extensions.Services;

namespace Daybreak.Services.Options
{
    public sealed class JsonOptionsManager : IOptionsManager, IApplicationLifetimeService
    {
        private const string FilePath = "Daybreak.Options.json";

        private readonly ILogger<JsonOptionsManager> logger;

        private ConcurrentDictionary<string, string> Options { get; set; } = new();

        public JsonOptionsManager(
            ILogger<JsonOptionsManager> logger)
        {
            this.logger = logger.ThrowIfNull(nameof(logger));

            try
            {
                this.InitializeOptionsManager();
            }
            catch(Exception e)
            {
                this.logger.LogError(e, "Failed to load options! Running application with default options");
            }
        }

        public T GetOptions<T>() where T : class
        {
            var name = typeof(T).Name;
            if (this.Options.TryGetValue(name, out var value))
            {
                return value.Deserialize<T>();
            }

            return default;
        }

        public void UpdateOptions<T>(T value) where T : class
        {
            this.Options[typeof(T).Name] = value.Serialize();
        }

        public void OnStartup()
        {
        }

        public void OnClosing()
        {
            this.SaveOptions();
        }

        private void InitializeOptionsManager()
        {
            if (File.Exists(FilePath))
            {
                this.logger.LogInformation("Found options file. Deserializing");
                this.Options = File.ReadAllText(FilePath).Deserialize<ConcurrentDictionary<string, string>>();
                return;
            }

            this.logger.LogInformation("No options loaded. Running with default options");
            return;
        }

        private void SaveOptions()
        {
            File.WriteAllText(FilePath, this.Options.Serialize());
        }
    }
}
