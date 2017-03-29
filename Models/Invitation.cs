using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Invitation
    {
        public Invitation()
        {
            Candidate = new HashSet<Candidate>();
            InvitationAttachment = new HashSet<InvitationAttachment>();
            NpnOrder = new HashSet<NpnOrder>();
            VolunteerPool = new HashSet<VolunteerPool>();
        }

        public long InvitationId { get; set; }
        public long PositionId { get; set; }
        public long PositionListingId { get; set; }
        public long ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Comments { get; set; }
        public DateTime DateSent { get; set; }
        public string Status { get; set; }
        public bool Shared { get; set; }
        public int ReminderCount { get; set; }
        public DateTime? LastSent { get; set; }
        public long InvitationTypeId { get; set; }
        public long? ClientUserId { get; set; }

        public virtual ICollection<Candidate> Candidate { get; set; }
        public virtual ICollection<InvitationAttachment> InvitationAttachment { get; set; }
        public virtual ICollection<NpnOrder> NpnOrder { get; set; }
        public virtual ICollection<VolunteerPool> VolunteerPool { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual Position Position { get; set; }
        public virtual PositionListing PositionListing { get; set; }
    }
}
