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
            this.components = new System.ComponentModel.Container();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxNaziv = new System.Windows.Forms.TextBox();
            this.tbxAdresa = new System.Windows.Forms.TextBox();
            this.tbxBrojTelefona = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.epNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBrojTelefona = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(11, 35);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(11, 75);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(11, 115);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(66, 13);
            this.lblBrojTelefona.TabIndex = 3;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // tbxNaziv
            // 
            this.tbxNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNaziv.Location = new System.Drawing.Point(87, 32);
            this.tbxNaziv.Name = "tbxNaziv";
            this.tbxNaziv.Size = new System.Drawing.Size(239, 20);
            this.tbxNaziv.TabIndex = 1;
            // 
            // tbxAdresa
            // 
            this.tbxAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAdresa.Location = new System.Drawing.Point(87, 72);
            this.tbxAdresa.Name = "tbxAdresa";
            this.tbxAdresa.Size = new System.Drawing.Size(239, 20);
            this.tbxAdresa.TabIndex = 2;
            // 
            // tbxBrojTelefona
            // 
            this.tbxBrojTelefona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBrojTelefona.Location = new System.Drawing.Point(87, 112);
            this.tbxBrojTelefona.Name = "tbxBrojTelefona";
            this.tbxBrojTelefona.Size = new System.Drawing.Size(239, 20);
            this.tbxBrojTelefona.TabIndex = 3;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxEmail.Location = new System.Drawing.Point(87, 152);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(239, 20);
            this.tbxEmail.TabIndex = 4;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi.Location = new System.Drawing.Point(170, 200);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 5;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(251, 200);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // epNaziv
            // 
            this.epNaziv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNaziv.ContainerControl = this;
            // 
            // epBrojTelefona
            // 
            this.epBrojTelefona.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epBrojTelefona.ContainerControl = this;
            // 
            // DistributerDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 235);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxBrojTelefona);
            this.Controls.Add(this.tbxAdresa);
            this.Controls.Add(this.tbxNaziv);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNaziv);
            this.Name = "DistributerDodajForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj distributera";
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxNaziv;
        private System.Windows.Forms.TextBox tbxAdresa;
        private System.Windows.Forms.TextBox tbxBrojTelefona;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider epNaziv;
        private System.Windows.Forms.ErrorProvider epBrojTelefona;
    }
}

