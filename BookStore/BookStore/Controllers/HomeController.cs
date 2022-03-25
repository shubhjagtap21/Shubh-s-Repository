using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            //return View("TempView/ShubhamTemp.cshtml");//fullpathview
            //return View("../../TempView/ShubhamTemp.cshtml");//relative view
            //var obj = new { id = 1, name = "Shubham" };
            //return View(obj);
            //return View("ContactUs");
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
