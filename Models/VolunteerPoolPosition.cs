using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class VolunteerPoolPosition
    {
        public long VolunteerPoolPositionId { get; set; }
        public long VolunteerPoolId { get; set; }
        public long PositionId { get; set; }

        public virtual Position Position { get; set; }
        public virtual VolunteerPool VolunteerPool { get; set; }
    }
}
