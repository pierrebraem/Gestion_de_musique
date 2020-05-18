namespace Gestion_de_musique
{
    partial class frmSituation_familleModification
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
            this.lst_numero = new System.Windows.Forms.ComboBox();
            this.Numero_label = new System.Windows.Forms.Label();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.Nom_label = new System.Windows.Forms.Label();
            this.Nom_saisie = new System.Windows.Forms.TextBox();
            this.CP_label = new System.Windows.Forms.Label();
            this.CP_saisie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_numero
            // 
            this.lst_numero.FormattingEnabled = true;
            this.lst_numero.Location = new System.Drawing.Point(322, 121);
            this.lst_numero.Name = "lst_numero";
            this.lst_numero.Size = new System.Drawing.Size(121, 21);
            this.lst_numero.TabIndex = 37;
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_label.Location = new System.Drawing.Point(229, 126);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(62, 16);
            this.Numero_label.TabIndex = 36;
            this.Numero_label.Text = "Numéro :";
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(377, 280);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(100, 45);
            this.btn_suivant.TabIndex = 35;
            this.btn_suivant.Text = "situation suivante";
            this.btn_suivant.UseVisualStyleBackColor = true;
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(483, 280);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(100, 45);
            this.btn_dernier.TabIndex = 34;
            this.btn_dernier.Text = "Dernière situation";
            this.btn_dernier.UseVisualStyleBackColor = true;
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(165, 280);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(100, 45);
            this.btn_premier.TabIndex = 33;
            this.btn_premier.Text = "Première situation";
            this.btn_premier.UseVisualStyleBackColor = true;
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(271, 280);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(100, 45);
            this.btn_precedent.TabIndex = 32;
            this.btn_precedent.Text = "Situation précédente";
            this.btn_precedent.UseVisualStyleBackColor = true;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(411, 331);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(100, 45);
            this.btn_fermer.TabIndex = 31;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(199, 331);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(100, 45);
            this.btn_modifier.TabIndex = 30;
            this.btn_modifier.Text = "Modifier situation";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_label.Location = new System.Drawing.Point(248, 199);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(43, 16);
            this.Nom_label.TabIndex = 29;
            this.Nom_label.Text = "Nom :";
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(322, 195);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(121, 20);
            this.Nom_saisie.TabIndex = 28;
            // 
            // CP_label
            // 
            this.CP_label.AutoSize = true;
            this.CP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_label.Location = new System.Drawing.Point(204, 162);
            this.CP_label.Name = "CP_label";
            this.CP_label.Size = new System.Drawing.Size(87, 16);
            this.CP_label.TabIndex = 27;
            this.CP_label.Text = "Code postal :";
            // 
            // CP_saisie
            // 
            this.CP_saisie.Location = new System.Drawing.Point(322, 158);
            this.CP_saisie.Name = "CP_saisie";
            this.CP_saisie.Size = new System.Drawing.Size(121, 20);
            this.CP_saisie.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Modification de la situation";
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(305, 331);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(100, 45);
            this.btn_effacer.TabIndex = 24;
            this.btn_effacer.Text = "Effacer champs";
            this.btn_effacer.UseVisualStyleBackColor = true;
            // 
            // frmSituation_familleModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_numero);
            this.Controls.Add(this.Numero_label);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_dernier);
            this.Controls.Add(this.btn_premier);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.Nom_label);
            this.Controls.Add(this.Nom_saisie);
            this.Controls.Add(this.CP_label);
            this.Controls.Add(this.CP_saisie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_effacer);
            this.Name = "frmSituation_familleModification";
            this.Text = "frmSituation_familleModification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lst_numero;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_dernier;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Label CP_label;
        private System.Windows.Forms.TextBox CP_saisie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_effacer;
    }
}