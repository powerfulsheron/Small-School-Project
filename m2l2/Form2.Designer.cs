namespace m2l2
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.afficheurPhotocopieCouleur = new System.Windows.Forms.TextBox();
            this.afficheurPhotocopieNb = new System.Windows.Forms.TextBox();
            this.afficheurTraceur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.prixAffranchissement = new System.Windows.Forms.Label();
            this.prixPhotocopieCouleur = new System.Windows.Forms.Label();
            this.prixPhotocopieNb = new System.Windows.Forms.Label();
            this.prixTraceur = new System.Windows.Forms.Label();
            this.montantAffranchissement = new System.Windows.Forms.Label();
            this.montantPhotocopieNb = new System.Windows.Forms.Label();
            this.montantTraceur = new System.Windows.Forms.Label();
            this.montantPhotocopiesCouleur = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.totalTtc = new System.Windows.Forms.Label();
            this.btnGenererPdf = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.afficheurAffranchissement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LIGUE : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Afranchissement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Photocopies couleur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Photocopies Noir et Blanc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Traceur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantité";
            // 
            // afficheurPhotocopieCouleur
            // 
            this.afficheurPhotocopieCouleur.Location = new System.Drawing.Point(163, 194);
            this.afficheurPhotocopieCouleur.Name = "afficheurPhotocopieCouleur";
            this.afficheurPhotocopieCouleur.Size = new System.Drawing.Size(58, 20);
            this.afficheurPhotocopieCouleur.TabIndex = 9;
            this.afficheurPhotocopieCouleur.TextChanged += new System.EventHandler(this.afficheurPhotocopieCouleur_TextChanged);
            // 
            // afficheurPhotocopieNb
            // 
            this.afficheurPhotocopieNb.Location = new System.Drawing.Point(163, 247);
            this.afficheurPhotocopieNb.Name = "afficheurPhotocopieNb";
            this.afficheurPhotocopieNb.Size = new System.Drawing.Size(58, 20);
            this.afficheurPhotocopieNb.TabIndex = 10;
            this.afficheurPhotocopieNb.TextChanged += new System.EventHandler(this.afficheurPhotocopieNb_TextChanged);
            // 
            // afficheurTraceur
            // 
            this.afficheurTraceur.Location = new System.Drawing.Point(163, 300);
            this.afficheurTraceur.Name = "afficheurTraceur";
            this.afficheurTraceur.Size = new System.Drawing.Size(58, 20);
            this.afficheurTraceur.TabIndex = 11;
            this.afficheurTraceur.TextChanged += new System.EventHandler(this.afficheurTraceur_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Prix unitaire HT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Montant TTC";
            // 
            // prixAffranchissement
            // 
            this.prixAffranchissement.AutoSize = true;
            this.prixAffranchissement.Location = new System.Drawing.Point(277, 144);
            this.prixAffranchissement.Name = "prixAffranchissement";
            this.prixAffranchissement.Size = new System.Drawing.Size(34, 13);
            this.prixAffranchissement.TabIndex = 14;
            this.prixAffranchissement.Text = "3,330";
            this.prixAffranchissement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prixPhotocopieCouleur
            // 
            this.prixPhotocopieCouleur.AutoSize = true;
            this.prixPhotocopieCouleur.Location = new System.Drawing.Point(277, 197);
            this.prixPhotocopieCouleur.Name = "prixPhotocopieCouleur";
            this.prixPhotocopieCouleur.Size = new System.Drawing.Size(34, 13);
            this.prixPhotocopieCouleur.TabIndex = 15;
            this.prixPhotocopieCouleur.Text = "0,240";
            this.prixPhotocopieCouleur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prixPhotocopieNb
            // 
            this.prixPhotocopieNb.AutoSize = true;
            this.prixPhotocopieNb.Location = new System.Drawing.Point(277, 250);
            this.prixPhotocopieNb.Name = "prixPhotocopieNb";
            this.prixPhotocopieNb.Size = new System.Drawing.Size(34, 13);
            this.prixPhotocopieNb.TabIndex = 16;
            this.prixPhotocopieNb.Text = "0,055";
            this.prixPhotocopieNb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prixTraceur
            // 
            this.prixTraceur.AutoSize = true;
            this.prixTraceur.Location = new System.Drawing.Point(277, 303);
            this.prixTraceur.Name = "prixTraceur";
            this.prixTraceur.Size = new System.Drawing.Size(34, 13);
            this.prixTraceur.TabIndex = 17;
            this.prixTraceur.Text = "0,356";
            this.prixTraceur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // montantAffranchissement
            // 
            this.montantAffranchissement.AutoSize = true;
            this.montantAffranchissement.Location = new System.Drawing.Point(376, 144);
            this.montantAffranchissement.Name = "montantAffranchissement";
            this.montantAffranchissement.Size = new System.Drawing.Size(28, 13);
            this.montantAffranchissement.TabIndex = 18;
            this.montantAffranchissement.Text = "0,00";
            this.montantAffranchissement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // montantPhotocopieNb
            // 
            this.montantPhotocopieNb.AutoSize = true;
            this.montantPhotocopieNb.Location = new System.Drawing.Point(376, 250);
            this.montantPhotocopieNb.Name = "montantPhotocopieNb";
            this.montantPhotocopieNb.Size = new System.Drawing.Size(28, 13);
            this.montantPhotocopieNb.TabIndex = 20;
            this.montantPhotocopieNb.Text = "0,00";
            this.montantPhotocopieNb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // montantTraceur
            // 
            this.montantTraceur.AutoSize = true;
            this.montantTraceur.Location = new System.Drawing.Point(376, 303);
            this.montantTraceur.Name = "montantTraceur";
            this.montantTraceur.Size = new System.Drawing.Size(28, 13);
            this.montantTraceur.TabIndex = 21;
            this.montantTraceur.Text = "0,00";
            this.montantTraceur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // montantPhotocopiesCouleur
            // 
            this.montantPhotocopiesCouleur.AutoSize = true;
            this.montantPhotocopiesCouleur.Location = new System.Drawing.Point(376, 197);
            this.montantPhotocopiesCouleur.Name = "montantPhotocopiesCouleur";
            this.montantPhotocopiesCouleur.Size = new System.Drawing.Size(28, 13);
            this.montantPhotocopiesCouleur.TabIndex = 22;
            this.montantPhotocopiesCouleur.Text = "0,00";
            this.montantPhotocopiesCouleur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(261, 373);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(66, 13);
            this.labelTotal.TabIndex = 23;
            this.labelTotal.Text = "TOTAL TTC";
            // 
            // totalTtc
            // 
            this.totalTtc.AutoSize = true;
            this.totalTtc.Location = new System.Drawing.Point(376, 373);
            this.totalTtc.Name = "totalTtc";
            this.totalTtc.Size = new System.Drawing.Size(28, 13);
            this.totalTtc.TabIndex = 24;
            this.totalTtc.Text = "0,00";
            this.totalTtc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenererPdf
            // 
            this.btnGenererPdf.Location = new System.Drawing.Point(181, 429);
            this.btnGenererPdf.Name = "btnGenererPdf";
            this.btnGenererPdf.Size = new System.Drawing.Size(75, 23);
            this.btnGenererPdf.TabIndex = 25;
            this.btnGenererPdf.Text = "Générer";
            this.btnGenererPdf.UseVisualStyleBackColor = true;
            this.btnGenererPdf.Click += new System.EventHandler(this.btnGenererPdf_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(177, 429);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(83, 23);
            this.btnSauvegarder.TabIndex = 26;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Visible = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // afficheurAffranchissement
            // 
            this.afficheurAffranchissement.Location = new System.Drawing.Point(163, 141);
            this.afficheurAffranchissement.Name = "afficheurAffranchissement";
            this.afficheurAffranchissement.Size = new System.Drawing.Size(58, 20);
            this.afficheurAffranchissement.TabIndex = 27;
            this.afficheurAffranchissement.TextChanged += new System.EventHandler(this.afficheurAffranchissement_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 464);
            this.Controls.Add(this.afficheurAffranchissement);
            this.Controls.Add(this.totalTtc);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.montantPhotocopiesCouleur);
            this.Controls.Add(this.montantTraceur);
            this.Controls.Add(this.montantPhotocopieNb);
            this.Controls.Add(this.montantAffranchissement);
            this.Controls.Add(this.prixTraceur);
            this.Controls.Add(this.prixPhotocopieNb);
            this.Controls.Add(this.prixPhotocopieCouleur);
            this.Controls.Add(this.prixAffranchissement);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.afficheurTraceur);
            this.Controls.Add(this.afficheurPhotocopieNb);
            this.Controls.Add(this.afficheurPhotocopieCouleur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnGenererPdf);
            this.Name = "Form2";
            this.Text = "Nouvelle facture";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox afficheurPhotocopieCouleur;
        private System.Windows.Forms.TextBox afficheurPhotocopieNb;
        private System.Windows.Forms.TextBox afficheurTraceur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label prixAffranchissement;
        private System.Windows.Forms.Label prixPhotocopieCouleur;
        private System.Windows.Forms.Label prixPhotocopieNb;
        private System.Windows.Forms.Label prixTraceur;
        private System.Windows.Forms.Label montantAffranchissement;
        private System.Windows.Forms.Label montantPhotocopieNb;
        private System.Windows.Forms.Label montantTraceur;
        private System.Windows.Forms.Label montantPhotocopiesCouleur;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label totalTtc;
        private System.Windows.Forms.Button btnGenererPdf;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.TextBox afficheurAffranchissement;
    }
}