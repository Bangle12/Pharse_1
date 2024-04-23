using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Partial_Subscribe()
        {
            return PartialView();
        }

        [HttpPost]
        
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       
   
    }
}