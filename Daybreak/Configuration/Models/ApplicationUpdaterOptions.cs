using Daybreak.Attributes;

namespace Daybreak.Configuration.Models
{
    [NamedOptions("Updater Options")]
    public class ApplicationUpdaterOptions : IOptionsSection
    {
        [NamedOption("Auto-update")]
        public bool AutoUpdate { get; set; }
    }
}
