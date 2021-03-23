using System;
using System.Collections.Generic;

#nullable disable

namespace NerdCraft.Models
{
    public partial class employee
    {
        public employee()
        {
            InverseSupervisorNavigation = new HashSet<employee>();
        }

        public int ID { get; set; }
        public string EmployeeEmail { get; set; }
        public string Supervisor { get; set; }
        public string Userpass { get; set; }

        public virtual person IDNavigation { get; set; }
        public virtual employee SupervisorNavigation { get; set; }
        public virtual ICollection<employee> InverseSupervisorNavigation { get; set; }
    }
}
