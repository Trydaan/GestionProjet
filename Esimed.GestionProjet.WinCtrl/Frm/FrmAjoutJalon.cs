using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esimed.GestionProjet.WinCtrl.Frm
{
    public partial class FrmAjoutJalon : Form
    {
        public FrmAjoutJalon()
        {
            InitializeComponent();
        }

        public void Initialiser(int p_projet, bool p_modif = false, int p_id = 0)
        {
            this.Text = p_modif ? "Modifier un jalon" : "Ajouter un jalon";

            ctrlAjoutJalon1.Initialiser(p_projet, p_modif, p_id);
        }
    }
}
