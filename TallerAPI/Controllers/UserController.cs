using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Get(string username)
        {
            var response = userService.GetUser(username);

            if (response is null)
                return Response.StatusCode  //NotFound
            else
                return //OK
                   
        }
    }
}
