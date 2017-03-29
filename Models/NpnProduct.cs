using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NpnProduct
    {
        public NpnProduct()
        {
            AdverseAction = new HashSet<AdverseAction>();
            Client = new HashSet<Client>();
            ClientPricing = new HashSet<ClientPricing>();
            ConsentForm = new HashSet<ConsentForm>();
            Endorsement = new HashSet<Endorsement>();
            NpnOrderProduct = new HashSet<NpnOrderProduct>();
            OrderSearch = new HashSet<OrderSearch>();
            PositionNpnProduct = new HashSet<PositionNpnProduct>();
            ProductAudit = new HashSet<ProductAudit>();
            ProductAuthorization = new HashSet<ProductAuthorization>();
        }

        public long NpnProductId { get; set; }
        public string ProductDesc { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductAbbr { get; set; }
        public bool AlaCarteProduct { get; set; }
        public bool CrimProduct { get; set; }
        public bool OrderProduct { get; set; }
        public int Payer { get; set; }
        public decimal? AltProductPrice { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<AdverseAction> AdverseAction { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<ClientPricing> ClientPricing { get; set; }
        public virtual ICollection<ConsentForm> ConsentForm { get; set; }
        public virtual ICollection<Endorsement> Endorsement { get; set; }
        public virtual ICollection<NpnOrderProduct> NpnOrderProduct { get; set; }
        public virtual ICollection<OrderSearch> OrderSearch { get; set; }
        public virtual ICollection<PositionNpnProduct> PositionNpnProduct { get; set; }
        public virtual ICollection<ProductAudit> ProductAudit { get; set; }
        public virtual ICollection<ProductAuthorization> ProductAuthorization { get; set; }
    }
}
