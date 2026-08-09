using System.Security.Claims;

namespace Casko.NemLogin3ForUmbraco.Services;

public interface INemLogin3BackOfficeClaimsMapper
{
    ClaimsPrincipal Map(ClaimsPrincipal principal);
}
