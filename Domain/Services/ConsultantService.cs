using Microsoft.EntityFrameworkCore;
using SrDashboard_SR.Domain.Services.Interfaces;
using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.Domain.Services
{
    public class ConsultantService : IConsultantService
    {
        private readonly AteamContext _dbContext;

        public ConsultantService(AteamContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Consultants GetConsultant(int consultantId)
        {
            var consultant = _dbContext.Consultants.FirstOrDefault(x => x.Id == consultantId);
            return consultant;
        }

        public ICollection<Consultants> GetConsultants()
        {
            var consultants = _dbContext.Consultants.AsNoTracking().ToList();
            return consultants;
        }
    }
}
