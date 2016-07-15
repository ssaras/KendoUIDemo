using KendoUIApp1.Models;
using System.Collections.Generic;
using System.Linq;

namespace KendoUIApp1.Models.Gantt
{
    public class GanttDependencyService
    {
        private KendoDBEntities KendoDB = new KendoDBEntities();

        public virtual /*IQueryable<DependencyViewModel>*/ List<Dependency> GetAll()
        {

            List<Dependency> dependencies = KendoDB.Dependencies.ToList();
            return (dependencies);

            //return db.GanttDependencies.ToList().Select(dependency => new DependencyViewModel
            //{
            //    DependencyID = dependency.ID,
            //    PredecessorID = dependency.PredecessorID,
            //    SuccessorID = dependency.SuccessorID,
            //    Type = (DependencyType)dependency.Type
            //}).AsQueryable();
        }
    }
}