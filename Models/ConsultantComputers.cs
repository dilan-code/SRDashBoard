using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SrDashboard_SR.Models
{
    public partial class ConsultantComputers
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ConsultantId { get; set; }
        public long ComputerTypeId { get; set; }
        public long? EnvironmentTypeId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ComputerTypes ComputerType { get; set; }
        public virtual Consultants Consultant { get; set; }
        public virtual EnvironmentTypes EnvironmentType { get; set; }
    }
}
