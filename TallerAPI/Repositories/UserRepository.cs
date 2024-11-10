using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Fluent.Infrastructure.FluentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TallerAPI.Entities;

namespace TallerAPI.Repositories
{
    
    public class UserRepository
    {

        private readonly IConfiguration _configuration;
        String connString = "";

        public UserRepository()
        {
            connString = _configuration.GetConnectionString("DefaultConnection");
        }

        public UserRepository GetUser(String username)
        {

            using (var context = new DatabaseContext())
            {
                var userUsername = new SqlParameter("@username", username);

                var result = context.Database
                    .SqlQuery<User>("GetUser @username", userUsername)
                    .ToList();
            }

        }


    } 
}
