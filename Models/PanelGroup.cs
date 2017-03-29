using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class PanelGroup
    {
        public int PanelGroupId { get; set; }
        public int SectionId { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }
        public int Ordinal { get; set; }
    }
}
