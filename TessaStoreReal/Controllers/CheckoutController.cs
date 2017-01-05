using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TessaStoreReal.Models;

namespace TessaStoreReal.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            CheckoutModel model = new CheckoutModel();
            return View(model);
        }

        public ActionResult Purchase(CheckoutModel model)
        {
            if (ModelState.IsValid)
            {
                using (StorefrontEntities entities = new Models.StorefrontEntities())
                {
                    Order o = new Order();
                    //o.FirstName = model.FirstName;
                    //o.LastName = model.LastName;
                    //o.EmailAddress = model.EmailAddress;
                    //o.PhoneNumber = model.PhoneNumber;
                    //o.CreditCardNumber = model.CreditCardNumber;
                    //o.CreditCardVerificationValue = model.CreditCardVerificationValue;
                    //o.CreditCardName = model.CreditCardName;
                    //o.CreditCardExp = new DateTime(model.CreditCardExpirationMonth, model.CreditCardExpirationYear);

                    entities.Orders.Add(o);
                    entities.SaveChanges();
                }


                //TODO: Validate cc number- if it errors out add model error and display it to user
                return RedirectToAction("Index", "Receipt", null);
            }
            return View(model);
        }
    }

}