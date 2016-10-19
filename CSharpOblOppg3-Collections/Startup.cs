using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpOblOppg3_Collections.Startup))]
namespace CSharpOblOppg3_Collections
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
