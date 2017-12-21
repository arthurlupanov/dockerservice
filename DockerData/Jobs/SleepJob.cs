using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DockerData.Entities;

namespace DockerData.Jobs
{
   public class SleepJob
   {
      public void DoTheJob()
      {
         var _timeToSleepMS = 1000 * 60;
         //TODO: use IoC http://docs.hangfire.io/en/latest/background-methods/using-ioc-containers.html
         Thread.Sleep(_timeToSleepMS);
         using (var context = new DockerContext())
         {
            var jobResult = new JobResult()
            {
               CreateDate = DateTime.UtcNow,
               MachineName = System.Environment.MachineName,
               Result = $"I've Slept for {_timeToSleepMS} ms"
            };
            context.JobResults.Add(jobResult);
            context.SaveChanges();            
         }
      }
   }
}
