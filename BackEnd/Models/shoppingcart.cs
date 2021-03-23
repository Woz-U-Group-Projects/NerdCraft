using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class shoppingcart
    {
        public int CustomerID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public virtual customer Customer { get; set; }
        public virtual item Item { get; set; }
    }
}
