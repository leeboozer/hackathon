using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ErrorCount
    {
        public long ErrorCountId { get; set; }
        public int ErrorType { get; set; }
        public DateTime ErrorTime { get; set; }
        public string Message { get; set; }
    }
}
