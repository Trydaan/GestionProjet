using Esimed.GestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.ServiceDA
{
    public interface IJalonServiceDA
    {
        List<Jalon> GetJalonByProjet(int p_id);

        string InsertJalon(DateTime p_livrprev, string p_libelle, int p_resp, int p_projet, 
            DateTime? p_livrreelle = null);

        Jalon GetJalonById(int p_id);

        string UpdateJalon(DateTime p_livrprevu, string p_libelle, int p_resp, int p_id);
    }
}
