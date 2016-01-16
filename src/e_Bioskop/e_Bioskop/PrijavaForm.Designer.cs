namespace e_Bioskop
{
    partial class PrijavaForm
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
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.tbxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbxLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblGreska = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(12, 77);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(12, 108);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka";
            // 
            // tbxKorisnickoIme
            // 
            this.tbxKorisnickoIme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxKorisnickoIme.Location = new System.Drawing.Point(128, 74);
            this.tbxKorisnickoIme.Name = "tbxKorisnickoIme";
            this.tbxKorisnickoIme.Size = new System.Drawing.Size(222, 20);
            this.tbxKorisnickoIme.TabIndex = 1;
            // 
            // tbxLozinka
            // 
            this.tbxLozinka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLozinka.Location = new System.Drawing.Point(128, 105);
            this.tbxLozinka.Name = "tbxLozinka";
            this.tbxLozinka.PasswordChar = '*';
            this.tbxLozinka.Size = new System.Drawing.Size(222, 20);
            this.tbxLozinka.TabIndex = 2;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrijava.Location = new System.Drawing.Point(275, 172);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 3;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.ForeColor = System.Drawing.Color.Red;
            this.lblGreska.Location = new System.Drawing.Point(125, 58);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(174, 13);
            this.lblGreska.TabIndex = 5;
            this.lblGreska.Text = "Pogrešno korisničko ime i/ili lozinka";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(271, 24);
            this.lblNaslov.TabIndex = 6;
            this.lblNaslov.Text = "Unesite korisničko ime i lozinku";
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 207);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.tbxLozinka);
            this.Controls.Add(this.tbxKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "PrijavaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrijavaForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox tbxKorisnickoIme;
        private System.Windows.Forms.TextBox tbxLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Label lblNaslov;
    }
}