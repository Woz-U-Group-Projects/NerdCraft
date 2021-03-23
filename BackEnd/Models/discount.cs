using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class discount
    {
        public int DiscountID { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string DiscountCode { get; set; }
        public bool? Valid { get; set; }
    }
}
