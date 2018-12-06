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

namespace Esimed.GestionProjet.WinCtrl.Frm
{
    public partial class FrmAjoutProjet : Form
    {
        public FrmAjoutProjet()
        {
            InitializeComponent();
        }

        public void Initialiser(bool p_modif = false, int p_projet = 0)
        {
            this.Text = p_modif ? "Modifier un projet" : "Ajouter un projet";
            
            ctrlAjoutProjet1.Initialiser(p_modif, p_projet);
        }


    }
}
