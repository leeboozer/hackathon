using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateSecurityQuestions
    {
        public long CandidateSecQuestId { get; set; }
        public long CandidateId { get; set; }
        public long SecurityQuestionId { get; set; }
        public string SecurityAnswer { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual SecurityQuestions SecurityQuestion { get; set; }
    }
}
