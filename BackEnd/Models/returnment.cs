using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class returnment
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int? Quantity { get; set; }
        public string Comments { get; set; }
        public bool? Approval { get; set; }
    }
}
