using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CustomizedEmailTemplate
    {
        public CustomizedEmailTemplate()
        {
            CustomizedEmailTemplateAttachment = new HashSet<CustomizedEmailTemplateAttachment>();
        }

        public int CustomizedTemplateId { get; set; }
        public int EtemplateId { get; set; }
        public long? ClientId { get; set; }
        public string SubjectPrevious { get; set; }
        public string Subject { get; set; }
        public string DescriptionPrevious { get; set; }
        public string Description { get; set; }
        public int LayoutId { get; set; }
        public bool SendFromClient { get; set; }

        public virtual ICollection<CustomizedEmailTemplateAttachment> CustomizedEmailTemplateAttachment { get; set; }
        public virtual Client Client { get; set; }
        public virtual EmailTemplate Etemplate { get; set; }
        public virtual Layout Layout { get; set; }
    }
}
