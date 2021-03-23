using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class customer
    {
        public customer()
        {
            addresses = new HashSet<address>();
            cards = new HashSet<card>();
            orders = new HashSet<order>();
            shoppingcarts = new HashSet<shoppingcart>();
            wishlists = new HashSet<wishlist>();
        }

        public int CustomerID { get; set; }
        public string Userpass { get; set; }
        public bool? HasMembership { get; set; }

        public virtual person Customer { get; set; }
        public virtual ICollection<address> addresses { get; set; }
        public virtual ICollection<card> cards { get; set; }
        public virtual ICollection<order> orders { get; set; }
        public virtual ICollection<shoppingcart> shoppingcarts { get; set; }
        public virtual ICollection<wishlist> wishlists { get; set; }
    }
}
