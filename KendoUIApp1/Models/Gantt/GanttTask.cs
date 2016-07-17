using System;

namespace KendoUIApp1.Models.Gantt
{
    internal class GanttTask : GanttTaskService
    {
        public DateTime End { get; set; }
        public bool Expanded { get; set; }
        public int ID { get; set; }
        public int OrderID { get; set; }
        public decimal PercentComplete { get; set; }
        public DateTime Start { get; set; }
        public bool Summary { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
    }
}