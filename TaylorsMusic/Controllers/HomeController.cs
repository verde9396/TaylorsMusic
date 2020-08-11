using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaylorsMuic.Data.Services;

namespace TaylorsMusic.Controllers
{
    public class HomeController : Controller
    {
        IHerData db;
        public HomeController(IHerData db)
        {
          this.db = db;
        }
      
        public ActionResult Index()
        {
           
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}