using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {
            Student s1 = new Student();
            s1.StudentID = 1;
            s1.Name = "Jeet";
            s1.Description = "Testing";
            s1.PhoneNo = "+91 96244 49764";

            return View( s1);
        }
    }
}