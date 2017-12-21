using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DockerData;
using Hangfire;

namespace DockerWorker
{
   class Program
   {
      static void Main(string[] args)
      {
         DockerDatabaseInitializer.Initialize();
         GlobalConfiguration.Configuration.UseSqlServerStorage(ConfigurationManager.ConnectionStrings["DockerConnection"].ConnectionString);
         //Limit to 1 job a time for better test
         var backgroundServerOptions = new BackgroundJobServerOptions()
         {
            WorkerCount = 1
         };
         using (var server = new BackgroundJobServer(backgroundServerOptions))
         {
            Console.WriteLine("Hangfire Server started. Press any key to exit...");
            Thread.Sleep(Timeout.Infinite);
         }
      }
   }
}
