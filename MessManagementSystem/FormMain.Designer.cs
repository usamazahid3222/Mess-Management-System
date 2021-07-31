namespace MessManagementSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblClerkSignin = new System.Windows.Forms.Label();
            this.btnClerkLogin = new System.Windows.Forms.Button();
            this.txtBxClerkPword = new System.Windows.Forms.TextBox();
            this.txtbxClerkUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnManagerLogin = new System.Windows.Forms.Button();
            this.txtBxManagerPword = new System.Windows.Forms.TextBox();
            this.txtBxManagerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mess Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(35, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 35);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(757, 50);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome to";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.lblClerkSignin);
            this.tabPage2.Controls.Add(this.btnClerkLogin);
            this.tabPage2.Controls.Add(this.txtBxClerkPword);
            this.tabPage2.Controls.Add(this.txtbxClerkUserName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clerk";
            // 
            // lblClerkSignin
            // 
            this.lblClerkSignin.AutoSize = true;
            this.lblClerkSignin.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClerkSignin.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblClerkSignin.Location = new System.Drawing.Point(72, 16);
            this.lblClerkSignin.Name = "lblClerkSignin";
            this.lblClerkSignin.Size = new System.Drawing.Size(197, 39);
            this.lblClerkSignin.TabIndex = 19;
            this.lblClerkSignin.Text = "Clerk Signin";
            // 
            // btnClerkLogin
            // 
            this.btnClerkLogin.Location = new System.Drawing.Point(183, 257);
            this.btnClerkLogin.Name = "btnClerkLogin";
            this.btnClerkLogin.Size = new System.Drawing.Size(119, 32);
            this.btnClerkLogin.TabIndex = 18;
            this.btnClerkLogin.Text = "login";
            this.btnClerkLogin.UseVisualStyleBackColor = true;
            this.btnClerkLogin.Click += new System.EventHandler(this.btnClerkLogin_Click);
            // 
            // txtBxClerkPword
            // 
            this.txtBxClerkPword.Location = new System.Drawing.Point(107, 190);
            this.txtBxClerkPword.Name = "txtBxClerkPword";
            this.txtBxClerkPword.PasswordChar = '*';
            this.txtBxClerkPword.Size = new System.Drawing.Size(171, 23);
            this.txtBxClerkPword.TabIndex = 17;
            // 
            // txtbxClerkUserName
            // 
            this.txtbxClerkUserName.Location = new System.Drawing.Point(107, 138);
            this.txtbxClerkUserName.Name = "txtbxClerkUserName";
            this.txtbxClerkUserName.Size = new System.Drawing.Size(171, 23);
            this.txtbxClerkUserName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(29, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Aquamarine;
            this.label6.Location = new System.Drawing.Point(32, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Username";
            // 
            // btnManagerLogin
            // 
            this.btnManagerLogin.AllowDrop = true;
            this.btnManagerLogin.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnManagerLogin.Location = new System.Drawing.Point(191, 247);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(117, 27);
            this.btnManagerLogin.TabIndex = 24;
            this.btnManagerLogin.Text = "login";
            this.btnManagerLogin.UseVisualStyleBackColor = true;
            this.btnManagerLogin.Click += new System.EventHandler(this.btnManagerLogin_Click);
            // 
            // txtBxManagerPword
            // 
            this.txtBxManagerPword.Location = new System.Drawing.Point(108, 173);
            this.txtBxManagerPword.Name = "txtBxManagerPword";
            this.txtBxManagerPword.PasswordChar = '*';
            this.txtBxManagerPword.Size = new System.Drawing.Size(200, 25);
            this.txtBxManagerPword.TabIndex = 23;
            // 
            // txtBxManagerName
            // 
            this.txtBxManagerName.Location = new System.Drawing.Point(108, 111);
            this.txtBxManagerName.Name = "txtBxManagerName";
            this.txtBxManagerName.Size = new System.Drawing.Size(200, 25);
            this.txtBxManagerName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(31, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Attendance Manager  Signin ";
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnManagerLogin);
            this.tabPage1.Controls.Add(this.txtBxManagerPword);
            this.tabPage1.Controls.Add(this.txtBxManagerName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Aquamarine;
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(54, 25);
            this.tabControl1.Location = new System.Drawing.Point(323, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 375);
            this.tabControl1.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(757, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblClerkSignin;
        private System.Windows.Forms.Button btnClerkLogin;
        private System.Windows.Forms.TextBox txtBxClerkPword;
        private System.Windows.Forms.TextBox txtbxClerkUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnManagerLogin;
        private System.Windows.Forms.TextBox txtBxManagerPword;
        private System.Windows.Forms.TextBox txtBxManagerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

