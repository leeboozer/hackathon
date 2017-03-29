using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class JurisSourceFee
    {
        public byte JurisType { get; set; }
        public string JurisRoot { get; set; }
        public string JurisDesc { get; set; }
        public decimal JurisFee { get; set; }
        public decimal CivilJurisFee { get; set; }
        public decimal? AltJurisFee { get; set; }
    }
}
