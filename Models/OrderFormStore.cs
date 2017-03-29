using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderFormStore
    {
        public long OrderFormStoreId { get; set; }
        public long NpnOrderId { get; set; }
        public long FormId { get; set; }
        public int FormTypeId { get; set; }

        public virtual FormStore Form { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
