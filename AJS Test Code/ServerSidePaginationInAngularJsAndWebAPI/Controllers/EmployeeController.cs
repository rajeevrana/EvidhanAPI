using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServerSidePaginationInAngularJsAndWebAPI.DBOperation;
using ServerSidePaginationInAngularJsAndWebAPI.Models;

namespace ServerSidePaginationInAngularJsAndWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public EmployeeList GetEmployees(int pageIndex, int pageSize)
        {
            EmployeeInfo empInfo = new EmployeeInfo();
            EmployeeList empList = empInfo.GetEmployees(pageIndex, pageSize);
            return empList;
        }  
    }
}
