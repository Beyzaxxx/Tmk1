using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Products()
        {
            
            return View();
        }

        public ActionResult Fınger()
        {
            return View();
        }
        public ActionResult Pallet()
        {
            return View();
        }
        public ActionResult Timber()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
       
    }
}