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
    public partial class CtrlListeJalon : UserControl
    {
        public CtrlListeJalon()
        {
            InitializeComponent();
        }

        public void Initialiser(int p_projet)
        {
            this.LoadData(p_projet);
        }

        private void LoadData(int p_projet)
        {
            List<Jalon> v_jalons = FEsimedService.CreateJalonService().GetJalonByProjet(p_projet);
            
            bsJalon.DataSource = v_jalons;
            dgvJalon.DataSource = bsJalon;

            dgvJalon.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            dgvJalon.Columns["Id"].Visible = false;
        }

        private void DoStuff(EnumActionListeJalon p_enum, object p_sender)
        {
            switch (p_enum)
            {
                case EnumActionListeJalon.selectionJalon:
                    {
                        this.JalonSelected(p_sender);
                    }
                    break;
            }
        }

        #region Methodes
        private void JalonSelected(object p_sender)
        {

        }

        public Jalon GetJalonSelected()
        {
            Jalon v_jalon = null;
            if (dgvJalon.CurrentRow.DataBoundItem != null)
            {
                v_jalon = (Jalon)dgvJalon.CurrentRow.DataBoundItem;
            }
            return v_jalon;
        }
        #endregion

        private void dgvJalon_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                this.DoStuff(EnumActionListeJalon.selectionJalon, sender);
            }
        }
    }

    public enum EnumActionListeJalon
    {
        selectionJalon,

    }
}
