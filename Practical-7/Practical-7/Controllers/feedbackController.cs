using Practical_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_7.Controllers
{
    public class feedbackController : Controller
    {
        // GET: feedback
        public ActionResult Index()
        {
            return View("feedback");
        }

        [HttpPost]
        public ActionResult feedback(feedback model)
        {
            if (ModelState.IsValid)
            {
                return View("thankyou", model);
            }
            return View(model);
        }
    }
}