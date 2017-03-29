using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class FormStore
    {
        public FormStore()
        {
            CandidateForms = new HashSet<CandidateForms>();
            OrderFormStore = new HashSet<OrderFormStore>();
        }

        public long FormId { get; set; }
        public int FormTypeId { get; set; }
        public string FileName { get; set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public byte[] FormStoreItem { get; set; }
        public string Name { get; set; }
        public int VersionNumber { get; set; }

        public virtual ICollection<CandidateForms> CandidateForms { get; set; }
        public virtual ICollection<OrderFormStore> OrderFormStore { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
    }
}
