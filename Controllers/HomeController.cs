// =====================================================
// Session demo with short explanation
// https://www.c-sharpcorner.com/article/how-to-use-session-in-asp-net-core/
// ======================================================

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using SessionState01.Models;


namespace SessionState01.Controllers
{
    public class HomeController : Controller // ---------------------------------------------------
    {
        const string SessionName = "_Name";
        const string SessionAge = "_Age";
       
        

        public IActionResult Index()
        {
            // HttpContext is an abstract class
            // Session is a property of HttpContext that implements ISession interface
            // SetString SetInt32 are extension methods on Session
            HttpContext.Session.SetString(SessionName, "Jarvik");
            HttpContext.Session.SetInt32(SessionAge, 24);
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
            ViewData["Message"] = "Asp.Net Core !!!.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    } // eo HomeController class ------------------------------------------------------------------
   
} // eo namespace
