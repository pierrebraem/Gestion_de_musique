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
            this.CD_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ecole_enregistrer = new System.Windows.Forms.Button();
            this.Nom_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CD_label
            // 
            this.CD_label.AutoSize = true;
            this.CD_label.Location = new System.Drawing.Point(150, 106);
            this.CD_label.Name = "CD_label";
            this.CD_label.Size = new System.Drawing.Size(69, 13);
            this.CD_label.TabIndex = 0;
            this.CD_label.Text = "Code postal :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_ecole_enregistrer
            // 
            this.btn_ecole_enregistrer.Location = new System.Drawing.Point(93, 273);
            this.btn_ecole_enregistrer.Name = "btn_ecole_enregistrer";
            this.btn_ecole_enregistrer.Size = new System.Drawing.Size(107, 47);
            this.btn_ecole_enregistrer.TabIndex = 2;
            this.btn_ecole_enregistrer.Text = "Enregistrer école";
            this.btn_ecole_enregistrer.UseVisualStyleBackColor = true;
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Location = new System.Drawing.Point(184, 152);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(35, 13);
            this.Nom_label.TabIndex = 3;
            this.Nom_label.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ajout d\'une école";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(251, 273);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(107, 47);
            this.btn_effacer.TabIndex = 6;
            this.btn_effacer.Text = "Effacer champs";
            this.btn_effacer.UseVisualStyleBackColor = true;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(410, 273);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(107, 47);
            this.btn_fermer.TabIndex = 7;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // frmEcoleAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_effacer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom_label);
            this.Controls.Add(this.btn_ecole_enregistrer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CD_label);
            this.Name = "frmEcoleAjout";
            this.Text = "frmEcoleAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CD_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ecole_enregistrer;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.Button btn_fermer;
    }
}