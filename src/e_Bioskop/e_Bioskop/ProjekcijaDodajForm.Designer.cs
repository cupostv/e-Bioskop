namespace e_Bioskop
{
    partial class ProjekcijaDodajForm
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
            this.btnIzborFilma = new System.Windows.Forms.Button();
            this.lblTrajanjeFilma = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOpisFilma = new System.Windows.Forms.Label();
            this.lblZanrFilma = new System.Windows.Forms.Label();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIzabraniFilm = new System.Windows.Forms.GroupBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.gbIzabraniFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzborFilma
            // 
            this.btnIzborFilma.Location = new System.Drawing.Point(29, 30);
            this.btnIzborFilma.Name = "btnIzborFilma";
            this.btnIzborFilma.Size = new System.Drawing.Size(200, 23);
            this.btnIzborFilma.TabIndex = 0;
            this.btnIzborFilma.Text = "Izaberite film";
            this.btnIzborFilma.UseVisualStyleBackColor = true;
            this.btnIzborFilma.Click += new System.EventHandler(this.btnIzborFilma_Click);
            // 
            // lblTrajanjeFilma
            // 
            this.lblTrajanjeFilma.AutoSize = true;
            this.lblTrajanjeFilma.Location = new System.Drawing.Point(111, 111);
            this.lblTrajanjeFilma.Name = "lblTrajanjeFilma";
            this.lblTrajanjeFilma.Size = new System.Drawing.Size(35, 13);
            this.lblTrajanjeFilma.TabIndex = 20;
            this.lblTrajanjeFilma.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Trajanje";
            // 
            // lblOpisFilma
            // 
            this.lblOpisFilma.AutoSize = true;
            this.lblOpisFilma.Location = new System.Drawing.Point(111, 82);
            this.lblOpisFilma.Name = "lblOpisFilma";
            this.lblOpisFilma.Size = new System.Drawing.Size(35, 13);
            this.lblOpisFilma.TabIndex = 18;
            this.lblOpisFilma.Text = "label7";
            // 
            // lblZanrFilma
            // 
            this.lblZanrFilma.AutoSize = true;
            this.lblZanrFilma.Location = new System.Drawing.Point(111, 54);
            this.lblZanrFilma.Name = "lblZanrFilma";
            this.lblZanrFilma.Size = new System.Drawing.Size(35, 13);
            this.lblZanrFilma.TabIndex = 17;
            this.lblZanrFilma.Text = "label7";
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Location = new System.Drawing.Point(111, 25);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(35, 13);
            this.lblNazivFilma.TabIndex = 16;
            this.lblNazivFilma.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Žanr:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv:";
            // 
            // gbIzabraniFilm
            // 
            this.gbIzabraniFilm.Controls.Add(this.label1);
            this.gbIzabraniFilm.Controls.Add(this.lblTrajanjeFilma);
            this.gbIzabraniFilm.Controls.Add(this.label2);
            this.gbIzabraniFilm.Controls.Add(this.label7);
            this.gbIzabraniFilm.Controls.Add(this.label3);
            this.gbIzabraniFilm.Controls.Add(this.lblOpisFilma);
            this.gbIzabraniFilm.Controls.Add(this.lblNazivFilma);
            this.gbIzabraniFilm.Controls.Add(this.lblZanrFilma);
            this.gbIzabraniFilm.Location = new System.Drawing.Point(29, 59);
            this.gbIzabraniFilm.Name = "gbIzabraniFilm";
            this.gbIzabraniFilm.Size = new System.Drawing.Size(200, 143);
            this.gbIzabraniFilm.TabIndex = 21;
            this.gbIzabraniFilm.TabStop = false;
            this.gbIzabraniFilm.Text = "Izabrani film";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(29, 228);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 22;
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(29, 265);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dtpVrijeme.TabIndex = 23;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(154, 361);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 24;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(29, 303);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(200, 21);
            this.cbSala.TabIndex = 25;
            // 
            // ProjekcijaDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 396);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.gbIzabraniFilm);
            this.Controls.Add(this.btnIzborFilma);
            this.Name = "ProjekcijaDodajForm";
            this.Text = "ProjekcijaDodajForm";
            this.gbIzabraniFilm.ResumeLayout(false);
            this.gbIzabraniFilm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzborFilma;
        private System.Windows.Forms.Label lblTrajanjeFilma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOpisFilma;
        private System.Windows.Forms.Label lblZanrFilma;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbIzabraniFilm;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbSala;
    }
}