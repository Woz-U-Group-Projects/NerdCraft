using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class payment
    {
        public int OrderID { get; set; }
        public string CardComp { get; set; }
        public string CardName { get; set; }
        public string CardNum { get; set; }
        public DateTime CardExp { get; set; }
        public string CardSec { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string PostalID { get; set; }

        public virtual order Order { get; set; }
    }
}
