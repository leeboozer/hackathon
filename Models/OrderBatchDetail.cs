using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderBatchDetail
    {
        public long OrderBatchDetailId { get; set; }
        public long OrderBatchFileId { get; set; }
        public long? ClientId { get; set; }
        public long? ClientUserId { get; set; }
        public long? PositionListingId { get; set; }
        public long? NpnOrderId { get; set; }
        public string ApiCandidateId { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string Email { get; set; }
        public string Ssn { get; set; }
        public string Phone { get; set; }
        public byte? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string AddressLn1 { get; set; }
        public string AddressLn2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Mvrlicense { get; set; }
        public string Mvrstate { get; set; }
        public string Country { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Errors { get; set; }
        public string AliasNames { get; set; }
        public int StatusId { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual Client Client { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
        public virtual OrderBatchFile OrderBatchFile { get; set; }
        public virtual PositionListing PositionListing { get; set; }
    }
}
