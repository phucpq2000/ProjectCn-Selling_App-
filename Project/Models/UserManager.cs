using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Models;

namespace Project.Models
{

    public class UserManager
    {
        Web2034Entities1 db = new Web2034Entities1();
        public bool checkName (string name)
        {
            List<User> userList = (from user in db.User where user.Name == name select user).ToList();  // câu lện data base
            if (userList.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkEmail(string email)
        {
            List<User> emailList = (from user in db.User where user.Email == email select user).ToList();  // câu lện data base
            if (emailList.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkPassword(string password)
        {
            List<User> passList = (from user in db.User where user.Password == password select user).ToList(); // câu lện data base
            if (passList.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkLoginA(string Password, string Email)
        {
            User user = db.User.Where(m => m.Email == Email).FirstOrDefault(); 
            if (user != null)
            {
                if (user.Password == Password)
                    return true;

            }
            return false;
        }
    }
}