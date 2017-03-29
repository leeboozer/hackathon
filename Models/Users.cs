using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Users
    {
        public Users()
        {
            Candidate = new HashSet<Candidate>();
            ClientUser = new HashSet<ClientUser>();
            Cloud = new HashSet<Cloud>();
            FormStore = new HashSet<FormStore>();
            ImageStore = new HashSet<ImageStore>();
            StaffEmulateUser = new HashSet<Staff>();
            StaffUser = new HashSet<Staff>();
            UserAudit = new HashSet<UserAudit>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public virtual ICollection<Candidate> Candidate { get; set; }
        public virtual ICollection<ClientUser> ClientUser { get; set; }
        public virtual ICollection<Cloud> Cloud { get; set; }
        public virtual ICollection<FormStore> FormStore { get; set; }
        public virtual ICollection<ImageStore> ImageStore { get; set; }
        public virtual ICollection<Staff> StaffEmulateUser { get; set; }
        public virtual ICollection<Staff> StaffUser { get; set; }
        public virtual ICollection<UserAudit> UserAudit { get; set; }
        public virtual Applications Application { get; set; }
    }
}
