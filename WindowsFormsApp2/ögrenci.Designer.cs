namespace WindowsFormsApp2
{
    partial class ögrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ögrenci));
            this.qrolustur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qrtext = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // qrolustur
            // 
            this.qrolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.qrolustur.ForeColor = System.Drawing.SystemColors.Control;
            this.qrolustur.Image = ((System.Drawing.Image)(resources.GetObject("qrolustur.Image")));
            this.qrolustur.Location = new System.Drawing.Point(65, 605);
            this.qrolustur.Name = "qrolustur";
            this.qrolustur.Size = new System.Drawing.Size(230, 47);
            this.qrolustur.TabIndex = 2;
            this.qrolustur.Text = "Yoklamaya Katıl";
            this.qrolustur.UseVisualStyleBackColor = true;
            this.qrolustur.Click += new System.EventHandler(this.qrolustur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // qrtext
            // 
            this.qrtext.Location = new System.Drawing.Point(65, 541);
            this.qrtext.MaxLength = 9;
            this.qrtext.Multiline = true;
            this.qrtext.Name = "qrtext";
            this.qrtext.Size = new System.Drawing.Size(230, 36);
            this.qrtext.TabIndex = 4;
            this.qrtext.TextChanged += new System.EventHandler(this.qrtext_TextChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(214, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 38);
            this.button4.TabIndex = 26;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ögrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(376, 664);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.qrtext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.qrolustur);
            this.Name = "ögrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ögrenci";
            this.Load += new System.EventHandler(this.ögrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qrolustur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox qrtext;
        private System.Windows.Forms.Button button4;
    }
}