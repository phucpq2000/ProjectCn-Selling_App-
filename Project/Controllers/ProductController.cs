using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;
namespace Project.Controllers
{
    public class ProductController : Controller
    {
        Web2034Entities1 db = new Web2034Entities1();

        
        public ActionResult Chitiet(int id)
        {
            var product = db.Product.Where(m => m.Product_id == id).FirstOrDefault();
            ShopingPhone shoping = new ShopingPhone()
            {
                Productdetail = product,
                Quantity = 1
            };
            //{

            //     Quantity = 1
            //};
            return View(shoping);
        }

        public ActionResult Cart()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(ShopingPhone phone)
        {
            var sessionId = HttpContext.Session.SessionID;
            ViewBag.SessionID = sessionId;

            Phone phones = (Phone)HttpContext.Session["phone"];
                if (phones == null)
            {
                phones = new Phone();
                phones.AddToCart(phone);
            }
            else
            {
                phones.AddToCart(phone);
                HttpContext.Session.Add("phone", phones);
            }
            List<ShopingPhone> items = phones.getAlltems();
            return View("cart", items);
        }


    }
}