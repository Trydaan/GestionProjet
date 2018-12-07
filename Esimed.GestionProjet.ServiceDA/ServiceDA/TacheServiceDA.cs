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
    public class TacheServiceDA 
    {
        public List<Tache> GetTacheByJalon(int p_jalon)
        {
            List<Tache> v_taches = new List<Tache>();
            foreach (db_GestionProjetDataSet.TacheRow tr in new TacheTableAdapter().GetTacheByJalon(p_jalon))
            {
                v_taches.Add(FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Tache>(tr));
            }
            return v_taches;
        }

        //public string InsertTache(string p_libelle, string p_descrp, string p_code, DateTime p_debutprev, int p_charge, int p_resp, int p_jalon, DateTime? p_debutreel = null, DateTime? p_finreelle = null, int? p_tacheprec = null)
        //{
        //    int result = new TacheTableAdapter().InsertTache(p_livrprev, p_livrreelle, p_libelle, p_resp, p_projet);
        //    return result > 0 ? "Jalon ajouté" : "Erreur : Jalon non ajouté";
        //}

        //public int CountExigByCode(string p_code, int p_projet)
        //{ 
        //    return (int)new ExigenceTableAdapter().CountExigByCode(p_code, p_projet);          
        //}

        //public string UpdateJalon(DateTime p_livrprevu, string p_libelle, int p_resp, int p_id)
        //{
        //    int result = new JalonTableAdapter().UpdateJalon(p_livrprevu, p_libelle, p_resp, p_id);
        //    return result > 0 ? "Jalon modifé" : "Erreur : jalon non modifié";
        //}

        //public Jalon GetJalonById(int p_id)
        //{
        //    db_GestionProjetDataSet.JalonRow jr = new JalonTableAdapter().GetById(p_id)[0];

        //    Jalon v_jalon = FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Jalon>(jr);

        //    return v_jalon;
        //}

        


        
    }
}
