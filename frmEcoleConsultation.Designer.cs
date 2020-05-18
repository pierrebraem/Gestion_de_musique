namespace Gestion_de_musique
{
    partial class frmEcoleConsultation
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
            this.label3 = new System.Windows.Forms.Label();
            this.libelle_saisie = new System.Windows.Forms.TextBox();
            this.libelle_label = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_première = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.Numero_label = new System.Windows.Forms.Label();
            this.Numero_list = new System.Windows.Forms.ComboBox();
            this.tab_matiere = new System.Windows.Forms.DataGridView();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matiere_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tab_matiere)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Consultation d\'une école";
            // 
            // libelle_saisie
            // 
            this.libelle_saisie.Location = new System.Drawing.Point(263, 150);
            this.libelle_saisie.Name = "libelle_saisie";
            this.libelle_saisie.Size = new System.Drawing.Size(281, 20);
            this.libelle_saisie.TabIndex = 7;
            // 
            // libelle_label
            // 
            this.libelle_label.AutoSize = true;
            this.libelle_label.Location = new System.Drawing.Point(192, 153);
            this.libelle_label.Name = "libelle_label";
            this.libelle_label.Size = new System.Drawing.Size(39, 13);
            this.libelle_label.TabIndex = 6;
            this.libelle_label.Text = "libellé :";
            this.libelle_label.Click += new System.EventHandler(this.CD_label_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(256, 349);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(107, 47);
            this.btn_fermer.TabIndex = 11;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_première
            // 
            this.btn_première.Location = new System.Drawing.Point(96, 278);
            this.btn_première.Name = "btn_première";
            this.btn_première.Size = new System.Drawing.Size(107, 47);
            this.btn_première.TabIndex = 12;
            this.btn_première.Text = "Première école";
            this.btn_première.UseVisualStyleBackColor = true;
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(209, 278);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(107, 47);
            this.btn_precedent.TabIndex = 13;
            this.btn_precedent.Text = "Ecole précédente";
            this.btn_precedent.UseVisualStyleBackColor = true;
            this.btn_precedent.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(322, 278);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(107, 47);
            this.btn_suivant.TabIndex = 14;
            this.btn_suivant.Text = "Ecole suivante";
            this.btn_suivant.UseVisualStyleBackColor = true;
            // 
            // btn_derniere
            // 
            this.btn_derniere.Location = new System.Drawing.Point(435, 278);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(107, 47);
            this.btn_derniere.TabIndex = 15;
            this.btn_derniere.Text = "Dernière école";
            this.btn_derniere.UseVisualStyleBackColor = true;
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Location = new System.Drawing.Point(181, 118);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(50, 13);
            this.Numero_label.TabIndex = 16;
            this.Numero_label.Text = "Numéro :";
            // 
            // Numero_list
            // 
            this.Numero_list.FormattingEnabled = true;
            this.Numero_list.Location = new System.Drawing.Point(263, 115);
            this.Numero_list.Name = "Numero_list";
            this.Numero_list.Size = new System.Drawing.Size(121, 21);
            this.Numero_list.TabIndex = 17;
            // 
            // tab_matiere
            // 
            this.tab_matiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_matiere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.Libellé});
            this.tab_matiere.Location = new System.Drawing.Point(195, 216);
            this.tab_matiere.Name = "tab_matiere";
            this.tab_matiere.Size = new System.Drawing.Size(244, 46);
            this.tab_matiere.TabIndex = 18;
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
            // Matiere_label
            // 
            this.Matiere_label.AutoSize = true;
            this.Matiere_label.Location = new System.Drawing.Point(192, 200);
            this.Matiere_label.Name = "Matiere_label";
            this.Matiere_label.Size = new System.Drawing.Size(53, 13);
            this.Matiere_label.TabIndex = 19;
            this.Matiere_label.Text = "Matières :";
            this.Matiere_label.Click += new System.EventHandler(this.Label1_Click);
            // 
            // frmEcoleConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "frmEcoleConsultation";
            this.Text = "frmEcoleConsultation";
            ((System.ComponentModel.ISupportInitialize)(this.tab_matiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox libelle_saisie;
        private System.Windows.Forms.Label libelle_label;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_première;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.ComboBox Numero_list;
        private System.Windows.Forms.DataGridView tab_matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libellé;
        private System.Windows.Forms.Label Matiere_label;
    }
}