using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class MaintenanceWindow
    {
        public long MaintenanceWindowId { get; set; }
        public string Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RecurringType { get; set; }
        public bool CreatedByAutomation { get; set; }
        public int? ErrorType { get; set; }
    }
}
