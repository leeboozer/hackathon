using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class VolunteerPoolCalc
    {
        public long VolunteerPoolId { get; set; }
        public long ClientId { get; set; }
        public long? RootClientId { get; set; }
        public string AccountName { get; set; }
        public long? CandidateId { get; set; }
        public string Level { get; set; }
        public bool IsShared { get; set; }
        public bool IsInterested { get; set; }
        public DateTime? LastScreen { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string LastUpdateDisplay { get; set; }
        public DateTime? VolunteerSince { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int? LastUpdateImageId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string MyStory { get; set; }
        public long? ImageStoreId { get; set; }
        public DateTime? Dob { get; set; }
        public bool HasBgprocessing { get; set; }
        public bool HasInvitationOrder { get; set; }
        public string ApicandidateId { get; set; }
        public string Position { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public bool IsPhoneEditable { get; set; }
        public bool IsEmailEditable { get; set; }
        public bool IsAddressEditable { get; set; }
        public string CreateType { get; set; }
        public DateTime? LastAdjudicationDate { get; set; }
        public long? LastNpnOrderId { get; set; }
        public long? ClientRatingRestrictionId { get; set; }
        public DateTime? ClientRatingRestrictionEndDate { get; set; }
        public string ClientRatingRestrictionNote { get; set; }
        public DateTime? InvitationDate { get; set; }

        public virtual ClientRatingRestriction ClientRatingRestriction { get; set; }
    }
}
