
namespace TI3
{
    partial class FormRabin
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
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.QLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.NLabel = new System.Windows.Forms.Label();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PTextBox
            // 
            this.PTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTextBox.Location = new System.Drawing.Point(44, 44);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(831, 30);
            this.PTextBox.TabIndex = 0;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PLabel.Location = new System.Drawing.Point(38, 9);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(42, 32);
            this.PLabel.TabIndex = 1;
            this.PLabel.Text = "P:";
            // 
            // QTextBox
            // 
            this.QTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QTextBox.Location = new System.Drawing.Point(44, 112);
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(831, 30);
            this.QTextBox.TabIndex = 2;
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QLabel.Location = new System.Drawing.Point(38, 77);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(45, 32);
            this.QLabel.TabIndex = 3;
            this.QLabel.Text = "Q:";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BLabel.Location = new System.Drawing.Point(38, 145);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(42, 32);
            this.BLabel.TabIndex = 4;
            this.BLabel.Text = "B:";
            // 
            // BTextBox
            // 
            this.BTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTextBox.Location = new System.Drawing.Point(44, 181);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(831, 30);
            this.BTextBox.TabIndex = 5;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(458, 307);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(159, 32);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Результат:";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptBtn.Location = new System.Drawing.Point(962, 57);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(199, 40);
            this.EncryptBtn.TabIndex = 8;
            this.EncryptBtn.Text = "Шифровать";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptBtn.Location = new System.Drawing.Point(962, 138);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(199, 40);
            this.DecryptBtn.TabIndex = 9;
            this.DecryptBtn.Text = "Дешифровать";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resultTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(464, 356);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(414, 155);
            this.resultTextBox.TabIndex = 10;
            // 
            // NTextBox
            // 
            this.NTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NTextBox.Enabled = false;
            this.NTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTextBox.Location = new System.Drawing.Point(44, 250);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(831, 30);
            this.NTextBox.TabIndex = 11;
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NLabel.Location = new System.Drawing.Point(41, 215);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(43, 32);
            this.NLabel.TabIndex = 12;
            this.NLabel.Text = "N:";
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SourceTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.SourceTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceTextBox.Location = new System.Drawing.Point(44, 356);
            this.SourceTextBox.Multiline = true;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SourceTextBox.Size = new System.Drawing.Size(414, 155);
            this.SourceTextBox.TabIndex = 13;
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceLabel.Location = new System.Drawing.Point(41, 307);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(233, 32);
            this.SourceLabel.TabIndex = 14;
            this.SourceLabel.Text = "Исходный файл:";
            // 
            // FormRabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 547);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.SourceTextBox);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.PTextBox);
            this.Name = "FormRabin";
            this.Text = "Рабин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label SourceLabel;
    }
}

