﻿namespace e_Bioskop
{
    partial class PregledRasporedaForm
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
            this.lvProjekcije = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvProjekcije
            // 
            this.lvProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProjekcije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lvProjekcije.FullRowSelect = true;
            this.lvProjekcije.GridLines = true;
            this.lvProjekcije.Location = new System.Drawing.Point(12, 50);
            this.lvProjekcije.Name = "lvProjekcije";
            this.lvProjekcije.Size = new System.Drawing.Size(318, 313);
            this.lvProjekcije.TabIndex = 4;
            this.lvProjekcije.UseCompatibleStateImageBehavior = false;
            this.lvProjekcije.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vrijeme projekcije";
            this.columnHeader3.Width = 103;
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
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(12, 24);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 23;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // PregledRasporedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 395);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lvProjekcije);
            this.Name = "PregledRasporedaForm";
            this.Text = "PregledRasporedaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProjekcije;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}