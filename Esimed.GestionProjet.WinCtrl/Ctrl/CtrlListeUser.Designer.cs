﻿namespace Esimed.GestionProjet.WinCtrl
{
    partial class CtrlListeUser
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbResp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Responsable :";
            // 
            // cbResp
            // 
            this.cbResp.FormattingEnabled = true;
            this.cbResp.Location = new System.Drawing.Point(81, 0);
            this.cbResp.Name = "cbResp";
            this.cbResp.Size = new System.Drawing.Size(121, 21);
            this.cbResp.TabIndex = 2;
            this.cbResp.SelectedIndexChanged += new System.EventHandler(this.cbProjets_SelectedIndexChanged);
            // 
            // CtrlListeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbResp);
            this.Controls.Add(this.label1);
            this.Name = "CtrlListeUser";
            this.Size = new System.Drawing.Size(239, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbResp;
    }
}
