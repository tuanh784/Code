namespace Steganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encodeButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.decodedTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(25, 84);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(75, 23);
            this.encodeButton.TabIndex = 0;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(25, 42);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 332);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(25, 351);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeBtn.TabIndex = 3;
            this.decodeBtn.Text = "Decode";
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // decodedTxt
            // 
            this.decodedTxt.AutoSize = true;
            this.decodedTxt.Location = new System.Drawing.Point(22, 398);
            this.decodedTxt.Name = "decodedTxt";
            this.decodedTxt.Size = new System.Drawing.Size(127, 13);
            this.decodedTxt.TabIndex = 4;
            this.decodedTxt.Text = "Decoded text will go here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 484);
            this.Controls.Add(this.decodedTxt);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.encodeButton);
            this.Name = "Form1";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button decodeBtn;
        private System.Windows.Forms.Label decodedTxt;
    }
}

