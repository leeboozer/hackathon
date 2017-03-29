using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class States
    {
        public States()
        {
            Candidate = new HashSet<Candidate>();
            ClientStates = new HashSet<ClientStates>();
            ProductAuthorization = new HashSet<ProductAuthorization>();
            VolunteerPool = new HashSet<VolunteerPool>();
        }

        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string MvrRegex { get; set; }
        public bool IsBatchUploadState { get; set; }

        public virtual ICollection<Candidate> Candidate { get; set; }
        public virtual ICollection<ClientStates> ClientStates { get; set; }
        public virtual ICollection<ProductAuthorization> ProductAuthorization { get; set; }
        public virtual ICollection<VolunteerPool> VolunteerPool { get; set; }
    }
}
