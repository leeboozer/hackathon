using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Cloud
    {
        public long CloudId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual Users User { get; set; }
    }
}
