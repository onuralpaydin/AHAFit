using AHAFit_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHAFit_UI
{
    public partial class LoginForm : Form
    {
        Onur onur = new Onur();
        public LoginForm()
        {

            InitializeComponent();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }

        private void btnLoginFormLogIn_Click(object sender, EventArgs e)
        {
            if (onur.LoginControl(txtLoginFormEmail.Text, txtLoginFormPassword.Text) == true)
            {
                MessageBox.Show("++++++++++++");
                //HomeForm homeForm = new HomeForm();
            }
            else
            {
                MessageBox.Show("Email or password is wrong.Please try again");
            }

        }
    }
}
