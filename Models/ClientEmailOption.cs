using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientEmailOption
    {
        public long ClientId { get; set; }
        public int EtemplateId { get; set; }
        public bool SendEmail { get; set; }

        public virtual Client Client { get; set; }
        public virtual EmailTemplate Etemplate { get; set; }
    }
}
