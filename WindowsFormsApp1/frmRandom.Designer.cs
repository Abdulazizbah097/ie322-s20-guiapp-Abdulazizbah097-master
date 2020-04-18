namespace IE322ABahaidrah
{
    partial class frmRandom
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
            this.btnGRC = new System.Windows.Forms.Button();
            this.btnRN = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelRan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGRC
            // 
            this.btnGRC.Location = new System.Drawing.Point(200, 22);
            this.btnGRC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGRC.Name = "btnGRC";
            this.btnGRC.Size = new System.Drawing.Size(133, 57);
            this.btnGRC.TabIndex = 0;
            this.btnGRC.Text = "generate Random Color";
            this.btnGRC.UseVisualStyleBackColor = true;
            this.btnGRC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRN
            // 
            this.btnRN.Location = new System.Drawing.Point(26, 192);
            this.btnRN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRN.Name = "btnRN";
            this.btnRN.Size = new System.Drawing.Size(133, 57);
            this.btnRN.TabIndex = 1;
            this.btnRN.Text = "Random Number";
            this.btnRN.UseVisualStyleBackColor = true;
            this.btnRN.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(426, 210);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 57);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelRan
            // 
            this.labelRan.AutoSize = true;
            this.labelRan.Location = new System.Drawing.Point(248, 95);
            this.labelRan.Name = "labelRan";
            this.labelRan.Size = new System.Drawing.Size(31, 13);
            this.labelRan.TabIndex = 3;
            this.labelRan.Text = "Color";
            this.labelRan.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 311);
            this.Controls.Add(this.labelRan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRN);
            this.Controls.Add(this.btnGRC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.Load += new System.EventHandler(this.frmRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGRC;
        private System.Windows.Forms.Button btnRN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelRan;
    }
}