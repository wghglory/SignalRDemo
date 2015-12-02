using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRKnockoutDemo.Hubs
{
    [HubName("widgets")]
    public class WidgetHub : Hub { }
}