using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Layout
    {
        public Layout()
        {
            CustomizedEmailTemplate = new HashSet<CustomizedEmailTemplate>();
            EmailTemplate = new HashSet<EmailTemplate>();
        }

        public int LayoutId { get; set; }
        public string Shell { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomizedEmailTemplate> CustomizedEmailTemplate { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplate { get; set; }
    }
}
