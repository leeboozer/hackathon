using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CustomSortColumn
    {
        public int CustomSortColumnId { get; set; }
        public int CustomSortId { get; set; }
        public int UicolumnId { get; set; }
        public int SortOrderId { get; set; }
        public short? Ordinal { get; set; }

        public virtual CustomSort CustomSort { get; set; }
        public virtual SortOrder SortOrder { get; set; }
        public virtual Uicolumn Uicolumn { get; set; }
    }
}
