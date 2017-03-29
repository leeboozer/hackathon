using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderReportView
    {
        public long OrderReportViewId { get; set; }
        public long NpnOrderId { get; set; }
        public long UserId { get; set; }
        public string UserType { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
    }
}
