using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIApp1.Models;
using KendoUIApp1.Models.Gantt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KendoUIApp1.Controllers
{
    public class HomeController : Controller
    {
        private KendoDBEntities KendoDB = new KendoDBEntities();

        private GanttTaskService taskService;

        public HomeController()
        {
            //taskService = new GanttTaskService();
        }

        /*************************
         * Gantt Task Methods
         ************************/
        
        public virtual JsonResult CreateTask([DataSourceRequest] DataSourceRequest request, Task task)
        {
            if (ModelState.IsValid)
            {
                KendoDB.Tasks.Add(task);
                KendoDB.SaveChanges();                
            }

            return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        }

        public virtual void UpdateTask(Task task)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(task.Title))
                {
                    task.Title = "";
                }

                KendoDB.Entry(task).State = EntityState.Modified;
                KendoDB.SaveChanges();
            }
        }

        public virtual JsonResult ReadTasks([DataSourceRequest] DataSourceRequest request)
        {
            List<Task> tasks = KendoDB.Tasks.ToList();
            return Json(tasks.ToDataSourceResult(request));
        }

        public virtual JsonResult DestroyTask([DataSourceRequest] DataSourceRequest request, Task task)
        {
            if (ModelState.IsValid)
            {
                Task taskForDeletion = KendoDB.Tasks.Find(task.TaskID);
                KendoDB.Tasks.Remove(taskForDeletion);
                KendoDB.SaveChanges();
            }

            return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        }

        /********************************
         * Gantt Dependency Methods 
         *******************************/

        public virtual JsonResult ReadDependencies([DataSourceRequest] DataSourceRequest request)
        {
            List<Dependency> dependencies = KendoDB.Dependencies.ToList();
            return Json(dependencies);

            //return Json(GanttDependencyService.GetAll().ToDataSourceResult(request));
        }

        /**************************
         * View Methods
         *************************/

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

        public ActionResult DependencyView()
        {
            ViewBag.Message = "Your dependency view page.";
            List<Dependency> dependencies = KendoDB.Dependencies.ToList();
            return View(dependencies);
        }
    }
}
