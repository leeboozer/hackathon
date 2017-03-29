using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ConsentFormParameter
    {
        public int ConsentFormParameterId { get; set; }
        public int ConsentFormId { get; set; }
        public short Ordinal { get; set; }
        public string DisplayName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DefaultValue { get; set; }
    }
}
