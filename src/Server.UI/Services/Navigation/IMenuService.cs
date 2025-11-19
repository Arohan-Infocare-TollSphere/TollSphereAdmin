using Arohan.TollSphere.Server.UI.Models.NavigationMenu;

namespace Arohan.TollSphere.Server.UI.Services.Navigation;

public interface IMenuService
{
    IEnumerable<MenuSectionModel> Features { get; }
}
