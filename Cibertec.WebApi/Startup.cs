using System;
using System.Threading.Tasks;
using System.Web.Http;
using Cibertec.WebApi.App_Start;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Cibertec.WebApi.Startup))]

namespace Cibertec.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            DIConfig.ConfigureInjector(config);
            TokenConfig.ConfigureOAuth(app, config);
            RouteConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
