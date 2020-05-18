namespace Gestion_de_musique
{
    partial class frmSituation_familleAjout
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
            this.btn_enregistrement = new System.Windows.Forms.Button();
            this.Nom_label = new System.Windows.Forms.Label();
            this.Nom_saisie = new System.Windows.Forms.TextBox();
            this.CP_label = new System.Windows.Forms.Label();
            this.CP_saisie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(445, 294);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(100, 45);
            this.btn_fermer.TabIndex = 15;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_enregistrement
            // 
            this.btn_enregistrement.Location = new System.Drawing.Point(233, 294);
            this.btn_enregistrement.Name = "btn_enregistrement";
            this.btn_enregistrement.Size = new System.Drawing.Size(100, 45);
            this.btn_enregistrement.TabIndex = 14;
            this.btn_enregistrement.Text = "Enregistrer situation";
            this.btn_enregistrement.UseVisualStyleBackColor = true;
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_label.Location = new System.Drawing.Point(265, 222);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(43, 16);
            this.Nom_label.TabIndex = 13;
            this.Nom_label.Text = "Nom :";
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(339, 218);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(100, 20);
            this.Nom_saisie.TabIndex = 12;
            // 
            // CP_label
            // 
            this.CP_label.AutoSize = true;
            this.CP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_label.Location = new System.Drawing.Point(221, 162);
            this.CP_label.Name = "CP_label";
            this.CP_label.Size = new System.Drawing.Size(87, 16);
            this.CP_label.TabIndex = 11;
            this.CP_label.Text = "Code postal :";
            // 
            // CP_saisie
            // 
            this.CP_saisie.Location = new System.Drawing.Point(339, 158);
            this.CP_saisie.Name = "CP_saisie";
            this.CP_saisie.Size = new System.Drawing.Size(100, 20);
            this.CP_saisie.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ajoutd\'une situation";
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(339, 294);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(100, 45);
            this.btn_effacer.TabIndex = 8;
            this.btn_effacer.Text = "Effacer champs";
            this.btn_effacer.UseVisualStyleBackColor = true;
            // 
            // frmSituation_familleAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_enregistrement);
            this.Controls.Add(this.Nom_label);
            this.Controls.Add(this.Nom_saisie);
            this.Controls.Add(this.CP_label);
            this.Controls.Add(this.CP_saisie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_effacer);
            this.Name = "frmSituation_familleAjout";
            this.Text = "frmSituation_familleAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_enregistrement;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Label CP_label;
        private System.Windows.Forms.TextBox CP_saisie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_effacer;
    }
}