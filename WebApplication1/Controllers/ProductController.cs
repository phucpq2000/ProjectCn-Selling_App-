using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        Web2034Entities db = new Web2034Entities();
        // GET: Product
        public ActionResult ListOfProduct()
        {

            // GET: Product
            List<Product> web = db.Product.ToList();
            return View(web);

        }
        // them listofproduct
        [HttpGet]
        public ActionResult Addproduct()
        {
            Product product = new Product();
            return View(product);
        }
        [HttpPost]
        public ActionResult Addproduct(Product product)
        {
            db.Product.Add(product);
            db.SaveChanges(); //hàm save co sẳn

            return RedirectToAction("ListOfProduct");




        }
        // xoa sua 
     
       

        [HttpPost]
        public ActionResult Editproduct(Product product)
        {
            var _product = db.Product.Where(c => c.Product_id == product.Product_id).SingleOrDefault();
            _product.Product_name = product.Product_name;
            _product.Product_img = product.Product_img;
            _product.Product_company = product.Product_company;
            _product.Product_size = product.Product_size;
            _product.Product_money = product.Product_money;

            db.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
        public ActionResult Editproduct(int id)
        {
            // tim chinh xac mot doi tuong co id tuong ung
            var _product = db.Product.Where(c => c.Product_id == id).SingleOrDefault();
            return View(_product);

        }
        // xoa
        [HttpGet]
        public ActionResult DeleteCategory(int id)
        {
            //remove item in db
            Product product = db.Product.Where(c => c.Product_id == id).SingleOrDefault();
            db.Product.Remove(product);
            db.SaveChanges();
            return RedirectToAction("listOfProduct");
        }
    }
}