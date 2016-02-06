namespace e_Bioskop
{
    partial class RezervacijePregledForm
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
            this.tbxOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIzbor = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDatum,
            this.colVrijeme,
            this.colOpis,
            this.colIzbor});
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 213);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbxOpis
            // 
            this.tbxOpis.Location = new System.Drawing.Point(410, 7);
            this.tbxOpis.Name = "tbxOpis";
            this.tbxOpis.Size = new System.Drawing.Size(132, 20);
            this.tbxOpis.TabIndex = 2;
            this.tbxOpis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opis";
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colDatum
            // 
            this.colDatum.HeaderText = "Datum";
            this.colDatum.Name = "colDatum";
            // 
            // colVrijeme
            // 
            this.colVrijeme.HeaderText = "Vrijeme";
            this.colVrijeme.Name = "colVrijeme";
            // 
            // colOpis
            // 
            this.colOpis.FillWeight = 200F;
            this.colOpis.HeaderText = "Opis";
            this.colOpis.Name = "colOpis";
            // 
            // colIzbor
            // 
            this.colIzbor.HeaderText = "Izaberi";
            this.colIzbor.Name = "colIzbor";
            // 
            // RezervacijePregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOpis);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RezervacijePregledForm";
            this.Text = "Pregled rezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpis;
        private System.Windows.Forms.DataGridViewButtonColumn colIzbor;
    }
}