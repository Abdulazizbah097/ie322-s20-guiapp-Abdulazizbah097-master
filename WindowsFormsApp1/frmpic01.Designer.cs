namespace IE322ABahaidrah
{
    partial class frmpic01
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
            this.btnload = new System.Windows.Forms.Button();
            this.pic01 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(20, 13);
            this.btnload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(124, 50);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "Load image\r\n\r\n";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // pic01
            // 
            this.pic01.Location = new System.Drawing.Point(162, 46);
            this.pic01.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(323, 219);
            this.pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic01.TabIndex = 2;
            this.pic01.TabStop = false;
            this.pic01.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmpic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 406);
            this.Controls.Add(this.pic01);
            this.Controls.Add(this.btnload);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmpic01";
            this.Text = "frmpic01";
            this.Load += new System.EventHandler(this.frmpic01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.PictureBox pic01;
    }
}