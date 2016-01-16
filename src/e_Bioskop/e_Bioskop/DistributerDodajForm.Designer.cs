namespace e_Bioskop
{
    partial class DistributerDodajForm
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
            this.lblDodajNaslov = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxNaziv = new System.Windows.Forms.TextBox();
            this.tbxAdresa = new System.Windows.Forms.TextBox();
            this.tbxBrojTelefona = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDodajNaslov
            // 
            this.lblDodajNaslov.AutoSize = true;
            this.lblDodajNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblDodajNaslov.Name = "lblDodajNaslov";
            this.lblDodajNaslov.Size = new System.Drawing.Size(329, 25);
            this.lblDodajNaslov.TabIndex = 0;
            this.lblDodajNaslov.Text = "Unesite podatke o distributeru";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 59);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(12, 99);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(12, 139);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(66, 13);
            this.lblBrojTelefona.TabIndex = 3;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // tbxNaziv
            // 
            this.tbxNaziv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxNaziv.Location = new System.Drawing.Point(88, 56);
            this.tbxNaziv.Name = "tbxNaziv";
            this.tbxNaziv.Size = new System.Drawing.Size(253, 20);
            this.tbxNaziv.TabIndex = 1;
            this.tbxNaziv.TextChanged += new System.EventHandler(this.tbxNaziv_TextChanged);
            // 
            // tbxAdresa
            // 
            this.tbxAdresa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxAdresa.Location = new System.Drawing.Point(88, 96);
            this.tbxAdresa.Name = "tbxAdresa";
            this.tbxAdresa.Size = new System.Drawing.Size(253, 20);
            this.tbxAdresa.TabIndex = 2;
            this.tbxAdresa.Enter += new System.EventHandler(this.tbxAdresa_Enter);
            this.tbxAdresa.Leave += new System.EventHandler(this.tbxAdresa_Leave);
            // 
            // tbxBrojTelefona
            // 
            this.tbxBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxBrojTelefona.Location = new System.Drawing.Point(88, 136);
            this.tbxBrojTelefona.Name = "tbxBrojTelefona";
            this.tbxBrojTelefona.Size = new System.Drawing.Size(253, 20);
            this.tbxBrojTelefona.TabIndex = 3;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxEmail.Location = new System.Drawing.Point(88, 176);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(253, 20);
            this.tbxEmail.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(266, 227);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DistributerDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxBrojTelefona);
            this.Controls.Add(this.tbxAdresa);
            this.Controls.Add(this.tbxNaziv);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblDodajNaslov);
            this.Name = "DistributerDodajForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje distributera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodajNaslov;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxNaziv;
        private System.Windows.Forms.TextBox tbxAdresa;
        private System.Windows.Forms.TextBox tbxBrojTelefona;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnDodaj;
    }
}

