using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MS.Hackathon.Startup))]
namespace MS.Hackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
