using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.Domain.Services.Interfaces
{
    public interface IOfficeService
    {
        ICollection<Offices> GetOffices();
        Offices GetOffice (int officeId);
    }
}