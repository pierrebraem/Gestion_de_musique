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
            this.Nom_saisie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nom_label = new System.Windows.Forms.Label();
            this.CD_saisie = new System.Windows.Forms.TextBox();
            this.CD_label = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_première = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.Numero_label = new System.Windows.Forms.Label();
            this.Numero_list = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(263, 196);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(100, 20);
            this.Nom_saisie.TabIndex = 10;
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
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Location = new System.Drawing.Point(196, 199);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(35, 13);
            this.Nom_label.TabIndex = 8;
            this.Nom_label.Text = "Nom :";
            // 
            // CD_saisie
            // 
            this.CD_saisie.Location = new System.Drawing.Point(263, 150);
            this.CD_saisie.Name = "CD_saisie";
            this.CD_saisie.Size = new System.Drawing.Size(100, 20);
            this.CD_saisie.TabIndex = 7;
            // 
            // CD_label
            // 
            this.CD_label.AutoSize = true;
            this.CD_label.Location = new System.Drawing.Point(162, 153);
            this.CD_label.Name = "CD_label";
            this.CD_label.Size = new System.Drawing.Size(69, 13);
            this.CD_label.TabIndex = 6;
            this.CD_label.Text = "Code postal :";
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
            // frmEcoleConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero_list);
            this.Controls.Add(this.Numero_label);
            this.Controls.Add(this.btn_derniere);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_première);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.Nom_saisie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom_label);
            this.Controls.Add(this.CD_saisie);
            this.Controls.Add(this.CD_label);
            this.Name = "frmEcoleConsultation";
            this.Text = "frmEcoleConsultation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.TextBox CD_saisie;
        private System.Windows.Forms.Label CD_label;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_première;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.ComboBox Numero_list;
    }
}