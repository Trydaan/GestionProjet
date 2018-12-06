namespace Esimed.GestionProjet.WinForm
{
    partial class Index
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInfoProjet = new System.Windows.Forms.Button();
            this.lbInfoProjet = new System.Windows.Forms.Label();
            this.btNouvProjet = new System.Windows.Forms.Button();
            this.btModifProjet = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exigencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAfficheExig = new System.Windows.Forms.Button();
            this.lbInfoExig = new System.Windows.Forms.Label();
            this.btAjoutExig = new System.Windows.Forms.Button();
            this.btModifExig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlListeJalon1 = new Esimed.GestionProjet.WinCtrl.Ctrl.CtrlListeJalon();
            this.ctrlListeExigence1 = new Esimed.GestionProjet.WinCtrl.Ctrl.CtrlListeExigence();
            this.ctrlListeProjet = new Esimed.GestionProjet.WinCtrl.CtrlListeProjet();
            this.btAjoutJalon = new System.Windows.Forms.Button();
            this.btModifJalon = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btInfoProjet
            // 
            this.btInfoProjet.Location = new System.Drawing.Point(162, 52);
            this.btInfoProjet.Name = "btInfoProjet";
            this.btInfoProjet.Size = new System.Drawing.Size(75, 23);
            this.btInfoProjet.TabIndex = 1;
            this.btInfoProjet.Text = "Afficher";
            this.btInfoProjet.UseVisualStyleBackColor = true;
            this.btInfoProjet.Click += new System.EventHandler(this.btInfoProjet_Click);
            // 
            // lbInfoProjet
            // 
            this.lbInfoProjet.AutoSize = true;
            this.lbInfoProjet.Location = new System.Drawing.Point(18, 86);
            this.lbInfoProjet.Name = "lbInfoProjet";
            this.lbInfoProjet.Size = new System.Drawing.Size(0, 13);
            this.lbInfoProjet.TabIndex = 2;
            // 
            // btNouvProjet
            // 
            this.btNouvProjet.Location = new System.Drawing.Point(351, 52);
            this.btNouvProjet.Name = "btNouvProjet";
            this.btNouvProjet.Size = new System.Drawing.Size(92, 23);
            this.btNouvProjet.TabIndex = 3;
            this.btNouvProjet.Text = "Nouveau projet";
            this.btNouvProjet.UseVisualStyleBackColor = true;
            this.btNouvProjet.Click += new System.EventHandler(this.btNouvProjet_Click);
            // 
            // btModifProjet
            // 
            this.btModifProjet.Location = new System.Drawing.Point(259, 52);
            this.btModifProjet.Name = "btModifProjet";
            this.btModifProjet.Size = new System.Drawing.Size(75, 23);
            this.btModifProjet.TabIndex = 4;
            this.btModifProjet.Text = "Modifier";
            this.btModifProjet.UseVisualStyleBackColor = true;
            this.btModifProjet.Click += new System.EventHandler(this.btModifProjet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exigencesToolStripMenuItem,
            this.tachesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exigencesToolStripMenuItem
            // 
            this.exigencesToolStripMenuItem.Name = "exigencesToolStripMenuItem";
            this.exigencesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.exigencesToolStripMenuItem.Text = "Exigences";
            // 
            // tachesToolStripMenuItem
            // 
            this.tachesToolStripMenuItem.Name = "tachesToolStripMenuItem";
            this.tachesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tachesToolStripMenuItem.Text = "Taches";
            // 
            // btAfficheExig
            // 
            this.btAfficheExig.Location = new System.Drawing.Point(30, 304);
            this.btAfficheExig.Name = "btAfficheExig";
            this.btAfficheExig.Size = new System.Drawing.Size(75, 40);
            this.btAfficheExig.TabIndex = 7;
            this.btAfficheExig.Text = "Affiche";
            this.btAfficheExig.UseVisualStyleBackColor = true;
            this.btAfficheExig.Click += new System.EventHandler(this.btAfficheExig_Click);
            // 
            // lbInfoExig
            // 
            this.lbInfoExig.AutoSize = true;
            this.lbInfoExig.Location = new System.Drawing.Point(27, 343);
            this.lbInfoExig.Name = "lbInfoExig";
            this.lbInfoExig.Size = new System.Drawing.Size(0, 13);
            this.lbInfoExig.TabIndex = 8;
            // 
            // btAjoutExig
            // 
            this.btAjoutExig.Location = new System.Drawing.Point(111, 304);
            this.btAjoutExig.Name = "btAjoutExig";
            this.btAjoutExig.Size = new System.Drawing.Size(80, 40);
            this.btAjoutExig.TabIndex = 9;
            this.btAjoutExig.Text = "Nouvelle exigence";
            this.btAjoutExig.UseVisualStyleBackColor = true;
            this.btAjoutExig.Click += new System.EventHandler(this.btAjoutExig_Click);
            // 
            // btModifExig
            // 
            this.btModifExig.Location = new System.Drawing.Point(197, 304);
            this.btModifExig.Name = "btModifExig";
            this.btModifExig.Size = new System.Drawing.Size(75, 40);
            this.btModifExig.TabIndex = 10;
            this.btModifExig.Text = "Modifier";
            this.btModifExig.UseVisualStyleBackColor = true;
            this.btModifExig.Click += new System.EventHandler(this.btModifExig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Exigences du projet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jalons du projet";
            // 
            // ctrlListeJalon1
            // 
            this.ctrlListeJalon1.Location = new System.Drawing.Point(436, 126);
            this.ctrlListeJalon1.Name = "ctrlListeJalon1";
            this.ctrlListeJalon1.Size = new System.Drawing.Size(464, 172);
            this.ctrlListeJalon1.TabIndex = 11;
            // 
            // ctrlListeExigence1
            // 
            this.ctrlListeExigence1.Location = new System.Drawing.Point(12, 102);
            this.ctrlListeExigence1.Name = "ctrlListeExigence1";
            this.ctrlListeExigence1.Size = new System.Drawing.Size(450, 196);
            this.ctrlListeExigence1.TabIndex = 5;
            // 
            // ctrlListeProjet
            // 
            this.ctrlListeProjet.Location = new System.Drawing.Point(12, 24);
            this.ctrlListeProjet.Name = "ctrlListeProjet";
            this.ctrlListeProjet.Size = new System.Drawing.Size(144, 61);
            this.ctrlListeProjet.TabIndex = 0;
            // 
            // btAjoutJalon
            // 
            this.btAjoutJalon.Location = new System.Drawing.Point(445, 304);
            this.btAjoutJalon.Name = "btAjoutJalon";
            this.btAjoutJalon.Size = new System.Drawing.Size(75, 40);
            this.btAjoutJalon.TabIndex = 14;
            this.btAjoutJalon.Text = "Nouveau Jalon";
            this.btAjoutJalon.UseVisualStyleBackColor = true;
            this.btAjoutJalon.Click += new System.EventHandler(this.btAjoutJalon_Click);
            // 
            // btModifJalon
            // 
            this.btModifJalon.Location = new System.Drawing.Point(526, 304);
            this.btModifJalon.Name = "btModifJalon";
            this.btModifJalon.Size = new System.Drawing.Size(75, 40);
            this.btModifJalon.TabIndex = 15;
            this.btModifJalon.Text = "Modifier";
            this.btModifJalon.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 388);
            this.Controls.Add(this.btModifJalon);
            this.Controls.Add(this.btAjoutJalon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlListeJalon1);
            this.Controls.Add(this.btModifExig);
            this.Controls.Add(this.btAjoutExig);
            this.Controls.Add(this.lbInfoExig);
            this.Controls.Add(this.btAfficheExig);
            this.Controls.Add(this.ctrlListeExigence1);
            this.Controls.Add(this.btModifProjet);
            this.Controls.Add(this.btNouvProjet);
            this.Controls.Add(this.lbInfoProjet);
            this.Controls.Add(this.btInfoProjet);
            this.Controls.Add(this.ctrlListeProjet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Gestion de projet";
            this.Load += new System.EventHandler(this.Index_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinCtrl.CtrlListeProjet ctrlListeProjet;
        private System.Windows.Forms.Button btInfoProjet;
        private System.Windows.Forms.Label lbInfoProjet;
        private System.Windows.Forms.Button btNouvProjet;
        private System.Windows.Forms.Button btModifProjet;
        private WinCtrl.Ctrl.CtrlListeExigence ctrlListeExigence1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exigencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tachesToolStripMenuItem;
        private System.Windows.Forms.Button btAfficheExig;
        private System.Windows.Forms.Label lbInfoExig;
        private System.Windows.Forms.Button btAjoutExig;
        private System.Windows.Forms.Button btModifExig;
        private WinCtrl.Ctrl.CtrlListeJalon ctrlListeJalon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAjoutJalon;
        private System.Windows.Forms.Button btModifJalon;

    }
}

