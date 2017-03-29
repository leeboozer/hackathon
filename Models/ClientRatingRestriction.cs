using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientRatingRestriction
    {
        public ClientRatingRestriction()
        {
            VolunteerPoolCalc = new HashSet<VolunteerPoolCalc>();
            VolunteerPoolClientRatingRestriction = new HashSet<VolunteerPoolClientRatingRestriction>();
        }

        public long ClientRatingRestrictionId { get; set; }
        public long ClientId { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<VolunteerPoolCalc> VolunteerPoolCalc { get; set; }
        public virtual ICollection<VolunteerPoolClientRatingRestriction> VolunteerPoolClientRatingRestriction { get; set; }
        public virtual Client Client { get; set; }
    }
}
