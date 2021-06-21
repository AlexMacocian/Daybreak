using Daybreak.Attributes;

namespace Daybreak.Configuration.Models
{
    [NamedOptions("Browsers")]
    public sealed class BrowserOptions : IOptionsSection
    {
        [NamedOption("Browsers enabled")]
        public bool BrowsersEnabled { get; set; }
        [NamedOption("Left browser default page")]
        public string LeftBrowserDefault { get; set; }
        [NamedOption("Right browser default page")]
        public string RightBrowserDefault { get; set; }
    }
}
