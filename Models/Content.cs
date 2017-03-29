using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Content
    {
        public Content()
        {
            CustomContent = new HashSet<CustomContent>();
        }

        public int ContentId { get; set; }
        public string Heading { get; set; }
        public string Message { get; set; }
        public int ContentPageId { get; set; }
        public int ContentSectionId { get; set; }
        public int ContentTypeId { get; set; }
        public string Name { get; set; }
        public string TemplateHtml { get; set; }
        public string Replacements { get; set; }
        public bool IsCustomizableClient { get; set; }

        public virtual ICollection<CustomContent> CustomContent { get; set; }
    }
}
