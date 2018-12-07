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
    public partial class CtrlAjoutJalon : UserControl
    {
        private bool modif;
        private int projetid;
        private int id;

        public CtrlAjoutJalon()
        {
            InitializeComponent();
        }

        public void Initialiser(int p_projet, bool p_modif, int p_id)
        {
            
            this.btAjoutJalon.Text = p_modif ? "Modifier" : "Ajouter";
            modif = p_modif;
            projetid = p_projet;
            id = p_id;
            this.LoadData();
        }

        private void LoadData()
        {

            //Chargement liste responsable
            ctrlListeUser1.Initialiser();

            if (modif)
            {
                Jalon jalonmodif = FEsimedService.CreateJalonService().GetJalonById(id);
                tbLibelle.Text = jalonmodif.Libelle;
                dtpLivrPrevu.Value = jalonmodif.LivraisonPrevu;
                ctrlListeUser1.SetUserSelected(jalonmodif.IdResp);
            }

        }

        private void DoStuff(EnumActionAjoutJalons p_enum, object p_sender)
        {
            switch (p_enum)
            {
                case EnumActionAjoutJalons.ajouterJalon:
                    {
                        if (tbLibelle.Text != string.Empty)
                        {
                            lbError.Text = FEsimedService.CreateJalonService().InsertJalon(dtpLivrPrevu.Value, tbLibelle.Text, ctrlListeUser1.GetUserSelected().Id, projetid);
                        }
                        else
                        {
                            lbError.Text = "Veuillez saisir un libelle pour le jalon";
                        }
                    }
                    break;
                case EnumActionAjoutJalons.modifierJalon:
                    {
                        if (tbLibelle.Text != string.Empty)
                        {
                            lbError.Text = FEsimedService.CreateJalonService().UpdateJalon(dtpLivrPrevu.Value, tbLibelle.Text, ctrlListeUser1.GetUserSelected().Id, id);                        

                        }
                        else
                        {
                            lbError.Text = "Veuillez saisir un libelle pour le jalon";
                        }
                    }
                    break;
            }
        }

        #region Methodes
        private void JalonSelected(object p_sender)
        {

        }

        #endregion

        #region Events
        private void btAjoutJalon_Click(object sender, EventArgs e)
        {
            this.DoStuff(modif ? EnumActionAjoutJalons.modifierJalon : EnumActionAjoutJalons.ajouterJalon, sender);
        }
        #endregion
    }

    public enum EnumActionAjoutJalons
    {
        ajouterJalon,
        modifierJalon
    }
}
