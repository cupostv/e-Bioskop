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
            this.tbRezervacija = new System.Windows.Forms.TabPage();
            this.tbPonistavanjeKarte = new System.Windows.Forms.TabPage();
            this.tbPonistavanjeRezervacije = new System.Windows.Forms.TabPage();
            this.btnIzborProjekcije = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbProdajaKarte.SuspendLayout();
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
            this.tbProdajaKarte.Controls.Add(this.btnIzborProjekcije);
            this.tbProdajaKarte.Location = new System.Drawing.Point(4, 22);
            this.tbProdajaKarte.Name = "tbProdajaKarte";
            this.tbProdajaKarte.Padding = new System.Windows.Forms.Padding(3);
            this.tbProdajaKarte.Size = new System.Drawing.Size(696, 318);
            this.tbProdajaKarte.TabIndex = 0;
            this.tbProdajaKarte.Text = "Prodaja karte";
            this.tbProdajaKarte.UseVisualStyleBackColor = true;
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
            // btnIzborProjekcije
            // 
            this.btnIzborProjekcije.Location = new System.Drawing.Point(41, 52);
            this.btnIzborProjekcije.Name = "btnIzborProjekcije";
            this.btnIzborProjekcije.Size = new System.Drawing.Size(167, 23);
            this.btnIzborProjekcije.TabIndex = 0;
            this.btnIzborProjekcije.Text = "Izbor projekcije";
            this.btnIzborProjekcije.UseVisualStyleBackColor = true;
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
    }
}