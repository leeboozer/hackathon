using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CustomContent
    {
        public long CustomContentId { get; set; }
        public string Heading { get; set; }
        public string Message { get; set; }
        public bool Active { get; set; }
        public int TimesUsed { get; set; }
        public int ContentId { get; set; }
        public long? ClientId { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual Client Client { get; set; }
        public virtual Content Content { get; set; }
    }
}
