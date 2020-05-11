namespace Gestion_de_musique
{
    partial class frmEcoleAjout
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
            this.btn_Ecole_enregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Nom_libal = new System.Windows.Forms.Label();
            this.CD_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(253, 214);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(100, 20);
            this.Nom_saisie.TabIndex = 16;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(400, 275);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(104, 47);
            this.btn_fermer.TabIndex = 15;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // CD_saisie
            // 
            this.CD_saisie.Location = new System.Drawing.Point(253, 177);
            this.CD_saisie.Name = "CD_saisie";
            this.CD_saisie.Size = new System.Drawing.Size(100, 20);
            this.CD_saisie.TabIndex = 14;
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(249, 275);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(104, 47);
            this.btn_effacer.TabIndex = 13;
            this.btn_effacer.Text = "Effacer champs";
            this.btn_effacer.UseVisualStyleBackColor = true;
            // 
            // btn_Ecole_enregistrer
            // 
            this.btn_Ecole_enregistrer.Location = new System.Drawing.Point(81, 275);
            this.btn_Ecole_enregistrer.Name = "btn_Ecole_enregistrer";
            this.btn_Ecole_enregistrer.Size = new System.Drawing.Size(104, 47);
            this.btn_Ecole_enregistrer.TabIndex = 12;
            this.btn_Ecole_enregistrer.Text = "Enregistrer ecole";
            this.btn_Ecole_enregistrer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ajout d\'une ecole";
            // 
            // Nom_libal
            // 
            this.Nom_libal.AutoSize = true;
            this.Nom_libal.Location = new System.Drawing.Point(147, 221);
            this.Nom_libal.Name = "Nom_libal";
            this.Nom_libal.Size = new System.Drawing.Size(38, 13);
            this.Nom_libal.TabIndex = 10;
            this.Nom_libal.Text = "Nom : ";
            // 
            // CD_label
            // 
            this.CD_label.AutoSize = true;
            this.CD_label.Location = new System.Drawing.Point(116, 184);
            this.CD_label.Name = "CD_label";
            this.CD_label.Size = new System.Drawing.Size(69, 13);
            this.CD_label.TabIndex = 9;
            this.CD_label.Text = "Code postal :";
            // 
            // frmEcoleAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nom_saisie);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.CD_saisie);
            this.Controls.Add(this.btn_effacer);
            this.Controls.Add(this.btn_Ecole_enregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom_libal);
            this.Controls.Add(this.CD_label);
            this.Name = "frmEcoleAjout";
            this.Text = "frmEcoleAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.TextBox CD_saisie;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.Button btn_Ecole_enregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nom_libal;
        private System.Windows.Forms.Label CD_label;
    }
}