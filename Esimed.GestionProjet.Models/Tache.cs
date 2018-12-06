using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.Models
{
    public class Tache
    {
        public int Id { get; set; }

        public string Libelle { get; set; }        

        public string Description { get; set; }

        public string Code { get; set; }

        public DateTime? DebutPrevu { get; set; }

        public int Charge { get; set; }

        public DateTime? DebutReel { get; set; }

        public DateTime? FinReelle { get; set; }

        public int IdResp { get; set; }

        public int? IdTachePrec { get; set; }

        public int IdJalon { get; set; }

        public List<Exigence> Exigences { get; set; }

        public Tache()
        {

        }

        public Tache(string p_libelle, string p_description, string p_code, DateTime p_debutprevu, 
            int p_charge, int p_idresp, int p_idjalon, DateTime? p_debutreel = null, DateTime? p_finreelle = null,
            int? p_idtacheprec = null)
        {
            this.Libelle = p_libelle;
            this.Description = p_description;
            this.Code = p_code;
            this.DebutPrevu = p_debutprevu;
            this.Charge = p_charge;
            this.IdResp = p_idresp;
            this.IdJalon = p_idjalon;
            this.DebutReel = p_debutreel;
            this.FinReelle = p_finreelle;
            this.IdTachePrec = p_idtacheprec;
        }
    }
}
