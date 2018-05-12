namespace WindowsFormsApp3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuSignUp = new System.Windows.Forms.Button();
            this.MenuLogin = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.SignUpPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpGender = new System.Windows.Forms.ComboBox();
            this.SignUpLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SignUpFirstname = new System.Windows.Forms.TextBox();
            this.SignUpUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SignUpPassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SignUpBirthday);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SignUpGender);
            this.panel1.Controls.Add(this.SignUpLastname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SignUpFirstname);
            this.panel1.Controls.Add(this.SignUpUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SignUpButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.LoginPassword);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.LoginUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MenuSignUp);
            this.panel3.Controls.Add(this.MenuLogin);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 450);
            this.panel3.TabIndex = 5;
            // 
            // MenuSignUp
            // 
            this.MenuSignUp.Location = new System.Drawing.Point(221, 10);
            this.MenuSignUp.Name = "MenuSignUp";
            this.MenuSignUp.Size = new System.Drawing.Size(75, 23);
            this.MenuSignUp.TabIndex = 1;
            this.MenuSignUp.Text = "Sign Up";
            this.MenuSignUp.UseVisualStyleBackColor = true;
            this.MenuSignUp.Click += new System.EventHandler(this.MenuSignUp_Click);
            // 
            // MenuLogin
            // 
            this.MenuLogin.Location = new System.Drawing.Point(20, 10);
            this.MenuLogin.Name = "MenuLogin";
            this.MenuLogin.Size = new System.Drawing.Size(75, 23);
            this.MenuLogin.TabIndex = 0;
            this.MenuLogin.Text = "Log in";
            this.MenuLogin.UseVisualStyleBackColor = true;
            this.MenuLogin.Click += new System.EventHandler(this.MenuLogin_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(221, 160);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password";
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(96, 107);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(200, 20);
            this.LoginPassword.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username";
            // 
            // LoginUsername
            // 
            this.LoginUsername.Location = new System.Drawing.Point(96, 60);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(200, 20);
            this.LoginUsername.TabIndex = 0;
            // 
            // SignUpPassword
            // 
            this.SignUpPassword.Location = new System.Drawing.Point(96, 258);
            this.SignUpPassword.Name = "SignUpPassword";
            this.SignUpPassword.Size = new System.Drawing.Size(200, 20);
            this.SignUpPassword.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 214);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday";
            // 
            // SignUpBirthday
            // 
            this.SignUpBirthday.Location = new System.Drawing.Point(96, 208);
            this.SignUpBirthday.Name = "SignUpBirthday";
            this.SignUpBirthday.Size = new System.Drawing.Size(200, 20);
            this.SignUpBirthday.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // SignUpGender
            // 
            this.SignUpGender.FormattingEnabled = true;
            this.SignUpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SignUpGender.Location = new System.Drawing.Point(96, 157);
            this.SignUpGender.Name = "SignUpGender";
            this.SignUpGender.Size = new System.Drawing.Size(200, 21);
            this.SignUpGender.TabIndex = 7;
            // 
            // SignUpLastname
            // 
            this.SignUpLastname.Location = new System.Drawing.Point(96, 107);
            this.SignUpLastname.Name = "SignUpLastname";
            this.SignUpLastname.Size = new System.Drawing.Size(200, 20);
            this.SignUpLastname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LastName";
            // 
            // SignUpFirstname
            // 
            this.SignUpFirstname.Location = new System.Drawing.Point(96, 64);
            this.SignUpFirstname.Name = "SignUpFirstname";
            this.SignUpFirstname.Size = new System.Drawing.Size(200, 20);
            this.SignUpFirstname.TabIndex = 4;
            // 
            // SignUpUsername
            // 
            this.SignUpUsername.Location = new System.Drawing.Point(96, 18);
            this.SignUpUsername.Name = "SignUpUsername";
            this.SignUpUsername.Size = new System.Drawing.Size(200, 20);
            this.SignUpUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FirstName";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(221, 334);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SignUpLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SignUpFirstname;
        private System.Windows.Forms.TextBox SignUpUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SignUpPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker SignUpBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SignUpGender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoginUsername;
        private System.Windows.Forms.Button MenuSignUp;
        private System.Windows.Forms.Button MenuLogin;
        private System.Windows.Forms.Panel panel3;
    }
}

