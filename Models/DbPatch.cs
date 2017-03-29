using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class DbPatch
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Patch { get; set; }
        public DateTime Date { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
    }
}
