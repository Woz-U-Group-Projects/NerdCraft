using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class address
    {
        public int CustomerID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string PostalID { get; set; }

        public virtual customer Customer { get; set; }
    }
}
