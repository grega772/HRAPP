using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRAPP.Models;
using System.Web.Mvc;

namespace HRAPP.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {

            return View(new EmployeeViewModel());
        }

        public ActionResult Employees()
        {

            return View();
        }
    }
}