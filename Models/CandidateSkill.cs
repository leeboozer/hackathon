using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateSkill
    {
        public long CandidateSkillId { get; set; }
        public long CandidateId { get; set; }
        public long SkillId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
