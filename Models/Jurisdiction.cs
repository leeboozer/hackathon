using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Jurisdiction
    {
        public Jurisdiction()
        {
            JurisOrder = new HashSet<JurisOrder>();
            JurisUpdate = new HashSet<JurisUpdate>();
        }

        public int JurisId { get; set; }
        public byte JurisType { get; set; }
        public string JurisRoot { get; set; }
        public string JurisDesc { get; set; }

        public virtual ICollection<JurisOrder> JurisOrder { get; set; }
        public virtual ICollection<JurisUpdate> JurisUpdate { get; set; }
    }
}
