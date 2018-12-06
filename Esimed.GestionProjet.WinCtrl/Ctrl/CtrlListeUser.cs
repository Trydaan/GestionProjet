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
    public partial class CtrlListeUser : UserControl
    {
        public CtrlListeUser()
        {
            InitializeComponent();
        }

        public void Initialiser()
        {
            this.LoadData();
        }

        private void LoadData()
        {


            List<User> v_projets = FEsimedService.CreateUserService().GetAllUser();


            cbResp.DataSource = v_projets;
            cbResp.ValueMember = "Id";
            cbResp.DisplayMember = "DisplayName";

            
        }

        private void DoStuff(EnumActionListeUser p_enum, object p_sender)
        {
            switch (p_enum)
            {
                case EnumActionListeUser.selectionUser:
                    {
                        this.UserSelected(p_sender);
                    }
                    break;


            }
        }

        #region Methodes
        private void UserSelected(object p_sender)
        {

        }

        public User GetUserSelected()
        {
            User v_user = null;
            if (cbResp.SelectedItem != null)
            {
                v_user = (User)cbResp.SelectedItem;
            }
            return v_user;
        }

        public void SetUserSelected(int p_id)
        {
            this.cbResp.SelectedValue = p_id;
        }
        #endregion

        #region Events
        private void cbProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DoStuff(EnumActionListeUser.selectionUser, sender);
        }
        #endregion

        public enum EnumActionListeUser
        {
            selectionUser,
            
        }

        
    }
}
