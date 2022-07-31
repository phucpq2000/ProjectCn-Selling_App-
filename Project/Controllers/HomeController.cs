using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        Web2034Entities1 db = new Web2034Entities1();
        public ActionResult Index()
        {
            List<Product> web = db.Product.ToList();
            return View(web);
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



        //public ActionResult homeCart()
        //{
        //    return View();
        //}

        //      [HttpPost]
        //public ActionResult AddToCart(ItemDetail model)
        //{
        //    var sessionID = HttpContext.Session.SessionID;
        //    ViewBag.SessionID = sessionID;
        //    Cart carts = (Cart)HttpContext.Session["cart"];
        //    if (carts == null)
        //    {
        //        carts = new Cart();
        //        carts.AddToCart(model);
        //        HttpContext.Session.Add("cart", carts);
        //    }
        //    else
        //    {
        //        carts.AddToCart(model);
        //        HttpContext.Session.Add("cart", carts);
        //    }
        //    List<ItemDetail> items = carts.getAllItems();
        //    ViewBag.Total = carts.getTotal();
        //    return View("Catelogy", items);

        }
    }
    
