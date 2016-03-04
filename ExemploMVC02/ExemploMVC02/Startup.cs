using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploMVC02.Startup))]
namespace ExemploMVC02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
