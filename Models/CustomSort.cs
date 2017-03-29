using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CustomSort
    {
        public CustomSort()
        {
            CustomSortColumn = new HashSet<CustomSortColumn>();
        }

        public int CustomSortId { get; set; }
        public long ClientUserId { get; set; }
        public string CustomSortName { get; set; }
        public string FilterFieldName { get; set; }
        public string FilterFieldValue { get; set; }
        public bool? UseThisSort { get; set; }

        public virtual ICollection<CustomSortColumn> CustomSortColumn { get; set; }
        public virtual ClientUser ClientUser { get; set; }
    }
}
