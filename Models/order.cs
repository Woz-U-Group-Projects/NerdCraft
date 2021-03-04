using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class order
    {
        public order()
        {
            ordereditems = new HashSet<ordereditem>();
        }

        public int OrderNum { get; set; }
        public int? CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public bool? Completed { get; set; }
        public string OrderName { get; set; }
        public string OrderEmail { get; set; }

        public virtual customer Customer { get; set; }
        public virtual payment payment { get; set; }
        public virtual shipment shipment { get; set; }
        public virtual ICollection<ordereditem> ordereditems { get; set; }
    }
}
