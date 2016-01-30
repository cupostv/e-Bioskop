namespace e_Bioskop
{
    partial class FilmIzborForm
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
            this.lvFilmovi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvFilmovi
            // 
            this.lvFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFilmovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFilmovi.FullRowSelect = true;
            this.lvFilmovi.GridLines = true;
            this.lvFilmovi.Location = new System.Drawing.Point(21, 12);
            this.lvFilmovi.Name = "lvFilmovi";
            this.lvFilmovi.Size = new System.Drawing.Size(476, 295);
            this.lvFilmovi.TabIndex = 4;
            this.lvFilmovi.UseCompatibleStateImageBehavior = false;
            this.lvFilmovi.View = System.Windows.Forms.View.Details;
            this.lvFilmovi.SelectedIndexChanged += new System.EventHandler(this.lvFilmovi_SelectedIndexChanged);
            this.lvFilmovi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFilmovi_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv filma";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Žanr filma";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trajanje";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opis";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(422, 321);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(75, 23);
            this.btnIzaberi.TabIndex = 5;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // FilmIzborForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 356);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.lvFilmovi);
            this.Name = "FilmIzborForm";
            this.Text = "Izbor filma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFilmovi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnIzaberi;
    }
}