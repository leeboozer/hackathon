using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CallToAction
    {
        public CallToAction()
        {
            CandidateCallToAction = new HashSet<CandidateCallToAction>();
        }

        public long CallToActionId { get; set; }
        public int Priority { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Sticky { get; set; }
        public int CallToActionEnum { get; set; }
        public bool IsActive { get; set; }
        public string ImageXs { get; set; }
        public string ImageSm { get; set; }
        public string ImageMd { get; set; }
        public string ImageLg { get; set; }

        public virtual ICollection<CandidateCallToAction> CandidateCallToAction { get; set; }
    }
}
