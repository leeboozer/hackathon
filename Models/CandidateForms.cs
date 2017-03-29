using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateForms
    {
        public long CandidateFormId { get; set; }
        public long CandidateId { get; set; }
        public long FormId { get; set; }
        public DateTime Created { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual FormStore Form { get; set; }
    }
}
