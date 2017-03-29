using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateEmailOption
    {
        public long CandidateId { get; set; }
        public int EtemplateId { get; set; }
        public bool SendEmail { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual EmailTemplate Etemplate { get; set; }
    }
}
