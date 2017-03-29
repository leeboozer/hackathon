using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class VolunteerPool
    {
        public VolunteerPool()
        {
            VolunteerPoolClientRatingRestriction = new HashSet<VolunteerPoolClientRatingRestriction>();
            VolunteerPoolClientView = new HashSet<VolunteerPoolClientView>();
            VolunteerPoolHistory = new HashSet<VolunteerPoolHistory>();
            VolunteerPoolPosition = new HashSet<VolunteerPoolPosition>();
        }

        public long VolunteerPoolId { get; set; }
        public long? CandidateId { get; set; }
        public long ClientId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        public long? InvitationId { get; set; }
        public string PromoCode { get; set; }
        public string Level { get; set; }
        public DateTime? LastScreen { get; set; }
        public DateTime? NextRenewal { get; set; }
        public int StatusId { get; set; }
        public long? OrderSharingId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public short? BgcheckStatus { get; set; }
        public DateTime? OriginalBgcheckDate { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string ApicandidateId { get; set; }
        public int? CreateType { get; set; }
        public long? ClientUserId { get; set; }
        public DateTime? VolunteerSince { get; set; }
        public long? ClientRatingRestrictionId { get; set; }

        public virtual ICollection<VolunteerPoolClientRatingRestriction> VolunteerPoolClientRatingRestriction { get; set; }
        public virtual ICollection<VolunteerPoolClientView> VolunteerPoolClientView { get; set; }
        public virtual ICollection<VolunteerPoolHistory> VolunteerPoolHistory { get; set; }
        public virtual ICollection<VolunteerPoolPosition> VolunteerPoolPosition { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual Invitation Invitation { get; set; }
        public virtual OrderSharing OrderSharing { get; set; }
        public virtual States StateCodeNavigation { get; set; }
    }
}
