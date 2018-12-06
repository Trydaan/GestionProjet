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
    public class ProjetServiceDA : IProjetServiceDA
    {        
        public List<Projet> GetAllProjet()
        {
            List<Projet> v_projets = new List<Projet>();
            foreach (db_GestionProjetDataSet.ProjetRow pr in new ProjetTableAdapter().GetProjets())
            {
                v_projets.Add(FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Projet>(pr));
            }
            return v_projets;
        }

        public Projet GetProjetById(int p_id)
        {            
            db_GestionProjetDataSet.ProjetRow pr = new ProjetTableAdapter().GetProjetById(p_id)[0];

            Projet v_projet = FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Projet>(pr);

            return v_projet;
        }

        public int InsertProjet(string p_nom, string p_code, int p_resp)
        {
            
            return new ProjetTableAdapter().InsertProjet(p_code, p_nom, p_resp);
        }

        public int UpdateProjet(string p_code, string p_nom, int p_resp, int p_id)
        {
            return new ProjetTableAdapter().UpdateProjet(p_code, p_nom, p_resp, p_id);
        }

        public int CountProjetByCode(string p_code)
        {
            return (int)new ProjetTableAdapter().CountProjetByCode(p_code);
        }
    }
}
