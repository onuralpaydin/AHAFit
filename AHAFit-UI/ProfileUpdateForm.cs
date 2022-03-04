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
    public partial class ProfileUpdateForm : Form
    {
        MemberData MemberData = new MemberData();
        private readonly int memberId;

        public ProfileUpdateForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
            foreach (var activity in (ActivityLevel[])Enum.GetValues(typeof(ActivityLevel)))
            {
                cmbActivity.Items.Add(activity);
            }
            cmbActivity.SelectedItem = MemberData.GetMemberActivityLevel(memberId);

            txtPassword.Text = MemberData.GetMemberPassword(memberId);
            txtReEnter.Text = MemberData.GetMemberPassword(memberId);
            dtpBirthDate.MaxDate = DateTime.Today;
        }

        private void ProfileUpdateForm_Load(object sender, EventArgs e)
        {
            var member = MemberData.getMemberInformations(memberId);
            txtEmail.Text = member.Email;
            txtName.Text = member.Name;
            txtSurname.Text = member.Surname;
            txtPassword.Text = member.Password;
            numWeight.Text = member.Weight.ToString();
            cmbGender.SelectedItem = member.Gender;
            numHeight.Text = member.Height.ToString();
            dtpBirthDate.Value = member.BirthDate;
            cmbActivity.SelectedText = member.ActivityLevel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("The e-mail address is invalid.");
                return;
            }

            if (MemberData.IsEmailAddressExist(txtEmail.Text.Trim(), memberId))
            {
                MessageBox.Show("This email address is already used.");
                return;
            }

            if (txtPassword.Text != txtReEnter.Text)
            {
                MessageBox.Show("The entered passwords do not match.");
                return;
            }

            if(lblPasswordLevel.Text != "*Strong Password")
            {
                MessageBox.Show("Please enter a strong password. A strong password consists of at least 6 characters. Must contain at least 1 Uppercase letter, 1 Lowercase letter, 1 Number and 1 Special character.");
                return;
            }

            MemberData.ChangeMemberInformation(memberId, txtEmail.Text.Trim(), txtName.Text.Trim(), txtSurname.Text.Trim(), txtPassword.Text.Trim(), Convert.ToDouble(numWeight.Value), cmbGender.Text, Convert.ToInt32(numHeight.Value), dtpBirthDate.Value.Date, cmbActivity.Text);
            MessageBox.Show("Your profile has been successfully updated.");
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
                return "*Week Password";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswordLevel.Text = PasswordControl(txtPassword.Text);
        }
    }
}
