using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SecurityQuestions
    {
        public SecurityQuestions()
        {
            CandidateSecurityQuestions = new HashSet<CandidateSecurityQuestions>();
        }

        public long SecurityQuestionId { get; set; }
        public string Question { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CandidateSecurityQuestions> CandidateSecurityQuestions { get; set; }
    }
}
