﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TessaStoreReal.Models;

namespace TessaStoreReal.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Product product)
        {
            string name = product.Name;
            int? quantity = product.Quantity;
            string type = product.Type;
            decimal? price = product.Price;
            string imageurl = product.ImageUrl;
            string description = product.Description;
            DateTime dateadded = product.DateAdded;
            int id = product.ID;

            return RedirectToAction("Index", "Checkout", new { name = product.Name, quantity = product.Quantity, type = product.Type, price = product.Price, imageurl = product.ImageUrl, description = product.Description, dateadded = product.DateAdded, id = product.ID });

        }

    }
}