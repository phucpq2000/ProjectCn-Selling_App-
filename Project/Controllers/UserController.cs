using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;
using static Project.Models.UserModels;

namespace Project.Controllers
{
    public class UserController : Controller
    {
        Web2034Entities1 db = new Web2034Entities1();
        // GET: User





        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {

            
                var check = db.User.Where(f => f.Name == user.Name).SingleOrDefault();
                if (check == null)
                {
                    User user1 = new User();
                    user1.Name = user.Name;
                    user1.Email = user.Email;
                    user1.Phone = user.Phone;
                    user1.Password = user.Password;

                    db.User.Add(user1);
                    db.SaveChanges();
                    return RedirectToAction("login"); // chuyen trang
                }
            else
            {
                return View();

            }
        }

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    User user = new User();
        //    return View(user);
        //}
        //[HttpPost]
        //public ActionResult Create(User user)
        //{
        //    db.User.Add(user);
        //    db.SaveChanges(); //hàm save co sẳn
        //    return RedirectToAction("login","User");
        //}



        [HttpGet]
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(User user)
        {
            var Check = db.User.Where(s => s.Name == user.Name && s.Password == user.Password).SingleOrDefault();
            if (Check == null)
            {
                return View();
            }
            else
            {
                Session["user"] = user.Name;
                return RedirectToAction("Index", "Home");

            }
        }


    }
}

       