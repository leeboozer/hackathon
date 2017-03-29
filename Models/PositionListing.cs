using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class PositionListing
    {
        public PositionListing()
        {
            Invitation = new HashSet<Invitation>();
            NpnOrderPositionListing = new HashSet<NpnOrder>();
            NpnOrderVolPositionListing = new HashSet<NpnOrder>();
            OrderBatchDetail = new HashSet<OrderBatchDetail>();
            OrderBatchFile = new HashSet<OrderBatchFile>();
        }

        public long PositionListingId { get; set; }
        public string Name { get; set; }
        public long ClientId { get; set; }
        public long PositionId { get; set; }
        public string PromoCode { get; set; }
        public bool HidePrice { get; set; }
        public bool HideDonations { get; set; }
        public decimal ProductFeeRate { get; set; }
        public decimal SourceFeeRate { get; set; }
        public bool HideOnInvite { get; set; }
        public Guid? Guid { get; set; }
        public bool HideOnClientOrder { get; set; }

        public virtual ICollection<Invitation> Invitation { get; set; }
        public virtual ICollection<NpnOrder> NpnOrderPositionListing { get; set; }
        public virtual ICollection<NpnOrder> NpnOrderVolPositionListing { get; set; }
        public virtual ICollection<OrderBatchDetail> OrderBatchDetail { get; set; }
        public virtual ICollection<OrderBatchFile> OrderBatchFile { get; set; }
        public virtual Client Client { get; set; }
        public virtual Position Position { get; set; }
    }
}
