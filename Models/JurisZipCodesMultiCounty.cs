using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class JurisZipCodesMultiCounty
    {
        public int JurisZipCodeId { get; set; }
        public int ZipCode { get; set; }
        public string State { get; set; }
        public string County { get; set; }
    }
}
