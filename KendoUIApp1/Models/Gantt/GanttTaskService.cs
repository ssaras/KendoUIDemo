using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using System;
using System.Data;
using KendoUIApp1.Models;
using System.Collections.Generic;


namespace KendoUIApp1.Models.Gantt
{
    public class GanttTaskService
    {
        private KendoDBEntities KendoDB = new KendoDBEntities();

        public virtual /*IQueryable<TaskViewModel>*/ List<Task> GetAll()
        {
            List<Task> tasks = KendoDB.Tasks.ToList();
            return (tasks);
        }
    }
}