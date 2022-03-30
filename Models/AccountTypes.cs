using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SrDashboard_SR.Models
{
    public partial class AccountTypes
    {
        public AccountTypes()
        {
            ConsultantAccounts = new HashSet<ConsultantAccounts>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ConsultantAccounts> ConsultantAccounts { get; set; }
    }
}
