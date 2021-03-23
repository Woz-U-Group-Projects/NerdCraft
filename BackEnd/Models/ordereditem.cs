using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class ordereditem
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int? Quantity { get; set; }

        public virtual item Item { get; set; }
        public virtual order Order { get; set; }
    }
}
