using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Courses2Controller : Controller
    {
        ContosoUniversityEntities db = new ContosoUniversityEntities();

        public ActionResult Index()
        {
            var data = db.Course.ToList();

            return View(data);
        }
    }
}