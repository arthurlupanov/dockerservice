using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DockerData;
using DockerData.Jobs;
using DockerService.Models;
using Hangfire;
using Newtonsoft.Json;

namespace DockerService.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         ViewBag.VisitCount = 1;
         string ipAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
         if (string.IsNullOrEmpty(ipAddress))
         {
            ipAddress = Request.ServerVariables["REMOTE_ADDR"];
         }
         using (var context = new DockerContext())
         {
            var visit = new DockerData.Entities.Visit()
            {
               IPAddress = ipAddress,
               CreateDate = DateTime.UtcNow
            };
            context.Visits.Add(visit);
            context.SaveChanges();
            ViewBag.VisitCount = context.Visits.Count();
         }
         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = System.Environment.OSVersion.ToString();
         ViewBag.MachineName = System.Environment.MachineName;
         ViewBag.Packages = typeof(JsonConvert).FullName;
         return View();
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }

      public ActionResult JobResults()
      {
         using (var context = new DockerContext())
         {
            var allJobResults = context.JobResults.ToList().Select(jr => new JobResultViewModel(jr)).OrderByDescending(r => r.Created).ToList();
            return View(allJobResults);
         }         
      }

      [HttpPost]
      public ActionResult AddJob()
      {
         BackgroundJob.Enqueue<SleepJob>(x => x.DoTheJob());
         return new JsonResult()
         {
            Data = new
            {
               success = true
            }
         };
      }
   }
}