namespace e_Bioskop
{
    partial class FilmDodajForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.txbOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbDistributer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbTrajanje = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.epNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epZanr = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDistributer = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOpis = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txbTrajanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epZanr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDistributer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zanr:";
            // 
            // txbNaziv
            // 
            this.txbNaziv.Location = new System.Drawing.Point(95, 22);
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(193, 20);
            this.txbNaziv.TabIndex = 1;
            // 
            // txbOpis
            // 
            this.txbOpis.Location = new System.Drawing.Point(95, 192);
            this.txbOpis.Multiline = true;
            this.txbOpis.Name = "txbOpis";
            this.txbOpis.Size = new System.Drawing.Size(193, 58);
            this.txbOpis.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Distributer";
            // 
            // cbZanr
            // 
            this.cbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Location = new System.Drawing.Point(95, 90);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(193, 21);
            this.cbZanr.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(95, 124);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(193, 21);
            this.cbStatus.TabIndex = 4;
            // 
            // cbDistributer
            // 
            this.cbDistributer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistributer.FormattingEnabled = true;
            this.cbDistributer.Location = new System.Drawing.Point(95, 158);
            this.cbDistributer.Name = "cbDistributer";
            this.cbDistributer.Size = new System.Drawing.Size(193, 21);
            this.cbDistributer.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTrajanje
            // 
            this.txbTrajanje.Location = new System.Drawing.Point(95, 57);
            this.txbTrajanje.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txbTrajanje.Name = "txbTrajanje";
            this.txbTrajanje.Size = new System.Drawing.Size(193, 20);
            this.txbTrajanje.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(213, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // epNaziv
            // 
            this.epNaziv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNaziv.ContainerControl = this;
            // 
            // epZanr
            // 
            this.epZanr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epZanr.ContainerControl = this;
            // 
            // epStatus
            // 
            this.epStatus.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epStatus.ContainerControl = this;
            // 
            // epDistributer
            // 
            this.epDistributer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epDistributer.ContainerControl = this;
            // 
            // epOpis
            // 
            this.epOpis.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epOpis.ContainerControl = this;
            // 
            // FilmDodajForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(312, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbTrajanje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDistributer);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbZanr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbOpis);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilmDodajForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj film";
            ((System.ComponentModel.ISupportInitialize)(this.txbTrajanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epZanr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDistributer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.TextBox txbOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbDistributer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txbTrajanje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider epNaziv;
        private System.Windows.Forms.ErrorProvider epZanr;
        private System.Windows.Forms.ErrorProvider epStatus;
        private System.Windows.Forms.ErrorProvider epDistributer;
        private System.Windows.Forms.ErrorProvider epOpis;
    }
}