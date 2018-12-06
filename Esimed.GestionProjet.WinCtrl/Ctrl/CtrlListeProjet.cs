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


namespace Esimed.GestionProjet.WinCtrl
{
    public partial class CtrlListeProjet : UserControl
    {
        public CtrlListeProjet()
        {
            InitializeComponent();
        }

        public void Initialiser()
        {
            this.LoadData();
        }

        private void LoadData()
        {          

            
            List<Projet> v_projets = FEsimedService.CreateProjetService().GetAllProjet();

            cbProjets.DataSource = v_projets;
            cbProjets.DisplayMember = "DisplayName";            
        }

        private void DoStuff(EnumActionListeProjets p_enum, object p_sender)
        {
            switch (p_enum)
            {
                case EnumActionListeProjets.selectionProjet:
                    {
                        this.GenreSelected(p_sender);
                    }
                    break;


            }
        }

        #region Methodes
        private void GenreSelected(object p_sender)
        {

        }

        public Projet GetProjetSelected()
        {
            Projet v_projet = null;
            if (cbProjets.SelectedItem != null)
            {
                v_projet = (Projet)cbProjets.SelectedItem;
            }
            return v_projet;
        }
        #endregion

        #region Events
        private void cbProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionListeProjets.selectionProjet, sender);
        }
        #endregion

        public enum EnumActionListeProjets
        {
            selectionProjet,
            ajoutProjet,
            editProjet
        }

        
    }
}
