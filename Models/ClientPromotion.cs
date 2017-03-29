using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientPromotion
    {
        public long ClientPromotionId { get; set; }
        public long ClientId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Discount { get; set; }

        public virtual Client Client { get; set; }
    }
}
