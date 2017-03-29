using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Staff
    {
        public Staff()
        {
            ClientStaffCommissionSalesRep = new HashSet<ClientStaffCommissionSalesRep>();
        }

        public long StaffId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string PhoneExt { get; set; }
        public int PrincipleDeptId { get; set; }
        public bool Status { get; set; }
        public DateTime DateEntered { get; set; }
        public Guid? EmulateUserId { get; set; }

        public virtual ICollection<ClientStaffCommissionSalesRep> ClientStaffCommissionSalesRep { get; set; }
        public virtual Users EmulateUser { get; set; }
        public virtual Users User { get; set; }
    }
}
