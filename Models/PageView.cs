using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class PageView
    {
        public long PageViewId { get; set; }
        public string PageName { get; set; }
        public long? CandidateId { get; set; }
        public long? NpnOrderId { get; set; }
        public DateTime? ViewDate { get; set; }
    }
}
