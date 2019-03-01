using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataWere.Startup))]
namespace DataWere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
