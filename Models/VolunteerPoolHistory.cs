using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class VolunteerPoolHistory
    {
        public long VolunteerPoolHistoryId { get; set; }
        public long? VolunteerPoolId { get; set; }
        public long? CandidateId { get; set; }
        public long? ClientId { get; set; }
        public string ClientUserName { get; set; }
        public string PositionName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CommunicationTypeId { get; set; }
        public string AttachmentNames { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual VolunteerPool VolunteerPool { get; set; }
    }
}
