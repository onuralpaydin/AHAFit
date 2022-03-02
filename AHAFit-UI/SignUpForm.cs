using AHAFit_BLL;
using AHAFit_Data;
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
    public partial class SignUpForm : Form
    {
        Onur onur = new Onur();



        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

            cmbSignUpGender.Items.Add("Male");
            cmbSignUpGender.Items.Add("Female");
            cmbSignUpGoal.Items.Add("Gain Weight");
            cmbSignUpGoal.Items.Add("Lose Weight");
            cmbSignUpGoal.Items.Add("Maintain Your Weight");
            foreach (var activity in (ActivityLevel[])Enum.GetValues(typeof(ActivityLevel)))
            {
                cmbSignUpActivityLevel.Items.Add(activity);
            }

            lblSignUpPasswordInfo.Text = "Your password must be 8-16 characters, and include at least one lowercase letter, one uppercase letter, one special character and a number .";
        }

        private void btnSignUpSignUp_Click(object sender, EventArgs e)
        {
            if (txtSignUpEmail.Text == null || txtSignUpName.Text == null || txtSignUpSurname.Text == null ||txtSignUpPassword.Text==null||txtSignUpPassword.Text==""||  nudSignUpHeight.Value == 0 || nudSignUpWeight.Value == 0 || txtSignUpEmail.Text == "" || txtSignUpName.Text == "" || txtSignUpSurname.Text == "" ||cmbSignUpActivityLevel.SelectedIndex==-1||cmbSignUpGender.SelectedIndex==-1||cmbSignUpGoal.SelectedIndex==-1)
            {
                MessageBox.Show("Required field cannot be left blank ");
            }
            else
            {
                int height;
                double weight;
                string gender = "";
                height = Convert.ToInt32(nudSignUpHeight.Value);
                weight = Convert.ToDouble(nudSignUpWeight.Value);
                int goalID = onur.GoalFinder(cmbSignUpGoal.Text);

                if (cmbSignUpGender.SelectedIndex == 0)
                    gender = "Male";

                if (cmbSignUpGender.SelectedIndex == 1)
                    gender = "Female";
                
                bool MemberControlTrueFalse = onur.MemberControl(txtSignUpEmail.Text);
                bool EmailControlTrueFalse = onur.SignUpEmailCheck(txtSignUpEmail.Text);

                if (EmailControlTrueFalse==false)
                {
                    MessageBox.Show("Invalid email address");
                }

                else if (MemberControlTrueFalse == false)
                {
                    MessageBox.Show("The Email adress is already taken.Please choose another.");
                }

                else if (dateTimePicker1.Value.Date.Year-DateTime.Now.Year<=15)
                {
                    MessageBox.Show("Not suitable for who is younger than 16.");
                }
                else if (MemberControlTrueFalse == true)
                {
                    onur.CreateNewMember(txtSignUpEmail.Text, txtSignUpPassword.Text, txtSignUpName.Text, txtSignUpSurname.Text, weight, height, gender, dateTimePicker1.Value.Date, goalID, cmbSignUpActivityLevel.SelectedItem.ToString());
                    MessageBox.Show("Account has been created succesfully");
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }



            }
        }



        private void txtSignUpPassword_TextChanged_1(object sender, EventArgs e)
        {
            lblSignUpPasswordInfo.Text = " ";


            if (onur.SignUpDataControl(txtSignUpPassword.Text) == true)
            {
                lblSignUpPasswordInfo.Text = "Strong Password";
                lblSignUpPasswordInfo.ForeColor = Color.Green;
            }

            else
            {

                lblSignUpPasswordInfo.Text = "Weak Password";
                lblSignUpPasswordInfo.ForeColor = Color.Red;
            }
        }
    }
}
