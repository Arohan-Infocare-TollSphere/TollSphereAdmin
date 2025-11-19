using Arohan.TollSphere.Application.Features.Identity.DTOs;
using Arohan.TollSphere.Domain.Identity;
using ZiggyCreatures.Caching.Fusion;

namespace Arohan.TollSphere.Infrastructure.Services.Identity;

public class RoleDataSourceService : DataSourceServiceBase<ApplicationRoleDto>, IDisposable
{
    private const string CACHEKEY = "ALL-ApplicationRoleDto";
    private readonly IMapper _mapper;
    private readonly IServiceScopeFactory _scopeFactory;

    public RoleDataSourceService(
        IMapper mapper,
        IFusionCache fusionCache,
        IServiceScopeFactory scopeFactory)
        : base(fusionCache, CACHEKEY)
    {
        _mapper = mapper;
        _scopeFactory = scopeFactory;
    }

    protected override async Task<List<ApplicationRoleDto>?> LoadAsync(CancellationToken cancellationToken)
    {
        using var scope = _scopeFactory.CreateScope();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
        return await roleManager.Roles
            .ProjectTo<ApplicationRoleDto>(_mapper.ConfigurationProvider)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
