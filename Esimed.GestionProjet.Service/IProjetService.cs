using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;

namespace Esimed.GestionProjet.Service
{
    public interface IProjetService
    {
        List<Projet> GetAllProjet();

        Projet GetProjetById(int p_id);

        string InsertProjet(string p_nom, string p_code, int p_resp);

        string UpdateProjet(int p_id, string p_nom, string p_code, int p_resp);

        int CountByCode(string p_code);
    }
}
