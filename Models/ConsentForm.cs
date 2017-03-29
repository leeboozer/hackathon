using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ConsentForm
    {
        public int ConsentFormId { get; set; }
        public long NpnProductId { get; set; }
        public string StateCode { get; set; }
        public string MvcArea { get; set; }
        public string MvcController { get; set; }
        public string MvcAction { get; set; }
        public long? FormId { get; set; }
        public bool? UseInVolunteerOrdering { get; set; }
        public bool? UseInClientOrdering { get; set; }

        public virtual NpnProduct NpnProduct { get; set; }
    }
}
