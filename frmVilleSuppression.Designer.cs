namespace Gestion_de_musique
{
    partial class frmVilleConsultation
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
            this.btn_Ville_derniere = new System.Windows.Forms.Button();
            this.Numero_list = new System.Windows.Forms.ComboBox();
            this.CD_saisie = new System.Windows.Forms.TextBox();
            this.Numero_label = new System.Windows.Forms.Label();
            this.CD_label = new System.Windows.Forms.Label();
            this.Nom_label = new System.Windows.Forms.Label();
            this.Nom_saisie = new System.Windows.Forms.TextBox();
            this.btn_Ville_premiere = new System.Windows.Forms.Button();
            this.btn_Ville_precedente = new System.Windows.Forms.Button();
            this.btn_Ville_suivante = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Consultation d\'une ville";
            // 
            // btn_Ville_derniere
            // 
            this.btn_Ville_derniere.Location = new System.Drawing.Point(383, 272);
            this.btn_Ville_derniere.Name = "btn_Ville_derniere";
            this.btn_Ville_derniere.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_derniere.TabIndex = 8;
            this.btn_Ville_derniere.Text = "Dernière";
            this.btn_Ville_derniere.UseVisualStyleBackColor = true;
            // 
            // Numero_list
            // 
            this.Numero_list.FormattingEnabled = true;
            this.Numero_list.Location = new System.Drawing.Point(291, 119);
            this.Numero_list.Name = "Numero_list";
            this.Numero_list.Size = new System.Drawing.Size(121, 21);
            this.Numero_list.TabIndex = 9;
            // 
            // CD_saisie
            // 
            this.CD_saisie.Location = new System.Drawing.Point(291, 152);
            this.CD_saisie.Name = "CD_saisie";
            this.CD_saisie.Size = new System.Drawing.Size(100, 20);
            this.CD_saisie.TabIndex = 10;
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Location = new System.Drawing.Point(142, 127);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(50, 13);
            this.Numero_label.TabIndex = 11;
            this.Numero_label.Text = "Numéro :";
            // 
            // CD_label
            // 
            this.CD_label.AutoSize = true;
            this.CD_label.Location = new System.Drawing.Point(142, 159);
            this.CD_label.Name = "CD_label";
            this.CD_label.Size = new System.Drawing.Size(69, 13);
            this.CD_label.TabIndex = 12;
            this.CD_label.Text = "Code postal :";
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Location = new System.Drawing.Point(142, 199);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(35, 13);
            this.Nom_label.TabIndex = 13;
            this.Nom_label.Text = "Nom :";
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(291, 192);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(100, 20);
            this.Nom_saisie.TabIndex = 14;
            // 
            // btn_Ville_premiere
            // 
            this.btn_Ville_premiere.Location = new System.Drawing.Point(53, 272);
            this.btn_Ville_premiere.Name = "btn_Ville_premiere";
            this.btn_Ville_premiere.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_premiere.TabIndex = 15;
            this.btn_Ville_premiere.Text = "Première ville";
            this.btn_Ville_premiere.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_precedente
            // 
            this.btn_Ville_precedente.Location = new System.Drawing.Point(163, 272);
            this.btn_Ville_precedente.Name = "btn_Ville_precedente";
            this.btn_Ville_precedente.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_precedente.TabIndex = 16;
            this.btn_Ville_precedente.Text = "Ville précédente";
            this.btn_Ville_precedente.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_suivante
            // 
            this.btn_Ville_suivante.Location = new System.Drawing.Point(273, 272);
            this.btn_Ville_suivante.Name = "btn_Ville_suivante";
            this.btn_Ville_suivante.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_suivante.TabIndex = 17;
            this.btn_Ville_suivante.Text = "Ville suivante";
            this.btn_Ville_suivante.UseVisualStyleBackColor = true;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(256, 341);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(104, 47);
            this.btn_fermer.TabIndex = 18;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // frmVilleConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_Ville_suivante);
            this.Controls.Add(this.btn_Ville_precedente);
            this.Controls.Add(this.btn_Ville_premiere);
            this.Controls.Add(this.Nom_saisie);
            this.Controls.Add(this.Nom_label);
            this.Controls.Add(this.CD_label);
            this.Controls.Add(this.Numero_label);
            this.Controls.Add(this.CD_saisie);
            this.Controls.Add(this.Numero_list);
            this.Controls.Add(this.btn_Ville_derniere);
            this.Controls.Add(this.label3);
            this.Name = "frmVilleConsultation";
            this.Text = "frmVilleConsultation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Ville_derniere;
        private System.Windows.Forms.ComboBox Numero_list;
        private System.Windows.Forms.TextBox CD_saisie;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.Label CD_label;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Button btn_Ville_premiere;
        private System.Windows.Forms.Button btn_Ville_precedente;
        private System.Windows.Forms.Button btn_Ville_suivante;
        private System.Windows.Forms.Button btn_fermer;
    }
}