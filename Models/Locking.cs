using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Locking
    {
        public Guid LockingId { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
