﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSForm.Models;

namespace AngularJSForm.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
//        [HttpPost]  
//public JsonResult CreateCustomer(Customer model)  
//{  
//    if (ModelState.IsValid)  
//    {  
//        //Data save to database  
//        return Json(new  
//        {  
//            success = true  
//        });  
//    }  
//    return Json(new  
//    {  
//        success = false,  
//            errors = ModelState.Keys.SelectMany(i => ModelState[i].Errors).Select(m => m.ErrorMessage).ToArray()  
//    });  
//}  

        [HttpPost]  
    public JsonResult CreateCustomer(Customer model)  
    {  
        if (ModelState.IsValid)  
        {  
            //Data save to database  
            var RedirectUrl = Url.Action("About", "Home", new  
            {  
                area = ""  
            });  
            return Json(new  
            {  
                success = true, redirectUrl = RedirectUrl  
            });  
        }  
        return Json(new  
        {  
            success = false,  
                errors = ModelState.Keys.SelectMany(i => ModelState[i].Errors).Select(m => m.ErrorMessage).ToArray()  
        });  
    }  
    // GET: Home/About  
    public ActionResult About()  
    {  
        return View();  
    }  
    }
}
