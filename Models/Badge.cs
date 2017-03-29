using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Badge
    {
        public Badge()
        {
            OrderSharing = new HashSet<OrderSharing>();
        }

        public int BadgeId { get; set; }
        public string BadgeName { get; set; }
        public long ImageId { get; set; }
        public long? ClientId { get; set; }
        public int BadgeTypeId { get; set; }

        public virtual ICollection<OrderSharing> OrderSharing { get; set; }
        public virtual Client Client { get; set; }
        public virtual ImageStore Image { get; set; }
    }
}
