using AHAFit_BLL;
using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHAFit_UI
{
    public partial class RegisterForm : Form
    {
        MemberData MemberData = new MemberData();
        GoalData GoalData = new GoalData();
        private readonly Panel pnlLogin;

        public RegisterForm(Panel pnlLogin)
        {
            InitializeComponent();
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
            var goalList = GoalData.GoalNamesToList();
            foreach (var gaolName in goalList)
            {
                cmbGoal.Items.Add(gaolName);
            }
            foreach (var activity in (ActivityLevel[])Enum.GetValues(typeof(ActivityLevel)))
            {
                cmbActivity.Items.Add(activity);
            }
            dtpBirthDate.MaxDate = DateTime.Today;
            this.pnlLogin = pnlLogin;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            cmbActivity.SelectedIndex = 0;
            cmbGoal.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("The e-mail address is invalid.");
                return;
            }

            if (MemberData.RecurringMailControl(txtEmail.Text.Trim()))
            {
                MessageBox.Show("This email address is already used.");
                return;
            }

            if (txtPassword.Text != txtReEnter.Text)
            {
                MessageBox.Show("The entered passwords do not match.");
                return;
            }

            if (lblPasswordLevel.Text != "*Strong Password")
            {
                MessageBox.Show("Please enter a strong password. A strong password consists of at least 6 characters. Must contain at least 1 Uppercase letter, 1 Lowercase letter, 1 Number and 1 Special character.");
                return;
            }

            MemberData.NewMember(txtEmail.Text.Trim(), txtName.Text.Trim(), txtSurname.Text.Trim(), txtPassword.Text.Trim(), Convert.ToDouble(numWeight.Value), cmbGender.Text, Convert.ToInt32(numHeight.Value), dtpBirthDate.Value.Date, cmbActivity.Text, GoalData.GoalIdFounder(cmbGoal.Text));
            MessageBox.Show("Your membership has been created. You will be redirected to the home page.");
            pnlLogin.Visible = true;
            this.Close();

        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {

                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private static string PasswordControl(string password)
        {
            if (password.Length < 6)
                return "*Password can't be shorter than 6 character.";

            int upperCase = 0;
            int lowerCase = 0;
            int number = 0;
            int specialCharacter = 0;
            foreach (var letter in password)
            {
                int ascii = Convert.ToInt32(letter);

                if (ascii >= 65 && ascii <= 90)
                {
                    upperCase++;
                }
                if (ascii >= 97 && ascii <= 122)
                {
                    lowerCase++;
                }
                if (ascii >= 48 && ascii <= 57)
                {
                    number++;
                }
                if ((ascii >= 32 && ascii <= 47) || (ascii >= 58 && ascii <= 64) || (ascii >= 91 && ascii <= 96) || (ascii >= 123 && ascii <= 126))
                {
                    specialCharacter++;
                }
            }

            if (upperCase > 0 && lowerCase > 0 && number > 0 && specialCharacter > 0)
                return "*Strong Password";
            else if (upperCase > 0 && lowerCase > 0 && number > 0)
                return "*Moderately Strong Password";
            else
                return "*Weak Password";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswordLevel.Text = PasswordControl(txtPassword.Text);
        }
    }
}
