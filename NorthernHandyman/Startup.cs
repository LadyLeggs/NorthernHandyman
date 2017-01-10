using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthernHandyman.Startup))]
namespace NorthernHandyman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
