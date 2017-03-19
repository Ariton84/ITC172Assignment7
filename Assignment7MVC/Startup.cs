using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment7MVC.Startup))]
namespace Assignment7MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
