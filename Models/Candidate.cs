using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            AddressInformation = new HashSet<AddressInformation>();
            AdverseAction = new HashSet<AdverseAction>();
            Alias = new HashSet<Alias>();
            CandidateCallToAction = new HashSet<CandidateCallToAction>();
            CandidateCause = new HashSet<CandidateCause>();
            CandidateCoupon = new HashSet<CandidateCoupon>();
            CandidateEmailOption = new HashSet<CandidateEmailOption>();
            CandidateEvent = new HashSet<CandidateEvent>();
            CandidateForms = new HashSet<CandidateForms>();
            CandidateInterest = new HashSet<CandidateInterest>();
            CandidateResponse = new HashSet<CandidateResponse>();
            CandidateSecurityQuestions = new HashSet<CandidateSecurityQuestions>();
            CandidateSkill = new HashSet<CandidateSkill>();
            IdAuthenticationResult = new HashSet<IdAuthenticationResult>();
            NpnOrder = new HashSet<NpnOrder>();
            OrderConsent = new HashSet<OrderConsent>();
            OrderQuestionnaire = new HashSet<OrderQuestionnaire>();
            OrderReference = new HashSet<OrderReference>();
            OrderSharing = new HashSet<OrderSharing>();
            OrderSharingExternal = new HashSet<OrderSharingExternal>();
            VolunteerPool = new HashSet<VolunteerPool>();
            VolunteerPoolClientView = new HashSet<VolunteerPoolClientView>();
            VolunteerPoolHistory = new HashSet<VolunteerPoolHistory>();
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public long CandidateId { get; set; }
        public bool UserActive { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public long? InvitationId { get; set; }
        public bool NeedsPasswordReset { get; set; }
        public long? ImageStoreId { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Phone { get; set; }
        public int? PhonePrivacy { get; set; }
        public bool? CanTextMsg { get; set; }
        public string Address { get; set; }
        public int? AddressPrivacy { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public int? EmailPrivacy { get; set; }
        public int? SocialMediaPrivacy { get; set; }
        public bool? DoesPermitSearch { get; set; }
        public string MyStory { get; set; }
        public long? ProfileImageStoreId { get; set; }
        public bool FirstTimeLogin { get; set; }
        public bool IsVerified { get; set; }
        public bool ClientCreated { get; set; }
        public long ApisourceId { get; set; }
        public int? SessionCount { get; set; }
        public bool HasViewedSkillsInterests { get; set; }
        public bool IsCheckinEnabled { get; set; }

        public virtual ICollection<AddressInformation> AddressInformation { get; set; }
        public virtual ICollection<AdverseAction> AdverseAction { get; set; }
        public virtual ICollection<Alias> Alias { get; set; }
        public virtual ICollection<CandidateCallToAction> CandidateCallToAction { get; set; }
        public virtual ICollection<CandidateCause> CandidateCause { get; set; }
        public virtual ICollection<CandidateCoupon> CandidateCoupon { get; set; }
        public virtual ICollection<CandidateEmailOption> CandidateEmailOption { get; set; }
        public virtual ICollection<CandidateEvent> CandidateEvent { get; set; }
        public virtual ICollection<CandidateForms> CandidateForms { get; set; }
        public virtual ICollection<CandidateInterest> CandidateInterest { get; set; }
        public virtual ICollection<CandidateResponse> CandidateResponse { get; set; }
        public virtual ICollection<CandidateSecurityQuestions> CandidateSecurityQuestions { get; set; }
        public virtual ICollection<CandidateSkill> CandidateSkill { get; set; }
        public virtual ICollection<IdAuthenticationResult> IdAuthenticationResult { get; set; }
        public virtual ICollection<NpnOrder> NpnOrder { get; set; }
        public virtual ICollection<OrderConsent> OrderConsent { get; set; }
        public virtual ICollection<OrderQuestionnaire> OrderQuestionnaire { get; set; }
        public virtual ICollection<OrderReference> OrderReference { get; set; }
        public virtual ICollection<OrderSharing> OrderSharing { get; set; }
        public virtual ICollection<OrderSharingExternal> OrderSharingExternal { get; set; }
        public virtual ICollection<VolunteerPool> VolunteerPool { get; set; }
        public virtual ICollection<VolunteerPoolClientView> VolunteerPoolClientView { get; set; }
        public virtual ICollection<VolunteerPoolHistory> VolunteerPoolHistory { get; set; }
        public virtual ImageStore ImageStore { get; set; }
        public virtual Invitation Invitation { get; set; }
        public virtual ImageStore ProfileImageStore { get; set; }
        public virtual States StateCodeNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
