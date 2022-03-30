using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.Domain.Services.Interfaces
{
    public interface IConsultantService
    {
        ICollection<Consultants> GetConsultants();
        Consultants GetConsultant(int consultantId);
    }
}
