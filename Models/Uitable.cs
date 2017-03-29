using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Uitable
    {
        public Uitable()
        {
            Uicolumn = new HashSet<Uicolumn>();
        }

        public int UitableId { get; set; }
        public string UitableName { get; set; }

        public virtual ICollection<Uicolumn> Uicolumn { get; set; }
    }
}
