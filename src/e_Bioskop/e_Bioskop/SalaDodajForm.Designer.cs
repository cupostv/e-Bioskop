namespace e_Bioskop
{
    partial class SalaDodajForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBrojRedova = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBrojSjedistaUredu = new System.Windows.Forms.NumericUpDown();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojRedova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojSjedistaUredu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // tbxNaziv
            // 
            this.tbxNaziv.Location = new System.Drawing.Point(82, 39);
            this.tbxNaziv.Name = "tbxNaziv";
            this.tbxNaziv.Size = new System.Drawing.Size(190, 20);
            this.tbxNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj redova";
            // 
            // tbxBrojRedova
            // 
            this.tbxBrojRedova.Location = new System.Drawing.Point(82, 106);
            this.tbxBrojRedova.Name = "tbxBrojRedova";
            this.tbxBrojRedova.Size = new System.Drawing.Size(190, 20);
            this.tbxBrojRedova.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj sjedišta u jednom redu";
            // 
            // tbxBrojSjedistaUredu
            // 
            this.tbxBrojSjedistaUredu.Location = new System.Drawing.Point(82, 173);
            this.tbxBrojSjedistaUredu.Name = "tbxBrojSjedistaUredu";
            this.tbxBrojSjedistaUredu.Size = new System.Drawing.Size(190, 20);
            this.tbxBrojSjedistaUredu.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(197, 226);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Sačuvaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // SalaDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxBrojSjedistaUredu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxBrojRedova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNaziv);
            this.Controls.Add(this.label1);
            this.Name = "SalaDodajForm";
            this.Text = "Unesite podatke o sali";
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojRedova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBrojSjedistaUredu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbxBrojRedova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbxBrojSjedistaUredu;
        private System.Windows.Forms.Button btnDodaj;
    }
}