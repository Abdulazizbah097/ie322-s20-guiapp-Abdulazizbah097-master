namespace IE322ABahaidrah
{
    partial class FrmCheck
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CBBrowni = new System.Windows.Forms.CheckBox();
            this.CBDonut = new System.Windows.Forms.CheckBox();
            this.CBCofee = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(572, 34);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(212, 93);
            this.BtnShow.TabIndex = 3;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(922, 543);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(212, 93);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // CBBrowni
            // 
            this.CBBrowni.AutoSize = true;
            this.CBBrowni.Location = new System.Drawing.Point(230, 304);
            this.CBBrowni.Name = "CBBrowni";
            this.CBBrowni.Size = new System.Drawing.Size(109, 29);
            this.CBBrowni.TabIndex = 0;
            this.CBBrowni.Text = "Brawni";
            this.CBBrowni.UseVisualStyleBackColor = true;
            // 
            // CBDonut
            // 
            this.CBDonut.AutoSize = true;
            this.CBDonut.Location = new System.Drawing.Point(230, 240);
            this.CBDonut.Name = "CBDonut";
            this.CBDonut.Size = new System.Drawing.Size(101, 29);
            this.CBDonut.TabIndex = 1;
            this.CBDonut.Text = "Donut";
            this.CBDonut.UseVisualStyleBackColor = true;
            // 
            // CBCofee
            // 
            this.CBCofee.AutoSize = true;
            this.CBCofee.Location = new System.Drawing.Point(230, 176);
            this.CBCofee.Name = "CBCofee";
            this.CBCofee.Size = new System.Drawing.Size(101, 29);
            this.CBCofee.TabIndex = 2;
            this.CBCofee.Text = "Cofee";
            this.CBCofee.UseVisualStyleBackColor = true;
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 720);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CBCofee);
            this.Controls.Add(this.CBDonut);
            this.Controls.Add(this.CBBrowni);
            this.Name = "FrmCheck";
            this.Text = "frmCheckBox";
            this.Load += new System.EventHandler(this.FrmCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.CheckBox CBBrowni;
        private System.Windows.Forms.CheckBox CBDonut;
        private System.Windows.Forms.CheckBox CBCofee;
    }
}