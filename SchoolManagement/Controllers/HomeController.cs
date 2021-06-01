using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
        }
        
    }
}
