using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.DataTransferObject
{
    public class ConsultantAccountRequestDto
    {
        public string Name { get; set; }
        public long? ConsultantId { get; set; }
        public long AccountTypeId { get; set; }
    }
}
