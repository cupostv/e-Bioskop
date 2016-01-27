namespace e_Bioskop
{
    partial class ZaposleniKreiranjeForm
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
            this.txbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLozinka1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txbLozinka = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBrojTelefona = new System.Windows.Forms.TextBox();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.cboxRadnoMjesto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.epNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBrojTelefona = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRadnoMjesto = new System.Windows.Forms.ErrorProvider(this.components);
            this.epKorisnickoIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLozinka1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRadnoMjesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKorisnickoIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinka)).BeginInit();
            this.SuspendLayout();
            // 
            // txbKorisnickoIme
            // 
            this.txbKorisnickoIme.Location = new System.Drawing.Point(124, 17);
            this.txbKorisnickoIme.Name = "txbKorisnickoIme";
            this.txbKorisnickoIme.Size = new System.Drawing.Size(232, 20);
            this.txbKorisnickoIme.TabIndex = 7;
            this.txbKorisnickoIme.Leave += new System.EventHandler(this.txbKorisnickoIme_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbLozinka1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblKorisnickoIme);
            this.groupBox1.Controls.Add(this.txbLozinka);
            this.groupBox1.Controls.Add(this.txbKorisnickoIme);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o korisničkom nalogu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Potvrdite lozinku";
            // 
            // txbLozinka1
            // 
            this.txbLozinka1.Location = new System.Drawing.Point(124, 74);
            this.txbLozinka1.Name = "txbLozinka1";
            this.txbLozinka1.PasswordChar = '*';
            this.txbLozinka1.Size = new System.Drawing.Size(232, 20);
            this.txbLozinka1.TabIndex = 9;
            this.txbLozinka1.TextChanged += new System.EventHandler(this.txbLozinka1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(16, 20);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(81, 13);
            this.lblKorisnickoIme.TabIndex = 2;
            this.lblKorisnickoIme.Text = "Korisničko ime: ";
            // 
            // txbLozinka
            // 
            this.txbLozinka.Location = new System.Drawing.Point(124, 44);
            this.txbLozinka.Name = "txbLozinka";
            this.txbLozinka.PasswordChar = '*';
            this.txbLozinka.Size = new System.Drawing.Size(232, 20);
            this.txbLozinka.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAktivan);
            this.groupBox2.Controls.Add(this.txbEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDatumRodjenja);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbBrojTelefona);
            this.groupBox2.Controls.Add(this.txbPrezime);
            this.groupBox2.Controls.Add(this.txbIme);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o zaposlenom";
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Checked = true;
            this.cbAktivan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktivan.Location = new System.Drawing.Point(124, 157);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbAktivan.TabIndex = 6;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(124, 127);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(232, 20);
            this.txbEmail.TabIndex = 5;
            this.txbEmail.Enter += new System.EventHandler(this.txbEmail_Enter);
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Broj telefona:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datum rođenja:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(124, 73);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(232, 20);
            this.dtpDatumRodjenja.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime:";
            // 
            // txbBrojTelefona
            // 
            this.txbBrojTelefona.Location = new System.Drawing.Point(124, 100);
            this.txbBrojTelefona.Name = "txbBrojTelefona";
            this.txbBrojTelefona.Size = new System.Drawing.Size(232, 20);
            this.txbBrojTelefona.TabIndex = 4;
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(124, 46);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(232, 20);
            this.txbPrezime.TabIndex = 2;
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(124, 19);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(232, 20);
            this.txbIme.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(237, 417);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Potvrdi";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(318, 417);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDatumZaposlenja);
            this.groupBox3.Controls.Add(this.cboxRadnoMjesto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(13, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o zaposlenju";
            // 
            // dtpDatumZaposlenja
            // 
            this.dtpDatumZaposlenja.Location = new System.Drawing.Point(123, 44);
            this.dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            this.dtpDatumZaposlenja.Size = new System.Drawing.Size(232, 20);
            this.dtpDatumZaposlenja.TabIndex = 11;
            // 
            // cboxRadnoMjesto
            // 
            this.cboxRadnoMjesto.BackColor = System.Drawing.SystemColors.Control;
            this.cboxRadnoMjesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRadnoMjesto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboxRadnoMjesto.FormattingEnabled = true;
            this.cboxRadnoMjesto.Location = new System.Drawing.Point(123, 16);
            this.cboxRadnoMjesto.Name = "cboxRadnoMjesto";
            this.cboxRadnoMjesto.Size = new System.Drawing.Size(232, 21);
            this.cboxRadnoMjesto.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Datum zaposlenja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Radno mjesto:";
            // 
            // epNaziv
            // 
            this.epNaziv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNaziv.ContainerControl = this;
            // 
            // epPrezime
            // 
            this.epPrezime.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPrezime.ContainerControl = this;
            // 
            // epBrojTelefona
            // 
            this.epBrojTelefona.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epBrojTelefona.ContainerControl = this;
            // 
            // epRadnoMjesto
            // 
            this.epRadnoMjesto.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epRadnoMjesto.ContainerControl = this;
            // 
            // epKorisnickoIme
            // 
            this.epKorisnickoIme.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epKorisnickoIme.ContainerControl = this;
            // 
            // epLozinka1
            // 
            this.epLozinka1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLozinka1.ContainerControl = this;
            // 
            // epLozinka
            // 
            this.epLozinka.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLozinka.ContainerControl = this;
            // 
            // ZaposleniKreiranjeForm
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(405, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ZaposleniKreiranjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje naloga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRadnoMjesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKorisnickoIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbKorisnickoIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbLozinka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLozinka1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbBrojTelefona;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposlenja;
        private System.Windows.Forms.ComboBox cboxRadnoMjesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider epNaziv;
        private System.Windows.Forms.ErrorProvider epPrezime;
        private System.Windows.Forms.ErrorProvider epBrojTelefona;
        private System.Windows.Forms.ErrorProvider epRadnoMjesto;
        private System.Windows.Forms.ErrorProvider epKorisnickoIme;
        private System.Windows.Forms.ErrorProvider epLozinka1;
        private System.Windows.Forms.ErrorProvider epLozinka;
    }
}