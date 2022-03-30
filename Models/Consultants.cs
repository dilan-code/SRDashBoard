using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SrDashboard_SR.Models
{
    public partial class Consultants
    {
        public Consultants()
        {
            ConsultantAccounts = new HashSet<ConsultantAccounts>();
            ConsultantComputers = new HashSet<ConsultantComputers>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public short? NonDisclosureAgreement { get; set; }
        public DateTime? NonDisclosureAgreementDate { get; set; }
        public long? SystemTypeId { get; set; }
        public long OfficeId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Offices Office { get; set; }
        public virtual SystemTypes SystemType { get; set; }
        public virtual ICollection<ConsultantAccounts> ConsultantAccounts { get; set; }
        public virtual ICollection<ConsultantComputers> ConsultantComputers { get; set; }
    }
}
