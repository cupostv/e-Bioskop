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
            this.components = new System.ComponentModel.Container();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCijena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.epFilm = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSala = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCijena = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbIzabraniFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzborFilma
            // 
            this.btnIzborFilma.Location = new System.Drawing.Point(12, 67);
            this.btnIzborFilma.Name = "btnIzborFilma";
            this.btnIzborFilma.Size = new System.Drawing.Size(90, 38);
            this.btnIzborFilma.TabIndex = 0;
            this.btnIzborFilma.Text = "Izaberite film";
            this.btnIzborFilma.UseVisualStyleBackColor = true;
            this.btnIzborFilma.Click += new System.EventHandler(this.btnIzborFilma_Click);
            // 
            // lblTrajanjeFilma
            // 
            this.lblTrajanjeFilma.AutoSize = true;
            this.lblTrajanjeFilma.Location = new System.Drawing.Point(71, 83);
            this.lblTrajanjeFilma.Name = "lblTrajanjeFilma";
            this.lblTrajanjeFilma.Size = new System.Drawing.Size(0, 13);
            this.lblTrajanjeFilma.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Trajanje";
            // 
            // lblOpisFilma
            // 
            this.lblOpisFilma.Location = new System.Drawing.Point(71, 111);
            this.lblOpisFilma.Name = "lblOpisFilma";
            this.lblOpisFilma.Size = new System.Drawing.Size(123, 29);
            this.lblOpisFilma.TabIndex = 18;
            // 
            // lblZanrFilma
            // 
            this.lblZanrFilma.AutoSize = true;
            this.lblZanrFilma.Location = new System.Drawing.Point(71, 55);
            this.lblZanrFilma.Name = "lblZanrFilma";
            this.lblZanrFilma.Size = new System.Drawing.Size(0, 13);
            this.lblZanrFilma.TabIndex = 17;
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.Location = new System.Drawing.Point(71, 27);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(123, 28);
            this.lblNazivFilma.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Žanr:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
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
            this.gbIzabraniFilm.Location = new System.Drawing.Point(108, 12);
            this.gbIzabraniFilm.Name = "gbIzabraniFilm";
            this.gbIzabraniFilm.Size = new System.Drawing.Size(200, 143);
            this.gbIzabraniFilm.TabIndex = 21;
            this.gbIzabraniFilm.TabStop = false;
            this.gbIzabraniFilm.Text = "Izabrani film";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(108, 161);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 22;
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.CustomFormat = "HH:mm";
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVrijeme.Location = new System.Drawing.Point(108, 193);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.ShowUpDown = true;
            this.dtpVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dtpVrijeme.TabIndex = 23;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(152, 298);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 24;
            this.btnSacuvaj.Text = "Potvrdi";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(108, 222);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(200, 21);
            this.cbSala.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Vrijeme projekcije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Datum:";
            // 
            // tbxCijena
            // 
            this.tbxCijena.Location = new System.Drawing.Point(108, 254);
            this.tbxCijena.Name = "tbxCijena";
            this.tbxCijena.Size = new System.Drawing.Size(200, 20);
            this.tbxCijena.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cijena karte:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(233, 298);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 31;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // epFilm
            // 
            this.epFilm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFilm.ContainerControl = this;
            // 
            // epSala
            // 
            this.epSala.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epSala.ContainerControl = this;
            // 
            // epCijena
            // 
            this.epCijena.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCijena.ContainerControl = this;
            // 
            // ProjekcijaDodajForm
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(329, 333);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.gbIzabraniFilm);
            this.Controls.Add(this.btnIzborFilma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProjekcijaDodajForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj projekciju";
            this.gbIzabraniFilm.ResumeLayout(false);
            this.gbIzabraniFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCijena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider epFilm;
        private System.Windows.Forms.ErrorProvider epSala;
        private System.Windows.Forms.ErrorProvider epCijena;
    }
}