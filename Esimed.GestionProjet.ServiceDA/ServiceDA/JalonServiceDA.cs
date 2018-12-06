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

        //public string UpdateExig(string p_texte, string p_code, int p_fonction, int p_id)
        //{
        //    int result = new ExigenceTableAdapter().UpdateExig(p_texte, p_code, p_fonction, p_id);
        //    return result > 0 ? "Exigence modifé" : "Erreur : exigence non modifié";
        //}

        //public Exigence GetExById(int p_id)
        //{
        //    db_GestionProjetDataSet.ExigenceRow er = new ExigenceTableAdapter().GetExigById(p_id)[0];

        //    Exigence v_exig = FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Exigence>(er);

        //    return v_exig;
        //}

        


        
    }
}
