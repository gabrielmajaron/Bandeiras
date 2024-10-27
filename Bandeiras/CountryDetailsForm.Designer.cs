namespace Bandeiras
{
    partial class CountryDetailsForm
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
            this.pcBoxImagem = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCountryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBoxImagem
            // 
            this.pcBoxImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcBoxImagem.Location = new System.Drawing.Point(31, 29);
            this.pcBoxImagem.Name = "pcBoxImagem";
            this.pcBoxImagem.Size = new System.Drawing.Size(560, 395);
            this.pcBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxImagem.TabIndex = 0;
            this.pcBoxImagem.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(516, 478);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 35);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCountryName
            // 
            this.lblCountryName.Location = new System.Drawing.Point(31, 438);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(560, 18);
            this.lblCountryName.TabIndex = 3;
            this.lblCountryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 525);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pcBoxImagem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountryDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.CountryDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pcBoxImagem;
        private Button btnVoltar;
        private Label lblCountryName;
    }
}