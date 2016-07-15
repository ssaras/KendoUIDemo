namespace KendoUIApp1.Models.Gantt
{
    internal class GanttDependency : GanttDependencyService
    {
        public int ID { get; set; }
        public int PredecessorID { get; set; }
        public int SuccessorID { get; set; }
        public int Type { get; set; }
    }
}