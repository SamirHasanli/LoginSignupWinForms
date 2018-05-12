using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        Module module = new Module();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void MenuSignUp_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            Button button = new Button();
            button.Text = "Back";
            button.Name = "SignUpBackButton";
            button.Location = new Point(96, 334);
            button.Click += Button_Click;
            panel1.Controls.Add(button);
            SignUpButton.Enabled = false;

            SignUpUsername.TextChanged += SignUpUsername_TextChanged;
            SignUpPassword.TextChanged += SignUpUsername_TextChanged;
            SignUpFirstname.TextChanged += SignUpUsername_TextChanged;
            SignUpLastname.TextChanged += SignUpUsername_TextChanged;
            SignUpBirthday.TextChanged += SignUpUsername_TextChanged;
            SignUpGender.TextChanged += SignUpUsername_TextChanged;
        }

        private void SignUpUsername_TextChanged(object sender, EventArgs e)
        {

            if (SignUpUsername.Text.Trim() != "" && SignUpFirstname.Text.Trim() != "" && SignUpLastname.Text.Trim() != "" && SignUpPassword.Text.Trim() != "" && SignUpBirthday.Value != null && SignUpGender.Text.Trim() != "")
            {
                SignUpButton.Enabled = true;
            }
            else
            {
                SignUpButton.Enabled = false;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void MenuLogin_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = false;
            Button button = new Button();
            button.Text = "Back";
            button.Name = "SignUpBackButton";
            button.Location = new Point(96, 155);
            button.Click += Button_Click;
            panel2.Controls.Add(button);
            LoginButton.Enabled = false;
            LoginUsername.TextChanged += LoginUsername_TextChanged;
            LoginPassword.TextChanged += LoginUsername_TextChanged;
        }

        private void LoginUsername_TextChanged(object sender, EventArgs e)
        {
            if (LoginUsername.Text.Trim() != "" && LoginPassword.Text.Trim() != "")
            {
                LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User temp = module.Login(LoginUsername.Text, LoginPassword.Text);
            if (temp != null)
            {
                MessageBox.Show(temp.Firstname);
            }
            else
            {
                MessageBox.Show("Wrong password or username");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            module.signUp(SignUpUsername.Text, SignUpFirstname.Text, SignUpLastname.Text, SignUpPassword.Text, SignUpBirthday.Value, SignUpGender.Text);
        }
    }
}
