namespace myOCR
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orgPictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelAnser1 = new System.Windows.Forms.Label();
            this.labelAnser2 = new System.Windows.Forms.Label();
            this.labelAnser3 = new System.Windows.Forms.Label();
            this.labelAnser4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(260, 51);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OCR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orgPictureBox
            // 
            this.orgPictureBox.Location = new System.Drawing.Point(12, 69);
            this.orgPictureBox.Name = "orgPictureBox";
            this.orgPictureBox.Size = new System.Drawing.Size(260, 49);
            this.orgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.orgPictureBox.TabIndex = 2;
            this.orgPictureBox.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(278, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 168);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // labelAnser1
            // 
            this.labelAnser1.AutoSize = true;
            this.labelAnser1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAnser1.Location = new System.Drawing.Point(98, 130);
            this.labelAnser1.Name = "labelAnser1";
            this.labelAnser1.Size = new System.Drawing.Size(20, 24);
            this.labelAnser1.TabIndex = 4;
            this.labelAnser1.Text = "?";
            // 
            // labelAnser2
            // 
            this.labelAnser2.AutoSize = true;
            this.labelAnser2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAnser2.Location = new System.Drawing.Point(124, 130);
            this.labelAnser2.Name = "labelAnser2";
            this.labelAnser2.Size = new System.Drawing.Size(20, 24);
            this.labelAnser2.TabIndex = 5;
            this.labelAnser2.Text = "?";
            // 
            // labelAnser3
            // 
            this.labelAnser3.AutoSize = true;
            this.labelAnser3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAnser3.Location = new System.Drawing.Point(150, 130);
            this.labelAnser3.Name = "labelAnser3";
            this.labelAnser3.Size = new System.Drawing.Size(20, 24);
            this.labelAnser3.TabIndex = 6;
            this.labelAnser3.Text = "?";
            // 
            // labelAnser4
            // 
            this.labelAnser4.AutoSize = true;
            this.labelAnser4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAnser4.Location = new System.Drawing.Point(176, 130);
            this.labelAnser4.Name = "labelAnser4";
            this.labelAnser4.Size = new System.Drawing.Size(20, 24);
            this.labelAnser4.TabIndex = 7;
            this.labelAnser4.Text = "?";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result.Location = new System.Drawing.Point(12, 130);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(80, 24);
            this.result.TabIndex = 8;
            this.result.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 188);
            this.Controls.Add(this.result);
            this.Controls.Add(this.labelAnser4);
            this.Controls.Add(this.labelAnser3);
            this.Controls.Add(this.labelAnser2);
            this.Controls.Add(this.labelAnser1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.orgPictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISU Recaptcha OCR By.aaaddress1.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox orgPictureBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelAnser1;
        private System.Windows.Forms.Label labelAnser2;
        private System.Windows.Forms.Label labelAnser3;
        private System.Windows.Forms.Label labelAnser4;
        private System.Windows.Forms.Label result;
    }
}

