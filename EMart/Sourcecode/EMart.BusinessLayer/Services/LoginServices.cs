using EMart.BusinessLayer.Interfaces;
using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Services
{
    public class LoginServices 
    {
        User LoginUser(string Email, string Password)
        {
            User userlogin = new User();
            return userlogin;
        }
        List<User> UserList(int Id)
        {
            List<User> userlist = new List<User>();
            return userlist;


        }
    }
}
