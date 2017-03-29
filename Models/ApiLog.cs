using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ApiLog
    {
        public long ApiLogId { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Path { get; set; }
        public bool Request { get; set; }
        public string Xml { get; set; }
        public Guid RequestId { get; set; }
        public string Method { get; set; }
        public int? Result { get; set; }
        public Guid? ErrorGuid { get; set; }
        public long? NpnOrderId { get; set; }
        public long? CandidateId { get; set; }
        public string ApiCandidateId { get; set; }
        public int? StatusId { get; set; }
        public int? TypeId { get; set; }
    }
}
