using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientSkill
    {
        public long ClientSkillId { get; set; }
        public long ClientId { get; set; }
        public long SkillId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUser { get; set; }

        public virtual Client Client { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
