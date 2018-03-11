namespace m2l2
{
    partial class form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFacture = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewListeFacture = new System.Windows.Forms.DataGridView();
            this.dataGridViewPrestation = new System.Windows.Forms.DataGridView();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabAcceuil = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bienvenue = new System.Windows.Forms.Label();
            this.tabLigue = new System.Windows.Forms.TabPage();
            this.btnAjouterLigue = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPrestation = new System.Windows.Forms.TabPage();
            this.btnAJouterPrestation = new System.Windows.Forms.Button();
            this.tabFacture = new System.Windows.Forms.TabPage();
            this.labelLogin = new System.Windows.Forms.Label();
            this.afficheurLogin = new System.Windows.Forms.TextBox();
            this.labelMdp = new System.Windows.Forms.Label();
            this.afficheurMdp = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.LabelConnectez = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestation)).BeginInit();
            this.tab1.SuspendLayout();
            this.tabAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabLigue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPrestation.SuspendLayout();
            this.tabFacture.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFacture
            // 
            this.btnFacture.Location = new System.Drawing.Point(312, 356);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(75, 23);
            this.btnFacture.TabIndex = 4;
            this.btnFacture.Text = "Créer";
            this.btnFacture.UseVisualStyleBackColor = true;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Copyright©";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewListeFacture
            // 
            this.dataGridViewListeFacture.AllowUserToAddRows = false;
            this.dataGridViewListeFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeFacture.Location = new System.Drawing.Point(183, 38);
            this.dataGridViewListeFacture.Name = "dataGridViewListeFacture";
            this.dataGridViewListeFacture.Size = new System.Drawing.Size(543, 300);
            this.dataGridViewListeFacture.TabIndex = 23;
            this.dataGridViewListeFacture.Visible = false;
            this.dataGridViewListeFacture.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewListeFacture_RowHeaderMouseClick);
            // 
            // dataGridViewPrestation
            // 
            this.dataGridViewPrestation.AllowUserToAddRows = false;
            this.dataGridViewPrestation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestation.Location = new System.Drawing.Point(270, 33);
            this.dataGridViewPrestation.Name = "dataGridViewPrestation";
            this.dataGridViewPrestation.Size = new System.Drawing.Size(368, 283);
            this.dataGridViewPrestation.TabIndex = 24;
            this.dataGridViewPrestation.Visible = false;
            this.dataGridViewPrestation.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestation_RowValidated);
            this.dataGridViewPrestation.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPrestation_UserDeletingRow);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(521, 356);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(75, 23);
            this.btnImprimer.TabIndex = 25;
            this.btnImprimer.Text = "Générer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Visible = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabAcceuil);
            this.tab1.Controls.Add(this.tabLigue);
            this.tab1.Controls.Add(this.tabPrestation);
            this.tab1.Controls.Add(this.tabFacture);
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(916, 414);
            this.tab1.TabIndex = 26;
            this.tab1.Visible = false;
            this.tab1.SelectedIndexChanged += new System.EventHandler(this.tab1_SelectedIndexChanged);
            // 
            // tabAcceuil
            // 
            this.tabAcceuil.Controls.Add(this.pictureBox1);
            this.tabAcceuil.Controls.Add(this.bienvenue);
            this.tabAcceuil.Controls.Add(this.label2);
            this.tabAcceuil.Location = new System.Drawing.Point(4, 22);
            this.tabAcceuil.Name = "tabAcceuil";
            this.tabAcceuil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcceuil.Size = new System.Drawing.Size(908, 388);
            this.tabAcceuil.TabIndex = 0;
            this.tabAcceuil.Text = "Acceuil";
            this.tabAcceuil.UseVisualStyleBackColor = true;
            this.tabAcceuil.Click += new System.EventHandler(this.tabAcceuil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::m2l2.Properties.Resources.mdl;
            this.pictureBox1.Location = new System.Drawing.Point(321, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bienvenue
            // 
            this.bienvenue.AutoSize = true;
            this.bienvenue.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenue.Location = new System.Drawing.Point(312, 32);
            this.bienvenue.Name = "bienvenue";
            this.bienvenue.Size = new System.Drawing.Size(284, 12);
            this.bienvenue.TabIndex = 7;
            this.bienvenue.Text = "BIENVENUE SUR L\'APPLICATION DE GESTION M2L";
            // 
            // tabLigue
            // 
            this.tabLigue.Controls.Add(this.btnAjouterLigue);
            this.tabLigue.Controls.Add(this.dataGridView1);
            this.tabLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLigue.Location = new System.Drawing.Point(4, 22);
            this.tabLigue.Name = "tabLigue";
            this.tabLigue.Padding = new System.Windows.Forms.Padding(3);
            this.tabLigue.Size = new System.Drawing.Size(908, 388);
            this.tabLigue.TabIndex = 1;
            this.tabLigue.Text = "Ligues";
            this.tabLigue.UseVisualStyleBackColor = true;
            this.tabLigue.Click += new System.EventHandler(this.tabLigue_Click);
            // 
            // btnAjouterLigue
            // 
            this.btnAjouterLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterLigue.Location = new System.Drawing.Point(402, 349);
            this.btnAjouterLigue.Name = "btnAjouterLigue";
            this.btnAjouterLigue.Size = new System.Drawing.Size(104, 22);
            this.btnAjouterLigue.TabIndex = 17;
            this.btnAjouterLigue.Text = "Ajouter une ligue";
            this.btnAjouterLigue.UseVisualStyleBackColor = true;
            this.btnAjouterLigue.Click += new System.EventHandler(this.btnAjouterLigue_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.Location = new System.Drawing.Point(33, 16);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(843, 318);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // tabPrestation
            // 
            this.tabPrestation.Controls.Add(this.btnAJouterPrestation);
            this.tabPrestation.Controls.Add(this.dataGridViewPrestation);
            this.tabPrestation.Location = new System.Drawing.Point(4, 22);
            this.tabPrestation.Name = "tabPrestation";
            this.tabPrestation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestation.Size = new System.Drawing.Size(908, 388);
            this.tabPrestation.TabIndex = 2;
            this.tabPrestation.Text = "Prestations";
            this.tabPrestation.UseVisualStyleBackColor = true;
            this.tabPrestation.Click += new System.EventHandler(this.tabPrestation_Click);
            // 
            // btnAJouterPrestation
            // 
            this.btnAJouterPrestation.Location = new System.Drawing.Point(405, 344);
            this.btnAJouterPrestation.Name = "btnAJouterPrestation";
            this.btnAJouterPrestation.Size = new System.Drawing.Size(99, 23);
            this.btnAJouterPrestation.TabIndex = 25;
            this.btnAJouterPrestation.Text = "Ajouter prestation";
            this.btnAJouterPrestation.UseVisualStyleBackColor = true;
            this.btnAJouterPrestation.Click += new System.EventHandler(this.btnAJouterPrestation_Click);
            // 
            // tabFacture
            // 
            this.tabFacture.Controls.Add(this.dataGridViewListeFacture);
            this.tabFacture.Controls.Add(this.btnImprimer);
            this.tabFacture.Controls.Add(this.btnFacture);
            this.tabFacture.Location = new System.Drawing.Point(4, 22);
            this.tabFacture.Name = "tabFacture";
            this.tabFacture.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacture.Size = new System.Drawing.Size(908, 388);
            this.tabFacture.TabIndex = 3;
            this.tabFacture.Text = "Factures";
            this.tabFacture.UseVisualStyleBackColor = true;
            this.tabFacture.Click += new System.EventHandler(this.tabFacture_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(143, 99);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(39, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login :";
            // 
            // afficheurLogin
            // 
            this.afficheurLogin.Location = new System.Drawing.Point(127, 139);
            this.afficheurLogin.MaxLength = 10;
            this.afficheurLogin.Name = "afficheurLogin";
            this.afficheurLogin.Size = new System.Drawing.Size(70, 20);
            this.afficheurLogin.TabIndex = 2;
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(124, 186);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(77, 13);
            this.labelMdp.TabIndex = 1;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // afficheurMdp
            // 
            this.afficheurMdp.Location = new System.Drawing.Point(127, 226);
            this.afficheurMdp.MaxLength = 10;
            this.afficheurMdp.Name = "afficheurMdp";
            this.afficheurMdp.Size = new System.Drawing.Size(70, 20);
            this.afficheurMdp.TabIndex = 3;
            this.afficheurMdp.UseSystemPasswordChar = true;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(139, 273);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(47, 23);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "Valider";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // LabelConnectez
            // 
            this.LabelConnectez.AutoSize = true;
            this.LabelConnectez.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConnectez.Location = new System.Drawing.Point(84, 17);
            this.LabelConnectez.Name = "LabelConnectez";
            this.LabelConnectez.Size = new System.Drawing.Size(157, 19);
            this.LabelConnectez.TabIndex = 27;
            this.LabelConnectez.Text = "CONNECTEZ VOUS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelConnectez);
            this.panel1.Controls.Add(this.btnConnection);
            this.panel1.Controls.Add(this.afficheurMdp);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.labelMdp);
            this.panel1.Controls.Add(this.afficheurLogin);
            this.panel1.Location = new System.Drawing.Point(294, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 321);
            this.panel1.TabIndex = 28;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 412);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.panel1);
            this.Name = "form";
            this.Text = "APPLICATION FACTURATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestation)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tabAcceuil.ResumeLayout(false);
            this.tabAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabLigue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPrestation.ResumeLayout(false);
            this.tabFacture.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewListeFacture;
        private System.Windows.Forms.DataGridView dataGridViewPrestation;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabLigue;
        private System.Windows.Forms.TabPage tabPrestation;
        private System.Windows.Forms.TabPage tabFacture;
        private System.Windows.Forms.TabPage tabAcceuil;
        private System.Windows.Forms.Label bienvenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAjouterLigue;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAJouterPrestation;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox afficheurLogin;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox afficheurMdp;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label LabelConnectez;
        private System.Windows.Forms.Panel panel1;

    }
}

