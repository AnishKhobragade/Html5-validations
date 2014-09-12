using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Html5_Validations.Startup))]
namespace Html5_Validations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
