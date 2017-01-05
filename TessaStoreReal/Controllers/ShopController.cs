using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TessaStoreReal.Models;

namespace TessaStoreReal.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            using (TessaStoreReal.Models.StorefrontEntities entities = new Models.StorefrontEntities())
            {
                var product = entities.Products.ToArray();


                return View(product);
                //add images to content, store urls in database
            };


        }
    }
}