using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyStudentName()
        {

            Student st = new Student();
            st.student_name = "Mohammad Koeik";
            return View(st);
        }
    }
}