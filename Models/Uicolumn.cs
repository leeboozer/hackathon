using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Uicolumn
    {
        public Uicolumn()
        {
            CustomSortColumn = new HashSet<CustomSortColumn>();
        }

        public int UicolumnId { get; set; }
        public int UitableId { get; set; }
        public string UicolumnName { get; set; }
        public string UicolumnText { get; set; }
        public int? Ordinal { get; set; }

        public virtual ICollection<CustomSortColumn> CustomSortColumn { get; set; }
        public virtual Uitable Uitable { get; set; }
    }
}
