using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientStates
    {
        public long ClientStateId { get; set; }
        public long ClientId { get; set; }
        public string StateCode { get; set; }

        public virtual Client Client { get; set; }
        public virtual States StateCodeNavigation { get; set; }
    }
}
