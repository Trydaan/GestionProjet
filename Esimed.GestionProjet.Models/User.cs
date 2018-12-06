using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Code { get; set; }

        public string DisplayName 
        {
            get { return Prenom + " " + Nom + " " + Code; } 
        }

        public User()
        {

        }

        public User(string p_nom, string p_prenom, string p_code)
        {
            this.Nom = p_nom;
            this.Prenom = p_prenom;
            this.Code = p_code;
        }
    }
}
