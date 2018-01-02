using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.ViewModel
{
    public class EmployeeListInfo
    {
        public List<EmployeeInfo> ListEmployee { get; set; }
        public string UserName { get; set; }
    }
}