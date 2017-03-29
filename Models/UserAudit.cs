using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class UserAudit
    {
        public long UserAuditId { get; set; }
        public int AuditType { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string OldValue1 { get; set; }
        public string NewValue1 { get; set; }
        public string OldValue2 { get; set; }
        public string OldValue3 { get; set; }
        public string NewValue2 { get; set; }
        public string NewValue3 { get; set; }
        public long? CoorelationId1 { get; set; }
        public long? CoorelationId2 { get; set; }
        public long? CoorelationId3 { get; set; }

        public virtual Users UserNameNavigation { get; set; }
    }
}
