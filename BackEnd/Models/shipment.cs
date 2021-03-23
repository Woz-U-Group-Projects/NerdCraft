using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class shipment
    {
        public int OrderID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string PostalID { get; set; }
        public int Fee { get; set; }
        public string Company { get; set; }
        public string ShipName { get; set; }

        public virtual order Order { get; set; }
    }
}
