﻿namespace Esimed.GestionProjet.WinCtrl.Frm
{
    partial class FrmAjoutProjet
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
            this.ctrlAjoutProjet1 = new Esimed.GestionProjet.WinCtrl.Ctrl.CtrlAjoutProjet();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlAjoutProjet1
            // 
            this.ctrlAjoutProjet1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAjoutProjet1.Name = "ctrlAjoutProjet1";
            this.ctrlAjoutProjet1.Size = new System.Drawing.Size(325, 205);
            this.ctrlAjoutProjet1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(287, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlAjoutProjet1);
            this.Name = "FrmAjoutProjet";
            this.Text = "Ajouter un projet";
            this.ResumeLayout(false);

        }

        #endregion

        private Ctrl.CtrlAjoutProjet ctrlAjoutProjet1;
        private System.Windows.Forms.Button button1;
    }
}