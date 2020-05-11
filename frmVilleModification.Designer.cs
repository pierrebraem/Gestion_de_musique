namespace Gestion_de_musique
{
    partial class frmVilleModification
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
            this.Nom_saisie = new System.Windows.Forms.TextBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.CD_saisie = new System.Windows.Forms.TextBox();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.btn_Ville_modification = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Nom_libal = new System.Windows.Forms.Label();
            this.CD_label = new System.Windows.Forms.Label();
            this.btn_Ville_suivante = new System.Windows.Forms.Button();
            this.btn_Ville_precedente = new System.Windows.Forms.Button();
            this.btn_Ville_premiere = new System.Windows.Forms.Button();
            this.btn_Ville_derniere = new System.Windows.Forms.Button();
            this.Numero_label = new System.Windows.Forms.Label();
            this.Numero_list = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(267, 220);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(100, 20);
            this.Nom_saisie.TabIndex = 16;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(412, 345);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(104, 47);
            this.btn_fermer.TabIndex = 15;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // CD_saisie
            // 
            this.CD_saisie.Location = new System.Drawing.Point(267, 183);
            this.CD_saisie.Name = "CD_saisie";
            this.CD_saisie.Size = new System.Drawing.Size(100, 20);
            this.CD_saisie.TabIndex = 14;
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(261, 345);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(104, 47);
            this.btn_effacer.TabIndex = 13;
            this.btn_effacer.Text = "Effacer champs";
            this.btn_effacer.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_modification
            // 
            this.btn_Ville_modification.Location = new System.Drawing.Point(93, 345);
            this.btn_Ville_modification.Name = "btn_Ville_modification";
            this.btn_Ville_modification.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_modification.TabIndex = 12;
            this.btn_Ville_modification.Text = "Enregistrer modification";
            this.btn_Ville_modification.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modification d\'une ville";
            // 
            // Nom_libal
            // 
            this.Nom_libal.AutoSize = true;
            this.Nom_libal.Location = new System.Drawing.Point(159, 227);
            this.Nom_libal.Name = "Nom_libal";
            this.Nom_libal.Size = new System.Drawing.Size(38, 13);
            this.Nom_libal.TabIndex = 10;
            this.Nom_libal.Text = "Nom : ";
            // 
            // CD_label
            // 
            this.CD_label.AutoSize = true;
            this.CD_label.Location = new System.Drawing.Point(130, 190);
            this.CD_label.Name = "CD_label";
            this.CD_label.Size = new System.Drawing.Size(69, 13);
            this.CD_label.TabIndex = 9;
            this.CD_label.Text = "Code postal :";
            // 
            // btn_Ville_suivante
            // 
            this.btn_Ville_suivante.Location = new System.Drawing.Point(305, 272);
            this.btn_Ville_suivante.Name = "btn_Ville_suivante";
            this.btn_Ville_suivante.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_suivante.TabIndex = 33;
            this.btn_Ville_suivante.Text = "Ville suivante";
            this.btn_Ville_suivante.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_precedente
            // 
            this.btn_Ville_precedente.Location = new System.Drawing.Point(195, 272);
            this.btn_Ville_precedente.Name = "btn_Ville_precedente";
            this.btn_Ville_precedente.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_precedente.TabIndex = 32;
            this.btn_Ville_precedente.Text = "Ville précédente";
            this.btn_Ville_precedente.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_premiere
            // 
            this.btn_Ville_premiere.Location = new System.Drawing.Point(85, 272);
            this.btn_Ville_premiere.Name = "btn_Ville_premiere";
            this.btn_Ville_premiere.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_premiere.TabIndex = 31;
            this.btn_Ville_premiere.Text = "Première ville";
            this.btn_Ville_premiere.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_derniere
            // 
            this.btn_Ville_derniere.Location = new System.Drawing.Point(415, 272);
            this.btn_Ville_derniere.Name = "btn_Ville_derniere";
            this.btn_Ville_derniere.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_derniere.TabIndex = 30;
            this.btn_Ville_derniere.Text = "Dernière";
            this.btn_Ville_derniere.UseVisualStyleBackColor = true;
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Location = new System.Drawing.Point(147, 153);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(50, 13);
            this.Numero_label.TabIndex = 35;
            this.Numero_label.Text = "Numéro :";
            // 
            // Numero_list
            // 
            this.Numero_list.FormattingEnabled = true;
            this.Numero_list.Location = new System.Drawing.Point(267, 145);
            this.Numero_list.Name = "Numero_list";
            this.Numero_list.Size = new System.Drawing.Size(121, 21);
            this.Numero_list.TabIndex = 34;
            // 
            // frmVilleModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero_label);
            this.Controls.Add(this.Numero_list);
            this.Controls.Add(this.btn_Ville_suivante);
            this.Controls.Add(this.btn_Ville_precedente);
            this.Controls.Add(this.btn_Ville_premiere);
            this.Controls.Add(this.btn_Ville_derniere);
            this.Controls.Add(this.Nom_saisie);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.CD_saisie);
            this.Controls.Add(this.btn_effacer);
            this.Controls.Add(this.btn_Ville_modification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom_libal);
            this.Controls.Add(this.CD_label);
            this.Name = "frmVilleModification";
            this.Text = "frmVilleModification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.TextBox CD_saisie;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.Button btn_Ville_modification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nom_libal;
        private System.Windows.Forms.Label CD_label;
        private System.Windows.Forms.Button btn_Ville_suivante;
        private System.Windows.Forms.Button btn_Ville_precedente;
        private System.Windows.Forms.Button btn_Ville_premiere;
        private System.Windows.Forms.Button btn_Ville_derniere;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.ComboBox Numero_list;
    }
}