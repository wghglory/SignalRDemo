using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRKnockoutDemo.Startup))]
namespace SignalRKnockoutDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}