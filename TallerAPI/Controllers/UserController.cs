using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TallerAPI.Entities;
using TallerAPI.Services;

namespace TallerAPI.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public User Get(string username)
        {
            var user = userService.GetUser(username);

            //if (user is null)
            //    HttpStatusCode.NotFound;
            //else
            //    HttpStatusCode.OK;

            return user;
                   
        }
    }
}
