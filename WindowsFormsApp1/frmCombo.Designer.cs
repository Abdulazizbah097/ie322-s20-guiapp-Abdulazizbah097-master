namespace IE322ABahaidrah
{
    partial class frmCombo
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
            this.btnSSM1 = new System.Windows.Forms.Button();
            this.brnSSM2 = new System.Windows.Forms.Button();
            this.btnRBI = new System.Windows.Forms.Button();
            this.btnRBN = new System.Windows.Forms.Button();
            this.btnRLI = new System.Windows.Forms.Button();
            this.btnRLSI = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSSM1
            // 
            this.btnSSM1.Location = new System.Drawing.Point(23, 27);
            this.btnSSM1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSSM1.Name = "btnSSM1";
            this.btnSSM1.Size = new System.Drawing.Size(104, 40);
            this.btnSSM1.TabIndex = 0;
            this.btnSSM1.Text = "show selected Method 1";
            this.btnSSM1.UseVisualStyleBackColor = true;
            this.btnSSM1.Click += new System.EventHandler(this.btnSSM1_Click);
            // 
            // brnSSM2
            // 
            this.brnSSM2.Location = new System.Drawing.Point(132, 27);
            this.brnSSM2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnSSM2.Name = "brnSSM2";
            this.brnSSM2.Size = new System.Drawing.Size(104, 40);
            this.brnSSM2.TabIndex = 1;
            this.brnSSM2.Text = "show selected method 2";
            this.brnSSM2.UseVisualStyleBackColor = true;
            this.brnSSM2.Click += new System.EventHandler(this.brnSSM2_Click);
            // 
            // btnRBI
            // 
            this.btnRBI.Location = new System.Drawing.Point(23, 230);
            this.btnRBI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRBI.Name = "btnRBI";
            this.btnRBI.Size = new System.Drawing.Size(104, 40);
            this.btnRBI.TabIndex = 2;
            this.btnRBI.Text = "Remove by Index";
            this.btnRBI.UseVisualStyleBackColor = true;
            this.btnRBI.Click += new System.EventHandler(this.btnRBI_Click);
            // 
            // btnRBN
            // 
            this.btnRBN.Location = new System.Drawing.Point(132, 230);
            this.btnRBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRBN.Name = "btnRBN";
            this.btnRBN.Size = new System.Drawing.Size(104, 40);
            this.btnRBN.TabIndex = 3;
            this.btnRBN.Text = "Remove by name";
            this.btnRBN.UseVisualStyleBackColor = true;
            this.btnRBN.Click += new System.EventHandler(this.btnRBN_Click);
            // 
            // btnRLI
            // 
            this.btnRLI.Location = new System.Drawing.Point(341, 27);
            this.btnRLI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRLI.Name = "btnRLI";
            this.btnRLI.Size = new System.Drawing.Size(124, 69);
            this.btnRLI.TabIndex = 4;
            this.btnRLI.Text = "Remove last item";
            this.btnRLI.UseVisualStyleBackColor = true;
            this.btnRLI.Click += new System.EventHandler(this.btnRLI_Click);
            // 
            // btnRLSI
            // 
            this.btnRLSI.Location = new System.Drawing.Point(341, 116);
            this.btnRLSI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRLSI.Name = "btnRLSI";
            this.btnRLSI.Size = new System.Drawing.Size(124, 69);
            this.btnRLSI.TabIndex = 5;
            this.btnRLSI.Text = "Remove last 2nd item";
            this.btnRLSI.UseVisualStyleBackColor = true;
            this.btnRLSI.Click += new System.EventHandler(this.btnRLSI_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(341, 265);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(104, 30);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(23, 141);
            this.CmbDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(216, 21);
            this.CmbDays.TabIndex = 7;
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 361);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnRLSI);
            this.Controls.Add(this.btnRLI);
            this.Controls.Add(this.btnRBN);
            this.Controls.Add(this.btnRBI);
            this.Controls.Add(this.brnSSM2);
            this.Controls.Add(this.btnSSM1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSSM1;
        private System.Windows.Forms.Button brnSSM2;
        private System.Windows.Forms.Button btnRBI;
        private System.Windows.Forms.Button btnRBN;
        private System.Windows.Forms.Button btnRLI;
        private System.Windows.Forms.Button btnRLSI;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}