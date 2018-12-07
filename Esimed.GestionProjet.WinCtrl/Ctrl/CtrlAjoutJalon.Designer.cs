namespace Esimed.GestionProjet.WinCtrl.Ctrl
{
    partial class CtrlAjoutJalon
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
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.dtpLivrPrevu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAjoutJalon = new System.Windows.Forms.Button();
            this.ctrlListeUser1 = new Esimed.GestionProjet.WinCtrl.CtrlListeUser();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(137, 3);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(120, 20);
            this.tbLibelle.TabIndex = 0;
            // 
            // dtpLivrPrevu
            // 
            this.dtpLivrPrevu.Location = new System.Drawing.Point(137, 41);
            this.dtpLivrPrevu.Name = "dtpLivrPrevu";
            this.dtpLivrPrevu.Size = new System.Drawing.Size(183, 20);
            this.dtpLivrPrevu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date de livraison prévu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libelle :";
            // 
            // btAjoutJalon
            // 
            this.btAjoutJalon.Location = new System.Drawing.Point(137, 119);
            this.btAjoutJalon.Name = "btAjoutJalon";
            this.btAjoutJalon.Size = new System.Drawing.Size(75, 23);
            this.btAjoutJalon.TabIndex = 5;
            this.btAjoutJalon.Text = "Ajouter";
            this.btAjoutJalon.UseVisualStyleBackColor = true;
            this.btAjoutJalon.Click += new System.EventHandler(this.btAjoutJalon_Click);
            // 
            // ctrlListeUser1
            // 
            this.ctrlListeUser1.Location = new System.Drawing.Point(56, 79);
            this.ctrlListeUser1.Name = "ctrlListeUser1";
            this.ctrlListeUser1.Size = new System.Drawing.Size(230, 34);
            this.ctrlListeUser1.TabIndex = 2;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(96, 159);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 6;
            // 
            // CtrlAjoutJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btAjoutJalon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlListeUser1);
            this.Controls.Add(this.dtpLivrPrevu);
            this.Controls.Add(this.tbLibelle);
            this.Name = "CtrlAjoutJalon";
            this.Size = new System.Drawing.Size(356, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.DateTimePicker dtpLivrPrevu;
        private CtrlListeUser ctrlListeUser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAjoutJalon;
        private System.Windows.Forms.Label lbError;
    }
}
