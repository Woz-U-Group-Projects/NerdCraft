using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class item
    {
        public item()
        {
            ordereditems = new HashSet<ordereditem>();
            shoppingcarts = new HashSet<shoppingcart>();
            wishlists = new HashSet<wishlist>();
        }

        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ItemType { get; set; }
        public string Seller { get; set; }
        public string ItemDesc { get; set; }
        public string Category { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<ordereditem> ordereditems { get; set; }
        public virtual ICollection<shoppingcart> shoppingcarts { get; set; }
        public virtual ICollection<wishlist> wishlists { get; set; }
    }
}
