using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.DataTransferObject
{
    public class ConsultantAccountResponseDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ConsultantId { get; set; }
        public long AccountTypeId { get; set; }
        public long EnvironmentTypeId { get; set; }
        public DateTime? ExpireAt { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? PasswordExpireAt { get; set; }
    }
}

