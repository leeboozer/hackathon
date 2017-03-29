using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Position
    {
        public Position()
        {
            Invitation = new HashSet<Invitation>();
            PositionListing = new HashSet<PositionListing>();
            PositionNpnProduct = new HashSet<PositionNpnProduct>();
            VolunteerPoolPosition = new HashSet<VolunteerPoolPosition>();
        }

        public long PositionId { get; set; }
        public string Name { get; set; }
        public long ClientId { get; set; }
        public int MinRenewalMonths { get; set; }
        public bool RegulatedJuris { get; set; }
        public int? MinHoldAmount { get; set; }

        public virtual ICollection<Invitation> Invitation { get; set; }
        public virtual ICollection<PositionListing> PositionListing { get; set; }
        public virtual ICollection<PositionNpnProduct> PositionNpnProduct { get; set; }
        public virtual ICollection<VolunteerPoolPosition> VolunteerPoolPosition { get; set; }
        public virtual Client Client { get; set; }
    }
}
