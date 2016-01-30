namespace e_Bioskop
{
    partial class ProjekcijaIzborForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpisFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIzbor = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colVrijeme,
            this.colNazivFilma,
            this.colZanr,
            this.colTrajanje,
            this.colOpisFilma,
            this.colCijena,
            this.colIzbor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colVrijeme
            // 
            this.colVrijeme.HeaderText = "Vrijeme";
            this.colVrijeme.Name = "colVrijeme";
            // 
            // colNazivFilma
            // 
            this.colNazivFilma.FillWeight = 200F;
            this.colNazivFilma.HeaderText = "Naziv filma";
            this.colNazivFilma.Name = "colNazivFilma";
            // 
            // colZanr
            // 
            this.colZanr.HeaderText = "Zanr";
            this.colZanr.Name = "colZanr";
            // 
            // colTrajanje
            // 
            this.colTrajanje.HeaderText = "Trajanje";
            this.colTrajanje.Name = "colTrajanje";
            // 
            // colOpisFilma
            // 
            this.colOpisFilma.FillWeight = 200F;
            this.colOpisFilma.HeaderText = "Opis filma";
            this.colOpisFilma.Name = "colOpisFilma";
            // 
            // colCijena
            // 
            this.colCijena.HeaderText = "Cijena karte";
            this.colCijena.Name = "colCijena";
            // 
            // colIzbor
            // 
            this.colIzbor.HeaderText = "Izaberi film";
            this.colIzbor.Name = "colIzbor";
            // 
            // ProjekcijaIzborForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 417);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProjekcijaIzborForm";
            this.Text = "ProjekcijaIzborForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpisFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCijena;
        private System.Windows.Forms.DataGridViewButtonColumn colIzbor;
    }
}