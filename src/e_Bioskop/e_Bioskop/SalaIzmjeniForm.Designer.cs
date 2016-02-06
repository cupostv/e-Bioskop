namespace e_Bioskop
{
    partial class SalaIzmjeniForm
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
            this.cbAktivna = new System.Windows.Forms.CheckBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbxBrojSjedistaUredu = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBrojRedova = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNazivSale = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNoviNaziv = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojSjedistaUredu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojRedova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAktivna
            // 
            this.cbAktivna.AutoSize = true;
            this.cbAktivna.Checked = true;
            this.cbAktivna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktivna.Location = new System.Drawing.Point(179, 145);
            this.cbAktivna.Name = "cbAktivna";
            this.cbAktivna.Size = new System.Drawing.Size(62, 17);
            this.cbAktivna.TabIndex = 18;
            this.cbAktivna.Text = "Aktivna";
            this.cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(280, 181);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 17;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(199, 181);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Potvrdi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbxBrojSjedistaUredu
            // 
            this.tbxBrojSjedistaUredu.Location = new System.Drawing.Point(179, 110);
            this.tbxBrojSjedistaUredu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxBrojSjedistaUredu.Name = "tbxBrojSjedistaUredu";
            this.tbxBrojSjedistaUredu.Size = new System.Drawing.Size(176, 20);
            this.tbxBrojSjedistaUredu.TabIndex = 15;
            this.tbxBrojSjedistaUredu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Broj sjedišta u jednom redu";
            // 
            // tbxBrojRedova
            // 
            this.tbxBrojRedova.Location = new System.Drawing.Point(179, 78);
            this.tbxBrojRedova.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxBrojRedova.Name = "tbxBrojRedova";
            this.tbxBrojRedova.Size = new System.Drawing.Size(176, 20);
            this.tbxBrojRedova.TabIndex = 13;
            this.tbxBrojRedova.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Broj redova";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv";
            // 
            // cbNazivSale
            // 
            this.cbNazivSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNazivSale.FormattingEnabled = true;
            this.cbNazivSale.Location = new System.Drawing.Point(179, 12);
            this.cbNazivSale.Name = "cbNazivSale";
            this.cbNazivSale.Size = new System.Drawing.Size(176, 21);
            this.cbNazivSale.TabIndex = 19;
            this.cbNazivSale.SelectedIndexChanged += new System.EventHandler(this.cbNazivSale_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Novi naziv";
            // 
            // tbxNoviNaziv
            // 
            this.tbxNoviNaziv.Location = new System.Drawing.Point(179, 43);
            this.tbxNoviNaziv.Name = "tbxNoviNaziv";
            this.tbxNoviNaziv.Size = new System.Drawing.Size(176, 20);
            this.tbxNoviNaziv.TabIndex = 21;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // SalaIzmjeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 214);
            this.Controls.Add(this.tbxNoviNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNazivSale);
            this.Controls.Add(this.cbAktivna);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxBrojSjedistaUredu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxBrojRedova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalaIzmjeniForm";
            this.Text = "Izmjena podataka";
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojSjedistaUredu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojRedova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAktivna;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown tbxBrojSjedistaUredu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbxBrojRedova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNazivSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNoviNaziv;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}