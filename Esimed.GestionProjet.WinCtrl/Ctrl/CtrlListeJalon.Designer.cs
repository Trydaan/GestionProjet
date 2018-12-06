namespace Esimed.GestionProjet.WinCtrl.Ctrl
{
    partial class CtrlListeJalon
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
            this.components = new System.ComponentModel.Container();
            this.dgvJalon = new System.Windows.Forms.DataGridView();
            this.bsJalon = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJalon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJalon
            // 
            this.dgvJalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJalon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvJalon.Location = new System.Drawing.Point(6, 13);
            this.dgvJalon.MultiSelect = false;
            this.dgvJalon.Name = "dgvJalon";
            this.dgvJalon.ReadOnly = true;
            this.dgvJalon.Size = new System.Drawing.Size(442, 150);
            this.dgvJalon.TabIndex = 0;
            this.dgvJalon.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvJalon_RowStateChanged);
            // 
            // CtrlListeJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvJalon);
            this.Name = "CtrlListeJalon";
            this.Size = new System.Drawing.Size(458, 227);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJalon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJalon;
        private System.Windows.Forms.BindingSource bsJalon;
    }
}
