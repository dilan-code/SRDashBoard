using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.Domain.Services.Interfaces
{
    public interface IUserService
    {
        ICollection<Users> GetUsers();
        Users GetUser(int userId);
    }
}
