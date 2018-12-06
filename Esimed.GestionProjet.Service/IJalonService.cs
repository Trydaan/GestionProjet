using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;

namespace Esimed.GestionProjet.Service
{
    public interface IJalonService
    {
        List<Jalon> GetJalonByProjet(int p_id);

        //Projet GetProjetById(int p_id);

        string InsertJalon(DateTime p_livrprev, string p_libelle, int p_resp, int p_projet,
            DateTime? p_livrreelle = null);

        //string UpdateProjet(int p_id, string p_nom, string p_code, int p_resp);
    }
}
