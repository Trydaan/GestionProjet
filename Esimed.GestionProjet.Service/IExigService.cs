using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esimed.GestionProjet.Models;

namespace Esimed.GestionProjet.Service
{
    public interface IExigService
    {
        List<Exigence> GetExByProjet(int p_id);

        string InsertExig(string p_texte, string p_code, int p_fonction, int p_projet);

        int CountExigByCode(string p_code, int p_projet);

        string UpdateExig(string p_texte, string p_code, int p_fonction, int p_id);

        Exigence GetExById(int p_id);
    }
}
