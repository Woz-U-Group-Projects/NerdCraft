using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class person
    {
        public person()
        {
            employees = new HashSet<employee>();
        }

        public int ID { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Phone { get; set; }
        public DateTime DateJoined { get; set; }
        public bool IsEmployee { get; set; }

        public virtual customer customer { get; set; }
        public virtual ICollection<employee> employees { get; set; }
    }
}
