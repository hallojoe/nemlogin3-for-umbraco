using Umbraco.Cms.Core.Sync;

namespace Casko.NemLogin3ForUmbraco.Web.Sync;

public class SchedulingPublisherServerRoleAccessor : IServerRoleAccessor
{
    public ServerRole CurrentServerRole => ServerRole.SchedulingPublisher;
}