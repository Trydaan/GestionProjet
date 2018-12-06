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
    public partial class CtrlListeExigence : UserControl
    {
        public CtrlListeExigence()
        {
            InitializeComponent();
        }

        public void Initialiser(int p_projet)
        {
            this.LoadData(p_projet);
        }

        private void LoadData(int p_projet)
        {
            List<Exigence> v_exigs = FEsimedService.CreateExigService().GetExByProjet(p_projet);           

            bsExigence.DataSource = v_exigs;
            dgvExigence.DataSource = bsExigence;

            dgvExigence.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            dgvExigence.Columns["IdProjet"].Visible = false;
            dgvExigence.Columns["Id"].Visible = false;
            dgvExigence.Columns["DisplayInfo"].Visible = false;
        }

        private void DoStuff(EnumActionListeExig p_enum, object p_sender)
        {
            switch (p_enum)
            {
                case EnumActionListeExig.selectionExig:
                    {
                        this.ExigSelected(p_sender);
                    }
                    break;
            }
        }

        #region Methodes
        private void ExigSelected(object p_sender)
        {

        }

        public Exigence GetExigSelected()
        {
            Exigence v_exig = null;
            if (dgvExigence.CurrentRow.DataBoundItem != null)
            {
                v_exig = (Exigence)dgvExigence.CurrentRow.DataBoundItem;
            }
            return v_exig;
        }        
        #endregion

        #region Events
        private void dgvExigence_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                this.DoStuff(EnumActionListeExig.selectionExig, sender);
            }            
        }
        #endregion

        
    }

    public enum EnumActionListeExig
    {
        selectionExig,

    }
}
