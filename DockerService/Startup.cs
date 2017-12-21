using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Hangfire;
using Owin;

namespace DockerService
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         GlobalConfiguration.Configuration.UseSqlServerStorage(ConfigurationManager.ConnectionStrings["DockerConnection"].ConnectionString);
         app.UseHangfireDashboard();
         //app.UseHangfireServer();
      }
   }
}