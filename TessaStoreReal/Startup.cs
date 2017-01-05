using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TessaStoreReal.Startup))]
namespace TessaStoreReal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
