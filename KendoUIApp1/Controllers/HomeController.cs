using Kendo.Mvc.UI;
using KendoUIApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KendoUIApp1.Controllers
{
    public class HomeController : Controller
    {
        private KendoDBEntities KendoDB = new KendoDBEntities();

        public virtual JsonResult ReadTasks([DataSourceRequest] DataSourceRequest request)
        {
            //return Json(taskService.GetAll().ToDataSourceResult(request));
            List<Task> tasks = KendoDB.Tasks.ToList();
            return Json(tasks);
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            List<Task> tasks = KendoDB.Tasks.ToList();
            return View(tasks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TaskView()
        {
            ViewBag.Message = "Your Task view page.";
            List < Task > tasks = KendoDB.Tasks.ToList();
            return View(tasks);
        }
    }
}
