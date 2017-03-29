using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientViewClientUser
    {
        public long ClientViewClientUserId { get; set; }
        public long ClientViewId { get; set; }
        public long ClientUserId { get; set; }

        public virtual ClientUser ClientUser { get; set; }
        public virtual ClientView ClientView { get; set; }
    }
}
