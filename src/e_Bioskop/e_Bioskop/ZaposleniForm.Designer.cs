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
            this.btnIzborProjekcije = new System.Windows.Forms.Button();
            this.tbRezervacija = new System.Windows.Forms.TabPage();
            this.tbPonistavanjeKarte = new System.Windows.Forms.TabPage();
            this.tbPonistavanjeRezervacije = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblProdajaKarteOpis = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblProdajaKarteZanr = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblProdajaKarteNazivFilma = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbProdajaKarte.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tbProdajaKarte.Controls.Add(this.groupBox1);
            this.tbProdajaKarte.Controls.Add(this.flowLayoutPanel1);
            this.tbProdajaKarte.Controls.Add(this.groupBox3);
            this.tbProdajaKarte.Controls.Add(this.btnIzborProjekcije);
            this.tbProdajaKarte.Location = new System.Drawing.Point(4, 22);
            this.tbProdajaKarte.Name = "tbProdajaKarte";
            this.tbProdajaKarte.Padding = new System.Windows.Forms.Padding(3);
            this.tbProdajaKarte.Size = new System.Drawing.Size(696, 318);
            this.tbProdajaKarte.TabIndex = 0;
            this.tbProdajaKarte.Text = "Prodaja karte";
            this.tbProdajaKarte.UseVisualStyleBackColor = true;
            // 
            // btnIzborProjekcije
            // 
            this.btnIzborProjekcije.Location = new System.Drawing.Point(28, 16);
            this.btnIzborProjekcije.Name = "btnIzborProjekcije";
            this.btnIzborProjekcije.Size = new System.Drawing.Size(167, 23);
            this.btnIzborProjekcije.TabIndex = 0;
            this.btnIzborProjekcije.Text = "Izbor projekcije";
            this.btnIzborProjekcije.UseVisualStyleBackColor = true;
            this.btnIzborProjekcije.Click += new System.EventHandler(this.btnIzborProjekcije_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblProdajaKarteOpis);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblProdajaKarteZanr);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblProdajaKarteNazivFilma);
            this.groupBox3.Location = new System.Drawing.Point(28, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o filmu";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(364, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(28, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblProdajaKarteOpis;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblProdajaKarteZanr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblProdajaKarteNazivFilma;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}