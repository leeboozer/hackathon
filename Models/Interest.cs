using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Interest
    {
        public Interest()
        {
            CandidateInterest = new HashSet<CandidateInterest>();
            ClientInterest = new HashSet<ClientInterest>();
        }

        public long InterestId { get; set; }
        public string InterestName { get; set; }
        public string InterestCategory { get; set; }

        public virtual ICollection<CandidateInterest> CandidateInterest { get; set; }
        public virtual ICollection<ClientInterest> ClientInterest { get; set; }
    }
}
