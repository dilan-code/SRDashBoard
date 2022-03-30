using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.DataTransferObject
{
    public class ConsultantResponseDto
    {
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
    }
}
