using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Cause
    {
        public Cause()
        {
            CandidateCause = new HashSet<CandidateCause>();
        }

        public int CauseId { get; set; }
        public string CauseName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CandidateCause> CandidateCause { get; set; }
    }
}
