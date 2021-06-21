using Daybreak.Attributes;

namespace Daybreak.Configuration.Models
{
    [NamedOptions("Launcher Options")]
    public sealed class ApplicationLaunchOptions : IOptionsSection
    {
        [NamedOption("Desired screen id")]
        public int DesiredScreen { get; set; }
        [NamedOption("Place on desired screen")]
        public bool SetGuildwarsWindowSizeOnLaunch { get; set; }
        [NamedOption("Path to GWToolbox executable")]
        public string ToolboxPath { get; set; }
        [NamedOption("Path to Texmod executable")]
        public string TexmodPath { get; set; }
        [NamedOption("Launch GWToolbox on startup")]
        public bool ToolboxAutoLaunch { get; set; }
    }
}
