using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NationalCrimCaseArchive
    {
        public long NationalCrimCaseArchiveId { get; set; }
        public long NpnOrderId { get; set; }
        public bool Match { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string CourtName { get; set; }
        public string CaseNumbers { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
    }
}
