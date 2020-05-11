namespace Gestion_de_musique
{
    partial class frmVilleSuppression
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
            this.btn_Ville_suivante = new System.Windows.Forms.Button();
            this.btn_Ville_precedente = new System.Windows.Forms.Button();
            this.btn_Ville_premiere = new System.Windows.Forms.Button();
            this.Nom_saisie = new System.Windows.Forms.TextBox();
            this.Nom_label = new System.Windows.Forms.Label();
            this.CD_label = new System.Windows.Forms.Label();
            this.Numero_label = new System.Windows.Forms.Label();
            this.CD_saisie = new System.Windows.Forms.TextBox();
            this.Numero_list = new System.Windows.Forms.ComboBox();
            this.btn_Ville_derniere = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_suppression = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(483, 346);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(104, 47);
            this.btn_fermer.TabIndex = 30;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_suivante
            // 
            this.btn_Ville_suivante.Location = new System.Drawing.Point(373, 280);
            this.btn_Ville_suivante.Name = "btn_Ville_suivante";
            this.btn_Ville_suivante.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_suivante.TabIndex = 29;
            this.btn_Ville_suivante.Text = "Ville suivante";
            this.btn_Ville_suivante.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_precedente
            // 
            this.btn_Ville_precedente.Location = new System.Drawing.Point(263, 280);
            this.btn_Ville_precedente.Name = "btn_Ville_precedente";
            this.btn_Ville_precedente.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_precedente.TabIndex = 28;
            this.btn_Ville_precedente.Text = "Ville précédente";
            this.btn_Ville_precedente.UseVisualStyleBackColor = true;
            // 
            // btn_Ville_premiere
            // 
            this.btn_Ville_premiere.Location = new System.Drawing.Point(153, 280);
            this.btn_Ville_premiere.Name = "btn_Ville_premiere";
            this.btn_Ville_premiere.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_premiere.TabIndex = 27;
            this.btn_Ville_premiere.Text = "Première ville";
            this.btn_Ville_premiere.UseVisualStyleBackColor = true;
            // 
            // Nom_saisie
            // 
            this.Nom_saisie.Location = new System.Drawing.Point(391, 200);
            this.Nom_saisie.Name = "Nom_saisie";
            this.Nom_saisie.Size = new System.Drawing.Size(100, 20);
            this.Nom_saisie.TabIndex = 26;
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Location = new System.Drawing.Point(242, 207);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(35, 13);
            this.Nom_label.TabIndex = 25;
            this.Nom_label.Text = "Nom :";
            // 
            // CD_label
            // 
            this.CD_label.AutoSize = true;
            this.CD_label.Location = new System.Drawing.Point(242, 167);
            this.CD_label.Name = "CD_label";
            this.CD_label.Size = new System.Drawing.Size(69, 13);
            this.CD_label.TabIndex = 24;
            this.CD_label.Text = "Code postal :";
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Location = new System.Drawing.Point(242, 135);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(50, 13);
            this.Numero_label.TabIndex = 23;
            this.Numero_label.Text = "Numéro :";
            // 
            // CD_saisie
            // 
            this.CD_saisie.Location = new System.Drawing.Point(391, 160);
            this.CD_saisie.Name = "CD_saisie";
            this.CD_saisie.Size = new System.Drawing.Size(100, 20);
            this.CD_saisie.TabIndex = 22;
            // 
            // Numero_list
            // 
            this.Numero_list.FormattingEnabled = true;
            this.Numero_list.Location = new System.Drawing.Point(391, 127);
            this.Numero_list.Name = "Numero_list";
            this.Numero_list.Size = new System.Drawing.Size(121, 21);
            this.Numero_list.TabIndex = 21;
            // 
            // btn_Ville_derniere
            // 
            this.btn_Ville_derniere.Location = new System.Drawing.Point(483, 280);
            this.btn_Ville_derniere.Name = "btn_Ville_derniere";
            this.btn_Ville_derniere.Size = new System.Drawing.Size(104, 47);
            this.btn_Ville_derniere.TabIndex = 20;
            this.btn_Ville_derniere.Text = "Dernière";
            this.btn_Ville_derniere.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Suppression d\'une ville";
            // 
            // btn_suppression
            // 
            this.btn_suppression.Location = new System.Drawing.Point(263, 346);
            this.btn_suppression.Name = "btn_suppression";
            this.btn_suppression.Size = new System.Drawing.Size(214, 47);
            this.btn_suppression.TabIndex = 31;
            this.btn_suppression.Text = "Suppression";
            this.btn_suppression.UseVisualStyleBackColor = true;
            // 
            // frmVilleSuppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_suppression);
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
            this.Name = "frmVilleSuppression";
            this.Text = "frmVilleSuppression";
            this.Load += new System.EventHandler(this.FrmVilleSuppression_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_Ville_suivante;
        private System.Windows.Forms.Button btn_Ville_precedente;
        private System.Windows.Forms.Button btn_Ville_premiere;
        private System.Windows.Forms.TextBox Nom_saisie;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.Label CD_label;
        private System.Windows.Forms.Label Numero_label;
        private System.Windows.Forms.TextBox CD_saisie;
        private System.Windows.Forms.ComboBox Numero_list;
        private System.Windows.Forms.Button btn_Ville_derniere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_suppression;
    }
}