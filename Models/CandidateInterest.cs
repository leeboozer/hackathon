using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateInterest
    {
        public long CandidateInterestId { get; set; }
        public long CandidateId { get; set; }
        public long InterestId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Interest Interest { get; set; }
    }
}
