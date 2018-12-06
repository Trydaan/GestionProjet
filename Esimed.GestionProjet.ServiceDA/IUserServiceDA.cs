using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;

namespace Esimed.GestionProjet.ServiceDA
{
    public interface IUserServiceDA
    {
        List<User> GetAllUsers();

        //bool SaveUser(User p_user);
    }
}
