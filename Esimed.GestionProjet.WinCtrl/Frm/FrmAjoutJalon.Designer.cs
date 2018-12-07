namespace Esimed.GestionProjet.WinCtrl.Frm
{
    partial class FrmAjoutJalon
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
            this.ctrlAjoutJalon1 = new Esimed.GestionProjet.WinCtrl.Ctrl.CtrlAjoutJalon();
            this.SuspendLayout();
            // 
            // ctrlAjoutJalon1
            // 
            this.ctrlAjoutJalon1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAjoutJalon1.Name = "ctrlAjoutJalon1";
            this.ctrlAjoutJalon1.Size = new System.Drawing.Size(356, 204);
            this.ctrlAjoutJalon1.TabIndex = 0;
            // 
            // FrmAjoutJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.ctrlAjoutJalon1);
            this.Name = "FrmAjoutJalon";
            this.Text = "Ajouter un jalon";
            this.ResumeLayout(false);

        }

        #endregion

        private Ctrl.CtrlAjoutJalon ctrlAjoutJalon1;
    }
}