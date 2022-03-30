using Microsoft.EntityFrameworkCore;
using SrDashboard_SR.Domain.Services.Interfaces;
using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class UserService : IUserService
    {
        private readonly AteamContext _dbContext;

        public UserService(AteamContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get a user, by specific id
        public Users GetUser(int userId)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == userId);
            return user;
        }
        
        // Get all users
        public ICollection<Users> GetUsers()
        {
            var users = _dbContext.Users.AsNoTracking().ToList();
            return users;
        }

    }
