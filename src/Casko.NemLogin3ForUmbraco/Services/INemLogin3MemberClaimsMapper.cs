using System.Security.Claims;

namespace Casko.NemLogin3ForUmbraco.Services;

public interface INemLogin3MemberClaimsMapper
{
    ClaimsPrincipal Map(ClaimsPrincipal principal);
}
