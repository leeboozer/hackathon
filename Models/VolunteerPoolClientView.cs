using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class VolunteerPoolClientView
    {
        public long VolunteerPoolClientViewId { get; set; }
        public long VolunteerPoolId { get; set; }
        public long ClientViewId { get; set; }
        public long? CandidateId { get; set; }
        public long ClientId { get; set; }
        public DateTime Created { get; set; }
        public long CreatedBy { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientView ClientView { get; set; }
        public virtual VolunteerPool VolunteerPool { get; set; }
    }
}
