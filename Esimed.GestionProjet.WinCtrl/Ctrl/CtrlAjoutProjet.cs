using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esimed.GestionProjet.Models;
using Esimed.GestionProjet.Service;

namespace Esimed.GestionProjet.WinCtrl.Ctrl
{
    public partial class CtrlAjoutProjet : UserControl
    {
        private bool modif;
        private int projetid;

        public CtrlAjoutProjet()
        {
            InitializeComponent();
        }

        public void Initialiser(bool p_modif, int p_projet)
        {
            this.LoadData(p_modif, p_projet);
            this.btAjoutProjet.Text = p_modif ? "Modifier" : "Ajouter";
            modif = p_modif;
            projetid = p_projet;
        }

        private void LoadData(bool p_modif, int p_projet)
        {          
            
            //Chargement liste responsable
            ctrlListeUser.Initialiser();

            if (p_modif)
            {
                Projet projetmodif = FEsimedService.CreateProjetService().GetProjetById(p_projet);
                tbNomProjet.Text = projetmodif.Nom;
                tbCodeProjet.Text = projetmodif.Code;
                ctrlListeUser.SetUserSelected(projetmodif.IdResp);
            }
                     
        }

        private void DoStuff(EnumActionAjoutProjets p_enum, object p_sender)
        {
            switch (p_enum)
            {
                case EnumActionAjoutProjets.ajouterProjet:
                    {
                        if (tbNomProjet.Text != string.Empty)
                        {
                            if (tbCodeProjet.Text != string.Empty)
                            {
                                if (tbCodeProjet.Text.Length == 3)
                                {
                                    if (FEsimedService.CreateProjetService().CountByCode(tbCodeProjet.Text) == 0)
                                    {
                                        lbError.Text = FEsimedService.CreateProjetService().InsertProjet(tbNomProjet.Text, tbCodeProjet.Text, ctrlListeUser.GetUserSelected().Id);

                                    }
                                    else
                                    {
                                        lbError.Text = "Ce trigramme est déjà utilisé";
                                    }
                                }
                                else
                                {
                                    lbError.Text = "Le trigramme doit être de 3 caractères";
                                }
                                
                            }
                            else
                            {
                                lbError.Text = "Veuillez saisir un trigramme pour le projet";
                            }
                            
                        }
                        else
                        {
                            lbError.Text = "Veuillez saisir un nom pour le projet";
                        }


                    }
                    break;
                case EnumActionAjoutProjets.modifierProjet:
                    {
                        if (FEsimedService.CreateProjetService().CountByCode(tbCodeProjet.Text) == 0)
                        {
                            lbError.Text = FEsimedService.CreateProjetService().UpdateProjet(projetid, tbNomProjet.Text, tbCodeProjet.Text, ctrlListeUser.GetUserSelected().Id);

                        }
                        else
                        {
                            lbError.Text = "Ce trigramme est déjà utilisé";
                        }
                    }
                    break;
            }
        }

        #region Methodes
        private void ProjetSelected(object p_sender)
        {

        }

        #endregion

        #region Events
        
                 

        private void btAjoutProjet_Click(object sender, EventArgs e)
        {
            this.DoStuff(modif ? EnumActionAjoutProjets.modifierProjet : EnumActionAjoutProjets.ajouterProjet, sender);
        }

        #endregion


    }

    public enum EnumActionAjoutProjets
    {
        ajouterProjet,
        modifierProjet
    }
}
