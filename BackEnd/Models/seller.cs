using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class seller
    {
        public int SellerID { get; set; }
        public int? ID { get; set; }
        public int? ItemID { get; set; }
        public string SellerName { get; set; }
        public string SellerDesc { get; set; }
        public string SellerEmail { get; set; }
        public string SellerPhone { get; set; }
    }
}
