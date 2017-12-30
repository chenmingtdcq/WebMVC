using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using WebMVC.ViewModel;

namespace WebMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string GetString()
        {
            return "Hello World is old now. It's time for wassup bro ;)";
        }

        //public ActionResult GetView()
        //{
        //    Employee emp = new Employee
        //    {
        //        FirstName = "Sukesh",
        //        LasrName = "Marla",
        //        Salary = 20000,
        //    };
        //    //ViewData["Employee"] = emp;
        //    //ViewBag.Employee = emp;
        //    //
        //    return View("ModelView",emp);
        //}

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LasrName = "Marla";
            emp.Salary = 20000;

            EmployeeInfo info = new EmployeeInfo()
            {
                EmployeeName = emp.FirstName + emp.LasrName,
                EmployeeSalary = emp.Salary.ToString(),
                UserName = "Admin",
            };
            if (emp.Salary > 15000)
                info.SalaryColor = "red";
            else
                info.SalaryColor = "yellow";

            return View("ViewModelView", info);
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustorerName = "Customer1";
            c.Address = "Address1";
            return c;
        }

        [NonAction]
        public string SimpleAction()
        {
            return "I am not a simple action";
        }
    }

    public class Customer
    {
        public string CustorerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustorerName + "|" + this.Address;
        }
    }
}