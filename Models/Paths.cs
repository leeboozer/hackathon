using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Paths
    {
        public Guid ApplicationId { get; set; }
        public Guid PathId { get; set; }
        public string Path { get; set; }
        public string LoweredPath { get; set; }

        public virtual Applications Application { get; set; }
    }
}
