using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;



namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Web2034Entities db = new Web2034Entities();
        public ActionResult Index()
        {
            List<User> listOfUser = db.User.ToList();
            return View(listOfUser);
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
        
        
        // các bước add giá trị
        [HttpGet]
        public ActionResult addUser()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public ActionResult addUser(User user)
        {
            db.User.Add(user);
            db.SaveChanges(); //hàm save co sẳn

            return RedirectToAction("index");




        }
        public ActionResult DeleteUser(int id)
        {
            //remove item in db
            var user = db.User.Where(c => c.id == id).SingleOrDefault();
            db.User.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        public ActionResult EditUser(User user)
        {
            var _user = db.User.Where(c => c.id == user.id).SingleOrDefault();
            _user.Name = user.Name;
            _user.Email = user.Email;
            _user.Phone = user.Phone;
            _user.Password = user.Password;
            
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult EditUser(int id)
        {
            var _user = db.User.Where(c => c.id == id).SingleOrDefault();
            return View(_user);
        }

    }
}