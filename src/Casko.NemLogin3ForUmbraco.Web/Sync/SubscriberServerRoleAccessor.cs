using Umbraco.Cms.Core.Sync;

namespace Casko.NemLogin3ForUmbraco.Web.Sync;

public class SubscriberServerRoleAccessor : IServerRoleAccessor
{
    public ServerRole CurrentServerRole => ServerRole.Subscriber;
}