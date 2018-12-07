using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;
using Esimed.GestionProjet.ServiceDA;

namespace Esimed.GestionProjet.Service
{
    public class JalonService : IJalonService
    {
        public List<Jalon> GetJalonByProjet(int p_id)
        {            
            return FEsimedServiceDA.CreateJalonServiceDA().GetJalonByProjet(p_id);
        }

        public Jalon GetJalonById(int p_id)
        {
            return FEsimedServiceDA.CreateJalonServiceDA().GetJalonById(p_id);
        }

        public string InsertJalon(DateTime p_livrprev, string p_libelle, int p_resp, int p_projet, DateTime? p_livrreelle = null)
        {
            return FEsimedServiceDA.CreateJalonServiceDA().InsertJalon(p_livrprev, p_libelle, p_resp, p_projet, p_livrreelle);           
        }

        public string UpdateJalon(DateTime p_livrprevu, string p_libelle, int p_resp, int p_id)
        {

            return FEsimedServiceDA.CreateJalonServiceDA().UpdateJalon(p_livrprevu, p_libelle, p_resp, p_id);
            
        }
    }
}
