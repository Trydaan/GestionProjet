namespace Esimed.GestionProjet.WinCtrl.Frm
{
    partial class FrmAjoutExig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlAjoutExign1 = new Esimed.GestionProjet.WinCtrl.Ctrl.CtrlAjoutExign();
            this.SuspendLayout();
            // 
            // ctrlAjoutExign1
            // 
            this.ctrlAjoutExign1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAjoutExign1.Name = "ctrlAjoutExign1";
            this.ctrlAjoutExign1.Size = new System.Drawing.Size(333, 294);
            this.ctrlAjoutExign1.TabIndex = 0;
            // 
            // FrmAjoutExig
            // 
            this.ClientSize = new System.Drawing.Size(396, 318);
            this.Controls.Add(this.ctrlAjoutExign1);
            this.Name = "FrmAjoutExig";
            this.Text = "Ajouter une exigence";
            this.ResumeLayout(false);

        }

        #endregion

        private Ctrl.CtrlAjoutExign ctrlAjoutExign1;

        
    }
}