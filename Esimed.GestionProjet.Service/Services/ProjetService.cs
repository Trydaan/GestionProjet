using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;
using Esimed.GestionProjet.ServiceDA;

namespace Esimed.GestionProjet.Service
{
    public class ProjetService : IProjetService
    {
        public List<Projet> GetAllProjet()
        {            
            return FEsimedServiceDA.CreateProjetServiceDA().GetAllProjet();
        }

        public Projet GetProjetById(int p_id)
        {
            return FEsimedServiceDA.CreateProjetServiceDA().GetProjetById(p_id);
        }

        public string InsertProjet(string p_nom, string p_code, int p_resp)
        {
            //TODO : vérif caractere unique du trigramme
            int result = FEsimedServiceDA.CreateProjetServiceDA().InsertProjet(p_nom, p_code, p_resp);

            return result > 0 ? "Projet ajouté" : "Erreur : projet non ajouté";
        }

        public string UpdateProjet(int p_id, string p_nom, string p_code, int p_resp)
        {
            int result = FEsimedServiceDA.CreateProjetServiceDA().UpdateProjet(p_code, p_nom, p_resp, p_id);

            return result > 0 ? "Projet modifié" : "Erreur : projet non modifié";
        }

        public int CountByCode(string p_code)
        {
            return FEsimedServiceDA.CreateProjetServiceDA().CountProjetByCode(p_code);
        }
    }
}
