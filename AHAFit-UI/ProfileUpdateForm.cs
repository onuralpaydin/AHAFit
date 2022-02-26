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
    public partial class ProfileUpdateForm : Form
    {
        private readonly int memberId;

        public ProfileUpdateForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
            foreach (var activity in (ActivityLevel[]) Enum.GetValues(typeof(ActivityLevel)))
            {
                cmbActivity.Items.Add(activity);
            }
        }

        private void ProfileUpdateForm_Load(object sender, EventArgs e)
        {
            var member = Huseyin.getMemberInformations(memberId);
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
            Huseyin.ChangeMemberInformation(memberId, txtEmail.Text, txtName.Text, txtSurname.Text, txtPassword.Text, Convert.ToDouble(numWeight.Value), cmbGender.Text, Convert.ToInt32(numHeight.Value), dtpBirthDate.Value.Date, cmbActivity.Text);
        }
    }
}
