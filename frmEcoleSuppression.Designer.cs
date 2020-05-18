namespace Gestion_de_musique
{
    partial class frmEcoleSuppression
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
            this.Matiere_label = new System.Windows.Forms.Label();
            this.tab_matiere = new System.Windows.Forms.DataGridView();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_list = new System.Windows.Forms.ComboBox();
            this.Numero_label = new System.Windows.Forms.Label();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_première = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.libelle_saisie = new System.Windows.Forms.TextBox();
            this.libelle_label = new System.Windows.Forms.Label();
            this.btn_supp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tab_matiere)).BeginInit();
            this.SuspendLayout();
            // 
            // Matiere_label
            // 
            this.Matiere_label.AutoSize = true;
            this.Matiere_label.Location = new System.Drawing.Point(215, 209);
            this.Matiere_label.Name = "Matiere_label";
            this.Matiere_label.Size = new System.Drawing.Size(53, 13);
            this.Matiere_label.TabIndex = 31;
            this.Matiere_label.Text = "Matières :";
            // 
            // tab_matiere
            // 
            this.tab_matiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_matiere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.Libellé});
            this.tab_matiere.Location = new System.Drawing.Point(218, 225);
            this.tab_matiere.Name = "tab_matiere";
            this.tab_matiere.Size = new System.Drawing.Size(244, 46);
            this.tab_matiere.TabIndex = 30;
            // 
            // Numéro
            // 
            this.Numéro.HeaderText = "Numéro";
            this.Numéro.Name = "Numéro";
            // 
            // Libellé
            // 
            this.Libellé.HeaderText = "Libellé";
            this.Libellé.Name = "Libellé";
            // 
            // Numero_list
            // 
            this.Numero_list.FormattingEnabled = true;
            this.Numero_list.Location = new System.Drawing.Point(286, 124);
            this.Numero_list.Name = "Numero_list";
            this.Numero_list.Size = new System.Drawing.Size(121, 21);
            this.Numero_list.TabIndex = 29;
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Location = new System.Drawing.Point(204, 127);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(50, 13);
            this.Numero_label.TabIndex = 28;
            this.Numero_label.Text = "Numéro :";
            // 
            // btn_derniere
            // 
            this.btn_derniere.Location = new System.Drawing.Point(458, 287);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(107, 47);
            this.btn_derniere.TabIndex = 27;
            this.btn_derniere.Text = "Dernière école";
            this.btn_derniere.UseVisualStyleBackColor = true;
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(345, 287);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(107, 47);
            this.btn_suivant.TabIndex = 26;
            this.btn_suivant.Text = "Ecole suivante";
            this.btn_suivant.UseVisualStyleBackColor = true;
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(232, 287);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(107, 47);
            this.btn_precedent.TabIndex = 25;
            this.btn_precedent.Text = "Ecole précédente";
            this.btn_precedent.UseVisualStyleBackColor = true;
            // 
            // btn_première
            // 
            this.btn_première.Location = new System.Drawing.Point(119, 287);
            this.btn_première.Name = "btn_première";
            this.btn_première.Size = new System.Drawing.Size(107, 47);
            this.btn_première.TabIndex = 24;
            this.btn_première.Text = "Première école";
            this.btn_première.UseVisualStyleBackColor = true;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(345, 362);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(107, 47);
            this.btn_fermer.TabIndex = 23;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Suppression d\'une école";
            // 
            // libelle_saisie
            // 
            this.libelle_saisie.Location = new System.Drawing.Point(286, 159);
            this.libelle_saisie.Name = "libelle_saisie";
            this.libelle_saisie.Size = new System.Drawing.Size(281, 20);
            this.libelle_saisie.TabIndex = 21;
            // 
            // libelle_label
            // 
            this.libelle_label.AutoSize = true;
            this.libelle_label.Location = new System.Drawing.Point(215, 162);
            this.libelle_label.Name = "libelle_label";
            this.libelle_label.Size = new System.Drawing.Size(39, 13);
            this.libelle_label.TabIndex = 20;
            this.libelle_label.Text = "libellé :";
            // 
            // btn_supp
            // 
            this.btn_supp.Location = new System.Drawing.Point(232, 362);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(107, 47);
            this.btn_supp.TabIndex = 32;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = true;
            // 
            // frmEcoleSuppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.Matiere_label);
            this.Controls.Add(this.tab_matiere);
            this.Controls.Add(this.Numero_list);
            this.Controls.Add(this.Numero_label);
            this.Controls.Add(this.btn_derniere);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_première);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.libelle_saisie);
            this.Controls.Add(this.libelle_label);
            this.Name = "frmEcoleSuppression";
            this.Text = "frmEcoleSuppression";
            ((System.ComponentModel.ISupportInitialize)(this.tab_matiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Matiere_label;
        private System.Windows.Forms.DataGridView tab_matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libellé;
        private System.Windows.Forms.ComboBox Numero_list;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_première;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox libelle_saisie;
        private System.Windows.Forms.Label libelle_label;
        private System.Windows.Forms.Button btn_supp;
    }
}