﻿namespace Gestion_de_musique
{
    partial class frmInstrumentConsultation
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
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.Nom_label = new System.Windows.Forms.Label();
            this.Nom_saisie = new System.Windows.Forms.TextBox();
            this.CP_label = new System.Windows.Forms.Label();
            this.CP_saisie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.Numero_label = new System.Windows.Forms.Label();
            this.lst_numero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(337, 338);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(100, 45);
            this.btn_fermer.TabIndex = 15;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(179, 287);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(100, 45);
            this.btn_premier.TabIndex = 14;
            this.btn_premier.Text = "Premier Instrument";
            this.btn_premier.UseVisualStyleBackColor = true;
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_label.Location = new System.Drawing.Point(251, 214);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(43, 16);
            this.Nom_label.TabIndex = 13;
            this.Nom_label.Text = "Nom :";
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(325, 210);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(121, 20);
            this.Nom_saisie.TabIndex = 12;
            // 
            // CP_label
            // 
            this.CP_label.AutoSize = true;
            this.CP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_label.Location = new System.Drawing.Point(207, 176);
            this.CP_label.Name = "CP_label";
            this.CP_label.Size = new System.Drawing.Size(87, 16);
            this.CP_label.TabIndex = 11;
            this.CP_label.Text = "Code postal :";
            // 
            // CP_saisie
            // 
            this.CP_saisie.Location = new System.Drawing.Point(325, 172);
            this.CP_saisie.Name = "CP_saisie";
            this.CP_saisie.Size = new System.Drawing.Size(121, 20);
            this.CP_saisie.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consultation d\'un instrument";
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(285, 287);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(100, 45);
            this.btn_precedent.TabIndex = 8;
            this.btn_precedent.Text = "Instrument précédent";
            this.btn_precedent.UseVisualStyleBackColor = true;
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(391, 287);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(100, 45);
            this.btn_suivant.TabIndex = 17;
            this.btn_suivant.Text = "Instrument suivant";
            this.btn_suivant.UseVisualStyleBackColor = true;
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(497, 287);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(100, 45);
            this.btn_dernier.TabIndex = 16;
            this.btn_dernier.Text = "Dernier Instrument";
            this.btn_dernier.UseVisualStyleBackColor = true;
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_label.Location = new System.Drawing.Point(232, 138);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(62, 16);
            this.Numero_label.TabIndex = 18;
            this.Numero_label.Text = "Numéro :";
            // 
            // lst_numero
            // 
            this.lst_numero.FormattingEnabled = true;
            this.lst_numero.Location = new System.Drawing.Point(325, 133);
            this.lst_numero.Name = "lst_numero";
            this.lst_numero.Size = new System.Drawing.Size(121, 21);
            this.lst_numero.TabIndex = 19;
            // 
            // frmInstrumentConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_numero);
            this.Controls.Add(this.Numero_label);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_dernier);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_premier);
            this.Controls.Add(this.Nom_label);
            this.Controls.Add(this.Nom_saisie);
            this.Controls.Add(this.CP_label);
            this.Controls.Add(this.CP_saisie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_precedent);
            this.Name = "frmInstrumentConsultation";
            this.Text = "frmInstrumentConsultation";
            this.Load += new System.EventHandler(this.FrmInstrumentConsultation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Label CP_label;
        private System.Windows.Forms.TextBox CP_saisie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_dernier;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.ComboBox lst_numero;
    }
}