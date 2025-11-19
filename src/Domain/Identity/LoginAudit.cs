using Arohan.TollSphere.Domain.Common.Entities;

namespace Arohan.TollSphere.Domain.Identity;
public class LoginAudit : BaseAuditableEntity
{
    public DateTime LoginTimeUtc { get; set; }
    public string UserId { get; set; }= string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string? IpAddress { get; set; }
    public string? BrowserInfo { get; set; }
    public string? Region { get; set; }
    public string? Provider { get; set; }
    public bool Success { get; set; } = true;
}
