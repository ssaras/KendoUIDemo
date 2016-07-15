using KendoUIApp1.Models.Gantt;
using KendoUIApp1.Models;

namespace KendoUIApp1.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Kendo.Mvc.UI;
    using System;
    using System.Data;
    using KendoUIApp1.Models;
    using System.Collections.Generic;

    public class GanttTaskService
    {
        private KendoDBEntities KendoDB = new KendoDBEntities();

        public virtual /*IQueryable<TaskViewModel>*/ List<task> GetAll()
        {
            List<task> tasks = KendoDB.tasks.ToList();
            return (tasks);
        }
    }
}