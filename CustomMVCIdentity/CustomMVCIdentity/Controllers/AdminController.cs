//using System;
//using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentityManagement.DAL;
using IdentityManagement.Data;
using IdentityManagement.Entities;

namespace CustomMVCIdentity.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUser(string id)
        {
            ApplicationUser user = UserController.GetUser(id);
            return View(user);
        }

        public ActionResult GetUserByUsername(string userName)
        {
            ApplicationUser user = UserController.GetUserByUsername(userName);
            return View(user);
        }
    }
}
