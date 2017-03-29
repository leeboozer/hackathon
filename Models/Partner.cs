using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Partner
    {
        public Partner()
        {
            ClientStaffCommission = new HashSet<ClientStaffCommission>();
        }

        public long PartnerId { get; set; }
        public string PartnerName { get; set; }

        public virtual ICollection<ClientStaffCommission> ClientStaffCommission { get; set; }
    }
}
