using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.Models
{
    public class Exigence
    {
        public int Id { get; set; }

        public string Texte { get; set; }        

        public string Code { get; set; }

        public int Fonction { get; set; }
        
        public int IdProjet { get; set; }

        public List<Tache> Taches { get; set; }

        public string DisplayInfo 
        { 
            get { return Texte + " - " + Code + " - " + Fonction; } 
        }

        public Exigence()
        {

        }

        public Exigence(string p_texte, string p_code, int p_fonction, int p_idprojet)
        {
            this.Texte = p_texte;
            this.Code = p_code;
            this.Fonction = p_fonction;
            this.IdProjet = p_idprojet;
        }
    }

    public enum ExigenceEnum
	{
        fonctionnelle = 0,
        donnees = 1,
        performances = 2,
        interfaces = 3,
        qualité = 4,
        services = 5	         
	}
}
