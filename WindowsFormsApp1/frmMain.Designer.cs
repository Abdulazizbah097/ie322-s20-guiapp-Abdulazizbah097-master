namespace IE322ABahaidrah
{
    partial class FormMain
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
            this.Btnlogin = new System.Windows.Forms.Button();
            this.BTnexit = new System.Windows.Forms.Button();
            this.LplUser = new System.Windows.Forms.Label();
            this.LplPW = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.Txtuser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnLA = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.BtnSA = new System.Windows.Forms.Button();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnRandomCompo = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnGA = new System.Windows.Forms.Button();
            this.BtnPB2 = new System.Windows.Forms.Button();
            this.BtnPB1 = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(288, 287);
            this.Btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(208, 63);
            this.Btnlogin.TabIndex = 0;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // BTnexit
            // 
            this.BTnexit.BackColor = System.Drawing.Color.Transparent;
            this.BTnexit.ForeColor = System.Drawing.Color.Red;
            this.BTnexit.Location = new System.Drawing.Point(40, 287);
            this.BTnexit.Margin = new System.Windows.Forms.Padding(4);
            this.BTnexit.Name = "BTnexit";
            this.BTnexit.Size = new System.Drawing.Size(208, 63);
            this.BTnexit.TabIndex = 1;
            this.BTnexit.Text = "Exit";
            this.BTnexit.UseVisualStyleBackColor = false;
            this.BTnexit.Click += new System.EventHandler(this.BTnexit_Click);
            // 
            // LplUser
            // 
            this.LplUser.AutoSize = true;
            this.LplUser.Location = new System.Drawing.Point(68, 67);
            this.LplUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LplUser.Name = "LplUser";
            this.LplUser.Size = new System.Drawing.Size(119, 25);
            this.LplUser.TabIndex = 2;
            this.LplUser.Text = "User Name";
            // 
            // LplPW
            // 
            this.LplPW.AutoSize = true;
            this.LplPW.Location = new System.Drawing.Point(68, 148);
            this.LplPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LplPW.Name = "LplPW";
            this.LplPW.Size = new System.Drawing.Size(106, 25);
            this.LplPW.TabIndex = 3;
            this.LplPW.Text = "Password";
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(212, 142);
            this.TxtPW.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(100, 31);
            this.TxtPW.TabIndex = 4;
            this.TxtPW.TextChanged += new System.EventHandler(this.TxtPW_TextChanged);
            // 
            // Txtuser
            // 
            this.Txtuser.Location = new System.Drawing.Point(212, 62);
            this.Txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.Txtuser.Name = "Txtuser";
            this.Txtuser.Size = new System.Drawing.Size(100, 31);
            this.Txtuser.TabIndex = 5;
            this.Txtuser.TextChanged += new System.EventHandler(this.Txtuser_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txtuser);
            this.groupBox1.Controls.Add(this.LplUser);
            this.groupBox1.Controls.Add(this.LplPW);
            this.groupBox1.Controls.Add(this.TxtPW);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(356, 204);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnCheck
            // 
            this.BtnCheck.ForeColor = System.Drawing.Color.Blue;
            this.BtnCheck.Location = new System.Drawing.Point(258, 41);
            this.BtnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(182, 62);
            this.BtnCheck.TabIndex = 10;
            this.BtnCheck.Text = "CheckBox";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnLA
            // 
            this.BtnLA.ForeColor = System.Drawing.Color.Blue;
            this.BtnLA.Location = new System.Drawing.Point(48, 163);
            this.BtnLA.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLA.Name = "BtnLA";
            this.BtnLA.Size = new System.Drawing.Size(302, 65);
            this.BtnLA.TabIndex = 11;
            this.BtnLA.Text = "ABC Analysis";
            this.BtnLA.UseVisualStyleBackColor = true;
            // 
            // BtnRadio
            // 
            this.BtnRadio.ForeColor = System.Drawing.Color.Blue;
            this.BtnRadio.Location = new System.Drawing.Point(50, 41);
            this.BtnRadio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(182, 62);
            this.BtnRadio.TabIndex = 12;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = true;
            this.BtnRadio.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.ForeColor = System.Drawing.Color.Blue;
            this.BtnCombo.Location = new System.Drawing.Point(258, 155);
            this.BtnCombo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(182, 62);
            this.BtnCombo.TabIndex = 13;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = true;
            this.BtnCombo.Click += new System.EventHandler(this.button7_Click);
            // 
            // BtnMC
            // 
            this.BtnMC.ForeColor = System.Drawing.Color.Blue;
            this.BtnMC.Location = new System.Drawing.Point(48, 362);
            this.BtnMC.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(302, 65);
            this.BtnMC.TabIndex = 16;
            this.BtnMC.Text = "Manufactring cell ";
            this.BtnMC.UseVisualStyleBackColor = true;
            // 
            // BtnJohari
            // 
            this.BtnJohari.ForeColor = System.Drawing.Color.Blue;
            this.BtnJohari.Location = new System.Drawing.Point(48, 265);
            this.BtnJohari.Margin = new System.Windows.Forms.Padding(4);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(302, 65);
            this.BtnJohari.TabIndex = 17;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = true;
            this.BtnJohari.Click += new System.EventHandler(this.button11_Click);
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.ForeColor = System.Drawing.Color.Blue;
            this.BtnRoboticCell.Location = new System.Drawing.Point(48, 67);
            this.BtnRoboticCell.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(302, 65);
            this.BtnRoboticCell.TabIndex = 18;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseVisualStyleBackColor = true;
            // 
            // BtnArduino
            // 
            this.BtnArduino.ForeColor = System.Drawing.Color.Blue;
            this.BtnArduino.Location = new System.Drawing.Point(46, 81);
            this.BtnArduino.Margin = new System.Windows.Forms.Padding(4);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(302, 65);
            this.BtnArduino.TabIndex = 19;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = true;
            // 
            // BtnSA
            // 
            this.BtnSA.ForeColor = System.Drawing.Color.Blue;
            this.BtnSA.Location = new System.Drawing.Point(258, 48);
            this.BtnSA.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSA.Name = "BtnSA";
            this.BtnSA.Size = new System.Drawing.Size(182, 62);
            this.BtnSA.TabIndex = 20;
            this.BtnSA.Text = "SelfieApp";
            this.BtnSA.UseVisualStyleBackColor = true;
            // 
            // BtnProgress
            // 
            this.BtnProgress.ForeColor = System.Drawing.Color.Blue;
            this.BtnProgress.Location = new System.Drawing.Point(258, 46);
            this.BtnProgress.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(182, 62);
            this.BtnProgress.TabIndex = 21;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = true;
            // 
            // BtnTimer
            // 
            this.BtnTimer.ForeColor = System.Drawing.Color.Blue;
            this.BtnTimer.Location = new System.Drawing.Point(50, 46);
            this.BtnTimer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(182, 62);
            this.BtnTimer.TabIndex = 22;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = true;
            // 
            // BtnRandomCompo
            // 
            this.BtnRandomCompo.ForeColor = System.Drawing.Color.Blue;
            this.BtnRandomCompo.Location = new System.Drawing.Point(258, 188);
            this.BtnRandomCompo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRandomCompo.Name = "BtnRandomCompo";
            this.BtnRandomCompo.Size = new System.Drawing.Size(182, 62);
            this.BtnRandomCompo.TabIndex = 23;
            this.BtnRandomCompo.Text = "RandomCombo";
            this.BtnRandomCompo.UseVisualStyleBackColor = true;
            this.BtnRandomCompo.Click += new System.EventHandler(this.BtnRandomCompo_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.ForeColor = System.Drawing.Color.Blue;
            this.BtnRandom.Location = new System.Drawing.Point(50, 188);
            this.BtnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(182, 62);
            this.BtnRandom.TabIndex = 24;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnGA
            // 
            this.BtnGA.ForeColor = System.Drawing.Color.Blue;
            this.BtnGA.Location = new System.Drawing.Point(258, 152);
            this.BtnGA.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGA.Name = "BtnGA";
            this.BtnGA.Size = new System.Drawing.Size(182, 62);
            this.BtnGA.TabIndex = 25;
            this.BtnGA.Text = "Groupie App";
            this.BtnGA.UseVisualStyleBackColor = true;
            // 
            // BtnPB2
            // 
            this.BtnPB2.ForeColor = System.Drawing.Color.Blue;
            this.BtnPB2.Location = new System.Drawing.Point(50, 152);
            this.BtnPB2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPB2.Name = "BtnPB2";
            this.BtnPB2.Size = new System.Drawing.Size(182, 62);
            this.BtnPB2.TabIndex = 26;
            this.BtnPB2.Text = "PictureBox2";
            this.BtnPB2.UseVisualStyleBackColor = true;
            // 
            // BtnPB1
            // 
            this.BtnPB1.ForeColor = System.Drawing.Color.Blue;
            this.BtnPB1.Location = new System.Drawing.Point(50, 48);
            this.BtnPB1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPB1.Name = "BtnPB1";
            this.BtnPB1.Size = new System.Drawing.Size(182, 62);
            this.BtnPB1.TabIndex = 27;
            this.BtnPB1.Text = "PictureBox";
            this.BtnPB1.UseVisualStyleBackColor = true;
            this.BtnPB1.Click += new System.EventHandler(this.BtnPB1_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.ForeColor = System.Drawing.Color.Blue;
            this.BtnDraw.Location = new System.Drawing.Point(30, 77);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(182, 62);
            this.BtnDraw.TabIndex = 28;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnTalk
            // 
            this.BtnTalk.ForeColor = System.Drawing.Color.Blue;
            this.BtnTalk.Location = new System.Drawing.Point(220, 77);
            this.BtnTalk.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(182, 62);
            this.BtnTalk.TabIndex = 29;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = true;
            this.BtnTalk.Click += new System.EventHandler(this.BtnTalk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDraw);
            this.groupBox2.Controls.Add(this.BtnTalk);
            this.groupBox2.Location = new System.Drawing.Point(1100, 658);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(466, 279);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Draw and Talk";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnTimer);
            this.groupBox4.Controls.Add(this.BtnProgress);
            this.groupBox4.Controls.Add(this.BtnRandom);
            this.groupBox4.Controls.Add(this.BtnRandomCompo);
            this.groupBox4.Location = new System.Drawing.Point(524, 658);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(492, 279);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnSA);
            this.groupBox5.Controls.Add(this.BtnPB1);
            this.groupBox5.Controls.Add(this.BtnGA);
            this.groupBox5.Controls.Add(this.BtnPB2);
            this.groupBox5.Location = new System.Drawing.Point(524, 387);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(492, 262);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Graphical";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnArray);
            this.groupBox6.Controls.Add(this.BtnCheck);
            this.groupBox6.Controls.Add(this.BtnRadio);
            this.groupBox6.Controls.Add(this.BtnCombo);
            this.groupBox6.Location = new System.Drawing.Point(524, 33);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(492, 342);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Basic Controls";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // BtnArray
            // 
            this.BtnArray.ForeColor = System.Drawing.Color.Blue;
            this.BtnArray.Location = new System.Drawing.Point(50, 155);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(182, 62);
            this.BtnArray.TabIndex = 31;
            this.BtnArray.Text = "Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BtnJohari);
            this.groupBox7.Controls.Add(this.BtnLA);
            this.groupBox7.Controls.Add(this.BtnRoboticCell);
            this.groupBox7.Controls.Add(this.BtnMC);
            this.groupBox7.Location = new System.Drawing.Point(1100, 121);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox7.Size = new System.Drawing.Size(400, 525);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Exam Apps";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.BtnArduino);
            this.groupBox8.Location = new System.Drawing.Point(1576, 121);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox8.Size = new System.Drawing.Size(400, 310);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Micro Controller";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1559);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTnexit);
            this.Controls.Add(this.Btnlogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Button BTnexit;
        private System.Windows.Forms.Label LplUser;
        private System.Windows.Forms.Label LplPW;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox Txtuser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnLA;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnSA;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnRandomCompo;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnGA;
        private System.Windows.Forms.Button BtnPB2;
        private System.Windows.Forms.Button BtnPB1;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button BtnArray;
    }
}

