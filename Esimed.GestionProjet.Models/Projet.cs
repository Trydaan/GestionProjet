using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.Models
{
    public class Projet 
    {
        public int Id { get; set; }

        public string Nom { get; set; }        

        public string Code { get; set; }

        public int IdResp { get; set; }

        public string DisplayName 
        {
            get { return Nom + " - " + Code; } 
        }

        public Projet()
        {

        }

        public Projet(string p_nom, string p_code, int p_idresp)
        {
            this.Nom = p_nom;
            this.Code = p_code;
            this.IdResp = p_idresp;            
        }
    }
}
