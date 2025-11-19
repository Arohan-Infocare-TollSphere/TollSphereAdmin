using System.ComponentModel;

namespace Arohan.TollSphere.Server.UI.Models.NavigationMenu;

public enum PageStatus
{
    [Description("Coming Soon")] ComingSoon,
    [Description("WIP")] Wip,
    [Description("New")] New,
    [Description("Completed")] Completed
}
