using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
         Web2034Entities db = new Web2034Entities();
        // GET:User
        public ActionResult listUser(int id)
        {
            User us = db.User.FirstOrDefault(x => x.id == id);
            return View(us);

        }
            // xoa sua 
        [HttpGet]
        public ActionResult EditUser(int id)
        {
            // tim chinh xac mot doi tuong co id tuong ung
           User user= db.User.Where(c => c.id == id).SingleOrDefault();
            return View(user);
             
        }
        // eidt
        [HttpPost]
        public ActionResult EditUser( User user)
        {
            if (ModelState.IsValid)
            {

                // find into table category
               User user1 = db.User.Where(c => c.id == user.id).SingleOrDefault();
                //update category name
               user1.Name = user.Name;
              


               db.SaveChanges();

                return RedirectToAction("listOfUser");
            }
            return View(user);

        }
       
        // xoa
        public ActionResult DeleteUser(int id)
        {
            //remove item in db
           var user = db.User.Where(c => c.id == id).SingleOrDefault();
            //db.User.Remove(user);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
