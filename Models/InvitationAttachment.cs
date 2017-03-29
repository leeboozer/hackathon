using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class InvitationAttachment
    {
        public long InvitationAttachmentId { get; set; }
        public long AttachmentId { get; set; }
        public long InvitationId { get; set; }

        public virtual AttachmentStore Attachment { get; set; }
        public virtual Invitation Invitation { get; set; }
    }
}
