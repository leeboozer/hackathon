using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ApiEndpointLog
    {
        public long ApiEndpointLogId { get; set; }
        public DateTime Date { get; set; }
        public string Path { get; set; }
        public string Xml { get; set; }
    }
}
