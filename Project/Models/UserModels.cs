using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class UserModels
    {
        public class RegisterModel
        {
            public String Name { get; set; }
            public String Email { get; set; }
            public String Phone { get; set; }
            public String Password { get; set; }
            public String Confinm_Password { get; set; }
        }

        public class loginModel
        {
            public String Email { get; set; }
            public String Password { get; set; }
        }

        
    }
}