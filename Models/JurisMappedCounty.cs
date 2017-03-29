using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class JurisMappedCounty
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string CourtName { get; set; }
        public string OffenseCounty { get; set; }
        public string MappedCounty { get; set; }
    }
}
