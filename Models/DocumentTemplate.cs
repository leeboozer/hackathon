using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class DocumentTemplate
    {
        public long DocTemplateId { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
    }
}
