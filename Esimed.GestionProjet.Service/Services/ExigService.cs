using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;
using Esimed.GestionProjet.ServiceDA;

namespace Esimed.GestionProjet.Service
{
    public class ExigService : IExigService
    {
        public List<Exigence> GetExByProjet(int p_id)
        {
            return FEsimedServiceDA.CreateExigServiceDA().GetExByProjet(p_id);
        }

        public string InsertExig(string p_texte, string p_code, int p_fonction, int p_projet)
        {
            return FEsimedServiceDA.CreateExigServiceDA().InsertExig(p_texte, p_code, p_fonction, p_projet);
        }

        public int CountExigByCode(string p_code, int p_projet)
        {
            return FEsimedServiceDA.CreateExigServiceDA().CountExigByCode(p_code, p_projet);
        }

        public string UpdateExig(string p_texte, string p_code, int p_fonction, int p_id)
        {
            return FEsimedServiceDA.CreateExigServiceDA().UpdateExig(p_texte, p_code, p_fonction, p_id);
        }

        public Exigence GetExById(int p_id)
        {
            return FEsimedServiceDA.CreateExigServiceDA().GetExById(p_id);
        }
        
    }
}
