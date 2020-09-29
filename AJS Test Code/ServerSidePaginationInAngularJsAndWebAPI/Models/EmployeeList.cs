using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSidePaginationInAngularJsAndWebAPI.Models
{
    public class EmployeeList
    {
        public List<Employee> employees { get; set; }
        public string totalCount { get; set; }
    }  
}