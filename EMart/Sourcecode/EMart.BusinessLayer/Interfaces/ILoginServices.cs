using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Interfaces
{
    public interface ILoginServices
    {
        User LoginUser(string Email, string Password);

        List<User> Users();

        User UserDetails (int UserId);
    }
}
