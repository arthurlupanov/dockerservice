using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DockerData.Entities;

namespace DockerService.Models
{
   public class JobResultViewModel
   {
      public DateTime Created { get; set; }
      public string MachineName { get; set; }
      public string Result { get; set; }

      public JobResultViewModel(JobResult jobResult)
      {
         Created = jobResult.CreateDate;
         MachineName = jobResult.MachineName;
         Result = jobResult.Result;
      }
   }
}