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
            HttpContext.Session.SetString(SessionName, "Russell");
            HttpContext.Session.SetInt32(SessionAge, 71);
            return View();
        }

        public IActionResult About()
        {
            HttpContext ctx = this.HttpContext;
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
            ViewData["Message"] = "Asp.Net Core !!!.";


            return View(ctx);
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

        public PullHdr MakePullOrder() // create a Pull order for testing
        {
            PullHdr pull = new PullHdr
            {
                PullHdrId = 99,
                PullDate = DateTime.Now.Date,
                LocationId = "SHTO",
                Destination = "Coldspring TX",
                Requester = "R Fisher",
                ReqEmail = "russell.fisher@redcross.org",
                ReqPhone = "832-316-7737",
                Status = "Open",
                Comment = "Session Practice",
                
            };
            pull.PullItems.Add(                                            
                new PullItem {PullItemId=11, ItemId = "OS-P950", UoM = "PKG", PullHdrId = 2, QtyReq = 18, QtyShp = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" });
            pull.PullItems.Add(
                new PullItem { PullItemId = 12, ItemId = "OS-D283", PullHdrId = 2, QtyReq = 25, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment="Test Item 2" } );
            pull.PullItems.Add(
                new PullItem { PullItemId = 13, ItemId = "KF-D46", UoM = "PKG", PullHdrId = 1, QtyReq = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "Test Item 3" } );
            pull.PullItems.Add(    
                    new PullItem { PullItemId = 14, ItemId = "BD-D275", UoM = "Bx", PullHdrId = 1, QtyReq = 2, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "Test Item 4" });
            return pull ;
        }
    } // eo HomeController class ------------------------------------------------------------------
   
} // eo namespace
