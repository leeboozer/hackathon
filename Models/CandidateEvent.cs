using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateEvent
    {
        public long CandidateEventId { get; set; }
        public long CandidateId { get; set; }
        public long ClientId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
    }
}
