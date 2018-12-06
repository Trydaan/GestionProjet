namespace Esimed.GestionProjet.WinCtrl.Ctrl
{
    partial class CtrlAjoutProjet
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomProjet = new System.Windows.Forms.TextBox();
            this.tbCodeProjet = new System.Windows.Forms.TextBox();
            this.btAjoutProjet = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.ctrlListeUser = new Esimed.GestionProjet.WinCtrl.CtrlListeUser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trigramme : ";
            // 
            // tbNomProjet
            // 
            this.tbNomProjet.Location = new System.Drawing.Point(113, 15);
            this.tbNomProjet.Name = "tbNomProjet";
            this.tbNomProjet.Size = new System.Drawing.Size(100, 20);
            this.tbNomProjet.TabIndex = 2;
            // 
            // tbCodeProjet
            // 
            this.tbCodeProjet.Location = new System.Drawing.Point(113, 49);
            this.tbCodeProjet.Name = "tbCodeProjet";
            this.tbCodeProjet.Size = new System.Drawing.Size(100, 20);
            this.tbCodeProjet.TabIndex = 3;
            // 
            // btAjoutProjet
            // 
            this.btAjoutProjet.Location = new System.Drawing.Point(113, 122);
            this.btAjoutProjet.Name = "btAjoutProjet";
            this.btAjoutProjet.Size = new System.Drawing.Size(75, 23);
            this.btAjoutProjet.TabIndex = 6;
            this.btAjoutProjet.Text = "Ajouter";
            this.btAjoutProjet.UseVisualStyleBackColor = true;
            this.btAjoutProjet.Click += new System.EventHandler(this.btAjoutProjet_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(26, 157);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 8;
            // 
            // ctrlListeUser
            // 
            this.ctrlListeUser.Location = new System.Drawing.Point(34, 82);
            this.ctrlListeUser.Name = "ctrlListeUser";
            this.ctrlListeUser.Size = new System.Drawing.Size(218, 34);
            this.ctrlListeUser.TabIndex = 9;
            // 
            // CtrlAjoutProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlListeUser);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btAjoutProjet);
            this.Controls.Add(this.tbCodeProjet);
            this.Controls.Add(this.tbNomProjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CtrlAjoutProjet";
            this.Size = new System.Drawing.Size(271, 209);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomProjet;
        private System.Windows.Forms.TextBox tbCodeProjet;
        private System.Windows.Forms.Button btAjoutProjet;
        private System.Windows.Forms.Label lbError;
        private CtrlListeUser ctrlListeUser;
    }
}
