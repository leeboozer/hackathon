using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NpnOrder
    {
        public NpnOrder()
        {
            AddressInformation = new HashSet<AddressInformation>();
            AdverseAction = new HashSet<AdverseAction>();
            Alias = new HashSet<Alias>();
            CandidateCoupon = new HashSet<CandidateCoupon>();
            CandidateCouponUsage = new HashSet<CandidateCouponUsage>();
            ClientCredit = new HashSet<ClientCredit>();
            IdAuthenticationResult = new HashSet<IdAuthenticationResult>();
            IdAuthenticationResultModification = new HashSet<IdAuthenticationResultModification>();
            JurisOrder = new HashSet<JurisOrder>();
            NationalCrimArchive = new HashSet<NationalCrimArchive>();
            NationalCrimCaseArchive = new HashSet<NationalCrimCaseArchive>();
            NationalCrimCaseHash = new HashSet<NationalCrimCaseHash>();
            NpnOrderProduct = new HashSet<NpnOrderProduct>();
            OrderBatchDetail = new HashSet<OrderBatchDetail>();
            OrderConsent = new HashSet<OrderConsent>();
            OrderCrimCase = new HashSet<OrderCrimCase>();
            OrderCrimCharge = new HashSet<OrderCrimCharge>();
            OrderFormStore = new HashSet<OrderFormStore>();
            OrderQuestionnaire = new HashSet<OrderQuestionnaire>();
            OrderReference = new HashSet<OrderReference>();
            OrderReportView = new HashSet<OrderReportView>();
            OrderSearch = new HashSet<OrderSearch>();
            OrderSharing = new HashSet<OrderSharing>();
            OrderSharingExternal = new HashSet<OrderSharingExternal>();
            OrderUpdate = new HashSet<OrderUpdate>();
            SsnTraceArchive = new HashSet<SsnTraceArchive>();
            SsnTraceRecordArchive = new HashSet<SsnTraceRecordArchive>();
            StateAbuseCode = new HashSet<StateAbuseCode>();
        }

        public long NpnOrderId { get; set; }
        public long CandidateId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateDue { get; set; }
        public long? InvitationId { get; set; }
        public long? PositionListingId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string EmailAddr { get; set; }
        public string SuffixName { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string Mvrlicense { get; set; }
        public string Mvrstate { get; set; }
        public string MvrlastName { get; set; }
        public string MvrfirstName { get; set; }
        public string MvrmiddleName { get; set; }
        public string Ssn { get; set; }
        public DateTime Dob { get; set; }
        public byte Gender { get; set; }
        public long? PaymentId { get; set; }
        public int? SterlingId { get; set; }
        public DateTime? EstimatedCompleteDate { get; set; }
        public decimal SalesTaxRate { get; set; }
        public int ProcessStatusId { get; set; }
        public string PromoCode { get; set; }
        public bool CreditReportViewable { get; set; }
        public DateTime? CreditReportAccessDate { get; set; }
        public int? Score { get; set; }
        public decimal SubTotal { get; set; }
        public decimal AmountOrganization { get; set; }
        public decimal AmountTax { get; set; }
        public decimal Donation { get; set; }
        public decimal FinalTotal { get; set; }
        public decimal BeforeDonationTotal { get; set; }
        public Guid NatCrimId { get; set; }
        public DateTime? NextOrderUpdateDate { get; set; }
        public long? OrderClientUserId { get; set; }
        public long ApisourceId { get; set; }
        public long? VolPositionListingId { get; set; }
        public int AbsolveOrderTypeId { get; set; }
        public decimal AmountCoupon { get; set; }
        public DateTime? AbsolveSubmittedDate { get; set; }
        public int ResubmitAttemptCount { get; set; }
        public bool? SharingSubscription { get; set; }
        public int AuthenticationAttempts { get; set; }
        public bool? PreviouslyScreenedForNeglectAbuse { get; set; }
        public DateTime? HoldDate { get; set; }
        public long? HoldSubmitClientUserId { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }

        public virtual ICollection<AddressInformation> AddressInformation { get; set; }
        public virtual ICollection<AdverseAction> AdverseAction { get; set; }
        public virtual ICollection<Alias> Alias { get; set; }
        public virtual ICollection<CandidateCoupon> CandidateCoupon { get; set; }
        public virtual ICollection<CandidateCouponUsage> CandidateCouponUsage { get; set; }
        public virtual ICollection<ClientCredit> ClientCredit { get; set; }
        public virtual ICollection<IdAuthenticationResult> IdAuthenticationResult { get; set; }
        public virtual ICollection<IdAuthenticationResultModification> IdAuthenticationResultModification { get; set; }
        public virtual ICollection<JurisOrder> JurisOrder { get; set; }
        public virtual ICollection<NationalCrimArchive> NationalCrimArchive { get; set; }
        public virtual ICollection<NationalCrimCaseArchive> NationalCrimCaseArchive { get; set; }
        public virtual ICollection<NationalCrimCaseHash> NationalCrimCaseHash { get; set; }
        public virtual ICollection<NpnOrderProduct> NpnOrderProduct { get; set; }
        public virtual ICollection<OrderBatchDetail> OrderBatchDetail { get; set; }
        public virtual ICollection<OrderConsent> OrderConsent { get; set; }
        public virtual ICollection<OrderCrimCase> OrderCrimCase { get; set; }
        public virtual ICollection<OrderCrimCharge> OrderCrimCharge { get; set; }
        public virtual ICollection<OrderFormStore> OrderFormStore { get; set; }
        public virtual ICollection<OrderQuestionnaire> OrderQuestionnaire { get; set; }
        public virtual ICollection<OrderReference> OrderReference { get; set; }
        public virtual ICollection<OrderReportView> OrderReportView { get; set; }
        public virtual ICollection<OrderSearch> OrderSearch { get; set; }
        public virtual ICollection<OrderSharing> OrderSharing { get; set; }
        public virtual ICollection<OrderSharingExternal> OrderSharingExternal { get; set; }
        public virtual ICollection<OrderUpdate> OrderUpdate { get; set; }
        public virtual SharingSubscription SharingSubscriptionNavigation { get; set; }
        public virtual ICollection<SsnTraceArchive> SsnTraceArchive { get; set; }
        public virtual ICollection<SsnTraceRecordArchive> SsnTraceRecordArchive { get; set; }
        public virtual ICollection<StateAbuseCode> StateAbuseCode { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual ClientUser HoldSubmitClientUser { get; set; }
        public virtual Invitation Invitation { get; set; }
        public virtual ClientUser OrderClientUser { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual PositionListing PositionListing { get; set; }
        public virtual PositionListing VolPositionListing { get; set; }
    }
}
