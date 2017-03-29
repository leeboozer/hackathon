using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class JurisStateDistrictCounty
    {
        public long JurisStateDistrictCountyId { get; set; }
        public string StateCode { get; set; }
        public string DistrictName { get; set; }
        public string CountyName { get; set; }
    }
}
