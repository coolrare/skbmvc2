using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Courses2Controller : Controller
    {
        StringBuilder sb = new StringBuilder();
        ContosoUniversityEntities db = new ContosoUniversityEntities();

        CourseRepository repo = RepositoryHelper.GetCourseRepository();

        public Courses2Controller()
        {
            db.Database.Log = (sql) => sb.AppendLine(sql);
        }

        public ActionResult Index()
        {
            // var data = db.Course.ToList();

            var data = repo.All();

            var item = repo.Get單一筆資料(1);

            var agit = repo.Get所有Git課程();

            return View(data);
        }

        public ActionResult ListByDepartment(int deptId)
        {
            //var data = db.Course.Where(p => p.DepartmentID == deptId).ToList();
            var dept = db.Department.Include(p => p.Course);
            var data = dept.First(p => p.DepartmentID == deptId).Course.ToList();
            return Content(sb.ToString(), "text/plain");
            //return View(data);
        }

        public ActionResult ListStudents(int id)
        {
            var cour = db.Course.Include(p => p.Students).First(p => p.CourseID == id);
            var data = cour.Students;
            //return Content(sb.ToString(), "text/plain");
            return View(data);
        }

        public ActionResult UpdateCredits(int credit)
        {
            var data = db.Course.ToList();

            foreach (var item in data)
            {
                item.Credits += credit;
            }

            db.SaveChanges();

            return Content(sb.ToString(), "text/plain");
        }

        public ActionResult InsertCredits()
        {
            var course = new Course()
            {
                Title = "SKB MVC",
                Credits = 5,
                DepartmentID = 2
            };

            db.Course.Add(course);

            db.SaveChanges();

            sb.AppendLine("Inserted ID is " + course.CourseID);

            return Content(sb.ToString(), "text/plain");
        }

        public ActionResult DeleteCredits()
        {
            var c = db.Course.Find(15);
            db.Course.Remove(c);

            //var c = new Course() { CourseID = 15 };
            //db.Course.Attach(c);
            //db.Course.Remove(c);

            db.SaveChanges();

            return Content(sb.ToString(), "text/plain");
        }
    }
}