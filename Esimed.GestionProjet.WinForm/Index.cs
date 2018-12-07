using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esimed.GestionProjet.Models;
using Esimed.GestionProjet.Service;
using Esimed.GestionProjet.WinCtrl;
using Esimed.GestionProjet.WinCtrl.Frm;

namespace Esimed.GestionProjet.WinForm
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            InitIHM();
        }

        public void InitIHM()
        {
            ctrlListeProjet.Initialiser();
            
            
        }

        private void DoStuff(EnumActionAccueil p_enum, object p_sender)
        {
            switch (p_enum)
            {
                case EnumActionAccueil.afficheProjet:
                    {
                        //Affiche les objets lié au projet
                        Projet v_projetselected = ctrlListeProjet.GetProjetSelected();
                        lbInfoProjet.Text = v_projetselected.Nom + " - " + v_projetselected.Code + " Resp : " + v_projetselected.IdResp;
                        
                        ctrlListeExigence1.Initialiser(v_projetselected.Id);

                        ctrlListeJalon1.Initialiser(v_projetselected.Id);
                    }
                    break;
                case EnumActionAccueil.ajoutProjet:
                    {
                        using (FrmAjoutProjet v_frm = new FrmAjoutProjet())
                        {
                            v_frm.Initialiser();

                            v_frm.ShowDialog();
                        }
                        this.InitIHM();
                    }
                    break;
                case EnumActionAccueil.modifProjet:
                    {
                        using (FrmAjoutProjet v_frm = new FrmAjoutProjet())
                        {
                            //Passez le projet selectionné pour réutiliser le FrmAjoutProjet
                            v_frm.Initialiser(true, ctrlListeProjet.GetProjetSelected().Id);

                            v_frm.ShowDialog();
                        }
                        this.InitIHM();
                    }
                    break;
                case EnumActionAccueil.afficheExig:
                    {
                        Exigence exigselect = ctrlListeExigence1.GetExigSelected();
                        lbInfoExig.Text = exigselect.DisplayInfo;
                    }
                    break;
                case EnumActionAccueil.ajoutExig:
                    {
                        using (FrmAjoutExig v_frm = new FrmAjoutExig())
                        {
                            //Passez le projet selectionné pour réutiliser le FrmAjoutProjet
                            v_frm.Initialiser(ctrlListeProjet.GetProjetSelected().Id);

                            v_frm.ShowDialog();
                        }
                        ctrlListeExigence1.Initialiser(ctrlListeProjet.GetProjetSelected().Id);
                    }
                    break;
                case EnumActionAccueil.modifExig:
                    {
                        using (FrmAjoutExig v_frm = new FrmAjoutExig())
                        {
                            //Passez le projet selectionné pour réutiliser le FrmAjoutProjet
                            v_frm.Initialiser(ctrlListeProjet.GetProjetSelected().Id, true, ctrlListeExigence1.GetExigSelected().Id);

                            v_frm.ShowDialog();
                        }
                        ctrlListeExigence1.Initialiser(ctrlListeProjet.GetProjetSelected().Id);
                    }
                    break;
                case EnumActionAccueil.ajoutJalon:
                    {
                        using (FrmAjoutJalon v_frm = new FrmAjoutJalon())
                        {
                            //Passez le projet selectionné pour réutiliser le FrmAjoutProjet
                            v_frm.Initialiser(ctrlListeProjet.GetProjetSelected().Id);

                            v_frm.ShowDialog();
                        }
                        ctrlListeJalon1.Initialiser(ctrlListeProjet.GetProjetSelected().Id);
                    }
                    break;
                case EnumActionAccueil.modifJalon:
                    {
                        using (FrmAjoutJalon v_frm = new FrmAjoutJalon())
                        {
                            //Passez le projet selectionné pour réutiliser le FrmAjoutProjet
                            v_frm.Initialiser(ctrlListeProjet.GetProjetSelected().Id, true, ctrlListeJalon1.GetJalonSelected().Id);

                            v_frm.ShowDialog();
                        }                        
                        ctrlListeJalon1.Initialiser(ctrlListeProjet.GetProjetSelected().Id);
                    }
                    break;
            }
        }

        private void btInfoProjet_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.afficheProjet, sender);
        }

        

        private void btNouvProjet_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.ajoutProjet, sender);
        }

        private void btModifProjet_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.modifProjet, sender);
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btAfficheExig_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.afficheExig, sender);
        }

        private void btAjoutExig_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.ajoutExig, sender);
        }

        private void btModifExig_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.modifExig, sender);
        }

        private void btAjoutJalon_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.ajoutJalon, sender);
        }

        private void btModifJalon_Click(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionAccueil.modifJalon, sender);
        }
    }

    public enum EnumActionAccueil
    {
        afficheProjet,
        ajoutProjet,
        modifProjet,
        afficheExig,
        ajoutExig,
        modifExig,
        ajoutJalon,
        modifJalon
    }
}
