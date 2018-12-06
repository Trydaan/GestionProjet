namespace Esimed.GestionProjet.WinCtrl.Ctrl
{
    partial class CtrlAjoutExign
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
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.cbFonction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAjout = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(113, 23);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(121, 20);
            this.tbCode.TabIndex = 0;
            // 
            // tbTexte
            // 
            this.tbTexte.Location = new System.Drawing.Point(113, 116);
            this.tbTexte.Multiline = true;
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTexte.Size = new System.Drawing.Size(177, 86);
            this.tbTexte.TabIndex = 1;
            // 
            // cbFonction
            // 
            this.cbFonction.FormattingEnabled = true;
            this.cbFonction.Location = new System.Drawing.Point(113, 67);
            this.cbFonction.Name = "cbFonction";
            this.cbFonction.Size = new System.Drawing.Size(121, 21);
            this.cbFonction.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fonction :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description :";
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(113, 218);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 6;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(32, 258);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 7;
            // 
            // CtrlAjoutExign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFonction);
            this.Controls.Add(this.tbTexte);
            this.Controls.Add(this.tbCode);
            this.Name = "CtrlAjoutExign";
            this.Size = new System.Drawing.Size(333, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbTexte;
        private System.Windows.Forms.ComboBox cbFonction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Label lbError;
    }
}
