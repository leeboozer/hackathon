using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class EmailTemplate
    {
        public EmailTemplate()
        {
            CandidateEmailOption = new HashSet<CandidateEmailOption>();
            ClientEmailOption = new HashSet<ClientEmailOption>();
            CustomizedEmailTemplate = new HashSet<CustomizedEmailTemplate>();
            EmailHistory = new HashSet<EmailHistory>();
        }

        public int EtemplateId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public bool SendEmail { get; set; }
        public bool IsCustomizable { get; set; }
        public int LayoutId { get; set; }
        public bool SendFromClientEnabled { get; set; }
        public bool IsCustomizableStaff { get; set; }
        public bool ClientToggleable { get; set; }

        public virtual ICollection<CandidateEmailOption> CandidateEmailOption { get; set; }
        public virtual ICollection<ClientEmailOption> ClientEmailOption { get; set; }
        public virtual ICollection<CustomizedEmailTemplate> CustomizedEmailTemplate { get; set; }
        public virtual ICollection<EmailHistory> EmailHistory { get; set; }
        public virtual Layout Layout { get; set; }
    }
}
