using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HorsePagesProject.Models.Entity;

namespace HorsePagesProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        HorsePagesEntities db = new HorsePagesEntities();
        public ActionResult Index()
        {
            var degerler = db.TBL_bilgiler.ToList();
            return View(degerler);
        }
    }
}