using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DockerData.Entities;

namespace DockerData
{
   public class DockerContext: DbContext
   {
      public DockerContext() : base("DockerConnection")
      {
         Database.SetInitializer(new DockerContextInitializer());
      }

      public DbSet<Visit> Visits { get; set; }
      public DbSet<JobResult> JobResults { get; set; }
   }
}
