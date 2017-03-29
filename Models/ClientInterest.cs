using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientInterest
    {
        public long ClientInterestId { get; set; }
        public long ClientId { get; set; }
        public long InterestId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUser { get; set; }

        public virtual Client Client { get; set; }
        public virtual Interest Interest { get; set; }
    }
}
