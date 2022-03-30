using Microsoft.EntityFrameworkCore;
using SrDashboard_SR.Domain.Services.Interfaces;
using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.Domain.Services
{
    public class ConsultantAccountService : IConsultantAccountService
    {
        private readonly AteamContext _dbContext;

        public ConsultantAccountService(AteamContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ConsultantAccounts GetConsultantAccount(int consultantAccountId)
        {
            var consultantAccount = _dbContext.ConsultantAccounts.FirstOrDefault(x => x.Id == consultantAccountId);
            return consultantAccount;
        }

        public ICollection<ConsultantAccounts> GetConsultantAccounts()
        {
            var consultantAccounts = _dbContext.ConsultantAccounts.AsNoTracking().ToList();
            return consultantAccounts;
        }

        public ICollection<ConsultantAccounts> GetConsultantsAccounts()
        {
            var consultantAccounts = _dbContext.ConsultantAccounts.AsNoTracking().ToList();
            return consultantAccounts;
        }
    }
}
    

