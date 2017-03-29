using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientUser
    {
        public ClientUser()
        {
            AdverseAction = new HashSet<AdverseAction>();
            ClientReportAudit = new HashSet<ClientReportAudit>();
            ClientUserConsent = new HashSet<ClientUserConsent>();
            ClientViewClientUser = new HashSet<ClientViewClientUser>();
            CustomSort = new HashSet<CustomSort>();
            Invitation = new HashSet<Invitation>();
            NpnOrderHoldSubmitClientUser = new HashSet<NpnOrder>();
            NpnOrderOrderClientUser = new HashSet<NpnOrder>();
            OrderBatchDetail = new HashSet<OrderBatchDetail>();
            OrderBatchFile = new HashSet<OrderBatchFile>();
            OrderConsent = new HashSet<OrderConsent>();
            PdfHeader = new HashSet<PdfHeader>();
            VolunteerPool = new HashSet<VolunteerPool>();
            VolunteerPoolClientRatingRestrictionAddedByClientUser = new HashSet<VolunteerPoolClientRatingRestriction>();
            VolunteerPoolClientRatingRestrictionRemovedByClientUser = new HashSet<VolunteerPoolClientRatingRestriction>();
        }

        public long ClientUserId { get; set; }
        public long ClientId { get; set; }
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool ChangePassword { get; set; }
        public string SmsPhone { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string SterlingWestUserName { get; set; }
        public string TwitterPassword { get; set; }
        public string FacebookPassword { get; set; }
        public bool ShowName { get; set; }
        public bool ShowPosition { get; set; }
        public bool ShowLevelScreen { get; set; }
        public bool ShowShared { get; set; }
        public bool ShowLastScreen { get; set; }
        public bool ShowLastUpdate { get; set; }
        public bool ShowVolunteerSince { get; set; }
        public bool ShowStatus { get; set; }
        public bool ShowEmail { get; set; }
        public bool ShowPhone { get; set; }
        public bool ShowAddress { get; set; }
        public bool ShowExtra1 { get; set; }
        public bool ShowExtra2 { get; set; }
        public bool ShowExtra3 { get; set; }
        public int? Extension { get; set; }
        public bool ShowDob { get; set; }
        public bool IsEnabled { get; set; }
        public bool ShowAccount { get; set; }
        public long CurrentClientId { get; set; }
        public bool ShowLastNpnOrderId { get; set; }
        public bool ShowLastAdjudicationDate { get; set; }
        public bool ShowRatingRestrictions { get; set; }
        public bool ShowInvitationDate { get; set; }
        public bool AllViews { get; set; }

        public virtual ICollection<AdverseAction> AdverseAction { get; set; }
        public virtual ICollection<ClientReportAudit> ClientReportAudit { get; set; }
        public virtual ICollection<ClientUserConsent> ClientUserConsent { get; set; }
        public virtual ICollection<ClientViewClientUser> ClientViewClientUser { get; set; }
        public virtual ICollection<CustomSort> CustomSort { get; set; }
        public virtual ICollection<Invitation> Invitation { get; set; }
        public virtual ICollection<NpnOrder> NpnOrderHoldSubmitClientUser { get; set; }
        public virtual ICollection<NpnOrder> NpnOrderOrderClientUser { get; set; }
        public virtual ICollection<OrderBatchDetail> OrderBatchDetail { get; set; }
        public virtual ICollection<OrderBatchFile> OrderBatchFile { get; set; }
        public virtual ICollection<OrderConsent> OrderConsent { get; set; }
        public virtual ICollection<PdfHeader> PdfHeader { get; set; }
        public virtual ICollection<VolunteerPool> VolunteerPool { get; set; }
        public virtual ICollection<VolunteerPoolClientRatingRestriction> VolunteerPoolClientRatingRestrictionAddedByClientUser { get; set; }
        public virtual ICollection<VolunteerPoolClientRatingRestriction> VolunteerPoolClientRatingRestrictionRemovedByClientUser { get; set; }
        public virtual Client Client { get; set; }
        public virtual Users User { get; set; }
    }
}
