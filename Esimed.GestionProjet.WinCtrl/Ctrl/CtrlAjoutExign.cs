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
    public partial class CtrlAjoutExign : UserControl
    {
        private int projet;
        private bool modif;
        private int id;
        private string identifiant;

        public CtrlAjoutExign()
        {
            InitializeComponent();
        }

        public void Initialiser(int p_projet, bool p_modif, int p_id)
        {
            projet = p_projet;
            modif = p_modif;
            id = p_id;
            this.btAjout.Text = p_modif ? "Modifier" : "Ajouter";
            this.LoadData(p_projet, p_modif, p_id);

        }

        private void LoadData(int p_projet, bool p_modif, int p_id)
        {
            //Chargement liste des fonctions
            cbFonction.DataSource = Enum.GetValues(typeof(ExigenceEnum));

            if (p_modif)
            {
                Exigence exig = FEsimedService.CreateExigService().GetExById(p_id);
                tbCode.Text = exig.Code;
                tbTexte.Text = exig.Texte;
                //Identifiant d'origine
                identifiant = exig.Code;

                ExigenceEnum result; 
                Enum.TryParse<ExigenceEnum>(exig.Fonction.ToString(), out result);

                cbFonction.SelectedItem = result;
            }
        }

        private void DoStuff(EnumActionAjoutExigs p_enum, object p_sender)
        {
            ExigenceEnum fonction;
            Enum.TryParse<ExigenceEnum>(cbFonction.SelectedValue.ToString(), out fonction);

            switch (p_enum)
            {
                case EnumActionAjoutExigs.ajouterExig:
                    {

                        if (tbCode.Text != string.Empty)
                        {
                            if (FEsimedService.CreateExigService().CountExigByCode(tbCode.Text, projet) == 0)
                            {                                
                                lbError.Text = FEsimedService.CreateExigService().InsertExig(tbTexte.Text, tbCode.Text, (int)fonction, projet);
                            }
                            else
                            {
                                lbError.Text = "Cet identifiant est déjà utilisé";
                            }

                        }
                        else
                        {
                            lbError.Text = "Veuillez saisir un trigramme pour l'exigence";
                        }



                    }
                    break;
                case EnumActionAjoutExigs.modifierExig:
                    {
                        if (tbCode.Text != identifiant && FEsimedService.CreateExigService().CountExigByCode(tbCode.Text, projet) != 0)
                        {
                            lbError.Text = "Cet identifiant est déjà utilisé";
                        }                        
                        else
                        {
                            lbError.Text = FEsimedService.CreateExigService().UpdateExig(tbTexte.Text, tbCode.Text, (int)fonction, id);
                        }
                    }
                    break;
            }
        }

        #region Methodes
        private void ExigSelected(object p_sender)
        {

        }

        #endregion

        #region Events
        private void btAjout_Click(object sender, EventArgs e)
        {
            this.DoStuff(modif ? EnumActionAjoutExigs.modifierExig : EnumActionAjoutExigs.ajouterExig, sender);
        }
        #endregion

    }

    public enum EnumActionAjoutExigs
    {
        ajouterExig,
        modifierExig
    }
}
