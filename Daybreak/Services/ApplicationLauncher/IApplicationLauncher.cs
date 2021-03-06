using System.Threading.Tasks;

namespace Daybreak.Services.ApplicationLauncher
{
    public interface IApplicationLauncher
    {
        bool IsGuildwarsRunning { get; }
        bool IsToolboxRunning { get; }
        bool IsTexmodRunning { get; }
        Task<bool> LaunchGuildwars();
        Task LaunchGuildwarsToolbox();
        Task LaunchTexmod();
        void RestartDaybreakAsAdmin();
    }
}
