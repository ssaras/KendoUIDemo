//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KendoUIApp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int TaskID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public Nullable<bool> Summary { get; set; }
        public Nullable<bool> Expanded { get; set; }
        public Nullable<decimal> PercentComplete { get; set; }
        public Nullable<int> OrderId { get; set; }
    }
}