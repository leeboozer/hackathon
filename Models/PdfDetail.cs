using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class PdfDetail
    {
        public long PdfDetailId { get; set; }
        public long PdfHeaderId { get; set; }
        public long OrderSharingId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateProcessingStart { get; set; }
        public DateTime? DateProcessingEnd { get; set; }
        public int PdfDetailStatus { get; set; }
        public bool SummaryVersion { get; set; }
        public int SubmissionAttempts { get; set; }
        public byte[] PdfFile { get; set; }

        public virtual PdfHeader PdfHeader { get; set; }
    }
}
