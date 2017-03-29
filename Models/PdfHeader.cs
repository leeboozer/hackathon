using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class PdfHeader
    {
        public PdfHeader()
        {
            PdfDetail = new HashSet<PdfDetail>();
        }

        public long PdfHeaderId { get; set; }
        public long ClientId { get; set; }
        public long ClientUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateProcessingStart { get; set; }
        public DateTime? DateProcessingEnd { get; set; }
        public DateTime DateProcessingExpire { get; set; }
        public int NumReportsRequested { get; set; }
        public int PdfHeaderStatus { get; set; }
        public bool DoubleSided { get; set; }
        public byte[] PdfFile { get; set; }

        public virtual ICollection<PdfDetail> PdfDetail { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientUser ClientUser { get; set; }
    }
}
