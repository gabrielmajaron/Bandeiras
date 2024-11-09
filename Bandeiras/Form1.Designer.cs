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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBoxFlag = new PictureBox();
            btnNext = new Button();
            btnPrev = new Button();
            cbbAnswer = new ComboBox();
            lblNomeBandeira = new Label();
            checkBox1 = new CheckBox();
            lblLoading = new Label();
            cbbContinents = new ComboBox();
            lblCountriesRemaining = new Label();
            ckbRandom = new CheckBox();
            picBoxBook = new PictureBox();
            picBoxRefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRefresh).BeginInit();
            SuspendLayout();
            // 
            // picBoxFlag
            // 
            picBoxFlag.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxFlag.Location = new Point(52, 111);
            picBoxFlag.Name = "picBoxFlag";
            picBoxFlag.Size = new Size(323, 182);
            picBoxFlag.TabIndex = 0;
            picBoxFlag.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(300, 329);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 38);
            btnNext.TabIndex = 1;
            btnNext.Text = "Próximo";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(219, 329);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 38);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "Anterior";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // cbbAnswer
            // 
            cbbAnswer.FormattingEnabled = true;
            cbbAnswer.Location = new Point(52, 64);
            cbbAnswer.Name = "cbbAnswer";
            cbbAnswer.Size = new Size(194, 23);
            cbbAnswer.TabIndex = 3;
            cbbAnswer.KeyDown += cbbAnswer_KeyDown;
            // 
            // lblNomeBandeira
            // 
            lblNomeBandeira.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNomeBandeira.Location = new Point(121, 391);
            lblNomeBandeira.Name = "lblNomeBandeira";
            lblNomeBandeira.Size = new Size(300, 15);
            lblNomeBandeira.TabIndex = 4;
            lblNomeBandeira.TextAlign = ContentAlignment.MiddleRight;
            lblNomeBandeira.Click += lblNomeBandeira_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(252, 68);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Esconder resposta";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblLoading
            // 
            lblLoading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoading.Location = new Point(52, 172);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(323, 65);
            lblLoading.TabIndex = 6;
            lblLoading.Text = "Carregando... Aguarde";
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbContinents
            // 
            cbbContinents.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbContinents.FormattingEnabled = true;
            cbbContinents.Location = new Point(52, 35);
            cbbContinents.Name = "cbbContinents";
            cbbContinents.Size = new Size(194, 23);
            cbbContinents.TabIndex = 7;
            cbbContinents.SelectedIndexChanged += cbbContinents_SelectedIndexChanged;
            // 
            // lblCountriesRemaining
            // 
            lblCountriesRemaining.AutoSize = true;
            lblCountriesRemaining.Location = new Point(52, 296);
            lblCountriesRemaining.Name = "lblCountriesRemaining";
            lblCountriesRemaining.Size = new Size(13, 15);
            lblCountriesRemaining.TabIndex = 8;
            lblCountriesRemaining.Text = "0";
            // 
            // ckbRandom
            // 
            ckbRandom.AutoSize = true;
            ckbRandom.Checked = true;
            ckbRandom.CheckState = CheckState.Checked;
            ckbRandom.Location = new Point(252, 39);
            ckbRandom.Name = "ckbRandom";
            ckbRandom.Size = new Size(63, 19);
            ckbRandom.TabIndex = 9;
            ckbRandom.Text = "Sortear";
            ckbRandom.UseVisualStyleBackColor = true;
            // 
            // picBoxBook
            // 
            picBoxBook.BackgroundImage = (Image)resources.GetObject("picBoxBook.BackgroundImage");
            picBoxBook.BackgroundImageLayout = ImageLayout.Center;
            picBoxBook.Location = new Point(52, 329);
            picBoxBook.Name = "picBoxBook";
            picBoxBook.Size = new Size(45, 40);
            picBoxBook.TabIndex = 11;
            picBoxBook.TabStop = false;
            picBoxBook.Click += picBoxBook_Click;
            // 
            // picBoxRefresh
            // 
            picBoxRefresh.BackgroundImage = (Image)resources.GetObject("picBoxRefresh.BackgroundImage");
            picBoxRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxRefresh.Location = new Point(330, 325);
            picBoxRefresh.Name = "picBoxRefresh";
            picBoxRefresh.Size = new Size(45, 45);
            picBoxRefresh.TabIndex = 13;
            picBoxRefresh.TabStop = false;
            picBoxRefresh.Visible = false;
            picBoxRefresh.Click += picBoxRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 415);
            Controls.Add(picBoxRefresh);
            Controls.Add(picBoxBook);
            Controls.Add(ckbRandom);
            Controls.Add(lblCountriesRemaining);
            Controls.Add(cbbContinents);
            Controls.Add(lblLoading);
            Controls.Add(checkBox1);
            Controls.Add(lblNomeBandeira);
            Controls.Add(cbbAnswer);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(picBoxFlag);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bandeiras";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)picBoxFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox picBoxBook;
        private PictureBox picBoxRefresh;
    }
}