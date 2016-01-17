namespace e_Bioskop
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvZaposleni = new System.Windows.Forms.ListView();
            this.colKorisnickoIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblImePrezime = new System.Windows.Forms.ToolStripLabel();
            this.lblImeStatic = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPrezimeStatic = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblTelefonStatic = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailStatic = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblDatumZaposlenjaStatic = new System.Windows.Forms.Label();
            this.lblRadnoMjestoStatic = new System.Windows.Forms.Label();
            this.lblDatumZaposlenja = new System.Windows.Forms.Label();
            this.lblRadnoMjesto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzmjeniZaposleni = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnDodajDistributera = new System.Windows.Forms.ToolStripButton();
            this.btnDodajFilm = new System.Windows.Forms.ToolStripButton();
            this.picAktivan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAktivan)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvZaposleni);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(770, 501);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 2;
            // 
            // lvZaposleni
            // 
            this.lvZaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKorisnickoIme,
            this.colIme,
            this.colPrezime});
            this.lvZaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvZaposleni.FullRowSelect = true;
            this.lvZaposleni.GridLines = true;
            this.lvZaposleni.Location = new System.Drawing.Point(0, 0);
            this.lvZaposleni.Name = "lvZaposleni";
            this.lvZaposleni.Size = new System.Drawing.Size(318, 501);
            this.lvZaposleni.TabIndex = 0;
            this.lvZaposleni.UseCompatibleStateImageBehavior = false;
            this.lvZaposleni.View = System.Windows.Forms.View.Details;
            this.lvZaposleni.SelectedIndexChanged += new System.EventHandler(this.lvZaposleni_SelectedIndexChanged);
            // 
            // colKorisnickoIme
            // 
            this.colKorisnickoIme.DisplayIndex = 2;
            this.colKorisnickoIme.Text = "Korisničko ime";
            this.colKorisnickoIme.Width = 87;
            // 
            // colIme
            // 
            this.colIme.DisplayIndex = 0;
            this.colIme.Text = "Ime";
            this.colIme.Width = 106;
            // 
            // colPrezime
            // 
            this.colPrezime.DisplayIndex = 1;
            this.colPrezime.Text = "Prezime";
            this.colPrezime.Width = 86;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDodajZaposlenog,
            this.toolStripButton3,
            this.btnDodajDistributera,
            this.btnDodajFilm,
            this.toolStripSeparator1,
            this.lblImePrezime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(0, 28);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(784, 533);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 507);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Zaposleni";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 507);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Distributeri";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(776, 507);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Filmovi";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(72, 22);
            this.lblImePrezime.Text = "Ime Prezime";
            // 
            // lblImeStatic
            // 
            this.lblImeStatic.AutoSize = true;
            this.lblImeStatic.Location = new System.Drawing.Point(6, 31);
            this.lblImeStatic.Name = "lblImeStatic";
            this.lblImeStatic.Size = new System.Drawing.Size(27, 13);
            this.lblImeStatic.TabIndex = 1;
            this.lblImeStatic.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(121, 63);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(35, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "label2";
            // 
            // lblPrezimeStatic
            // 
            this.lblPrezimeStatic.AutoSize = true;
            this.lblPrezimeStatic.Location = new System.Drawing.Point(6, 63);
            this.lblPrezimeStatic.Name = "lblPrezimeStatic";
            this.lblPrezimeStatic.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeStatic.TabIndex = 3;
            this.lblPrezimeStatic.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(121, 31);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(35, 13);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "label4";
            // 
            // lblTelefonStatic
            // 
            this.lblTelefonStatic.AutoSize = true;
            this.lblTelefonStatic.Location = new System.Drawing.Point(6, 127);
            this.lblTelefonStatic.Name = "lblTelefonStatic";
            this.lblTelefonStatic.Size = new System.Drawing.Size(69, 13);
            this.lblTelefonStatic.TabIndex = 5;
            this.lblTelefonStatic.Text = "Broj telefona:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(121, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "label6";
            // 
            // lblEmailStatic
            // 
            this.lblEmailStatic.AutoSize = true;
            this.lblEmailStatic.Location = new System.Drawing.Point(6, 95);
            this.lblEmailStatic.Name = "lblEmailStatic";
            this.lblEmailStatic.Size = new System.Drawing.Size(38, 13);
            this.lblEmailStatic.TabIndex = 7;
            this.lblEmailStatic.Text = "E-mail:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(121, 127);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(35, 13);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "label8";
            // 
            // lblDatumZaposlenjaStatic
            // 
            this.lblDatumZaposlenjaStatic.AutoSize = true;
            this.lblDatumZaposlenjaStatic.Location = new System.Drawing.Point(6, 159);
            this.lblDatumZaposlenjaStatic.Name = "lblDatumZaposlenjaStatic";
            this.lblDatumZaposlenjaStatic.Size = new System.Drawing.Size(94, 13);
            this.lblDatumZaposlenjaStatic.TabIndex = 9;
            this.lblDatumZaposlenjaStatic.Text = "Datum zaposlenja:";
            // 
            // lblRadnoMjestoStatic
            // 
            this.lblRadnoMjestoStatic.AutoSize = true;
            this.lblRadnoMjestoStatic.Location = new System.Drawing.Point(6, 191);
            this.lblRadnoMjestoStatic.Name = "lblRadnoMjestoStatic";
            this.lblRadnoMjestoStatic.Size = new System.Drawing.Size(75, 13);
            this.lblRadnoMjestoStatic.TabIndex = 10;
            this.lblRadnoMjestoStatic.Text = "Radno mjesto:";
            // 
            // lblDatumZaposlenja
            // 
            this.lblDatumZaposlenja.AutoSize = true;
            this.lblDatumZaposlenja.Location = new System.Drawing.Point(121, 159);
            this.lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            this.lblDatumZaposlenja.Size = new System.Drawing.Size(35, 13);
            this.lblDatumZaposlenja.TabIndex = 11;
            this.lblDatumZaposlenja.Text = "label6";
            // 
            // lblRadnoMjesto
            // 
            this.lblRadnoMjesto.AutoSize = true;
            this.lblRadnoMjesto.Location = new System.Drawing.Point(121, 191);
            this.lblRadnoMjesto.Name = "lblRadnoMjesto";
            this.lblRadnoMjesto.Size = new System.Drawing.Size(35, 13);
            this.lblRadnoMjesto.TabIndex = 12;
            this.lblRadnoMjesto.Text = "label8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picAktivan);
            this.groupBox1.Controls.Add(this.btnIzmjeniZaposleni);
            this.groupBox1.Controls.Add(this.lblImeStatic);
            this.groupBox1.Controls.Add(this.lblRadnoMjesto);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Controls.Add(this.lblDatumZaposlenja);
            this.groupBox1.Controls.Add(this.lblPrezimeStatic);
            this.groupBox1.Controls.Add(this.lblRadnoMjestoStatic);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.lblDatumZaposlenjaStatic);
            this.groupBox1.Controls.Add(this.lblTelefonStatic);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblEmailStatic);
            this.groupBox1.Location = new System.Drawing.Point(34, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 297);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji o zaposlenom";
            // 
            // btnIzmjeniZaposleni
            // 
            this.btnIzmjeniZaposleni.Location = new System.Drawing.Point(9, 242);
            this.btnIzmjeniZaposleni.Name = "btnIzmjeniZaposleni";
            this.btnIzmjeniZaposleni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeniZaposleni.TabIndex = 13;
            this.btnIzmjeniZaposleni.Text = "Izmjeni";
            this.btnIzmjeniZaposleni.UseVisualStyleBackColor = true;
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Image = global::e_Bioskop.Properties.Resources.korisnik_dodaj;
            this.btnDodajZaposlenog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(121, 22);
            this.btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton3.Text = "Odjava";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btnDodajDistributera
            // 
            this.btnDodajDistributera.Image = global::e_Bioskop.Properties.Resources.distributer_dodaj;
            this.btnDodajDistributera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodajDistributera.Name = "btnDodajDistributera";
            this.btnDodajDistributera.Size = new System.Drawing.Size(121, 22);
            this.btnDodajDistributera.Text = "Dodaj distributera";
            this.btnDodajDistributera.Click += new System.EventHandler(this.btnDodajDistributera_Click);
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Image = global::e_Bioskop.Properties.Resources.filmovi_dodaj;
            this.btnDodajFilm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(82, 22);
            this.btnDodajFilm.Text = "Dodaj film";
            // 
            // picAktivan
            // 
            this.picAktivan.Image = global::e_Bioskop.Properties.Resources.crveno;
            this.picAktivan.InitialImage = global::e_Bioskop.Properties.Resources.zeleno;
            this.picAktivan.Location = new System.Drawing.Point(361, 19);
            this.picAktivan.Name = "picAktivan";
            this.picAktivan.Size = new System.Drawing.Size(12, 12);
            this.picAktivan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAktivan.TabIndex = 14;
            this.picAktivan.TabStop = false;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl2);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAktivan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvZaposleni;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDodajZaposlenog;
        private System.Windows.Forms.ColumnHeader colIme;
        private System.Windows.Forms.ColumnHeader colPrezime;
        private System.Windows.Forms.ColumnHeader colKorisnickoIme;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolStripButton btnDodajDistributera;
        private System.Windows.Forms.ToolStripButton btnDodajFilm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblImePrezime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzmjeniZaposleni;
        private System.Windows.Forms.Label lblImeStatic;
        private System.Windows.Forms.Label lblRadnoMjesto;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumZaposlenja;
        private System.Windows.Forms.Label lblPrezimeStatic;
        private System.Windows.Forms.Label lblRadnoMjestoStatic;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblDatumZaposlenjaStatic;
        private System.Windows.Forms.Label lblTelefonStatic;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailStatic;
        private System.Windows.Forms.PictureBox picAktivan;
    }
}