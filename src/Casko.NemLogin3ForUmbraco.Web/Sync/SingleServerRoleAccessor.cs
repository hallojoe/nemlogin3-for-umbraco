using Umbraco.Cms.Core.Sync;

namespace Casko.NemLogin3ForUmbraco.Web.Sync;

public class SingleServerRoleAccessor : IServerRoleAccessor
{
    public ServerRole CurrentServerRole => ServerRole.Single;
}