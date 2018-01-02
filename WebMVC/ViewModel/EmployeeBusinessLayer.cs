using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC.Models;

namespace WebMVC.ViewModel
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){
                    FirstName="John",
                    LasrName="Yoshom",
                    Salary=20000
                },
                new Employee(){
                    FirstName="Wison",
                    LasrName="Hohn",
                    Salary=15000
                },
                new Employee(){
                    FirstName="Tony",
                    LasrName="Qdkm",
                    Salary=10000
                },
            };
            return employees;
        }
    }
}