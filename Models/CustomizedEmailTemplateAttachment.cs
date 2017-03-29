using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CustomizedEmailTemplateAttachment
    {
        public long CustomizedEmailTemplateAttachmentId { get; set; }
        public long AttachmentId { get; set; }
        public int CustomizedTemplateId { get; set; }

        public virtual AttachmentStore Attachment { get; set; }
        public virtual CustomizedEmailTemplate CustomizedTemplate { get; set; }
    }
}
