using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderBatchFile
    {
        public OrderBatchFile()
        {
            OrderBatchDetail = new HashSet<OrderBatchDetail>();
        }

        public long OrderBatchFileId { get; set; }
        public long? ClientId { get; set; }
        public long? ClientUserId { get; set; }
        public long PositionListingId { get; set; }
        public byte[] BatchFile { get; set; }
        public int ProcessStatus { get; set; }
        public DateTime DateUpload { get; set; }
        public DateTime? DateProcessingStart { get; set; }
        public DateTime? DateProcessingEnd { get; set; }
        public DateTime? DateSummaryOfRightsConsent { get; set; }
        public DateTime? DateStandardConsent { get; set; }
        public string Results { get; set; }
        public string FileName { get; set; }
        public int LastRowProcessed { get; set; }

        public virtual ICollection<OrderBatchDetail> OrderBatchDetail { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual PositionListing PositionListing { get; set; }
    }
}
