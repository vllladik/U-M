using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University_Manager.Areas.User.Controllers
{
    public class UserController : Controller
    {
        // GET: User/User
        public ActionResult UsersView()
        {
            return View();
        }
    }
}