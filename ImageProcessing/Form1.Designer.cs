namespace ImageProcessing
{
    partial class Form1
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
            this.pbcGrey = new System.Windows.Forms.PictureBox();
            this.pbxOriginal = new System.Windows.Forms.PictureBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnGrey = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcGrey
            // 
            this.pbcGrey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcGrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbcGrey.Location = new System.Drawing.Point(407, 12);
            this.pbcGrey.Name = "pbcGrey";
            this.pbcGrey.Size = new System.Drawing.Size(381, 364);
            this.pbcGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcGrey.TabIndex = 0;
            this.pbcGrey.TabStop = false;
            // 
            // pbxOriginal
            // 
            this.pbxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOriginal.ErrorImage = null;
            this.pbxOriginal.Image = global::ImageProcessing.Properties.Resources.dream_whatsapp_dp;
            this.pbxOriginal.Location = new System.Drawing.Point(12, 12);
            this.pbxOriginal.Name = "pbxOriginal";
            this.pbxOriginal.Size = new System.Drawing.Size(381, 364);
            this.pbxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOriginal.TabIndex = 0;
            this.pbxOriginal.TabStop = false;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectPicture.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectPicture.Location = new System.Drawing.Point(260, 395);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(133, 43);
            this.btnSelectPicture.TabIndex = 1;
            this.btnSelectPicture.Text = "Select Picture";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.BtnSelectPicture_Click);
            // 
            // btnGrey
            // 
            this.btnGrey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrey.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGrey.Location = new System.Drawing.Point(407, 395);
            this.btnGrey.Name = "btnGrey";
            this.btnGrey.Size = new System.Drawing.Size(133, 43);
            this.btnGrey.TabIndex = 1;
            this.btnGrey.Text = "Convert to Grey";
            this.btnGrey.UseVisualStyleBackColor = true;
            this.btnGrey.Click += new System.EventHandler(this.BtnGrey_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(532, 189);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(139, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Image is being Processing...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(607, 382);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 56);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGrey);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.pbxOriginal);
            this.Controls.Add(this.pbcGrey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbcGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcGrey;
        private System.Windows.Forms.PictureBox pbxOriginal;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnGrey;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

