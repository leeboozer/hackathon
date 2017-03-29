using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class VolunteerPoolClientRatingRestriction
    {
        public long VolunteerPoolClientRatingRestrictionId { get; set; }
        public long ClientRatingRestrictionId { get; set; }
        public long VolunteerPoolId { get; set; }
        public long? RemovedByClientUserId { get; set; }
        public long AddedByClientUserId { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? RemovedDate { get; set; }

        public virtual ClientUser AddedByClientUser { get; set; }
        public virtual ClientRatingRestriction ClientRatingRestriction { get; set; }
        public virtual ClientUser RemovedByClientUser { get; set; }
        public virtual VolunteerPool VolunteerPool { get; set; }
    }
}
