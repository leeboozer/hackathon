using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class IdAuthenticationResult
    {
        public IdAuthenticationResult()
        {
            IdAuthenticationResultModification = new HashSet<IdAuthenticationResultModification>();
        }

        public long IdAuthenticationResultId { get; set; }
        public long CandidateId { get; set; }
        public long NpnOrderId { get; set; }
        public string AuthenticationGuid { get; set; }
        public DateTime SubmittedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime? ProcessingCompletedOn { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string IssuingState { get; set; }
        public DateTime? IssuanceDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Dlnumber { get; set; }
        public DateTime? ImageSubmissionConsentDate { get; set; }
        public DateTime? ModificationConsentDate { get; set; }
        public string RawJsonResult { get; set; }
        public int? Score { get; set; }

        public virtual ICollection<IdAuthenticationResultModification> IdAuthenticationResultModification { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
