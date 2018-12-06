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
    public class ExigenceServiceDA : IExigenceServiceDA
    {
        public List<Exigence> GetExByProjet(int p_id)
        {
            List<Exigence> v_exigs = new List<Exigence>();
            foreach (db_GestionProjetDataSet.ExigenceRow er in new ExigenceTableAdapter().GetExigByProjet(p_id))
            {
                v_exigs.Add(FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Exigence>(er));
            }
            return v_exigs;            
        }

        public string InsertExig(string p_texte, string p_code, int p_fonction, int p_projet)
        {
            int result = new ExigenceTableAdapter().InsertExig(p_texte, p_code, p_fonction, p_projet);
            return result > 0 ? "Exigence ajoutée" : "Erreur : exigence non ajoutée";
        }

        public int CountExigByCode(string p_code, int p_projet)
        { 
            return (int)new ExigenceTableAdapter().CountExigByCode(p_code, p_projet);          
        }

        public string UpdateExig(string p_texte, string p_code, int p_fonction, int p_id)
        {
            int result = new ExigenceTableAdapter().UpdateExig(p_texte, p_code, p_fonction, p_id);
            return result > 0 ? "Exigence modifé" : "Erreur : exigence non modifié";
        }

        public Exigence GetExById(int p_id)
        {
            db_GestionProjetDataSet.ExigenceRow er = new ExigenceTableAdapter().GetExigById(p_id)[0];

            Exigence v_exig = FEsimedServiceDA.CreateRowServiceDA().FromDBToBean<Exigence>(er);

            return v_exig;
        }

        


        
    }
}
