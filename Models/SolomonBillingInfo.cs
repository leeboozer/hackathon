using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SolomonBillingInfo
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string SterlingAccountGlcode { get; set; }
        public string SterlingAccountGldescription { get; set; }
        public string SterlingInventoryCode { get; set; }
        public long? NpnProductId { get; set; }
        public byte? JurisType { get; set; }
        public int? SterlingWestProductCode { get; set; }
    }
}
