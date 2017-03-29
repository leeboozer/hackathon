using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Skill
    {
        public Skill()
        {
            CandidateSkill = new HashSet<CandidateSkill>();
            ClientSkill = new HashSet<ClientSkill>();
        }

        public long SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillCategory { get; set; }

        public virtual ICollection<CandidateSkill> CandidateSkill { get; set; }
        public virtual ICollection<ClientSkill> ClientSkill { get; set; }
    }
}
