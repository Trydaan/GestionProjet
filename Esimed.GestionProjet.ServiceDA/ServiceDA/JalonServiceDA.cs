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
    public class JalonServiceDA : IJalonServiceDA
    {
        public List<Jalon> GetJalonByProjet(int p_id)
        {
            List<Jalon> v_jalons = new List<Jalon>();
            foreach (db_GestionProjetDataSet.JalonRow jr in new JalonTableAdapter().GetJalonByProjet(p_id))
            {
                v_jalons.Add(FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Jalon>(jr));
            }
            return v_jalons;            
        }

        public string InsertJalon(DateTime p_livrprev, string p_libelle, int p_resp, int p_projet, DateTime? p_livrreelle = null)
        {
            int result = new JalonTableAdapter().InsertJalon(p_livrprev, p_livrreelle, p_libelle, p_resp, p_projet);
            return result > 0 ? "Jalon ajouté" : "Erreur : Jalon non ajouté";
        }

        //public int CountExigByCode(string p_code, int p_projet)
        //{ 
        //    return (int)new ExigenceTableAdapter().CountExigByCode(p_code, p_projet);          
        //}

        public string UpdateJalon(DateTime p_livrprevu, string p_libelle, int p_resp, int p_id)
        {
            int result = new JalonTableAdapter().UpdateJalon(p_livrprevu, p_libelle, p_resp, p_id);
            return result > 0 ? "Jalon modifé" : "Erreur : jalon non modifié";
        }

        public Jalon GetJalonById(int p_id)
        {
            db_GestionProjetDataSet.JalonRow jr = new JalonTableAdapter().GetById(p_id)[0];

            Jalon v_jalon = FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Jalon>(jr);

            return v_jalon;
        }

        


        
    }
}
