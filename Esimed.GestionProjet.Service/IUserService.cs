using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;

namespace Esimed.GestionProjet.Service
{
    public interface IUserService
    {
        List<User> GetAllUser();

        //Projet GetProjetById(int p_id);

        //string InsertProjet(string p_nom, string p_code, int p_resp);

        //string UpdateProjet(int p_id, string p_nom, string p_code, int p_resp);
    }
}
