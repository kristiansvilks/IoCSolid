using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IoCSolid.Models;
using IoCSolid.Interfaces;
using IoCSolid.Repository;

namespace IoCSolid.Controllers
{
    public class ProductController : Controller
    {        
        private IServices services;

        public ProductController(IServices services)
        {        
            this.services = services;
        }

        public ActionResult AllInStock()
        {
            return View(services.GetAllInStock());
        }

        public ActionResult Laptops()
        {
            return View(services.GetAllLaptops());
        }

        public ActionResult Mobiles()
        {
            return View(services.GetAllMobiles());
        }

        public ActionResult MobilesInStock()
        {
            return View(services.GetAllMobilesInStock());
        }

        public ActionResult LaptopsInStock()
        {
            return View(services.GetAllLaptopsInStock());
        }

        public ActionResult Undefined()
        {
            return View(services.GetAllUndefined());
        }
    }
}
