using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TessaStoreReal.Models;

namespace TessaStoreReal.Controllers
{
    public class ProductController : Controller
    {
        private static Product product = new Product();

        // GET: Product{id}
        public ActionResult Index(int? id)
        {
            using (TessaStoreReal.Models.StorefrontEntities entities = new StorefrontEntities())

            {
                var product = entities.Products.Single(x => x.ID == id);

                Product model = new Product();
                model.Name = product.Name;
                model.Quantity = product.Quantity;
                model.Type = product.Type;
                model.Price = product.Price;
                model.ImageUrl = product.ImageUrl;
                model.Description = product.Description;
                model.DateAdded = product.DateAdded;
                model.ID = product.ID;

                return View(model);

            }
        }

        //POST: Product{id}
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

            //TOOD: add div on checkout model to display, 
            //if(Request.Cookies.AllKeys.Contains("OrderID"))
            //{
               // int orderId=(Request.Cookies["OrderID"].Value);
               // using (TessaStoreReal.Models.StorefrontEntities entities = new Models.StorefrontEntities())
               // {
                   // var order = entities.Orders.Single(x => x.Id == orderId);
               // }
           // }
           //else{
           //     using (TessaStoreReal.Models.StorefrontEntities entities= new Models.StorefrontEntities())
           //     {
           //         Orders order = new Orders();
           //         entities.Orders.Add(order);
           //         entities.SaveChanges();
           //         Response.Cookies.Add(new HttpCookie("OrderID", order.Id.ToString()));
           //     }
           // }
            return RedirectToAction("Index","Cart", new { name=product.Name, quantity=product.Quantity, type=product.Type, price=product.Price, imageurl=product.ImageUrl, description=product.Description, dateadded=product.DateAdded, id=product.ID  } );
        }

    }


}

