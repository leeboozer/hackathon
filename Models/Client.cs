using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Client
    {
        public Client()
        {
            AdverseAction = new HashSet<AdverseAction>();
            ApiLogError = new HashSet<ApiLogError>();
            AttachmentStore = new HashSet<AttachmentStore>();
            Badge = new HashSet<Badge>();
            CandidateEvent = new HashSet<CandidateEvent>();
            ClientConfiguration = new HashSet<ClientConfiguration>();
            ClientCredit = new HashSet<ClientCredit>();
            ClientEmailOption = new HashSet<ClientEmailOption>();
            ClientFeature = new HashSet<ClientFeature>();
            ClientInterest = new HashSet<ClientInterest>();
            ClientPricing = new HashSet<ClientPricing>();
            ClientProductAuthorization = new HashSet<ClientProductAuthorization>();
            ClientPromotion = new HashSet<ClientPromotion>();
            ClientRatingRestriction = new HashSet<ClientRatingRestriction>();
            ClientReportAudit = new HashSet<ClientReportAudit>();
            ClientSkill = new HashSet<ClientSkill>();
            ClientSsoSettings = new HashSet<ClientSsoSettings>();
            ClientStaffCommission = new HashSet<ClientStaffCommission>();
            ClientStates = new HashSet<ClientStates>();
            ClientUser = new HashSet<ClientUser>();
            ClientView = new HashSet<ClientView>();
            CustomContent = new HashSet<CustomContent>();
            CustomizedEmailTemplate = new HashSet<CustomizedEmailTemplate>();
            Invitation = new HashSet<Invitation>();
            OrderBatchDetail = new HashSet<OrderBatchDetail>();
            OrderBatchFile = new HashSet<OrderBatchFile>();
            OrderConsent = new HashSet<OrderConsent>();
            OrderQuestionnaire = new HashSet<OrderQuestionnaire>();
            OrderSharing = new HashSet<OrderSharing>();
            PdfHeader = new HashSet<PdfHeader>();
            Position = new HashSet<Position>();
            PositionListing = new HashSet<PositionListing>();
            Questionnaire = new HashSet<Questionnaire>();
            VolunteerPool = new HashSet<VolunteerPool>();
            VolunteerPoolClientView = new HashSet<VolunteerPoolClientView>();
            VolunteerPoolHistory = new HashSet<VolunteerPoolHistory>();
        }

        public long ClientId { get; set; }
        public string AccountName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string TaxZipCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Website { get; set; }
        public string OtherPlatforms { get; set; }
        public string Status { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime? DateActivated { get; set; }
        public string CustomerType { get; set; }
        public bool ChargePilot { get; set; }
        public string Market { get; set; }
        public string Industry { get; set; }
        public bool VulnerableSector { get; set; }
        public string SolomonBillingId { get; set; }
        public decimal AnnualContractValue { get; set; }
        public int NumberOfVolunteer { get; set; }
        public int NumberofScreened { get; set; }
        public bool? IsPrivate { get; set; }
        public long? ParentClientId { get; set; }
        public long? RootClientId { get; set; }
        public long? MinProductLevel { get; set; }
        public long RevenueReportingClientId { get; set; }
        public decimal AnnualForecastRev { get; set; }
        public string ForecastNotes { get; set; }
        public decimal AnnualRev { get; set; }
        public int? SwabsolveAccountId { get; set; }
        public bool IsTestAccount { get; set; }
        public string SalesforceLink { get; set; }

        public virtual ICollection<AdverseAction> AdverseAction { get; set; }
        public virtual ICollection<ApiLogError> ApiLogError { get; set; }
        public virtual ICollection<AttachmentStore> AttachmentStore { get; set; }
        public virtual ICollection<Badge> Badge { get; set; }
        public virtual Billing Billing { get; set; }
        public virtual ICollection<CandidateEvent> CandidateEvent { get; set; }
        public virtual ICollection<ClientConfiguration> ClientConfiguration { get; set; }
        public virtual ICollection<ClientCredit> ClientCredit { get; set; }
        public virtual ICollection<ClientEmailOption> ClientEmailOption { get; set; }
        public virtual ICollection<ClientFeature> ClientFeature { get; set; }
        public virtual ICollection<ClientInterest> ClientInterest { get; set; }
        public virtual ICollection<ClientPricing> ClientPricing { get; set; }
        public virtual ICollection<ClientProductAuthorization> ClientProductAuthorization { get; set; }
        public virtual ICollection<ClientPromotion> ClientPromotion { get; set; }
        public virtual ICollection<ClientRatingRestriction> ClientRatingRestriction { get; set; }
        public virtual ICollection<ClientReportAudit> ClientReportAudit { get; set; }
        public virtual ICollection<ClientSkill> ClientSkill { get; set; }
        public virtual ICollection<ClientSsoSettings> ClientSsoSettings { get; set; }
        public virtual ICollection<ClientStaffCommission> ClientStaffCommission { get; set; }
        public virtual ICollection<ClientStates> ClientStates { get; set; }
        public virtual ICollection<ClientUser> ClientUser { get; set; }
        public virtual ICollection<ClientView> ClientView { get; set; }
        public virtual ICollection<CustomContent> CustomContent { get; set; }
        public virtual ICollection<CustomizedEmailTemplate> CustomizedEmailTemplate { get; set; }
        public virtual ICollection<Invitation> Invitation { get; set; }
        public virtual ICollection<OrderBatchDetail> OrderBatchDetail { get; set; }
        public virtual ICollection<OrderBatchFile> OrderBatchFile { get; set; }
        public virtual ICollection<OrderConsent> OrderConsent { get; set; }
        public virtual ICollection<OrderQuestionnaire> OrderQuestionnaire { get; set; }
        public virtual ICollection<OrderSharing> OrderSharing { get; set; }
        public virtual ICollection<PdfHeader> PdfHeader { get; set; }
        public virtual ICollection<Position> Position { get; set; }
        public virtual ICollection<PositionListing> PositionListing { get; set; }
        public virtual ICollection<Questionnaire> Questionnaire { get; set; }
        public virtual ICollection<VolunteerPool> VolunteerPool { get; set; }
        public virtual ICollection<VolunteerPoolClientView> VolunteerPoolClientView { get; set; }
        public virtual ICollection<VolunteerPoolHistory> VolunteerPoolHistory { get; set; }
        public virtual NpnProduct MinProductLevelNavigation { get; set; }
        public virtual Client ParentClient { get; set; }
        public virtual ICollection<Client> InverseParentClient { get; set; }
        public virtual Client RootClient { get; set; }
        public virtual ICollection<Client> InverseRootClient { get; set; }
    }
}
