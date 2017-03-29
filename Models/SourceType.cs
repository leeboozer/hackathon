using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SourceType
    {
        public SourceType()
        {
            JurisOrder = new HashSet<JurisOrder>();
            JurisUpdate = new HashSet<JurisUpdate>();
        }

        public int SourceTypeId { get; set; }
        public string Source { get; set; }

        public virtual ICollection<JurisOrder> JurisOrder { get; set; }
        public virtual ICollection<JurisUpdate> JurisUpdate { get; set; }
    }
}
