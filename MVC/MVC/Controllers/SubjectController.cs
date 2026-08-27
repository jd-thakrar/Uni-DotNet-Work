using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            Subject s1 = new Subject();
            s1.Code = "CE01";
            s1.Name = ".Net";
            s1.Credit = 4;
            return View("Subject", s1);
        }
    }
}