using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.Models
{
    public class Jalon
    {
        public int Id { get; set; }

        public string Libelle { get; set; }        

        public DateTime LivraisonPrevue { get; set; }

        public DateTime? LivraisonReelle { get; set; }

        public int IdResp { get; set; }

        public int IdProjet { get; set; }

        public Jalon()
        {

        }

        public Jalon(string p_libelle, DateTime p_livraisonprevue, int p_resp, int p_projet, 
            DateTime? p_livraisonreelle = null)
        {
            this.Libelle = p_libelle;
            this.LivraisonPrevue = p_livraisonprevue;
            this.LivraisonReelle = p_livraisonreelle;
            this.IdResp = p_resp;
            this.IdProjet = p_projet;
        }
    }
}
