using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientView
    {
        public ClientView()
        {
            ClientViewClientUser = new HashSet<ClientViewClientUser>();
            VolunteerPoolClientView = new HashSet<VolunteerPoolClientView>();
        }

        public long ClientViewId { get; set; }
        public long ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ClientViewClientUser> ClientViewClientUser { get; set; }
        public virtual ICollection<VolunteerPoolClientView> VolunteerPoolClientView { get; set; }
        public virtual Client Client { get; set; }
    }
}
