namespace IE322ABahaidrah
{
    partial class frmRandomCombo
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.comboNumbers = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.radioGreater500 = new System.Windows.Forms.RadioButton();
            this.radioless500 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioless50 = new System.Windows.Forms.RadioButton();
            this.radioGreater50 = new System.Windows.Forms.RadioButton();
            this.ComboNumber2 = new System.Windows.Forms.ComboBox();
            this.btnGenerate2 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(316, 31);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(234, 58);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // comboNumbers
            // 
            this.comboNumbers.FormattingEnabled = true;
            this.comboNumbers.Location = new System.Drawing.Point(16, 56);
            this.comboNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.comboNumbers.Name = "comboNumbers";
            this.comboNumbers.Size = new System.Drawing.Size(228, 33);
            this.comboNumbers.TabIndex = 1;
            this.comboNumbers.SelectedIndexChanged += new System.EventHandler(this.comboNumbers_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(380, 396);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 48);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioGreater500
            // 
            this.radioGreater500.AutoSize = true;
            this.radioGreater500.Location = new System.Drawing.Point(380, 262);
            this.radioGreater500.Margin = new System.Windows.Forms.Padding(4);
            this.radioGreater500.Name = "radioGreater500";
            this.radioGreater500.Size = new System.Drawing.Size(205, 29);
            this.radioGreater500.TabIndex = 3;
            this.radioGreater500.TabStop = true;
            this.radioGreater500.Text = "Greater than 500";
            this.radioGreater500.UseVisualStyleBackColor = true;
            // 
            // radioless500
            // 
            this.radioless500.AutoSize = true;
            this.radioless500.Location = new System.Drawing.Point(380, 143);
            this.radioless500.Margin = new System.Windows.Forms.Padding(4);
            this.radioless500.Name = "radioless500";
            this.radioless500.Size = new System.Drawing.Size(179, 29);
            this.radioless500.TabIndex = 4;
            this.radioless500.TabStop = true;
            this.radioless500.Text = "Less than 500";
            this.radioless500.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.comboNumbers);
            this.groupBox1.Controls.Add(this.radioGreater500);
            this.groupBox1.Controls.Add(this.radioless500);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(588, 508);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03_AAF19";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioless50);
            this.groupBox2.Controls.Add(this.radioGreater50);
            this.groupBox2.Controls.Add(this.ComboNumber2);
            this.groupBox2.Controls.Add(this.btnGenerate2);
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Location = new System.Drawing.Point(649, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 508);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03_EAF19";
            // 
            // radioless50
            // 
            this.radioless50.AutoSize = true;
            this.radioless50.Location = new System.Drawing.Point(370, 143);
            this.radioless50.Name = "radioless50";
            this.radioless50.Size = new System.Drawing.Size(160, 29);
            this.radioless50.TabIndex = 5;
            this.radioless50.TabStop = true;
            this.radioless50.Text = "less than 50";
            this.radioless50.UseVisualStyleBackColor = true;
            // 
            // radioGreater50
            // 
            this.radioGreater50.AutoSize = true;
            this.radioGreater50.Location = new System.Drawing.Point(370, 262);
            this.radioGreater50.Name = "radioGreater50";
            this.radioGreater50.Size = new System.Drawing.Size(193, 29);
            this.radioGreater50.TabIndex = 6;
            this.radioGreater50.TabStop = true;
            this.radioGreater50.Text = "Greater than 50";
            this.radioGreater50.UseVisualStyleBackColor = true;
            // 
            // ComboNumber2
            // 
            this.ComboNumber2.FormattingEnabled = true;
            this.ComboNumber2.Location = new System.Drawing.Point(16, 56);
            this.ComboNumber2.Name = "ComboNumber2";
            this.ComboNumber2.Size = new System.Drawing.Size(228, 33);
            this.ComboNumber2.TabIndex = 7;
            this.ComboNumber2.SelectedIndexChanged += new System.EventHandler(this.ComboNumber2_SelectedIndexChanged);
            // 
            // btnGenerate2
            // 
            this.btnGenerate2.Location = new System.Drawing.Point(306, 42);
            this.btnGenerate2.Name = "btnGenerate2";
            this.btnGenerate2.Size = new System.Drawing.Size(234, 58);
            this.btnGenerate2.TabIndex = 8;
            this.btnGenerate2.Text = "Generate";
            this.btnGenerate2.UseVisualStyleBackColor = true;
            this.btnGenerate2.Click += new System.EventHandler(this.btnGenerate2_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(370, 396);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(170, 48);
            this.btnReset2.TabIndex = 9;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1040, 621);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 72);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox comboNumbers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton radioGreater500;
        private System.Windows.Forms.RadioButton radioless500;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioless50;
        private System.Windows.Forms.RadioButton radioGreater50;
        private System.Windows.Forms.ComboBox ComboNumber2;
        private System.Windows.Forms.Button btnGenerate2;
        private System.Windows.Forms.Button btnReset2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}