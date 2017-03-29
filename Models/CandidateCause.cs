using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateCause
    {
        public long CandidateCauseId { get; set; }
        public long CandidateId { get; set; }
        public int CauseId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Cause Cause { get; set; }
    }
}
