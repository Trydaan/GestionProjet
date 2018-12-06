using Esimed.GestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.ServiceDA
{
    public interface IProjetServiceDA
    {
        List<Projet> GetAllProjet();

        Projet GetProjetById(int p_id);

        int InsertProjet(string p_nom, string p_code, int p_resp);

        int UpdateProjet(string p_code, string p_nom, int p_resp, int p_id);

        int CountProjetByCode(string p_code);
    }
}
