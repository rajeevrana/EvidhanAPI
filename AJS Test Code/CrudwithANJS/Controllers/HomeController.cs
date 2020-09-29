using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudwithANJS.Models;

namespace CrudwithANJS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getAll()
        {
            
            using (sampleEntities dataContext = new sampleEntities())
            {
                var employeeList = dataContext.employee1.ToList();
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult getEmployeeByNo(string EmpNo)
        {
            using (sampleEntities dataContext = new sampleEntities())
            {
                int no = Convert.ToInt32(EmpNo);
                var employeeList = dataContext.employee1.Find(no);
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }
        public string UpdateEmployee(employee1 Emp)
        {
            if (Emp != null)
            {
                using (sampleEntities dataContext = new sampleEntities())
                {
                    int no = Convert.ToInt32(Emp.id);
                    var employeeList = dataContext.employee1.Where(x => x.id == no).FirstOrDefault();
                    employeeList.name = Emp.name;
                    employeeList.mobile_no = Emp.mobile_no;
                    employeeList.email = Emp.email;
                    dataContext.SaveChanges();
                    return "Employee Updated";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }
        public string AddEmployee(employee1 Emp)
        {
            if (Emp != null)
            {
                using (sampleEntities dataContext = new sampleEntities())
                {
                    dataContext.employee1.Add(Emp);
                    dataContext.SaveChanges();
                    return "Employee Updated";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }

        public string DeleteEmployee(employee1 Emp)
        {
            if (Emp != null)
            {
                using (sampleEntities dataContext = new sampleEntities())
                {
                    int no = Convert.ToInt32(Emp.id);
                    var employeeList = dataContext.employee1.Where(x => x.id == no).FirstOrDefault();
                    dataContext.employee1.Remove(employeeList);
                    dataContext.SaveChanges();
                    return "Employee Deleted";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }

    }
}
