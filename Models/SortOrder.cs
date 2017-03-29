using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SortOrder
    {
        public SortOrder()
        {
            CustomSortColumn = new HashSet<CustomSortColumn>();
        }

        public int SortOrderId { get; set; }
        public string SortOrderName { get; set; }

        public virtual ICollection<CustomSortColumn> CustomSortColumn { get; set; }
    }
}
