namespace Esimed.GestionProjet.WinCtrl.Ctrl
{
    partial class CtrlListeExigence
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
            this.dgvExigence = new System.Windows.Forms.DataGridView();
            this.bsExigence = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExigence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExigence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExigence
            // 
            this.dgvExigence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExigence.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvExigence.Location = new System.Drawing.Point(19, 37);
            this.dgvExigence.MultiSelect = false;
            this.dgvExigence.Name = "dgvExigence";
            this.dgvExigence.ReadOnly = true;
            this.dgvExigence.Size = new System.Drawing.Size(394, 150);
            this.dgvExigence.TabIndex = 0;
            this.dgvExigence.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvExigence_RowStateChanged);
            // 
            // CtrlListeExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvExigence);
            this.Name = "CtrlListeExigence";
            this.Size = new System.Drawing.Size(437, 208);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExigence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExigence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExigence;
        private System.Windows.Forms.BindingSource bsExigence;
    }
}
