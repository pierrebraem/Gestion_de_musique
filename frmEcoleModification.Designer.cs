namespace Gestion_de_musique
{
    partial class frmEcoleModification
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
            this.btn_effacer = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nom_label = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CD_label = new System.Windows.Forms.Label();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_première = new System.Windows.Forms.Button();
            this.Numero_list = new System.Windows.Forms.ComboBox();
            this.Numero_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(505, 320);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(107, 47);
            this.btn_fermer.TabIndex = 15;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(346, 320);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(107, 47);
            this.btn_effacer.TabIndex = 14;
            this.btn_effacer.Text = "Effacer champs";
            this.btn_effacer.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Modification d\'une école";
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Location = new System.Drawing.Point(279, 227);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(35, 13);
            this.Nom_label.TabIndex = 11;
            this.Nom_label.Text = "Nom :";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(188, 320);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(107, 47);
            this.btn_valider.TabIndex = 10;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // CD_label
            // 
            this.CD_label.AutoSize = true;
            this.CD_label.Location = new System.Drawing.Point(245, 187);
            this.CD_label.Name = "CD_label";
            this.CD_label.Size = new System.Drawing.Size(69, 13);
            this.CD_label.TabIndex = 8;
            this.CD_label.Text = "Code postal :";
            // 
            // btn_derniere
            // 
            this.btn_derniere.Location = new System.Drawing.Point(488, 267);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(107, 47);
            this.btn_derniere.TabIndex = 19;
            this.btn_derniere.Text = "Dernière école";
            this.btn_derniere.UseVisualStyleBackColor = true;
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(375, 267);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(107, 47);
            this.btn_suivant.TabIndex = 18;
            this.btn_suivant.Text = "Ecole suivante";
            this.btn_suivant.UseVisualStyleBackColor = true;
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(262, 267);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(107, 47);
            this.btn_precedent.TabIndex = 17;
            this.btn_precedent.Text = "Ecole précédente";
            this.btn_precedent.UseVisualStyleBackColor = true;
            // 
            // btn_première
            // 
            this.btn_première.Location = new System.Drawing.Point(149, 267);
            this.btn_première.Name = "btn_première";
            this.btn_première.Size = new System.Drawing.Size(107, 47);
            this.btn_première.TabIndex = 16;
            this.btn_première.Text = "Première école";
            this.btn_première.UseVisualStyleBackColor = true;
            // 
            // Numero_list
            // 
            this.Numero_list.FormattingEnabled = true;
            this.Numero_list.Location = new System.Drawing.Point(346, 148);
            this.Numero_list.Name = "Numero_list";
            this.Numero_list.Size = new System.Drawing.Size(121, 21);
            this.Numero_list.TabIndex = 21;
            // 
            // Numero_label
            // 
            this.Numero_label.AutoSize = true;
            this.Numero_label.Location = new System.Drawing.Point(264, 151);
            this.Numero_label.Name = "Numero_label";
            this.Numero_label.Size = new System.Drawing.Size(50, 13);
            this.Numero_label.TabIndex = 20;
            this.Numero_label.Text = "Numéro :";
            // 
            // frmEcoleModification
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
            this.Controls.Add(this.btn_effacer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom_label);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CD_label);
            this.Name = "frmEcoleModification";
            this.Text = "frmEcoleModification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CD_label;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_première;
        private System.Windows.Forms.ComboBox Numero_list;
        private System.Windows.Forms.Label Numero_label;
    }
}