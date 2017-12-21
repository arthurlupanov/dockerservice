using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerData.Entities
{
   [Table("Visits")]
   public class Visit
   {
      [Index]
      public int Id { get; set; }
      public DateTime CreateDate { get; set; }
      public string IPAddress { get; set; }
   }
}
