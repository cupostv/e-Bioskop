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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picAktivan = new System.Windows.Forms.PictureBox();
            this.btnIzmjeniZaposleni = new System.Windows.Forms.Button();
            this.lblImeStatic = new System.Windows.Forms.Label();
            this.lblRadnoMjesto = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumZaposlenja = new System.Windows.Forms.Label();
            this.lblPrezimeStatic = new System.Windows.Forms.Label();
            this.lblRadnoMjestoStatic = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblDatumZaposlenjaStatic = new System.Windows.Forms.Label();
            this.lblTelefonStatic = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailStatic = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDodajZaposlenog = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnDodajDistributera = new System.Windows.Forms.ToolStripButton();
            this.btnDodajFilm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblImePrezime = new System.Windows.Forms.ToolStripLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvDistributeri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilmoviStatic = new System.Windows.Forms.Label();
            this.gboxDetaljiDistributer = new System.Windows.Forms.GroupBox();
            this.lblBrojTelefonaDist = new System.Windows.Forms.Label();
            this.lblEmailDist = new System.Windows.Forms.Label();
            this.lblAdresaDist = new System.Windows.Forms.Label();
            this.lblNazivDist = new System.Windows.Forms.Label();
            this.lblBrojTelefonaDistStatic = new System.Windows.Forms.Label();
            this.lblEmailDistStatic = new System.Windows.Forms.Label();
            this.lbAdresaDistStatic = new System.Windows.Forms.Label();
            this.lblNazivDistStatic = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lvFilmovi = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxPretragaFilma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAktivan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.gboxDetaljiDistributer.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.Size = new System.Drawing.Size(720, 402);
            this.splitContainer1.SplitterDistance = 285;
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
            this.lvZaposleni.Size = new System.Drawing.Size(285, 402);
            this.lvZaposleni.TabIndex = 0;
            this.lvZaposleni.UseCompatibleStateImageBehavior = false;
            this.lvZaposleni.View = System.Windows.Forms.View.Details;
            this.lvZaposleni.SelectedIndexChanged += new System.EventHandler(this.lvZaposleni_SelectedIndexChanged);
            // 
            // colKorisnickoIme
            // 
            this.colKorisnickoIme.DisplayIndex = 2;
            this.colKorisnickoIme.Text = "Korisničko ime";
            this.colKorisnickoIme.Width = 90;
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
            this.groupBox1.Location = new System.Drawing.Point(33, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 281);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji o zaposlenom";
            // 
            // picAktivan
            // 
            this.picAktivan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picAktivan.Image = global::e_Bioskop.Properties.Resources.crveno;
            this.picAktivan.InitialImage = global::e_Bioskop.Properties.Resources.zeleno;
            this.picAktivan.Location = new System.Drawing.Point(347, 10);
            this.picAktivan.Name = "picAktivan";
            this.picAktivan.Size = new System.Drawing.Size(12, 12);
            this.picAktivan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAktivan.TabIndex = 14;
            this.picAktivan.TabStop = false;
            // 
            // btnIzmjeniZaposleni
            // 
            this.btnIzmjeniZaposleni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzmjeniZaposleni.Location = new System.Drawing.Point(8, 252);
            this.btnIzmjeniZaposleni.Name = "btnIzmjeniZaposleni";
            this.btnIzmjeniZaposleni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeniZaposleni.TabIndex = 13;
            this.btnIzmjeniZaposleni.Text = "Izmjeni";
            this.btnIzmjeniZaposleni.UseVisualStyleBackColor = true;
            this.btnIzmjeniZaposleni.Click += new System.EventHandler(this.btnIzmjeniZaposleni_Click);
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
            // lblRadnoMjesto
            // 
            this.lblRadnoMjesto.AutoSize = true;
            this.lblRadnoMjesto.Location = new System.Drawing.Point(121, 191);
            this.lblRadnoMjesto.Name = "lblRadnoMjesto";
            this.lblRadnoMjesto.Size = new System.Drawing.Size(35, 13);
            this.lblRadnoMjesto.TabIndex = 12;
            this.lblRadnoMjesto.Text = "label8";
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
            // lblDatumZaposlenja
            // 
            this.lblDatumZaposlenja.AutoSize = true;
            this.lblDatumZaposlenja.Location = new System.Drawing.Point(121, 159);
            this.lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            this.lblDatumZaposlenja.Size = new System.Drawing.Size(35, 13);
            this.lblDatumZaposlenja.TabIndex = 11;
            this.lblDatumZaposlenja.Text = "label6";
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
            // lblRadnoMjestoStatic
            // 
            this.lblRadnoMjestoStatic.AutoSize = true;
            this.lblRadnoMjestoStatic.Location = new System.Drawing.Point(6, 191);
            this.lblRadnoMjestoStatic.Name = "lblRadnoMjestoStatic";
            this.lblRadnoMjestoStatic.Size = new System.Drawing.Size(75, 13);
            this.lblRadnoMjestoStatic.TabIndex = 10;
            this.lblRadnoMjestoStatic.Text = "Radno mjesto:";
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
            // lblDatumZaposlenjaStatic
            // 
            this.lblDatumZaposlenjaStatic.AutoSize = true;
            this.lblDatumZaposlenjaStatic.Location = new System.Drawing.Point(6, 159);
            this.lblDatumZaposlenjaStatic.Name = "lblDatumZaposlenjaStatic";
            this.lblDatumZaposlenjaStatic.Size = new System.Drawing.Size(94, 13);
            this.lblDatumZaposlenjaStatic.TabIndex = 9;
            this.lblDatumZaposlenjaStatic.Text = "Datum zaposlenja:";
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
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(121, 127);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(35, 13);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "label8";
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
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            this.btnDodajFilm.Click += new System.EventHandler(this.btnDodajFilm_Click);
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
            this.tabControl2.Size = new System.Drawing.Size(734, 434);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(726, 408);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Zaposleni";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(726, 408);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Distributeri";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvDistributeri);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvFilmovi);
            this.splitContainer2.Panel2.Controls.Add(this.lblFilmoviStatic);
            this.splitContainer2.Panel2.Controls.Add(this.gboxDetaljiDistributer);
            this.splitContainer2.Size = new System.Drawing.Size(720, 402);
            this.splitContainer2.SplitterDistance = 253;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvDistributeri
            // 
            this.lvDistributeri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDistributeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDistributeri.FullRowSelect = true;
            this.lvDistributeri.GridLines = true;
            this.lvDistributeri.LabelWrap = false;
            this.lvDistributeri.Location = new System.Drawing.Point(0, 0);
            this.lvDistributeri.MultiSelect = false;
            this.lvDistributeri.Name = "lvDistributeri";
            this.lvDistributeri.Size = new System.Drawing.Size(253, 402);
            this.lvDistributeri.TabIndex = 1;
            this.lvDistributeri.UseCompatibleStateImageBehavior = false;
            this.lvDistributeri.View = System.Windows.Forms.View.Details;
            this.lvDistributeri.SelectedIndexChanged += new System.EventHandler(this.lvDistributeri_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 244;
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.AllowUserToAddRows = false;
            this.dgvFilmovi.AllowUserToDeleteRows = false;
            this.dgvFilmovi.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.zanr,
            this.trajanje,
            this.Status});
            this.dgvFilmovi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFilmovi.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFilmovi.Location = new System.Drawing.Point(32, 182);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            this.dgvFilmovi.RowHeadersVisible = false;
            this.dgvFilmovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.Size = new System.Drawing.Size(403, 215);
            this.dgvFilmovi.TabIndex = 3;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // zanr
            // 
            this.zanr.HeaderText = "Žanr";
            this.zanr.Name = "zanr";
            this.zanr.ReadOnly = true;
            // 
            // trajanje
            // 
            this.trajanje.HeaderText = "Trajanje";
            this.trajanje.Name = "trajanje";
            this.trajanje.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // lblFilmoviStatic
            // 
            this.lblFilmoviStatic.AutoSize = true;
            this.lblFilmoviStatic.Location = new System.Drawing.Point(29, 166);
            this.lblFilmoviStatic.Name = "lblFilmoviStatic";
            this.lblFilmoviStatic.Size = new System.Drawing.Size(39, 13);
            this.lblFilmoviStatic.TabIndex = 2;
            this.lblFilmoviStatic.Text = "Filmovi";
            // 
            // gboxDetaljiDistributer
            // 
            this.gboxDetaljiDistributer.Controls.Add(this.lblBrojTelefonaDist);
            this.gboxDetaljiDistributer.Controls.Add(this.lblEmailDist);
            this.gboxDetaljiDistributer.Controls.Add(this.lblAdresaDist);
            this.gboxDetaljiDistributer.Controls.Add(this.lblNazivDist);
            this.gboxDetaljiDistributer.Controls.Add(this.lblBrojTelefonaDistStatic);
            this.gboxDetaljiDistributer.Controls.Add(this.lblEmailDistStatic);
            this.gboxDetaljiDistributer.Controls.Add(this.lbAdresaDistStatic);
            this.gboxDetaljiDistributer.Controls.Add(this.lblNazivDistStatic);
            this.gboxDetaljiDistributer.Location = new System.Drawing.Point(32, 3);
            this.gboxDetaljiDistributer.Name = "gboxDetaljiDistributer";
            this.gboxDetaljiDistributer.Size = new System.Drawing.Size(403, 160);
            this.gboxDetaljiDistributer.TabIndex = 0;
            this.gboxDetaljiDistributer.TabStop = false;
            this.gboxDetaljiDistributer.Text = "Detalji o distributeru";
            // 
            // lblBrojTelefonaDist
            // 
            this.lblBrojTelefonaDist.AutoSize = true;
            this.lblBrojTelefonaDist.Location = new System.Drawing.Point(121, 126);
            this.lblBrojTelefonaDist.Name = "lblBrojTelefonaDist";
            this.lblBrojTelefonaDist.Size = new System.Drawing.Size(35, 13);
            this.lblBrojTelefonaDist.TabIndex = 7;
            this.lblBrojTelefonaDist.Text = "label4";
            // 
            // lblEmailDist
            // 
            this.lblEmailDist.AutoSize = true;
            this.lblEmailDist.Location = new System.Drawing.Point(121, 95);
            this.lblEmailDist.Name = "lblEmailDist";
            this.lblEmailDist.Size = new System.Drawing.Size(35, 13);
            this.lblEmailDist.TabIndex = 6;
            this.lblEmailDist.Text = "label3";
            // 
            // lblAdresaDist
            // 
            this.lblAdresaDist.AutoSize = true;
            this.lblAdresaDist.Location = new System.Drawing.Point(121, 63);
            this.lblAdresaDist.Name = "lblAdresaDist";
            this.lblAdresaDist.Size = new System.Drawing.Size(35, 13);
            this.lblAdresaDist.TabIndex = 5;
            this.lblAdresaDist.Text = "label2";
            // 
            // lblNazivDist
            // 
            this.lblNazivDist.AutoSize = true;
            this.lblNazivDist.Location = new System.Drawing.Point(121, 31);
            this.lblNazivDist.Name = "lblNazivDist";
            this.lblNazivDist.Size = new System.Drawing.Size(35, 13);
            this.lblNazivDist.TabIndex = 4;
            this.lblNazivDist.Text = "label1";
            // 
            // lblBrojTelefonaDistStatic
            // 
            this.lblBrojTelefonaDistStatic.AutoSize = true;
            this.lblBrojTelefonaDistStatic.Location = new System.Drawing.Point(6, 126);
            this.lblBrojTelefonaDistStatic.Name = "lblBrojTelefonaDistStatic";
            this.lblBrojTelefonaDistStatic.Size = new System.Drawing.Size(69, 13);
            this.lblBrojTelefonaDistStatic.TabIndex = 3;
            this.lblBrojTelefonaDistStatic.Text = "Broj telefona:";
            // 
            // lblEmailDistStatic
            // 
            this.lblEmailDistStatic.AutoSize = true;
            this.lblEmailDistStatic.Location = new System.Drawing.Point(6, 95);
            this.lblEmailDistStatic.Name = "lblEmailDistStatic";
            this.lblEmailDistStatic.Size = new System.Drawing.Size(38, 13);
            this.lblEmailDistStatic.TabIndex = 2;
            this.lblEmailDistStatic.Text = "E-mail:";
            // 
            // lbAdresaDistStatic
            // 
            this.lbAdresaDistStatic.AutoSize = true;
            this.lbAdresaDistStatic.Location = new System.Drawing.Point(6, 63);
            this.lbAdresaDistStatic.Name = "lbAdresaDistStatic";
            this.lbAdresaDistStatic.Size = new System.Drawing.Size(43, 13);
            this.lbAdresaDistStatic.TabIndex = 1;
            this.lbAdresaDistStatic.Text = "Adresa:";
            // 
            // lblNazivDistStatic
            // 
            this.lblNazivDistStatic.AutoSize = true;
            this.lblNazivDistStatic.Location = new System.Drawing.Point(6, 31);
            this.lblNazivDistStatic.Name = "lblNazivDistStatic";
            this.lblNazivDistStatic.Size = new System.Drawing.Size(37, 13);
            this.lblNazivDistStatic.TabIndex = 0;
            this.lblNazivDistStatic.Text = "Naziv:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(726, 408);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Filmovi";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lvFilmovi);
            this.splitContainer3.Panel1.Controls.Add(this.tbxPretragaFilma);
            this.splitContainer3.Size = new System.Drawing.Size(726, 408);
            this.splitContainer3.SplitterDistance = 250;
            this.splitContainer3.TabIndex = 0;
            // 
            // lvFilmovi
            // 
            this.lvFilmovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvFilmovi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvFilmovi.FullRowSelect = true;
            this.lvFilmovi.GridLines = true;
            this.lvFilmovi.LabelWrap = false;
            this.lvFilmovi.Location = new System.Drawing.Point(0, 29);
            this.lvFilmovi.MultiSelect = false;
            this.lvFilmovi.Name = "lvFilmovi";
            this.lvFilmovi.Size = new System.Drawing.Size(250, 379);
            this.lvFilmovi.TabIndex = 2;
            this.lvFilmovi.UseCompatibleStateImageBehavior = false;
            this.lvFilmovi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 244;
            // 
            // tbxPretragaFilma
            // 
            this.tbxPretragaFilma.Location = new System.Drawing.Point(3, 3);
            this.tbxPretragaFilma.Name = "tbxPretragaFilma";
            this.tbxPretragaFilma.Size = new System.Drawing.Size(244, 20);
            this.tbxPretragaFilma.TabIndex = 0;
            this.tbxPretragaFilma.TextChanged += new System.EventHandler(this.tbxPretragaFilma_TextChanged);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl2);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAktivan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.gboxDetaljiDistributer.ResumeLayout(false);
            this.gboxDetaljiDistributer.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvDistributeri;
        private System.Windows.Forms.GroupBox gboxDetaljiDistributer;
        private System.Windows.Forms.Label lblBrojTelefonaDist;
        private System.Windows.Forms.Label lblEmailDist;
        private System.Windows.Forms.Label lblAdresaDist;
        private System.Windows.Forms.Label lblNazivDist;
        private System.Windows.Forms.Label lblBrojTelefonaDistStatic;
        private System.Windows.Forms.Label lblEmailDistStatic;
        private System.Windows.Forms.Label lbAdresaDistStatic;
        private System.Windows.Forms.Label lblNazivDistStatic;
        private System.Windows.Forms.Label lblFilmoviStatic;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListView lvFilmovi;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbxPretragaFilma;
    }
}