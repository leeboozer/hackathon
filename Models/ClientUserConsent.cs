using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientUserConsent
    {
        public long ClientUserConsentId { get; set; }
        public long ClientUserId { get; set; }
        public DateTime ConsentDate { get; set; }
        public int VersionNumber { get; set; }

        public virtual ClientUser ClientUser { get; set; }
    }
}
