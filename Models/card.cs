using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class card
    {
        public int CustomerID { get; set; }
        public string CardComp { get; set; }
        public string CardName { get; set; }
        public string CardNum { get; set; }
        public DateTime CardExp { get; set; }
        public string CardSec { get; set; }

        public virtual customer Customer { get; set; }
    }
}
