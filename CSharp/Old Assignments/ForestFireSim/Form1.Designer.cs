namespace ForestFireSim
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
            this.components = new System.ComponentModel.Container();
            this.treeDensity = new System.Windows.Forms.TextBox();
            this.setupBtn = new System.Windows.Forms.Button();
            this.windCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fireBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeDensity
            // 
            this.treeDensity.Location = new System.Drawing.Point(28, 85);
            this.treeDensity.Name = "treeDensity";
            this.treeDensity.Size = new System.Drawing.Size(100, 20);
            this.treeDensity.TabIndex = 0;
            this.treeDensity.Text = ".55";
            // 
            // setupBtn
            // 
            this.setupBtn.Location = new System.Drawing.Point(28, 122);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(75, 23);
            this.setupBtn.TabIndex = 1;
            this.setupBtn.Text = "Set Up";
            this.setupBtn.UseVisualStyleBackColor = true;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // windCheckBox
            // 
            this.windCheckBox.AutoSize = true;
            this.windCheckBox.Location = new System.Drawing.Point(28, 172);
            this.windCheckBox.Name = "windCheckBox";
            this.windCheckBox.Size = new System.Drawing.Size(51, 17);
            this.windCheckBox.TabIndex = 2;
            this.windCheckBox.Text = "Wind";
            this.windCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tree Density";
            // 
            // fireBtn
            // 
            this.fireBtn.Location = new System.Drawing.Point(28, 209);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(75, 23);
            this.fireBtn.TabIndex = 4;
            this.fireBtn.Text = "Start Fire";
            this.fireBtn.UseVisualStyleBackColor = true;
            this.fireBtn.Click += new System.EventHandler(this.fireBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ImageLocation = "System.Drawing.Bitmap";
            this.pictureBox1.Location = new System.Drawing.Point(186, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 65;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fireBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windCheckBox);
            this.Controls.Add(this.setupBtn);
            this.Controls.Add(this.treeDensity);
            this.Name = "Form1";
            this.Text = "Forest Fire Sim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox treeDensity;
        private System.Windows.Forms.Button setupBtn;
        private System.Windows.Forms.CheckBox windCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fireBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

