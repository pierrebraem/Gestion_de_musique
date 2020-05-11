namespace Gestion_de_musique
{
    partial class frmInscriptionAjout
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
            this.lblAjoutDescription = new System.Windows.Forms.Label();
            this.lblCleWallonnienne = new System.Windows.Forms.Label();
            this.btnRadioCleOui = new System.Windows.Forms.RadioButton();
            this.btnRadioCleNon = new System.Windows.Forms.RadioButton();
            this.lblRepresentantLegal = new System.Windows.Forms.Label();
            this.btnNouveauRepresentant = new System.Windows.Forms.Button();
            this.lblNumeroRepresentant = new System.Windows.Forms.Label();
            this.lstNumeroReprentation = new System.Windows.Forms.ComboBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lstNomPrenomRepresentation = new System.Windows.Forms.ComboBox();
            this.lblAdresseRepresentant = new System.Windows.Forms.Label();
            this.txtAdresseRepresentant = new System.Windows.Forms.TextBox();
            this.lblVilleRepresentant = new System.Windows.Forms.Label();
            this.txtVilleRepresentant = new System.Windows.Forms.TextBox();
            this.lblCodePostalRepresentant = new System.Windows.Forms.Label();
            this.txtCodePostalRepresentant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAjoutDescription
            // 
            this.lblAjoutDescription.AutoSize = true;
            this.lblAjoutDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutDescription.Location = new System.Drawing.Point(218, 20);
            this.lblAjoutDescription.Name = "lblAjoutDescription";
            this.lblAjoutDescription.Size = new System.Drawing.Size(310, 31);
            this.lblAjoutDescription.TabIndex = 0;
            this.lblAjoutDescription.Text = "Ajout d\'une description";
            // 
            // lblCleWallonnienne
            // 
            this.lblCleWallonnienne.AutoSize = true;
            this.lblCleWallonnienne.Location = new System.Drawing.Point(12, 77);
            this.lblCleWallonnienne.Name = "lblCleWallonnienne";
            this.lblCleWallonnienne.Size = new System.Drawing.Size(96, 13);
            this.lblCleWallonnienne.TabIndex = 1;
            this.lblCleWallonnienne.Text = "Clé Wallonnienne :";
            // 
            // btnRadioCleOui
            // 
            this.btnRadioCleOui.AutoSize = true;
            this.btnRadioCleOui.Location = new System.Drawing.Point(128, 76);
            this.btnRadioCleOui.Name = "btnRadioCleOui";
            this.btnRadioCleOui.Size = new System.Drawing.Size(44, 17);
            this.btnRadioCleOui.TabIndex = 2;
            this.btnRadioCleOui.TabStop = true;
            this.btnRadioCleOui.Text = "OUI";
            this.btnRadioCleOui.UseVisualStyleBackColor = true;
            // 
            // btnRadioCleNon
            // 
            this.btnRadioCleNon.AutoSize = true;
            this.btnRadioCleNon.Location = new System.Drawing.Point(178, 77);
            this.btnRadioCleNon.Name = "btnRadioCleNon";
            this.btnRadioCleNon.Size = new System.Drawing.Size(49, 17);
            this.btnRadioCleNon.TabIndex = 3;
            this.btnRadioCleNon.TabStop = true;
            this.btnRadioCleNon.Text = "NON";
            this.btnRadioCleNon.UseVisualStyleBackColor = true;
            // 
            // lblRepresentantLegal
            // 
            this.lblRepresentantLegal.AutoSize = true;
            this.lblRepresentantLegal.Location = new System.Drawing.Point(12, 107);
            this.lblRepresentantLegal.Name = "lblRepresentantLegal";
            this.lblRepresentantLegal.Size = new System.Drawing.Size(102, 13);
            this.lblRepresentantLegal.TabIndex = 4;
            this.lblRepresentantLegal.Text = "Représentant légal :";
            // 
            // btnNouveauRepresentant
            // 
            this.btnNouveauRepresentant.Location = new System.Drawing.Point(128, 102);
            this.btnNouveauRepresentant.Name = "btnNouveauRepresentant";
            this.btnNouveauRepresentant.Size = new System.Drawing.Size(87, 24);
            this.btnNouveauRepresentant.TabIndex = 5;
            this.btnNouveauRepresentant.Text = "Nouveau";
            this.btnNouveauRepresentant.UseVisualStyleBackColor = true;
            // 
            // lblNumeroRepresentant
            // 
            this.lblNumeroRepresentant.AutoSize = true;
            this.lblNumeroRepresentant.Location = new System.Drawing.Point(330, 108);
            this.lblNumeroRepresentant.Name = "lblNumeroRepresentant";
            this.lblNumeroRepresentant.Size = new System.Drawing.Size(50, 13);
            this.lblNumeroRepresentant.TabIndex = 6;
            this.lblNumeroRepresentant.Text = "Numéro :";
            // 
            // lstNumeroReprentation
            // 
            this.lstNumeroReprentation.FormattingEnabled = true;
            this.lstNumeroReprentation.Location = new System.Drawing.Point(398, 102);
            this.lstNumeroReprentation.Name = "lstNumeroReprentation";
            this.lstNumeroReprentation.Size = new System.Drawing.Size(130, 21);
            this.lstNumeroReprentation.TabIndex = 7;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(12, 153);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(74, 13);
            this.lblNomPrenom.TabIndex = 8;
            this.lblNomPrenom.Text = "Nom Prémon :";
            // 
            // lstNomPrenomRepresentation
            // 
            this.lstNomPrenomRepresentation.FormattingEnabled = true;
            this.lstNomPrenomRepresentation.Location = new System.Drawing.Point(103, 150);
            this.lstNomPrenomRepresentation.Name = "lstNomPrenomRepresentation";
            this.lstNomPrenomRepresentation.Size = new System.Drawing.Size(194, 21);
            this.lstNomPrenomRepresentation.TabIndex = 9;
            // 
            // lblAdresseRepresentant
            // 
            this.lblAdresseRepresentant.AutoSize = true;
            this.lblAdresseRepresentant.Location = new System.Drawing.Point(12, 189);
            this.lblAdresseRepresentant.Name = "lblAdresseRepresentant";
            this.lblAdresseRepresentant.Size = new System.Drawing.Size(51, 13);
            this.lblAdresseRepresentant.TabIndex = 10;
            this.lblAdresseRepresentant.Text = "Adresse :";
            // 
            // txtAdresseRepresentant
            // 
            this.txtAdresseRepresentant.Location = new System.Drawing.Point(103, 186);
            this.txtAdresseRepresentant.Name = "txtAdresseRepresentant";
            this.txtAdresseRepresentant.Size = new System.Drawing.Size(194, 20);
            this.txtAdresseRepresentant.TabIndex = 11;
            // 
            // lblVilleRepresentant
            // 
            this.lblVilleRepresentant.AutoSize = true;
            this.lblVilleRepresentant.Location = new System.Drawing.Point(12, 225);
            this.lblVilleRepresentant.Name = "lblVilleRepresentant";
            this.lblVilleRepresentant.Size = new System.Drawing.Size(32, 13);
            this.lblVilleRepresentant.TabIndex = 12;
            this.lblVilleRepresentant.Text = "Ville :";
            // 
            // txtVilleRepresentant
            // 
            this.txtVilleRepresentant.Location = new System.Drawing.Point(103, 222);
            this.txtVilleRepresentant.Name = "txtVilleRepresentant";
            this.txtVilleRepresentant.Size = new System.Drawing.Size(194, 20);
            this.txtVilleRepresentant.TabIndex = 13;
            // 
            // lblCodePostalRepresentant
            // 
            this.lblCodePostalRepresentant.AutoSize = true;
            this.lblCodePostalRepresentant.Location = new System.Drawing.Point(334, 227);
            this.lblCodePostalRepresentant.Name = "lblCodePostalRepresentant";
            this.lblCodePostalRepresentant.Size = new System.Drawing.Size(69, 13);
            this.lblCodePostalRepresentant.TabIndex = 14;
            this.lblCodePostalRepresentant.Text = "Code postal :";
            // 
            // txtCodePostalRepresentant
            // 
            this.txtCodePostalRepresentant.Location = new System.Drawing.Point(419, 222);
            this.txtCodePostalRepresentant.Name = "txtCodePostalRepresentant";
            this.txtCodePostalRepresentant.Size = new System.Drawing.Size(120, 20);
            this.txtCodePostalRepresentant.TabIndex = 15;
            // 
            // frmInscriptionAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.txtCodePostalRepresentant);
            this.Controls.Add(this.lblCodePostalRepresentant);
            this.Controls.Add(this.txtVilleRepresentant);
            this.Controls.Add(this.lblVilleRepresentant);
            this.Controls.Add(this.txtAdresseRepresentant);
            this.Controls.Add(this.lblAdresseRepresentant);
            this.Controls.Add(this.lstNomPrenomRepresentation);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.lstNumeroReprentation);
            this.Controls.Add(this.lblNumeroRepresentant);
            this.Controls.Add(this.btnNouveauRepresentant);
            this.Controls.Add(this.lblRepresentantLegal);
            this.Controls.Add(this.btnRadioCleNon);
            this.Controls.Add(this.btnRadioCleOui);
            this.Controls.Add(this.lblCleWallonnienne);
            this.Controls.Add(this.lblAjoutDescription);
            this.Name = "frmInscriptionAjout";
            this.Text = "frmInscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjoutDescription;
        private System.Windows.Forms.Label lblCleWallonnienne;
        private System.Windows.Forms.RadioButton btnRadioCleOui;
        private System.Windows.Forms.RadioButton btnRadioCleNon;
        private System.Windows.Forms.Label lblRepresentantLegal;
        private System.Windows.Forms.Button btnNouveauRepresentant;
        private System.Windows.Forms.Label lblNumeroRepresentant;
        private System.Windows.Forms.ComboBox lstNumeroReprentation;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.ComboBox lstNomPrenomRepresentation;
        private System.Windows.Forms.Label lblAdresseRepresentant;
        private System.Windows.Forms.TextBox txtAdresseRepresentant;
        private System.Windows.Forms.Label lblVilleRepresentant;
        private System.Windows.Forms.TextBox txtVilleRepresentant;
        private System.Windows.Forms.Label lblCodePostalRepresentant;
        private System.Windows.Forms.TextBox txtCodePostalRepresentant;
    }
}