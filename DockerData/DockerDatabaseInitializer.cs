using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerData
{
   public static class DockerDatabaseInitializer
   {
      public static void Initialize()
      {
         Database.SetInitializer(new DockerContextInitializer());
         using (var db = new DockerContext())
         {
            {
               db.Database.Initialize(false);
            }
         }
      }
   }
}
