using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class UserLoginController : Controller
    {
        public IActionResult Index(UserModel user)
        {
            if (ModelState.IsValid)
            {
                //数据验证
                return Redirect("/UserLogin/LoginData");
            }
            return View();
        }

        public IActionResult LoginData()
        {
            return View();
        }
    }
}