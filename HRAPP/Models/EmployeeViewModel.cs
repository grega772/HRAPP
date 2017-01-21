using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using HRAPP.Models;
using System.Web;

namespace HRAPP.Models
{
    public class EmployeeViewModel
    {
        public List<Employee> employees;
        public EmployeeViewModel()
        {
            employees = new List<Employee>()
            {
               new Employee {name="Greg" },
               new Employee {name="Cam" }
            };
        }




    }
}