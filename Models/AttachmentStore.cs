using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class AttachmentStore
    {
        public AttachmentStore()
        {
            CustomizedEmailTemplateAttachment = new HashSet<CustomizedEmailTemplateAttachment>();
            InvitationAttachment = new HashSet<InvitationAttachment>();
        }

        public long AttachmentId { get; set; }
        public byte[] AttachmentStoreItem { get; set; }
        public long? ClientId { get; set; }
        public string FileName { get; set; }

        public virtual ICollection<CustomizedEmailTemplateAttachment> CustomizedEmailTemplateAttachment { get; set; }
        public virtual ICollection<InvitationAttachment> InvitationAttachment { get; set; }
        public virtual Client Client { get; set; }
    }
}
