using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ProductAuthorization
    {
        public ProductAuthorization()
        {
            ClientProductAuthorization = new HashSet<ClientProductAuthorization>();
        }

        public long ProductAuthorizationId { get; set; }
        public long NpnProductId { get; set; }
        public int AuthorizationType { get; set; }
        public string StateCode { get; set; }

        public virtual ICollection<ClientProductAuthorization> ClientProductAuthorization { get; set; }
        public virtual NpnProduct NpnProduct { get; set; }
        public virtual States StateCodeNavigation { get; set; }
    }
}
