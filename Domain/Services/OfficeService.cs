using Microsoft.EntityFrameworkCore;
using SrDashboard_SR.Domain.Services.Interfaces;
using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.Domain.Services
{
    public class OfficeService : IOfficeService
    {

            private readonly AteamContext _dbContext;
            public OfficeService(AteamContext dbContext)
            {
                _dbContext = dbContext;
            }
            public Offices GetOffice(int officeId)
            {
                var office = _dbContext.Offices.FirstOrDefault(x => x.Id == officeId);
                return office;
            }

            public ICollection<Offices> GetOffices()
            {
                var offices = _dbContext.Offices.AsNoTracking().ToList();
                return offices;
            }
        }
    }
