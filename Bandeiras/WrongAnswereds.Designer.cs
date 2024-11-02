namespace Bandeiras
{
    partial class WrongAnswereds
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
            btnClear = new Button();
            label1 = new Label();
            lblFlagName = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            picBoxFlag = new PictureBox();
            lblFlagsCount = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxFlag).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(153, 288);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 38);
            btnClear.TabIndex = 14;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Location = new Point(67, 23);
            label1.Name = "label1";
            label1.Size = new Size(151, 18);
            label1.TabIndex = 13;
            label1.Text = "Bandeiras que você errou:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlagName
            // 
            lblFlagName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFlagName.Location = new Point(90, 257);
            lblFlagName.Name = "lblFlagName";
            lblFlagName.Size = new Size(300, 15);
            lblFlagName.TabIndex = 12;
            lblFlagName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(234, 288);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 38);
            btnPrev.TabIndex = 11;
            btnPrev.Text = "Anterior";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(315, 288);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 38);
            btnNext.TabIndex = 10;
            btnNext.Text = "Próximo";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // picBoxFlag
            // 
            picBoxFlag.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxFlag.ErrorImage = null;
            picBoxFlag.InitialImage = null;
            picBoxFlag.Location = new Point(67, 60);
            picBoxFlag.Name = "picBoxFlag";
            picBoxFlag.Size = new Size(323, 182);
            picBoxFlag.TabIndex = 9;
            picBoxFlag.TabStop = false;
            // 
            // lblFlagsCount
            // 
            lblFlagsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFlagsCount.Location = new Point(224, 23);
            lblFlagsCount.Name = "lblFlagsCount";
            lblFlagsCount.Size = new Size(116, 18);
            lblFlagsCount.TabIndex = 15;
            lblFlagsCount.Text = "0";
            lblFlagsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(72, 288);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 38);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // WrongAnswereds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 351);
            Controls.Add(btnRemove);
            Controls.Add(lblFlagsCount);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(lblFlagName);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(picBoxFlag);
            MaximizeBox = false;
            Name = "WrongAnswereds";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bandeiras não decoradas";
            Load += WrongAnswereds_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxFlag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClear;
        private Label label1;
        private Label lblFlagName;
        private Button btnPrev;
        private Button btnNext;
        private PictureBox picBoxFlag;
        private Label lblFlagsCount;
        private Button btnRemove;
    }
}