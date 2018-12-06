using Esimed.GestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.ServiceDA;
using Esimed.GestionProjet.ServiceDA.db_GestionProjetDataSetTableAdapters;


namespace Esimed.GestionProjet.ServiceDA
{
    public class UserServiceDA : IUserServiceDA
    {        
        public List<User> GetAllUsers()
        {
            List<User> v_users = new List<User>();
            foreach (db_GestionProjetDataSet.UserRow ur in new UserTableAdapter().GetUsers())
            {
                v_users.Add(FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<User>(ur));
            }
            return v_users;            
        }

        //public bool SaveUser(User p_user)
        //{
        //    return FEsimedServiceDA.CreateCsvServiceDA().WriteFile<User>(path, p_user);
        //}


        
    }
}
