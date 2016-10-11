using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using Part1.Api.App_Start;

[assembly: OwinStartup(typeof(Part1.Api.Startup))]

namespace Part1.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = UnityConfig.RegisterComponents(app.GetDataProtectionProvider());
            ConfigureAuth(app);
        }
    }
}
