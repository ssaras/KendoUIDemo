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

        public virtual void Insert(TaskViewModel task, ModelStateDictionary modelState)
        {
            if (ValidateModel(task, modelState))
            {
                //List<Task> tasks = KendoDB.Tasks.ToList();

                //var db = KendoDB.Tasks;

                //if (string.IsNullOrEmpty(task.Title))
                //{
                //    task.Title = "";
                //}

                //var entity = task.ToEntity();

                //db.Add(entity);
                //db.SaveChanges();

                //task.TaskID = entity.ID;
            }
        }

        private bool ValidateModel(TaskViewModel task, ModelStateDictionary modelState)
        {
            if (task.Start > task.End)
            {
                modelState.AddModelError("errors", "End date must be greater or equal to Start date.");
                return false;
            }

            return true;
        }
    }
}