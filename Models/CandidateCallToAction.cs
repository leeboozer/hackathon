using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateCallToAction
    {
        public long CandidateCallToActionId { get; set; }
        public long CandidateId { get; set; }
        public long CallToActionId { get; set; }
        public int SessionCount { get; set; }
        public bool ActionTaken { get; set; }
        public DateTime DateShownInitially { get; set; }
        public DateTime? DateActionTaken { get; set; }

        public virtual CallToAction CallToAction { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
