namespace e_Bioskop
{
    partial class ZaposleniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDodajZaposlenog = new System.Windows.Forms.ToolStripButton();
            this.btnOdjava = new System.Windows.Forms.ToolStripButton();
            this.btnDodajDistributera = new System.Windows.Forms.ToolStripButton();
            this.btnDodajFilm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblImePrezime = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProdajaKarte = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnIzborProjekcije = new System.Windows.Forms.Button();
            this.gbProdajaPodaciOProjekciji = new System.Windows.Forms.GroupBox();
            this.lblProdajaSalaProjekcije = new System.Windows.Forms.Label();
            this.lblProdajaVrijemeProjekcije = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProdajaPodaciOFilmu = new System.Windows.Forms.GroupBox();
            this.lblProdajaKarteOpis = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblProdajaKarteZanr = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblProdajaKarteNazivFilma = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbRezervacija = new System.Windows.Forms.TabPage();
            this.tbPonistavanjeKarte = new System.Windows.Forms.TabPage();
            this.tbPonistavanjeRezervacije = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnProdajaKarata = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbProdajaKarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbProdajaPodaciOProjekciji.SuspendLayout();
            this.gbProdajaPodaciOFilmu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDodajZaposlenog,
            this.btnOdjava,
            this.btnDodajDistributera,
            this.btnDodajFilm,
            this.toolStripSeparator1,
            this.lblImePrezime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Image = global::e_Bioskop.Properties.Resources.korisnik_dodaj;
            this.btnDodajZaposlenog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(121, 22);
            this.btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOdjava.Image = ((System.Drawing.Image)(resources.GetObject("btnOdjava.Image")));
            this.btnOdjava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(64, 22);
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click_1);
            // 
            // btnDodajDistributera
            // 
            this.btnDodajDistributera.Image = global::e_Bioskop.Properties.Resources.distributer_dodaj;
            this.btnDodajDistributera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodajDistributera.Name = "btnDodajDistributera";
            this.btnDodajDistributera.Size = new System.Drawing.Size(121, 22);
            this.btnDodajDistributera.Text = "Dodaj distributera";
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Image = global::e_Bioskop.Properties.Resources.filmovi_dodaj;
            this.btnDodajFilm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(82, 22);
            this.btnDodajFilm.Text = "Dodaj film";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbProdajaKarte);
            this.tabControl1.Controls.Add(this.tbRezervacija);
            this.tabControl1.Controls.Add(this.tbPonistavanjeKarte);
            this.tabControl1.Controls.Add(this.tbPonistavanjeRezervacije);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 344);
            this.tabControl1.TabIndex = 5;
            // 
            // tbProdajaKarte
            // 
            this.tbProdajaKarte.Controls.Add(this.splitContainer1);
            this.tbProdajaKarte.Location = new System.Drawing.Point(4, 22);
            this.tbProdajaKarte.Name = "tbProdajaKarte";
            this.tbProdajaKarte.Padding = new System.Windows.Forms.Padding(3);
            this.tbProdajaKarte.Size = new System.Drawing.Size(696, 318);
            this.tbProdajaKarte.TabIndex = 0;
            this.tbProdajaKarte.Text = "Prodaja karte";
            this.tbProdajaKarte.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnIzborProjekcije);
            this.splitContainer1.Panel1.Controls.Add(this.gbProdajaPodaciOProjekciji);
            this.splitContainer1.Panel1.Controls.Add(this.gbProdajaPodaciOFilmu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(690, 312);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 23;
            // 
            // btnIzborProjekcije
            // 
            this.btnIzborProjekcije.Location = new System.Drawing.Point(5, 3);
            this.btnIzborProjekcije.Name = "btnIzborProjekcije";
            this.btnIzborProjekcije.Size = new System.Drawing.Size(194, 23);
            this.btnIzborProjekcije.TabIndex = 0;
            this.btnIzborProjekcije.Text = "Izbor projekcije";
            this.btnIzborProjekcije.UseVisualStyleBackColor = true;
            this.btnIzborProjekcije.Click += new System.EventHandler(this.btnIzborProjekcije_Click);
            // 
            // gbProdajaPodaciOProjekciji
            // 
            this.gbProdajaPodaciOProjekciji.Controls.Add(this.lblProdajaSalaProjekcije);
            this.gbProdajaPodaciOProjekciji.Controls.Add(this.lblProdajaVrijemeProjekcije);
            this.gbProdajaPodaciOProjekciji.Controls.Add(this.label2);
            this.gbProdajaPodaciOProjekciji.Controls.Add(this.label1);
            this.gbProdajaPodaciOProjekciji.Location = new System.Drawing.Point(5, 158);
            this.gbProdajaPodaciOProjekciji.Name = "gbProdajaPodaciOProjekciji";
            this.gbProdajaPodaciOProjekciji.Size = new System.Drawing.Size(194, 81);
            this.gbProdajaPodaciOProjekciji.TabIndex = 22;
            this.gbProdajaPodaciOProjekciji.TabStop = false;
            this.gbProdajaPodaciOProjekciji.Text = "Podaci o projekciji";
            // 
            // lblProdajaSalaProjekcije
            // 
            this.lblProdajaSalaProjekcije.AutoSize = true;
            this.lblProdajaSalaProjekcije.Location = new System.Drawing.Point(53, 53);
            this.lblProdajaSalaProjekcije.Name = "lblProdajaSalaProjekcije";
            this.lblProdajaSalaProjekcije.Size = new System.Drawing.Size(35, 13);
            this.lblProdajaSalaProjekcije.TabIndex = 3;
            this.lblProdajaSalaProjekcije.Text = "label4";
            // 
            // lblProdajaVrijemeProjekcije
            // 
            this.lblProdajaVrijemeProjekcije.AutoSize = true;
            this.lblProdajaVrijemeProjekcije.Location = new System.Drawing.Point(59, 20);
            this.lblProdajaVrijemeProjekcije.Name = "lblProdajaVrijemeProjekcije";
            this.lblProdajaVrijemeProjekcije.Size = new System.Drawing.Size(35, 13);
            this.lblProdajaVrijemeProjekcije.TabIndex = 2;
            this.lblProdajaVrijemeProjekcije.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrijeme:";
            // 
            // gbProdajaPodaciOFilmu
            // 
            this.gbProdajaPodaciOFilmu.Controls.Add(this.lblProdajaKarteOpis);
            this.gbProdajaPodaciOFilmu.Controls.Add(this.label18);
            this.gbProdajaPodaciOFilmu.Controls.Add(this.label17);
            this.gbProdajaPodaciOFilmu.Controls.Add(this.lblProdajaKarteZanr);
            this.gbProdajaPodaciOFilmu.Controls.Add(this.label16);
            this.gbProdajaPodaciOFilmu.Controls.Add(this.lblProdajaKarteNazivFilma);
            this.gbProdajaPodaciOFilmu.Location = new System.Drawing.Point(5, 32);
            this.gbProdajaPodaciOFilmu.Name = "gbProdajaPodaciOFilmu";
            this.gbProdajaPodaciOFilmu.Size = new System.Drawing.Size(194, 102);
            this.gbProdajaPodaciOFilmu.TabIndex = 20;
            this.gbProdajaPodaciOFilmu.TabStop = false;
            this.gbProdajaPodaciOFilmu.Text = "Podaci o filmu";
            // 
            // lblProdajaKarteOpis
            // 
            this.lblProdajaKarteOpis.AutoSize = true;
            this.lblProdajaKarteOpis.Location = new System.Drawing.Point(50, 73);
            this.lblProdajaKarteOpis.Name = "lblProdajaKarteOpis";
            this.lblProdajaKarteOpis.Size = new System.Drawing.Size(35, 13);
            this.lblProdajaKarteOpis.TabIndex = 17;
            this.lblProdajaKarteOpis.Text = "label7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Naziv:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Žanr:";
            // 
            // lblProdajaKarteZanr
            // 
            this.lblProdajaKarteZanr.AutoSize = true;
            this.lblProdajaKarteZanr.Location = new System.Drawing.Point(50, 45);
            this.lblProdajaKarteZanr.Name = "lblProdajaKarteZanr";
            this.lblProdajaKarteZanr.Size = new System.Drawing.Size(35, 13);
            this.lblProdajaKarteZanr.TabIndex = 16;
            this.lblProdajaKarteZanr.Text = "label7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Opis:";
            // 
            // lblProdajaKarteNazivFilma
            // 
            this.lblProdajaKarteNazivFilma.AutoSize = true;
            this.lblProdajaKarteNazivFilma.Location = new System.Drawing.Point(50, 16);
            this.lblProdajaKarteNazivFilma.Name = "lblProdajaKarteNazivFilma";
            this.lblProdajaKarteNazivFilma.Size = new System.Drawing.Size(35, 13);
            this.lblProdajaKarteNazivFilma.TabIndex = 15;
            this.lblProdajaKarteNazivFilma.Text = "label7";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 253);
            this.flowLayoutPanel1.TabIndex = 21;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // tbRezervacija
            // 
            this.tbRezervacija.Location = new System.Drawing.Point(4, 22);
            this.tbRezervacija.Name = "tbRezervacija";
            this.tbRezervacija.Padding = new System.Windows.Forms.Padding(3);
            this.tbRezervacija.Size = new System.Drawing.Size(696, 318);
            this.tbRezervacija.TabIndex = 1;
            this.tbRezervacija.Text = "Rezervacija karte";
            this.tbRezervacija.UseVisualStyleBackColor = true;
            // 
            // tbPonistavanjeKarte
            // 
            this.tbPonistavanjeKarte.Location = new System.Drawing.Point(4, 22);
            this.tbPonistavanjeKarte.Name = "tbPonistavanjeKarte";
            this.tbPonistavanjeKarte.Size = new System.Drawing.Size(696, 318);
            this.tbPonistavanjeKarte.TabIndex = 2;
            this.tbPonistavanjeKarte.Text = "Ponistavanje karte";
            this.tbPonistavanjeKarte.UseVisualStyleBackColor = true;
            // 
            // tbPonistavanjeRezervacije
            // 
            this.tbPonistavanjeRezervacije.Location = new System.Drawing.Point(4, 22);
            this.tbPonistavanjeRezervacije.Name = "tbPonistavanjeRezervacije";
            this.tbPonistavanjeRezervacije.Size = new System.Drawing.Size(696, 318);
            this.tbPonistavanjeRezervacije.TabIndex = 3;
            this.tbPonistavanjeRezervacije.Text = "Ponistavanje rezervacije";
            this.tbPonistavanjeRezervacije.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnProdajaKarata);
            this.splitContainer2.Size = new System.Drawing.Size(456, 312);
            this.splitContainer2.SplitterDistance = 253;
            this.splitContainer2.TabIndex = 22;
            // 
            // btnProdajaKarata
            // 
            this.btnProdajaKarata.Location = new System.Drawing.Point(307, 23);
            this.btnProdajaKarata.Name = "btnProdajaKarata";
            this.btnProdajaKarata.Size = new System.Drawing.Size(113, 23);
            this.btnProdajaKarata.TabIndex = 0;
            this.btnProdajaKarata.Text = "Izvrsi prodaju";
            this.btnProdajaKarata.UseVisualStyleBackColor = true;
            // 
            // ZaposleniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 369);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ZaposleniForm";
            this.Text = "ZaposleniForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbProdajaKarte.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbProdajaPodaciOProjekciji.ResumeLayout(false);
            this.gbProdajaPodaciOProjekciji.PerformLayout();
            this.gbProdajaPodaciOFilmu.ResumeLayout(false);
            this.gbProdajaPodaciOFilmu.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDodajZaposlenog;
        private System.Windows.Forms.ToolStripButton btnOdjava;
        private System.Windows.Forms.ToolStripButton btnDodajDistributera;
        private System.Windows.Forms.ToolStripButton btnDodajFilm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblImePrezime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbProdajaKarte;
        private System.Windows.Forms.TabPage tbRezervacija;
        private System.Windows.Forms.TabPage tbPonistavanjeKarte;
        private System.Windows.Forms.TabPage tbPonistavanjeRezervacije;
        private System.Windows.Forms.Button btnIzborProjekcije;
        private System.Windows.Forms.GroupBox gbProdajaPodaciOFilmu;
        private System.Windows.Forms.Label lblProdajaKarteOpis;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblProdajaKarteZanr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblProdajaKarteNazivFilma;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbProdajaPodaciOProjekciji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProdajaSalaProjekcije;
        private System.Windows.Forms.Label lblProdajaVrijemeProjekcije;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnProdajaKarata;
    }
}