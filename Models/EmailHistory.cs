using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class EmailHistory
    {
        public int EventId { get; set; }
        public int? EmailTemplateId { get; set; }
        public long? ClientId { get; set; }
        public long? ClientUserId { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string CcAddress { get; set; }
        public string BccAddress { get; set; }
        public string EmailBody { get; set; }
        public string Subject { get; set; }
        public DateTime? SentDate { get; set; }
        public long? CorrelationId { get; set; }
        public long? CandidateId { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }
    }
}
