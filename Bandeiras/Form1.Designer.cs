using Bandeiras.Handlers;

namespace Bandeiras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxFlag = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cbbAnswer = new System.Windows.Forms.ComboBox();
            this.lblNomeBandeira = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.cbbContinents = new System.Windows.Forms.ComboBox();
            this.lblCountriesRemaining = new System.Windows.Forms.Label();
            this.ckbRandom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFlag
            // 
            this.picBoxFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxFlag.Location = new System.Drawing.Point(52, 93);
            this.picBoxFlag.Name = "picBoxFlag";
            this.picBoxFlag.Size = new System.Drawing.Size(323, 182);
            this.picBoxFlag.TabIndex = 0;
            this.picBoxFlag.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(310, 309);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Próximo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(229, 309);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Anterior";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // cbbAnswer
            // 
            this.cbbAnswer.FormattingEnabled = true;
            this.cbbAnswer.Location = new System.Drawing.Point(52, 64);
            this.cbbAnswer.Name = "cbbAnswer";
            this.cbbAnswer.Size = new System.Drawing.Size(194, 23);
            this.cbbAnswer.TabIndex = 3;
            this.cbbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbAnswer_KeyDown);
            // 
            // lblNomeBandeira
            // 
            this.lblNomeBandeira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeBandeira.Location = new System.Drawing.Point(121, 346);
            this.lblNomeBandeira.Name = "lblNomeBandeira";
            this.lblNomeBandeira.Size = new System.Drawing.Size(300, 15);
            this.lblNomeBandeira.TabIndex = 4;
            this.lblNomeBandeira.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNomeBandeira.Click += new System.EventHandler(this.lblNomeBandeira_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(252, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Esconder resposta";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.Location = new System.Drawing.Point(52, 172);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(323, 20);
            this.lblLoading.TabIndex = 6;
            this.lblLoading.Text = "Carregando... Aguarde";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbContinents
            // 
            this.cbbContinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbContinents.FormattingEnabled = true;
            this.cbbContinents.Location = new System.Drawing.Point(52, 35);
            this.cbbContinents.Name = "cbbContinents";
            this.cbbContinents.Size = new System.Drawing.Size(194, 23);
            this.cbbContinents.TabIndex = 7;
            this.cbbContinents.SelectedIndexChanged += new System.EventHandler(this.cbbContinents_SelectedIndexChanged);
            // 
            // lblCountriesRemaining
            // 
            this.lblCountriesRemaining.AutoSize = true;
            this.lblCountriesRemaining.Location = new System.Drawing.Point(52, 278);
            this.lblCountriesRemaining.Name = "lblCountriesRemaining";
            this.lblCountriesRemaining.Size = new System.Drawing.Size(13, 15);
            this.lblCountriesRemaining.TabIndex = 8;
            this.lblCountriesRemaining.Text = "0";
            // 
            // ckbRandom
            // 
            this.ckbRandom.AutoSize = true;
            this.ckbRandom.Checked = true;
            this.ckbRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbRandom.Location = new System.Drawing.Point(252, 39);
            this.ckbRandom.Name = "ckbRandom";
            this.ckbRandom.Size = new System.Drawing.Size(63, 19);
            this.ckbRandom.TabIndex = 9;
            this.ckbRandom.Text = "Sortear";
            this.ckbRandom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 370);
            this.Controls.Add(this.ckbRandom);
            this.Controls.Add(this.lblCountriesRemaining);
            this.Controls.Add(this.cbbContinents);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblNomeBandeira);
            this.Controls.Add(this.cbbAnswer);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picBoxFlag);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandeiras";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxFlag;
        private Button btnNext;
        private Button btnPrev;
        private ComboBox cbbAnswer;
        private Label lblNomeBandeira;
        private CheckBox checkBox1;
        private Label lblLoading;
        private ComboBox cbbContinents;
        private Label lblCountriesRemaining;
        private CheckBox ckbRandom;
    }
}