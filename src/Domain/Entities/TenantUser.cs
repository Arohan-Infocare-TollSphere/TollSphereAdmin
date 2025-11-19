using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arohan.TollSphere.Domain.Common.Entities;
using Arohan.TollSphere.Domain.Identity;

namespace Arohan.TollSphere.Domain.Entities;

public class TenantUser:IEntity<string>
{
    public string Id { get; set; }=Guid.CreateVersion7().ToString();
    public string? TenantId { get; set; }
    public Tenant? Tenant { get; set; }
    public string? UserId { get; set; }
    public ApplicationUser? User { get; set; }
}
