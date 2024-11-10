using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerAPI.Entities;
using TallerAPI.Repositories;

namespace TallerAPI.Services
{
    public class UserService
    {

        UserRepository userRepository = new UserRepository();
        public User GetUser(string username)
        {
            var user = userRepository.GetUser();

            return user;

        }
    }
} 
