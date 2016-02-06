namespace e_Bioskop
{
    partial class PonistavanjeKarteForm
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
            this.tbxBrojKarte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.errProvBrojKarte = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvBrojKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBrojKarte
            // 
            this.tbxBrojKarte.Location = new System.Drawing.Point(42, 55);
            this.tbxBrojKarte.Name = "tbxBrojKarte";
            this.tbxBrojKarte.Size = new System.Drawing.Size(207, 20);
            this.tbxBrojKarte.TabIndex = 0;
            this.tbxBrojKarte.TextChanged += new System.EventHandler(this.tbxBrojKarte_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite broj karte";
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(42, 93);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 2;
            this.btnPonisti.Text = "Poništi kartu";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // errProvBrojKarte
            // 
            this.errProvBrojKarte.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvBrojKarte.ContainerControl = this;
            // 
            // PonistavanjeKarteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 138);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBrojKarte);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 176);
            this.Name = "PonistavanjeKarteForm";
            this.Text = "Poništavanje karte";
            ((System.ComponentModel.ISupportInitialize)(this.errProvBrojKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBrojKarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.ErrorProvider errProvBrojKarte;
    }
}